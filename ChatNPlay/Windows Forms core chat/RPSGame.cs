using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows_Forms_CORE_CHAT_UGH.Properties;

namespace Windows_Forms_Chat
{
   // GameState store data about the ongoing game
    public enum State 
    {
        playing, draw, p1Wins, p2Wins
    }

    public enum Choice
    {
        blank, rock, paper, scissors
    }

    public class RPSGame
    {
        // default player's can't do any action in the game
        public bool myTurn = false;

        public List<PictureBox> boxes = new List<PictureBox>();//assuming 2 in order

        public Choice[] grid = new Choice[2];


        public void ResetBoard()
        {
            grid[0] = Choice.blank;
            grid[1] = Choice.blank;

            foreach (PictureBox pb in boxes) 
            {
                pb.Image = Resources.blank;
            }
        }

        public Bitmap ChoiceToImage(String choice) 
        {
            if (choice.ToLower().Equals("rock"))
                return Resources.rock;
            else if (choice.ToLower().Equals("paper"))
                return Resources.paper;
            else
                return Resources.scissors;
        }

        public void Move(int index, String type)
        {
            if (grid[index] == Choice.blank) 
            { 
                grid[index] = GetChoice(type);
                boxes[index].Image = ChoiceToImage(type);
            }
        }

        public State CheckForWin()
        {
            if (grid[0] == grid[1])
            {
                return State.draw;
            }
            else if (grid[0] == Choice.rock && grid[1] == Choice.scissors)
            {
                return State.p1Wins;
            }
            else if (grid[0] == Choice.paper && grid[1] == Choice.rock)
            {
                return State.p1Wins;
            }
            else if (grid[0] == Choice.scissors && grid[1] == Choice.paper)
            {
                return State.p1Wins;
            }
            else if (grid[0] != Choice.blank && grid[1] != Choice.blank)
                return State.p2Wins;
            else
                return State.playing;
        }

        public Choice GetChoice(String choice) 
        {
            if (choice.ToLower().Equals("rock"))
                return Choice.rock;
            else if (choice.ToLower().Equals("paper"))
                return Choice.paper;
            else
                return Choice.scissors;
        }
    }
}
