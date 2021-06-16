using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ibrahim.Model
{
    /*
        Wcf servisimin dışarı göndereceği tüm
        bilgileri bu sınıf türünden gönderiyorum.
    */

    public enum Status
    {
        Success,
        Error
    }
    /*
        Wcf servisimizden dışarı göndereceğimiz MessageInfo içerisinde yer alan Data 
        property'si ile gönderceğim türleri KnownType attribute ile işaretlemem gerekiyor. 
    */
    [DataContract]
    [KnownType(typeof(RoomInfo))]
    [KnownType(typeof(AttackInfo))]
    [KnownType(typeof(UserInfo))]
    public class MessageInfo
    {
        [DataMember]
        public Status Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public object Data { get; set; }
    }
}

