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
        public uc_Game()
        {
            InitializeComponent();
            _player = new Player();
        }
    }
}
