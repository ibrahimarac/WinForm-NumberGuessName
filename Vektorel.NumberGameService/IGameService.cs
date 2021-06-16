using Ibrahim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ibrahim.NumberGameService
{

    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        MessageInfo SignUp(string userName,string password,string email);
        [OperationContract]
        MessageInfo LogIn(string userName, string password);
        [OperationContract]
        MessageInfo CreateRoom(string roomName);
        [OperationContract]
        List<RoomInfo> GetAllEmptyRooms(UserInfo currentUser);
        [OperationContract]
        MessageInfo GetPartnerForUser(string roomName, UserInfo user);
        [OperationContract]
        MessageInfo JoinRoom(string roomName, UserInfo user,string userNumber);
        [OperationContract]
        MessageInfo LeaveRoom(string roomName, UserInfo user);
        [OperationContract]
        bool UserActivityTest(string roomName, UserInfo partnerUser);
        [OperationContract]
        AttackInfo SendAttack(string roomName, UserInfo user, string guess);
        [OperationContract]
        UserInfo GetUserOrderForRoom(string roomName);
        [OperationContract]
        AttackInfo GetLastAttackForPartner(UserInfo partnerUser);
        [OperationContract]
        void ChangePlayerOrder(string roomName);
    }
}



