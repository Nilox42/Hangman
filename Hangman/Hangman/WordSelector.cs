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
    public partial class WordSelector : Form
    {
        public WordSelector()
        {
            InitializeComponent();
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            string word = tbword.Text;
            Core.instance.StartGame(word);
        }

        private void Selection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.instance.showMainMenu();
        }

    }
}
