﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poker.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/WCF_Poker")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(int[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Poker.ServiceReference1.Card[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Poker.ServiceReference1.Card))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Poker.ServiceReference1.Room[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Poker.ServiceReference1.Room))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Poker.ServiceReference1.Player[]))]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Card[] bestCardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bestIdCombineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bestSumOfCardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int betField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bigBlindField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object cbField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool endMoveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idroomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int indexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isMoveNowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isOpenCardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isPlayNowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int moneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int placeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Card[] playerCardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool smallBlindField;
        
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
        public Poker.ServiceReference1.Card[] bestCards {
            get {
                return this.bestCardsField;
            }
            set {
                if ((object.ReferenceEquals(this.bestCardsField, value) != true)) {
                    this.bestCardsField = value;
                    this.RaisePropertyChanged("bestCards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bestIdCombine {
            get {
                return this.bestIdCombineField;
            }
            set {
                if ((this.bestIdCombineField.Equals(value) != true)) {
                    this.bestIdCombineField = value;
                    this.RaisePropertyChanged("bestIdCombine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bestSumOfCard {
            get {
                return this.bestSumOfCardField;
            }
            set {
                if ((this.bestSumOfCardField.Equals(value) != true)) {
                    this.bestSumOfCardField = value;
                    this.RaisePropertyChanged("bestSumOfCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bet {
            get {
                return this.betField;
            }
            set {
                if ((this.betField.Equals(value) != true)) {
                    this.betField = value;
                    this.RaisePropertyChanged("bet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bigBlind {
            get {
                return this.bigBlindField;
            }
            set {
                if ((this.bigBlindField.Equals(value) != true)) {
                    this.bigBlindField = value;
                    this.RaisePropertyChanged("bigBlind");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object cb {
            get {
                return this.cbField;
            }
            set {
                if ((object.ReferenceEquals(this.cbField, value) != true)) {
                    this.cbField = value;
                    this.RaisePropertyChanged("cb");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool endMove {
            get {
                return this.endMoveField;
            }
            set {
                if ((this.endMoveField.Equals(value) != true)) {
                    this.endMoveField = value;
                    this.RaisePropertyChanged("endMove");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idroom {
            get {
                return this.idroomField;
            }
            set {
                if ((this.idroomField.Equals(value) != true)) {
                    this.idroomField = value;
                    this.RaisePropertyChanged("idroom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int index {
            get {
                return this.indexField;
            }
            set {
                if ((this.indexField.Equals(value) != true)) {
                    this.indexField = value;
                    this.RaisePropertyChanged("index");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isMoveNow {
            get {
                return this.isMoveNowField;
            }
            set {
                if ((this.isMoveNowField.Equals(value) != true)) {
                    this.isMoveNowField = value;
                    this.RaisePropertyChanged("isMoveNow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isOpenCard {
            get {
                return this.isOpenCardField;
            }
            set {
                if ((this.isOpenCardField.Equals(value) != true)) {
                    this.isOpenCardField = value;
                    this.RaisePropertyChanged("isOpenCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isPlayNow {
            get {
                return this.isPlayNowField;
            }
            set {
                if ((this.isPlayNowField.Equals(value) != true)) {
                    this.isPlayNowField = value;
                    this.RaisePropertyChanged("isPlayNow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int money {
            get {
                return this.moneyField;
            }
            set {
                if ((this.moneyField.Equals(value) != true)) {
                    this.moneyField = value;
                    this.RaisePropertyChanged("money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int placeId {
            get {
                return this.placeIdField;
            }
            set {
                if ((this.placeIdField.Equals(value) != true)) {
                    this.placeIdField = value;
                    this.RaisePropertyChanged("placeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.ServiceReference1.Card[] playerCards {
            get {
                return this.playerCardsField;
            }
            set {
                if ((object.ReferenceEquals(this.playerCardsField, value) != true)) {
                    this.playerCardsField = value;
                    this.RaisePropertyChanged("playerCards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool smallBlind {
            get {
                return this.smallBlindField;
            }
            set {
                if ((this.smallBlindField.Equals(value) != true)) {
                    this.smallBlindField = value;
                    this.RaisePropertyChanged("smallBlind");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/WCF_Poker")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MastField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] imgField;
        
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
        public string Mast {
            get {
                return this.MastField;
            }
            set {
                if ((object.ReferenceEquals(this.MastField, value) != true)) {
                    this.MastField = value;
                    this.RaisePropertyChanged("Mast");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] img {
            get {
                return this.imgField;
            }
            set {
                if ((object.ReferenceEquals(this.imgField, value) != true)) {
                    this.imgField = value;
                    this.RaisePropertyChanged("img");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/WCF_Poker")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Card[] cardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Card[] cropieCardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int firstCheckField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idCardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idPlaceBigBlindField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isSuffleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int maxBetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool newCicleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool nextRoundField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] placeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int playerReadyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Player[] playersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int roomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Poker.ServiceReference1.Card[] tableCardsField;
        
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
        public int bank {
            get {
                return this.bankField;
            }
            set {
                if ((this.bankField.Equals(value) != true)) {
                    this.bankField = value;
                    this.RaisePropertyChanged("bank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.ServiceReference1.Card[] cards {
            get {
                return this.cardsField;
            }
            set {
                if ((object.ReferenceEquals(this.cardsField, value) != true)) {
                    this.cardsField = value;
                    this.RaisePropertyChanged("cards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.ServiceReference1.Card[] cropieCards {
            get {
                return this.cropieCardsField;
            }
            set {
                if ((object.ReferenceEquals(this.cropieCardsField, value) != true)) {
                    this.cropieCardsField = value;
                    this.RaisePropertyChanged("cropieCards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int firstCheck {
            get {
                return this.firstCheckField;
            }
            set {
                if ((this.firstCheckField.Equals(value) != true)) {
                    this.firstCheckField = value;
                    this.RaisePropertyChanged("firstCheck");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idCard {
            get {
                return this.idCardField;
            }
            set {
                if ((this.idCardField.Equals(value) != true)) {
                    this.idCardField = value;
                    this.RaisePropertyChanged("idCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idPlaceBigBlind {
            get {
                return this.idPlaceBigBlindField;
            }
            set {
                if ((this.idPlaceBigBlindField.Equals(value) != true)) {
                    this.idPlaceBigBlindField = value;
                    this.RaisePropertyChanged("idPlaceBigBlind");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isSuffle {
            get {
                return this.isSuffleField;
            }
            set {
                if ((this.isSuffleField.Equals(value) != true)) {
                    this.isSuffleField = value;
                    this.RaisePropertyChanged("isSuffle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int maxBet {
            get {
                return this.maxBetField;
            }
            set {
                if ((this.maxBetField.Equals(value) != true)) {
                    this.maxBetField = value;
                    this.RaisePropertyChanged("maxBet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool newCicle {
            get {
                return this.newCicleField;
            }
            set {
                if ((this.newCicleField.Equals(value) != true)) {
                    this.newCicleField = value;
                    this.RaisePropertyChanged("newCicle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool nextRound {
            get {
                return this.nextRoundField;
            }
            set {
                if ((this.nextRoundField.Equals(value) != true)) {
                    this.nextRoundField = value;
                    this.RaisePropertyChanged("nextRound");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] place {
            get {
                return this.placeField;
            }
            set {
                if ((object.ReferenceEquals(this.placeField, value) != true)) {
                    this.placeField = value;
                    this.RaisePropertyChanged("place");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int playerReady {
            get {
                return this.playerReadyField;
            }
            set {
                if ((this.playerReadyField.Equals(value) != true)) {
                    this.playerReadyField = value;
                    this.RaisePropertyChanged("playerReady");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.ServiceReference1.Player[] players {
            get {
                return this.playersField;
            }
            set {
                if ((object.ReferenceEquals(this.playersField, value) != true)) {
                    this.playersField = value;
                    this.RaisePropertyChanged("players");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int room {
            get {
                return this.roomField;
            }
            set {
                if ((this.roomField.Equals(value) != true)) {
                    this.roomField = value;
                    this.RaisePropertyChanged("room");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Poker.ServiceReference1.Card[] tableCards {
            get {
                return this.tableCardsField;
            }
            set {
                if ((object.ReferenceEquals(this.tableCardsField, value) != true)) {
                    this.tableCardsField = value;
                    this.RaisePropertyChanged("tableCards");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPoker", CallbackContract=typeof(Poker.ServiceReference1.IPokerCallback))]
    public interface IPoker {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendRooms")]
        void SendRooms(Poker.ServiceReference1.Player p, Poker.ServiceReference1.Card[] mass);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendRooms")]
        System.Threading.Tasks.Task SendRoomsAsync(Poker.ServiceReference1.Player p, Poker.ServiceReference1.Card[] mass);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/RemoveMe")]
        void RemoveMe(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/RemoveMe")]
        System.Threading.Tasks.Task RemoveMeAsync(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPoker/SendRoomId", ReplyAction="http://tempuri.org/IPoker/SendRoomIdResponse")]
        Poker.ServiceReference1.Player SendRoomId(int id, Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPoker/SendRoomId", ReplyAction="http://tempuri.org/IPoker/SendRoomIdResponse")]
        System.Threading.Tasks.Task<Poker.ServiceReference1.Player> SendRoomIdAsync(int id, Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendPlaceId")]
        void SendPlaceId(Poker.ServiceReference1.Player p, int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendPlaceId")]
        System.Threading.Tasks.Task SendPlaceIdAsync(Poker.ServiceReference1.Player p, int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendBet")]
        void SendBet(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendBet")]
        System.Threading.Tasks.Task SendBetAsync(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerFold")]
        void PlayerFold(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerFold")]
        System.Threading.Tasks.Task PlayerFoldAsync(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerCheck")]
        void PlayerCheck(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerCheck")]
        System.Threading.Tasks.Task PlayerCheckAsync(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerCall")]
        void PlayerCall(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerCall")]
        System.Threading.Tasks.Task PlayerCallAsync(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerRaise")]
        void PlayerRaise(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerRaise")]
        System.Threading.Tasks.Task PlayerRaiseAsync(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerAllIn")]
        void PlayerAllIn(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PlayerAllIn")]
        System.Threading.Tasks.Task PlayerAllInAsync(Poker.ServiceReference1.Player p, int bet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/UpdateTime")]
        void UpdateTime(Poker.ServiceReference1.Player p, int val);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/UpdateTime")]
        System.Threading.Tasks.Task UpdateTimeAsync(Poker.ServiceReference1.Player p, int val);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendMessage")]
        void SendMessage(System.DateTime dt, Poker.ServiceReference1.Player p, string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(System.DateTime dt, Poker.ServiceReference1.Player p, string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPokerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/GetRooms")]
        void GetRooms(Poker.ServiceReference1.Room[] rooms);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/Update")]
        void Update(Poker.ServiceReference1.Player[] p, Poker.ServiceReference1.Card[] cr);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/NewPlayer")]
        void NewPlayer(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/RemovePlayer")]
        void RemovePlayer(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/GetCard")]
        void GetCard(Poker.ServiceReference1.Player p, Poker.ServiceReference1.Card c);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/IsMove")]
        void IsMove(bool flag, bool small, bool big);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/UpdateBet")]
        void UpdateBet(Poker.ServiceReference1.Player p, int bet, int maxBet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/PFold")]
        void PFold(Poker.ServiceReference1.Player p);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/CropieCard")]
        void CropieCard(Poker.ServiceReference1.Card c, int bet, int maxBet);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/GetRezOfGame")]
        void GetRezOfGame(int playerBank, Poker.ServiceReference1.Player p, string combination);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/ClearDeck")]
        void ClearDeck();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/OpenCards")]
        void OpenCards();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/UpdatePlayerTime")]
        void UpdatePlayerTime(Poker.ServiceReference1.Player p, int val);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPoker/GetMessage")]
        void GetMessage(System.DateTime dt, Poker.ServiceReference1.Player p, string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPokerChannel : Poker.ServiceReference1.IPoker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PokerClient : System.ServiceModel.DuplexClientBase<Poker.ServiceReference1.IPoker>, Poker.ServiceReference1.IPoker {
        
        public PokerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PokerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PokerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PokerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PokerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SendRooms(Poker.ServiceReference1.Player p, Poker.ServiceReference1.Card[] mass) {
            base.Channel.SendRooms(p, mass);
        }
        
        public System.Threading.Tasks.Task SendRoomsAsync(Poker.ServiceReference1.Player p, Poker.ServiceReference1.Card[] mass) {
            return base.Channel.SendRoomsAsync(p, mass);
        }
        
        public void RemoveMe(Poker.ServiceReference1.Player p) {
            base.Channel.RemoveMe(p);
        }
        
        public System.Threading.Tasks.Task RemoveMeAsync(Poker.ServiceReference1.Player p) {
            return base.Channel.RemoveMeAsync(p);
        }
        
        public Poker.ServiceReference1.Player SendRoomId(int id, Poker.ServiceReference1.Player p) {
            return base.Channel.SendRoomId(id, p);
        }
        
        public System.Threading.Tasks.Task<Poker.ServiceReference1.Player> SendRoomIdAsync(int id, Poker.ServiceReference1.Player p) {
            return base.Channel.SendRoomIdAsync(id, p);
        }
        
        public void SendPlaceId(Poker.ServiceReference1.Player p, int id) {
            base.Channel.SendPlaceId(p, id);
        }
        
        public System.Threading.Tasks.Task SendPlaceIdAsync(Poker.ServiceReference1.Player p, int id) {
            return base.Channel.SendPlaceIdAsync(p, id);
        }
        
        public void SendBet(Poker.ServiceReference1.Player p, int bet) {
            base.Channel.SendBet(p, bet);
        }
        
        public System.Threading.Tasks.Task SendBetAsync(Poker.ServiceReference1.Player p, int bet) {
            return base.Channel.SendBetAsync(p, bet);
        }
        
        public void PlayerFold(Poker.ServiceReference1.Player p) {
            base.Channel.PlayerFold(p);
        }
        
        public System.Threading.Tasks.Task PlayerFoldAsync(Poker.ServiceReference1.Player p) {
            return base.Channel.PlayerFoldAsync(p);
        }
        
        public void PlayerCheck(Poker.ServiceReference1.Player p) {
            base.Channel.PlayerCheck(p);
        }
        
        public System.Threading.Tasks.Task PlayerCheckAsync(Poker.ServiceReference1.Player p) {
            return base.Channel.PlayerCheckAsync(p);
        }
        
        public void PlayerCall(Poker.ServiceReference1.Player p, int bet) {
            base.Channel.PlayerCall(p, bet);
        }
        
        public System.Threading.Tasks.Task PlayerCallAsync(Poker.ServiceReference1.Player p, int bet) {
            return base.Channel.PlayerCallAsync(p, bet);
        }
        
        public void PlayerRaise(Poker.ServiceReference1.Player p, int bet) {
            base.Channel.PlayerRaise(p, bet);
        }
        
        public System.Threading.Tasks.Task PlayerRaiseAsync(Poker.ServiceReference1.Player p, int bet) {
            return base.Channel.PlayerRaiseAsync(p, bet);
        }
        
        public void PlayerAllIn(Poker.ServiceReference1.Player p, int bet) {
            base.Channel.PlayerAllIn(p, bet);
        }
        
        public System.Threading.Tasks.Task PlayerAllInAsync(Poker.ServiceReference1.Player p, int bet) {
            return base.Channel.PlayerAllInAsync(p, bet);
        }
        
        public void UpdateTime(Poker.ServiceReference1.Player p, int val) {
            base.Channel.UpdateTime(p, val);
        }
        
        public System.Threading.Tasks.Task UpdateTimeAsync(Poker.ServiceReference1.Player p, int val) {
            return base.Channel.UpdateTimeAsync(p, val);
        }
        
        public void SendMessage(System.DateTime dt, Poker.ServiceReference1.Player p, string msg) {
            base.Channel.SendMessage(dt, p, msg);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(System.DateTime dt, Poker.ServiceReference1.Player p, string msg) {
            return base.Channel.SendMessageAsync(dt, p, msg);
        }
    }
}