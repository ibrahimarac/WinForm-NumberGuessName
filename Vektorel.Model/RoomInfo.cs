using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ibrahim.Model
{
    [DataContract]
    public class RoomInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public UserInfo User1 { get; set; }
        [DataMember]
        public string User1Number { get; set; }
        [DataMember]
        public DateTime User1JoinDate { get; set; }
        [DataMember]
        public UserInfo User2 { get; set; }
        [DataMember]
        public string User2Number { get; set; }
        [DataMember]
        public DateTime User2JoinDate { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public UserInfo ActiveUser { get; set; }

    }
}
