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

        MainMenu mainmenu = null;
        Game game = null;
        WordSelector selection = null;

        public Core()
        {
            instance = this;
            InitializeComponent();
        }

        private void Core_Load(object sender, EventArgs e)
        {
            HideForm();
            showMainMenu();
        }

        public async void HideForm()
        {
            await Task.Delay(100);
            this.Hide();
        }

        #region show / hide
        public void hideMainMenu()
        {
            if(mainmenu != null)
            {
                mainmenu.Hide();
                mainmenu.Close();
                mainmenu = null;
            }
        }
        public void showMainMenu()
        {
            hideGame();
            hideSelection();

            mainmenu = new MainMenu();
            mainmenu.Show();
        }

        public void hideSelection()
        {
            if (game != null)
            {
                game.Hide();
                game.Dispose();
                game = null;
            }
        }
        public void showSelection()
        {
            hideGame();
            hideMainMenu();

            selection = new WordSelector();
            selection.Show();
        }

        public void hideGame()
        {
            if (selection != null)
            {
                selection.Hide();
                selection.Dispose();
                selection = null;
            }
        }
        public void StartGame(string word)
        {
            hideMainMenu();
            hideSelection();

            game = new Game(word);
            game.Show();
        }
        #endregion


    }
}
