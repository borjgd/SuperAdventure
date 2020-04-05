using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Character
    {
        // Attributes
        protected int strength { get; set; }
        protected int dexterity { get; set; }
        protected int constitution { get; set; }
        protected int intelligence { get; set; }
        protected int wisdom { get; set; }
        protected int charisma { get; set; }

        protected int currentHealth { get; set; }
        protected int maxHealth { get; set; }
        protected int mana { get; set; }
        protected int experience { get; set; }
        protected int level { get; set; }

        public Character()
        {

        }

    }
}
