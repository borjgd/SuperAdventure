using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.Models;

namespace SuperAdventure
{
    public partial class uc_Game : UserControl
    {
        private Player _player;
        public String hero;
        public uc_Game(String pHero)
        {
            InitializeComponent();
            hero = pHero;
            MessageBox.Show(hero);
            _player = new Player();
        }
    }
}
