using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeyWildDungeon
{

    public class Room
    {
        private readonly Dictionary<string, Room> _rooms = new Dictionary<string, Room>
        {
            {"Treasure Room", new Room("Treasure Room!", false,false,true) },
            {"Poison Mushrooms", new Room("Mushroom Path", true,true,true) },
            {"Deep Mud", new Room("Muddy Patch", true,true,true) },
            {"Clearing", new Room("Clearing", false, true, false) },
            {"Small Cave", new Room("Small Cave", true, true, true) },
            {"Heavy Fog", new Room("Heavy Fog", true, false, false) }
        };

        public Room(){}
        public Room(string name, bool statusEffect, bool enemyIsAlive, bool hasReward)
        {
            Name = name;
            StatusEffect = statusEffect;
            EnemyIsAlive = enemyIsAlive;
            HasReward = hasReward;
        }

        public string Name { get; set; }
        public bool StatusEffect { get; set; }
        public bool EnemyIsAlive { get; set; }
        public bool HasReward { get; set; }

        public Room CreateRoom()
        {
            //Getting random number for room dictionary
            Random random = new Random();
            int randomKey = (random.Next(0, _rooms.Count()));

            //Getting dictionary element by random number
            KeyValuePair<string, Room> keyValuePair = _rooms.ElementAt(randomKey);
            Room generatedRoom = keyValuePair.Value;
            return generatedRoom;
        }
    }
}
