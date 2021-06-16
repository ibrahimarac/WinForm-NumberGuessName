using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ibrahim.Model
{
    /*
        Servisin login olan kullanıcı bilgilerini
        döndürebilmesi için aşağıdaki sınıf kullanılacak.
    */

    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public DateTime LastLoginDate { get; set; }
        [DataMember]
        public DateTime LastActivityDate { get; set; }

    }
}


