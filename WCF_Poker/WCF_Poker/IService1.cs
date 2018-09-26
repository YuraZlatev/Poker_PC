using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Poker
{
    [ServiceContract(CallbackContract =typeof(ICallback))]
    public interface IPoker
    {
        [OperationContract(IsOneWay = true)]
        void SendRooms(Player p, Card[] mass);          
        [OperationContract(IsOneWay = true)]
        void RemoveMe(Player p);
        [OperationContract]
        Player SendRoomId(int id, Player p);
        [OperationContract(IsOneWay = true)]
        void SendPlaceId(Player p, int id);
        [OperationContract(IsOneWay = true)]
        void SendBet(Player p, int bet);
        [OperationContract(IsOneWay = true)]
        //----------------------------------
        void PlayerFold(Player p);
        [OperationContract(IsOneWay = true)]
        void PlayerCheck(Player p);
        [OperationContract(IsOneWay = true)]
        void PlayerCall(Player p, int bet);
        [OperationContract(IsOneWay = true)]
        void PlayerRaise(Player p, int bet);
        [OperationContract(IsOneWay = true)]
        void PlayerAllIn(Player p, int bet);
        [OperationContract(IsOneWay = true)]
        void UpdateTime(Player p, int val);
        [OperationContract(IsOneWay = true)]
        void SendMessage(DateTime dt, Player p, String msg);
    }

    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void GetRooms(Room[] rooms);
        [OperationContract(IsOneWay = true)]
        void Update(Player[] p, Card[] cr);
        [OperationContract(IsOneWay = true)]
        void NewPlayer(Player p);
        [OperationContract(IsOneWay = true)]
        void RemovePlayer(Player p);
        [OperationContract(IsOneWay = true)]
        void GetCard(Player p, Card c);
        [OperationContract(IsOneWay = true)]
        void IsMove(bool flag, bool small, bool big);
        [OperationContract(IsOneWay = true)]
        void UpdateBet(Player p, int bet, int maxBet);
        [OperationContract(IsOneWay = true)]
        void PFold(Player p);
        [OperationContract(IsOneWay = true)]
        void CropieCard(Card c, int bet, int maxBet);
        [OperationContract(IsOneWay = true)]
        void GetRezOfGame(int playerBank, Player p, String combination);
        [OperationContract(IsOneWay = true)]
        void ClearDeck();
        [OperationContract(IsOneWay = true)]
        void OpenCards();
        [OperationContract(IsOneWay = true)]
        void UpdatePlayerTime(Player p, int val);
        [OperationContract(IsOneWay = true)]
        void GetMessage(DateTime dt, Player p, String msg);
    }
}
