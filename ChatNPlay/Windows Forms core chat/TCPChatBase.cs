using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Windows_Forms_Chat
{

    public class TCPChatBase
    {
        public TextBox chatTextBox;
        public int port;
        public RPSGame game;

        public void SetChat(string str)
        {
            chatTextBox.Invoke((Action)delegate
            {
                chatTextBox.Text = str;
                chatTextBox.AppendText(Environment.NewLine);
            });
        }
        public void AddToChat(string str)
        {
            //dumb https://iandotnet.wordpress.com/tag/multithreading-how-to-update-textbox-on-gui-from-another-thread/
            chatTextBox.Invoke((Action)delegate
            {
                chatTextBox.AppendText(str);
                chatTextBox.AppendText(Environment.NewLine);
            });
        }

        public void UpdateGame(int index, string move) 
        {
            game.Move(index,move);
        }

        public void ResetBoard() 
        {
            game.ResetBoard();
        }
    }
}
