using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_CORE_CHAT_UGH;
using Windows_Forms_CORE_CHAT_UGH.Properties;


//https://www.youtube.com/watch?v=xgLRe7QV6QI&ab_channel=HazardEditHazardEdit
namespace Windows_Forms_Chat
{
    public partial class Form1 : Form
    {
        RPSGame rps = new RPSGame();
        TCPChatServer server = null;
        TCPChatClient client = null;

        // store color code for panels
        private readonly Color colorCode1 = Color.FromArgb(90, Color.MediumPurple);
        private readonly Color colorCode2 = Color.FromArgb(150, Color.MediumPurple);

        public Form1()
        {
            InitializeComponent();
            ControlColor();
        }
        
        public bool CanHostOrJoin()
        {
            if (server == null && client == null)
                return true;
            else
                return false;
        }

        private void ControlColor() 
        {
            panel1.BackColor = colorCode1;
            panel2.BackColor = colorCode1;
            panel3.BackColor = colorCode1;
            panel4.BackColor = colorCode1;
            otherTile.BackColor = Color.FromArgb(150, Color.Crimson);
            myTile.BackColor = Color.FromArgb(150, Color.Blue);
            rock.BackColor = colorCode2;
            paper.BackColor = colorCode2;
            scissors.BackColor = colorCode2;
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            if (CanHostOrJoin())
            {
                try
                {
                    int port = int.Parse(MyPortTextBox.Text);
                    server = TCPChatServer.createInstance(port, ChatTextBox, rps);
                    //oh no, errors
                    if (server == null)
                        throw new Exception("Incorrect port value!");//thrown exceptions should exit the try and land in next catch

                    server.SetupServer();

                }
                catch (Exception ex)
                {
                    ChatTextBox.Text += "Error: " + ex ;
                    ChatTextBox.AppendText(Environment.NewLine);
                }
            }

        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (CanHostOrJoin())
            {
                try
                {
                    int port = int.Parse(MyPortTextBox.Text);
                    int serverPort = int.Parse(serverPortTextBox.Text);
                    client = TCPChatClient.CreateInstance(port, serverPort, ServerIPTextBox.Text, ChatTextBox, rps);
                    if (client == null)
                        throw new Exception("Incorrect port value!");//thrown exceptions should exit the try and land in next catch

                    client.ConnectToServer();
                    //ChatTextBox.AppendText("Please send your proposed username (!username [new_username])\n");


                    // begins Assignment 3 - Step 3
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    ChatTextBox.Text +=  form2.data + Environment.NewLine;
                    client.SendString("!username " + form2.username);

                }
                catch (Exception ex)
                {
                    client = null;
                    ChatTextBox.Text += "Error: " + ex;
                    ChatTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (client != null)
                client.SendString(TypeTextBox.Text);
            else if (server != null)
                server.SendToAll(TypeTextBox.Text, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On form loaded
            rps.boxes.Add(myTile);
            rps.boxes.Add(otherTile);

            // on form loaded, display default actions button
            rock.Image = Resources.rock;
            paper.Image = Resources.paper;
            scissors.Image = Resources.scissors;

            myTile.Image = Resources.blank;
            otherTile.Image = Resources.blank;
        }

        private void AttemptMove(String type) 
        {
            if (rps.myTurn) 
            {
                rps.Move(0, type);
                if (client != null)
                    client.SendString("mv@p1p2%" + type);

                rps.myTurn = false; // now player can't do any moves in the game
            }
        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rock_Click(object sender, EventArgs e)
        {
            AttemptMove("rock");
        }

        private void paper_Click(object sender, EventArgs e)
        {
            AttemptMove("paper");
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            AttemptMove("scissors");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ChatTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
