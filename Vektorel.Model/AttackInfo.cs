using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ibrahim.Model
{
    [DataContract]
    public class AttackInfo
    {
        [DataMember]
        public UserInfo User { get; set; }
        [DataMember]
        public int CorrectPosition { get; set; }
        [DataMember]
        public int WrongPosition { get; set; }
        [DataMember]
        public DateTime AttackDate { get; set; }
        [DataMember]
        public string Guess { get; set; }
    }
}
