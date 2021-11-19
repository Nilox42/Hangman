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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Input
        private void btplay_Click(object sender, EventArgs e)
        {
            Core.instance.showSelection();
        }

        private void btsettings_Click(object sender, EventArgs e)
        {

        }

        private void btend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion












    }
}
