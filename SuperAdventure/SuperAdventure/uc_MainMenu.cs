using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class uc_MainMenu : UserControl
    {
        private static uc_MainMenu _instance;

        public static uc_MainMenu instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uc_MainMenu();
                }
                return _instance;
            }
        }

        public uc_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            uc_HeroSelection heroSelectionMenu = new uc_HeroSelection();
            Parent.Controls.Add(heroSelectionMenu);
            Parent.Controls.Remove(instance);
            heroSelectionMenu.Dock = DockStyle.Fill;
            heroSelectionMenu.BringToFront();

        }

        private void btn_LoadGame_Click(object sender, EventArgs e)
        {

        }

        private void btn_Options_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
