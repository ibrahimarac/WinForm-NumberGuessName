//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ibrahim.OnlineGames.NumberGameService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageInfo", Namespace="http://schemas.datacontract.org/2004/07/Vektorel.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Ibrahim.OnlineGames.NumberGameService.Status))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Ibrahim.OnlineGames.NumberGameService.RoomInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Ibrahim.OnlineGames.NumberGameService.UserInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Ibrahim.OnlineGames.NumberGameService.AttackInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Ibrahim.OnlineGames.NumberGameService.RoomInfo[]))]
    public partial class MessageInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Ibrahim.OnlineGames.NumberGameService.Status ResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ibrahim.OnlineGames.NumberGameService.Status Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/Vektorel.Model")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomInfo", Namespace="http://schemas.datacontract.org/2004/07/Vektorel.Model")]
    [System.SerializableAttribute()]
    public partial class RoomInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Ibrahim.OnlineGames.NumberGameService.UserInfo ActiveUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Ibrahim.OnlineGames.NumberGameService.UserInfo User1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime User1JoinDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string User1NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Ibrahim.OnlineGames.NumberGameService.UserInfo User2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime User2JoinDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string User2NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ibrahim.OnlineGames.NumberGameService.UserInfo ActiveUser {
            get {
                return this.ActiveUserField;
            }
            set {
                if ((object.ReferenceEquals(this.ActiveUserField, value) != true)) {
                    this.ActiveUserField = value;
                    this.RaisePropertyChanged("ActiveUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ibrahim.OnlineGames.NumberGameService.UserInfo User1 {
            get {
                return this.User1Field;
            }
            set {
                if ((object.ReferenceEquals(this.User1Field, value) != true)) {
                    this.User1Field = value;
                    this.RaisePropertyChanged("User1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime User1JoinDate {
            get {
                return this.User1JoinDateField;
            }
            set {
                if ((this.User1JoinDateField.Equals(value) != true)) {
                    this.User1JoinDateField = value;
                    this.RaisePropertyChanged("User1JoinDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User1Number {
            get {
                return this.User1NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.User1NumberField, value) != true)) {
                    this.User1NumberField = value;
                    this.RaisePropertyChanged("User1Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ibrahim.OnlineGames.NumberGameService.UserInfo User2 {
            get {
                return this.User2Field;
            }
            set {
                if ((object.ReferenceEquals(this.User2Field, value) != true)) {
                    this.User2Field = value;
                    this.RaisePropertyChanged("User2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime User2JoinDate {
            get {
                return this.User2JoinDateField;
            }
            set {
                if ((this.User2JoinDateField.Equals(value) != true)) {
                    this.User2JoinDateField = value;
                    this.RaisePropertyChanged("User2JoinDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User2Number {
            get {
                return this.User2NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.User2NumberField, value) != true)) {
                    this.User2NumberField = value;
                    this.RaisePropertyChanged("User2Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/Vektorel.Model")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastActivityDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastLoginDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastActivityDate {
            get {
                return this.LastActivityDateField;
            }
            set {
                if ((this.LastActivityDateField.Equals(value) != true)) {
                    this.LastActivityDateField = value;
                    this.RaisePropertyChanged("LastActivityDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastLoginDate {
            get {
                return this.LastLoginDateField;
            }
            set {
                if ((this.LastLoginDateField.Equals(value) != true)) {
                    this.LastLoginDateField = value;
                    this.RaisePropertyChanged("LastLoginDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AttackInfo", Namespace="http://schemas.datacontract.org/2004/07/Vektorel.Model")]
    [System.SerializableAttribute()]
    public partial class AttackInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AttackDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CorrectPositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GuessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Ibrahim.OnlineGames.NumberGameService.UserInfo UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WrongPositionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AttackDate {
            get {
                return this.AttackDateField;
            }
            set {
                if ((this.AttackDateField.Equals(value) != true)) {
                    this.AttackDateField = value;
                    this.RaisePropertyChanged("AttackDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CorrectPosition {
            get {
                return this.CorrectPositionField;
            }
            set {
                if ((this.CorrectPositionField.Equals(value) != true)) {
                    this.CorrectPositionField = value;
                    this.RaisePropertyChanged("CorrectPosition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Guess {
            get {
                return this.GuessField;
            }
            set {
                if ((object.ReferenceEquals(this.GuessField, value) != true)) {
                    this.GuessField = value;
                    this.RaisePropertyChanged("Guess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ibrahim.OnlineGames.NumberGameService.UserInfo User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WrongPosition {
            get {
                return this.WrongPositionField;
            }
            set {
                if ((this.WrongPositionField.Equals(value) != true)) {
                    this.WrongPositionField = value;
                    this.RaisePropertyChanged("WrongPosition");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NumberGameService.IGameService")]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/SignUp", ReplyAction="http://tempuri.org/IGameService/SignUpResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo SignUp(string userName, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/LogIn", ReplyAction="http://tempuri.org/IGameService/LogInResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo LogIn(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/CreateRoom", ReplyAction="http://tempuri.org/IGameService/CreateRoomResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo CreateRoom(string roomName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetAllEmptyRooms", ReplyAction="http://tempuri.org/IGameService/GetAllEmptyRoomsResponse")]
        Ibrahim.OnlineGames.NumberGameService.RoomInfo[] GetAllEmptyRooms(Ibrahim.OnlineGames.NumberGameService.UserInfo currentUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetPartnerForUser", ReplyAction="http://tempuri.org/IGameService/GetPartnerForUserResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo GetPartnerForUser(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/JoinRoom", ReplyAction="http://tempuri.org/IGameService/JoinRoomResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo JoinRoom(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user, string userNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/LeaveRoom", ReplyAction="http://tempuri.org/IGameService/LeaveRoomResponse")]
        Ibrahim.OnlineGames.NumberGameService.MessageInfo LeaveRoom(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/UserActivityTest", ReplyAction="http://tempuri.org/IGameService/UserActivityTestResponse")]
        bool UserActivityTest(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo partnerUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/SendAttack", ReplyAction="http://tempuri.org/IGameService/SendAttackResponse")]
        Ibrahim.OnlineGames.NumberGameService.AttackInfo SendAttack(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user, string guess);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetUserOrderForRoom", ReplyAction="http://tempuri.org/IGameService/GetUserOrderForRoomResponse")]
        Ibrahim.OnlineGames.NumberGameService.UserInfo GetUserOrderForRoom(string roomName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetLastAttackForPartner", ReplyAction="http://tempuri.org/IGameService/GetLastAttackForPartnerResponse")]
        Ibrahim.OnlineGames.NumberGameService.AttackInfo GetLastAttackForPartner(Ibrahim.OnlineGames.NumberGameService.UserInfo partnerUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/ChangePlayerOrder", ReplyAction="http://tempuri.org/IGameService/ChangePlayerOrderResponse")]
        void ChangePlayerOrder(string roomName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceChannel : Ibrahim.OnlineGames.NumberGameService.IGameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServiceClient : System.ServiceModel.ClientBase<Ibrahim.OnlineGames.NumberGameService.IGameService>, Ibrahim.OnlineGames.NumberGameService.IGameService {
        
        public GameServiceClient() {
        }
        
        public GameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo SignUp(string userName, string password, string email) {
            return base.Channel.SignUp(userName, password, email);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo LogIn(string userName, string password) {
            return base.Channel.LogIn(userName, password);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo CreateRoom(string roomName) {
            return base.Channel.CreateRoom(roomName);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.RoomInfo[] GetAllEmptyRooms(Ibrahim.OnlineGames.NumberGameService.UserInfo currentUser) {
            return base.Channel.GetAllEmptyRooms(currentUser);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo GetPartnerForUser(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user) {
            return base.Channel.GetPartnerForUser(roomName, user);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo JoinRoom(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user, string userNumber) {
            return base.Channel.JoinRoom(roomName, user, userNumber);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.MessageInfo LeaveRoom(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user) {
            return base.Channel.LeaveRoom(roomName, user);
        }
        
        public bool UserActivityTest(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo partnerUser) {
            return base.Channel.UserActivityTest(roomName, partnerUser);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.AttackInfo SendAttack(string roomName, Ibrahim.OnlineGames.NumberGameService.UserInfo user, string guess) {
            return base.Channel.SendAttack(roomName, user, guess);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.UserInfo GetUserOrderForRoom(string roomName) {
            return base.Channel.GetUserOrderForRoom(roomName);
        }
        
        public Ibrahim.OnlineGames.NumberGameService.AttackInfo GetLastAttackForPartner(Ibrahim.OnlineGames.NumberGameService.UserInfo partnerUser) {
            return base.Channel.GetLastAttackForPartner(partnerUser);
        }
        
        public void ChangePlayerOrder(string roomName) {
            base.Channel.ChangePlayerOrder(roomName);
        }
    }
}
