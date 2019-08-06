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

        }

        private void pB_Warrior_Click(object sender, EventArgs e)
        {
            change_PictureBoxes_Border();
            pB_Warrior.BorderStyle = BorderStyle.Fixed3D;
            lbl_ChosenHero.Text = "Warrior";
            
        }

        private void pB_Mage_Click(object sender, EventArgs e)
        {
            change_PictureBoxes_Border();
            pB_Mage.BorderStyle = BorderStyle.Fixed3D;
            lbl_ChosenHero.Text = "Mage";
        }

        private void pB_Rogue_Click(object sender, EventArgs e)
        {
            change_PictureBoxes_Border();
            pB_Rogue.BorderStyle = BorderStyle.Fixed3D;
            lbl_ChosenHero.Text = "Rogue";
        }

        private void pB_Paladin_Click(object sender, EventArgs e)
        {
            change_PictureBoxes_Border();
            pB_Paladin.BorderStyle = BorderStyle.Fixed3D;
            lbl_ChosenHero.Text = "Paladin";
        }

        private void change_PictureBoxes_Border()
        {
            if (btn_StartGame.Visible == false)
            {
                btn_StartGame.Visible = true;
            }
            
            if (pB_Warrior.BorderStyle == BorderStyle.Fixed3D)
            {
                pB_Warrior.BorderStyle = BorderStyle.FixedSingle;
            }

            if (pB_Mage.BorderStyle == BorderStyle.Fixed3D)
            {
                pB_Mage.BorderStyle = BorderStyle.FixedSingle;
            }

            if (pB_Rogue.BorderStyle == BorderStyle.Fixed3D)
            {
                pB_Rogue.BorderStyle = BorderStyle.FixedSingle;
            }

            if (pB_Paladin.BorderStyle == BorderStyle.Fixed3D)
            {
                pB_Paladin.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
