using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ibrahim.OnlineGames.Properties;

namespace Ibrahim.OnlineGames.UserControls
{
    public enum IconType
    {
        Correct, Wrong
    }
    public partial class GuessObject : UserControl
    {
        int correctCount, wrongCount;

        public GuessObject()
        {
            InitializeComponent();
        }        
        void AddSmileyIcon(IconType type,int count)
        {
            Bitmap icon = (type == IconType.Correct) ?
                Resources.correct:Resources.wrong;
            for (int i = 0; i < count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BackColor = Color.Transparent;
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Width = 13;
                pb.Height = 13;
                pb.BackgroundImage = icon;

                if (type==IconType.Correct)
                {
                    flowCorrects.Controls.Add(pb);
                }
                else
                {
                    flowWrong.Controls.Add(pb);
                }
            }
        }
        public string Guess
        {
            get
            {
                return lblGuess.Text;
            }
            set
            {
                lblGuess.Text = value;
            }
        }
        public int CorrectCount
        {
            get
            {
                return correctCount;
            }
            set
            {
                correctCount = value;
                AddSmileyIcon(IconType.Correct, value);
            }
        }
        public int WrongCount
        {
            get
            {
                return wrongCount;
            }
            set
            {
                wrongCount = value;
                AddSmileyIcon(IconType.Wrong, value);
            }
        }
    }
}
