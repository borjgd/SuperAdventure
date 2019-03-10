using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventureForm : Form
    {
        public SuperAdventureForm()
        {
            InitializeComponent();
        }
        // Load the main menu usser control
        private void SuperAdventureForm_Load(object sender, EventArgs e)
        {
            if (!pn_MainPanel.Controls.Contains(uc_MainMenu.instance))
            {
                pn_MainPanel.Controls.Add(uc_MainMenu.instance);
                uc_MainMenu.instance.Dock = DockStyle.Fill;
                uc_MainMenu.instance.BringToFront();
            }
        }
    }
}
