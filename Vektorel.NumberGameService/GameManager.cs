using Ibrahim.DataHelpers;
using Ibrahim.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ibrahim.NumberGameService
{
    /*
        Aşağıdaki enum yardımıyla kullanıcı kaydı esnasında karşımıza çıkabilecek
        farklı durumları tespit ederek çok daha doğru mesajlar vermeye çalışıyoruz.
    */
    public enum IsInDatabase
    {
        NotExist = 0,
        UserName = 1,
        Email = 2,
        All = 3
    }

    public class GameManager
    {
        private static GameManager instance;

        private static List<RoomInfo> roomList = new List<RoomInfo>();

        private static List<AttackInfo> attackList = new List<AttackInfo>();


        private GameManager() { }


        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }
                

        /*
            Yeni kullanıcı kaydı yaparken daha önce seçilen bir kullanıcı adı
            veya email adresi ile kayıt yapıldığını kontrol ediyoruz.
        */
        IsInDatabase IsUserInDatabase(string username, string email)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserName",username),
                new SqlParameter("@Email",email),
                new SqlParameter("@RetValue",SqlDbType.Int)
            };
            parameters[2].Direction = ParameterDirection.ReturnValue;

            Helper.ExecuteNonQuery("sp_UserIsInDatabase",
                CommandType.StoredProcedure, parameters);

            return (IsInDatabase)Convert.ToInt32(parameters[2].Value);
        }

        /*
            Yeni kullanıcı kaydı yapmak üzere aşağıdaki metod kullanılmaktadır.
        */
        public MessageInfo SignUp(string userName, string password, string email)
        {
            IsInDatabase result = IsUserInDatabase(userName, password);
            if (result == IsInDatabase.UserName)
            {
                return new MessageInfo
                {
                    Result = Status.Error,
                    Message = "Bu kullanıcı adı zaten kullanılıyor."
                };
            }
            else if (result == IsInDatabase.Email)
            {
                return new MessageInfo
                {
                    Result = Status.Error,
                    Message = "Bu eposta adresi kullanılıyor."
                };
            }
            else if (result == IsInDatabase.All)
            {
                return new MessageInfo
                {
                    Result = Status.Error,
                    Message = "Bu kullanıcı adı ve eposta adresi zaten kullanılıyor."
                };
            }
            else
            {
                /*
                    Eğer kullanıcı bilgileri daha önce eklenmiş bir kullanıcı ile
                    çakışmıyorsa veritabanına kaydedelim.
                */
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserName",userName),
                    new SqlParameter("@Email",email),
                    new SqlParameter("@Password",password)
                };
                Helper.ExecuteNonQuery("sp_CreateUser", CommandType.StoredProcedure,
                    parameters);

                return new MessageInfo
                {
                    Result = Status.Success,
                    Message = "Hesap başarıyla oluşturuldu."
                };
            }
        }

        /*
             Kullanıcının doğrulanması için aşağıdaki metod kullanılacaktır.
             Bilgiler NumberGame veritabanında Login isimli tabloda saklanmaktadır.
        */
        public MessageInfo LogIn(string userName, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password",password)
            };
            SqlDataReader reader = Helper.ExecuteDataTable("sp_Login",
                CommandType.StoredProcedure,
                parameters);
            MessageInfo result = null;
            if (reader.Read())
            {
                result = new MessageInfo
                {
                    Data = new UserInfo
                    {
                        UserName = reader.GetString(0),
                        Password = reader.GetString(1),
                        Email = reader.GetString(2),
                        CreateDate = reader.GetDateTime(3),
                        LastLoginDate = reader.GetDateTime(4)
                    },
                    Result = Status.Success,
                    Message = "Giriş başarıyla tamamlandı."
                };
                reader.Close();
            }
            else
            {
                result = new MessageInfo
                {
                    Result = Status.Error,
                    Message = "Kullanıcı adı veya parola hatalı."
                };
            }
            return result;
        }



        /*
            Kullanıcının yeni bir oda oluşturmasını sağlayacak metod.
        */
        public MessageInfo CreateRoom(string roomName)
        {
            /*
                Eğer açılmış hiç oda yoksa sorun yoktur.
                Bu gönderilen isimde bir oda açalım.
            */
            if (roomList.Count == 0)
            {
                roomList.Add(
                new RoomInfo
                {
                    CreateDate = DateTime.Now,
                    Name = roomName
                });
                return new MessageInfo
                {
                    Message = "Oda başarıyla oluşturuldu",
                    Data = roomList[0],
                    Result = Status.Success
                };
            }
            else
            {
                /*
                    Daha önce bu isimle oluşturulmuş bir oda mevcut mu 
                */
                int roomCount = roomList.Where(r => r.Name == roomName).Count();
                if (roomCount != 0)
                {
                    return new MessageInfo
                    {
                        Message = "Bu isim zaten mevcut. Lütfen farklı bir oda ismi belirleyin",
                        Result = Status.Error
                    };
                }
                var room = new RoomInfo
                {
                    CreateDate = DateTime.Now,
                    Name = roomName
                };
                roomList.Add(room);
                return new MessageInfo
                {
                    Message = "Oda başarıyla oluşturuldu",
                    Data = room,
                    Result = Status.Success
                };
            }
        }

        /*
            Tüm müsait odaların listesini getiriyoruz. Oda listesini getirirken
            bu kullanıcının zaten dahil olmadığı ve en az 1 boş yer olan
            odaları getirmeye çalışıyoruz.
        */
        public List<RoomInfo> GetAllEmtyRooms(UserInfo currentUser)
        {
            /*
                Oda listesini gönderirken bu kullanıcının zaten dahil olduğu
                odalar dışındaki odaları döndürüyoruz.
            */
            return
                roomList.Where(r => (r.User1 == null || r.User2 == null) &&
                !currentUser.Equals(r.User1) && !currentUser.Equals(r.User2)).ToList();
        }

        /*
            Gelen kullanıcının dahil olduğu odada bu kullanıcı ile
            eşleşen rakibin kim olduğunu döndürüyorum.
        */
        public MessageInfo GetPartnerForUser(string roomName, UserInfo user)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName &&
                              (r.User1.Equals(user) || r.User2.Equals(user)));
            if (room == null)
            {
                return new MessageInfo
                {
                    Message = "Bağlanmış olduğunuz oda ile ilgili teknik bir sorun oluştu. " +
                    "Farklı bir oda belirleyebilirsiniz.",
                    Result = Status.Error
                };
            }
            else
            {
                return new MessageInfo
                {
                    Result = Status.Success,
                    Data = room.User1.Equals(user) ? room.User2 : room.User1
                };
            }
        }

        /*
            Kullanıcının seçili odaya tutmuş olduğu sayı ile birlikte dahil olmasını
            sağlıyoruz.
        */

        public MessageInfo JoinRoom(string roomName, UserInfo user, string userNumber)
        {
            var room = roomList.SingleOrDefault(
                r => r.Name == roomName && (r.User1 == null || r.User2 == null));
            //Eğer kullanıcıyı bağlamaya çalıştığım oda bulunamadı ise
            if (room == null)
            {
                return new MessageInfo
                {
                    Result = Status.Error,
                    Message = "The room is busy. Please select another room."
                };
            }
            else
            {
                /*
                    Eğer odaya şu ana kadar hiçbir kullanıcı bağlanmadı ise
                    ilk bağlanan bu oyuncuya ilk hamle hakkını veriyorum.
                */
                if (room.User1 == null && room.User2 == null)
                {
                    room.ActiveUser = user;
                }
                /*
                    Odaya bağlanmaya çalışan oyuncuyu boş bir yere ekliyorum.
                    Bu kullanıcıdan önce odaya kimse bağlanmadı ise User1,
                    bağlandı ise User2 olarak saklanacaktır.
                */
                if (room.User1 == null)
                {
                    room.User1 = user;
                    room.User1JoinDate = DateTime.Now;
                    room.User1Number = userNumber;
                    room.User1.LastActivityDate = DateTime.Now;
                }
                else if (room.User2 == null)
                {
                    room.User2 = user;
                    room.User2JoinDate = DateTime.Now;
                    room.User2Number = userNumber;
                    room.User2.LastActivityDate = DateTime.Now;
                }
                /*
                    Odanın son halini istemciye gönderiyorum. 
                */
                return new MessageInfo
                {
                    Result = Status.Success,
                    Message = "You are joined to room",
                    Data = room
                };
            }
        }

        /*
            Kullanıcı oyun esnasında oyun formunu kapatırsa oyundan atalımki
            rakibi de kişinin oyundan ayrıldığına dair bilgilendirebilelim.
        */
        public MessageInfo LeaveRoom(string roomName, UserInfo user)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName);
            if (room.User1 != null)
            {
                if (room.User1.UserName == user.UserName)
                {
                    room.User1 = null;
                }
            }
            else if (room.User2 != null)
            {
                if (room.User2.UserName == user.UserName)
                {
                    room.User2 = null;
                }
            }
            else
            {
                return new MessageInfo
                {
                    Result = Status.Error,
                    Message = "We have a problem on signing out the room"
                };
            }

            /*
                Kullanıcı oyundan ayrıldığına göre bu kullanıcıya ait
                hamleleri de siliyorum.
            */
            var attacksForUser=attackList.Where(a => a.User.Equals(user));
            foreach (var attack in attacksForUser)
            {
                attackList.Remove(attack);
            }

            return new MessageInfo
            {
                Result = Status.Success,
                Data = user,
                Message = "You signout from this room successfully"
            };
        }

        /*
            Kullanıcının son aktif olduğu tarih ile şu anın farkını alıyoruz.
            Dakika olarak hesaplayarak resturn ediyoruz. Her hamlede
            bu değeri DateTime.Now olarak ayarlamıştık.
        */
        int GetTimeSpanAsMinute(DateTime lastActivateDate)
        {
            TimeSpan ts = DateTime.Now - lastActivateDate;
            return Convert.ToInt32(ts.TotalMinutes);
        }

        /*
            Rakip kullanıcı uzun süre hamle yapmazsa kullanıcıya timeout
            veriyoruz. Bu süreyi 3 dakika olarak belirledim.
        */
        public bool UserActivityTest(string roomName, UserInfo partnerUser)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName);
            if (room != null)
            {
                if (room.User1 != null)
                {
                    if (room.User1.Equals(partnerUser))
                    {
                        if (GetTimeSpanAsMinute(room.User1.LastActivityDate) >= 3)
                        {
                            room.User1 = null;
                            return false;
                        }
                    }
                }
                if (room.User2 != null)
                {
                    if (room.User2.Equals(partnerUser))
                    {
                        if (GetTimeSpanAsMinute(room.User2.LastActivityDate) >= 3)
                        {
                            room.User2 = null;
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        /*
            Kullanıcının yapmış olduğu hamleyi inceleyerek kaç doğru kaç yanlışı
            olduğuna dair bilgileri AttackInfo türünden elde etmemizi sağlıyor.
        */
        AttackInfo CheckAttack(string guess, UserInfo user)
        {
            /*
                Tüm kullanıcılar diğer oyuncunun tutmuş olduğu sayıyı
                tahmin etmeye çalışıyor. Gönderilen tahminin sonucunu
                aşağıdaki metod yardımıyla tespit etmeye çalışıyoruz.
            */
            string originalNumber = "";
            var room = roomList.SingleOrDefault(
                r => r.User1.Equals(user) || r.User2.Equals(user));
            if (room == null)
            {
                return null;
            }
            else
            {
                if (room.User1.Equals(user))
                {
                    originalNumber = room.User2Number;
                }
                else if (room.User2.Equals(user))
                {
                    originalNumber = room.User1Number;
                }
            }
            AttackInfo attack = new AttackInfo();
            attack.AttackDate = DateTime.Now;
            attack.User = user;
            attack.Guess = guess;
            List<char> otherNumber = new List<char>();
            for (int i = 0; i < originalNumber.Length; i++)
            {
                if (originalNumber[i] == guess[i])
                    attack.CorrectPosition++;
                else
                    otherNumber.Add(originalNumber[i]);
            }
            for (int i = 0; i < guess.Length; i++)
            {
                if (otherNumber.Contains(guess[i]))
                    attack.WrongPosition++;
            }
            attackList.Add(attack);
            return attack;
        }

        /*
            Kullanıcının yapmış olduğu hamleyi değerlendirerek sonucunu sistemde
            kaydediyorum.
        */
        public AttackInfo SendAttack(string roomName, UserInfo user, string guess)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName);
            if (room != null)
            {
                /*
                    Eğer hamleyi yapan User1 ise
                */
                if (user.Equals(room.User1))
                {
                    room.User1.LastActivityDate = DateTime.Now;
                }
                else
                {
                    room.User2.LastActivityDate = DateTime.Now;
                }
                return CheckAttack(guess, user);
            }
            return null;
        }

        /*
            Rakibin son hamlesini öğrenmemizi sağlayacak metoddur.
            Eğer null gelirse yeni bir hamle yapılmamıştır.
            Oyun formunda bir timer yardımıyla bu durumu saklıyor olacağız.
        */
        public AttackInfo GetLastAttackForPartner(UserInfo partnerUser)
        {
            var lastAttackInDb = attackList.Where(
                a => a.User.Equals(partnerUser)).OrderByDescending(a => a.AttackDate).FirstOrDefault();
            return lastAttackInDb;
        }

        /*
            Oyun sırasının kimde olduğunu bu metod yardımıyla öğreniyorum.
        */
        public UserInfo GetUserOrderForRoom(string roomName)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName);
            if (room != null)
            {
                return room.ActiveUser;
            }
            return null;
        }

        /*
            Kullanıcı hamleyi yaptıktan sonra hamle sırasını rakibe
            aktarmak için aşağıdaki metod kullanılmaktadır.
        */
        public void ChangePlayerOrder(string roomName)
        {
            var room = roomList.SingleOrDefault(r => r.Name == roomName);
            if (room != null)
            {
                room.ActiveUser = (room.ActiveUser.Equals(room.User1)) ? room.User2 : room.User1;
            }
        }
    }
}

