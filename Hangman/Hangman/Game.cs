using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Game(string word)
        {
            this.word = word.ToLower();

            InitializeComponent();
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
            lbTest.Text = wrongcount.ToString();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.instance.showSelection();
        }
    }
}
