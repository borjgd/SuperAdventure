using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : Character
    {
        // Estados de los personajes para determinar los diálogos
        public enum player_states
        {
            CAOTIC,
            NEUTRAL,
            LEGAL
        }

        public player_states _state;
        public int gold { get; set; }

        public Player()
        {
            _state = player_states.NEUTRAL;
            setInitialAttributes();
            gold = 10;
        }

        public Player(player_states state)
        {
            _state = state;
            gold = 0;
        }

        public void setInitialAttributes()
        {
            base.strength = 10;
            base.dexterity = 10;
            base.constitution = 10;
            base.intelligence = 10;
            base.wisdom = 10;
            base.charisma = 10;

            base.currentHealth = 10;
            base.maxHealth = 10;
            base.mana = 10;
            base.experience = 0;
            base.level = 1;
        }
    }
}
