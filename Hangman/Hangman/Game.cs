using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Game : Form
    {
        string word = "";
        int wrongcount = 0;
        List<string> foundletters = new List<string>();
        List<Image> images = new List<Image>();

        public Game(string word)
        {
            this.word = word.ToLower();

            for (int i = 0; i < 7; i++)
            {
                images.Add(new Bitmap(Directory.GetCurrentDirectory() + @"\assets\pictures\Hangman " + i + ".png"));
            }

            InitializeComponent();

            pictureBox1.BackgroundImage = images.ElementAt(0);
        }

        private void bttestletter_Click(object sender, EventArgs e)
        {
            string totest = tbtest.Text.ToLower();
            if (totest.Length == 1)
            {
                bool succes = Test(tbtest.Text);
                if (succes)
                {
                    revealLetter(totest);
                }
                else
                {
                    incrementImage();
                }
            }
            else
            {
                lbdebug.Text = "You have to enter a single letter!";
            }
        }


        public bool Test(string letter)
        {
            if (word.Contains(letter.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void revealLetter(string totest)
        {
            foundletters.Add(totest);

            string res = "";

            for (int i = 0; i < word.Length; i++)
            {
                string sub = word.Substring(i, 1);
                if (foundletters.Contains(sub))
                {
                    res += sub;
                }
                else
                {
                    res += "-";
                }
            }

            lbword.Text = res;
        }

        public void incrementImage()
        {
            wrongcount++;
            if (wrongcount < 6)
            {
                pictureBox1.BackgroundImage = images.ElementAt(wrongcount);
            }
            if (wrongcount >= 6)
            {
                pictureBox1.BackgroundImage = images.ElementAt(6);

                tbtest.Enabled = false;
                bttestletter.Enabled = false;
                lbdebug.Text = "Close Window to return to Menu";
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.instance.showMainMenu();
        }
    }
}
