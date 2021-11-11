using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeyWildDungeon
{
    public class Player
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get;set; }
        public int Speed { get; set; }

        public Player()
        {
            this.Health = 100;
            this.Damage = 20;
            this.Speed = 15;
            //Setting default values for player
        }
    }
}
