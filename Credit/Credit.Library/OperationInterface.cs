﻿using Credit.Protocol;
using System.Net;

namespace Credit.Library
{
    public interface OperationInterface
    {
        bool Register(IPAddress lastConnectedIPAddress, string account, string password, string nickname, out ReturnCode returnCode, out string errorMessage);
        bool Login(string account, string password, out ReturnCode returnCode, out string errorMessage, out Player player);
        bool CreateDeck(int playerID, string deckName, out ReturnCode returnCode, out string errorMessage, out Deck deck);
        bool DeleteDeck(int deckID, out ReturnCode returnCode, out string errorMessage);
        void FindOpponent(Player player, Deck deck);
    }
}
