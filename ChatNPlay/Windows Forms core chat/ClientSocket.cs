using System;
using System.Net.Sockets;

namespace Windows_Forms_Chat
{
    // an enum to store the states of the client
    // login - when a client connects to the server
    // chatting - after successfully logged in to the server
    // playing - when a client join to play the game
    public enum ClientState 
    {
        login, chatting, playing
    }

    // created an enum to store the player numbers
    // nonplayer - clients who did not joined to a game
    // player1 - clients who joined to a team as a first player
    // player2 - clients who joined to a team as a second player
    public enum PlayerNumber 
    {
        nonplayer, player1, player2
    }

    public class ClientSocket
    {
        public Socket socket;
        public const int BUFFER_SIZE = 2048;
        public byte[] buffer = new byte[BUFFER_SIZE];

        // to store username for each client
        public String username = "";

        // to assign client or moderator
        public string role = "client";

        // to track each client state
        public ClientState state = ClientState.login;

        // to track the client current level
        public Double level = 1; 

        // to store what player they are
        public PlayerNumber player = PlayerNumber.nonplayer;
    }
}
