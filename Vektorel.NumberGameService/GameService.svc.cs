using Ibrahim.Model;
using Ibrahim.NumberGameService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace VIbrahim.NumberGameService
{
    
    public class GameService : IGameService
    {
        /*
            Kullanıcının daha önce veritabanına kaydedilmiş bilgilerle
            oluşturulmaya çalışıldığını anlamaya çalışıyoruz.
        */

        public MessageInfo LogIn(string userName, string password)
        {
            return GameManager.Instance.LogIn(userName, password);
        }
        public MessageInfo SignUp(string userName, string password, string email)
        {
            return GameManager.Instance.SignUp(userName, password, email);
        }
        public MessageInfo CreateRoom(string roomName)
        {
            return GameManager.Instance.CreateRoom(roomName);            
        }
        public List<RoomInfo> GetAllEmptyRooms(UserInfo currentUser)
        {
            return GameManager.Instance.GetAllEmtyRooms(currentUser);
        }
        public MessageInfo GetPartnerForUser(string roomName, UserInfo user)
        {
            return GameManager.Instance.GetPartnerForUser(roomName, user);
        }
        public MessageInfo JoinRoom(string roomName, UserInfo user,string userNumber)
        {
            return GameManager.Instance.JoinRoom(roomName, user,userNumber);
        }
        public MessageInfo LeaveRoom(string roomName, UserInfo user)
        {
            return GameManager.Instance.LeaveRoom(roomName, user);
        }
        public bool UserActivityTest(string roomName, UserInfo partnerUser)
        {
            return GameManager.Instance.UserActivityTest(roomName, partnerUser);
        }
        public AttackInfo SendAttack(string roomName, UserInfo user, string guess)
        {            
            return GameManager.Instance.SendAttack(roomName, user, guess);
        }
        public UserInfo GetUserOrderForRoom(string roomName)
        {
            return GameManager.Instance.GetUserOrderForRoom(roomName);
        }
        public AttackInfo GetLastAttackForPartner(UserInfo partnerUser)
        {
            return GameManager.Instance.GetLastAttackForPartner(partnerUser);
        }
        public void ChangePlayerOrder(string roomName)
        {
            GameManager.Instance.ChangePlayerOrder(roomName);
        }
    }
}
