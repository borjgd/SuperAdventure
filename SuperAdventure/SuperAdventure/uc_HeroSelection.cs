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
        private string heroType;
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

        private void btn_Back_HeroSelection(object sender, EventArgs e)
        {
            uc_MainMenu mainMenu = new uc_MainMenu();
            Parent.Controls.Add(mainMenu);
            Parent.Controls.Remove(instance);
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.BringToFront();
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            uc_Game gameScreen = new uc_Game(heroType);
            Parent.Controls.Add(gameScreen);
            Parent.Controls.Remove(instance);
            gameScreen.Dock = DockStyle.Fill;
            gameScreen.BringToFront();
        }

        private void checkTextAndSex(object sender, EventArgs e)
        {
            if(checkName() && checkSex())
            {
                btn_StartGame.Visible = true;
            }
            else
            {
                btn_StartGame.Visible = false;
            }
        }

        private bool checkName()
        {
            String text = txt_Name.Text.Trim();
            if(text != String.Empty)
            {
                if(text.Length < 3)
                {
                    lbl_NameError.Text = "Introduzca un nombre con al menos 3 caracteres";
                    return false;
                }
                else if(text.Any(Char.IsDigit))
                {
                    lbl_NameError.Text = "No se permiten números";
                    return false;
                }
                else
                {
                    lbl_NameError.Text = "";
                    return true;
                }
            }
            return false;
        }

        private bool checkSex()
        {
            if(cbm_Sex.Text != String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
