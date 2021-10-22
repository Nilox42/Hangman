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
    public partial class Core : Form
    {
        public static Core instance = null;

        Game game = null;
        Selection selection = null;

        public Core()
        {
            instance = this;
            InitializeComponent();
        }

        private void Core_Load(object sender, EventArgs e)
        {
            HideForm();
            showSelection();
        }

        public async void HideForm()
        {
            await Task.Delay(100);
            this.Hide();
        }

        public void showSelection()
        {
            if (game != null)
            {
                game.Hide();
                game.Dispose();
                game = null;
            }

            selection = new Selection();
            selection.Show();
        }

        public void StartGame(string word)
        {
            if (selection != null)
            {
                selection.Hide();
                selection.Dispose();
                selection = null;
            }

            game = new Game(word);
            game.Show();
        }

    }
}
