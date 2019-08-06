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
    public partial class uc_HeroSelection : UserControl
    {

        private static uc_HeroSelection _instance;

        public static uc_HeroSelection instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uc_HeroSelection();
                }
                return _instance;
            }
        }
        public uc_HeroSelection()
        {
            InitializeComponent();
        }

        private void heroSelection_back_button_Click(object sender, EventArgs e)
        {
            uc_MainMenu mainMenu = new uc_MainMenu();
            Parent.Controls.Add(mainMenu);
            Parent.Controls.Remove(instance);
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.BringToFront();
        }
    }
}
