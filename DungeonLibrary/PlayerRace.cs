using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PlayerRace : Player
    {
        private bool _isCimmerian;
        private bool _isShemite;
        private bool _isKushite;
        private bool _isStygian;
        private bool _isHimelian;

        public bool IsCimmerian
        {
            get { return _isCimmerian; }
            set { _isCimmerian = value; }
        }
        public bool IsShemite
        {
            get { return _isShemite; }
            set { _isShemite = value; }
        }
        public bool IsKushite
        {
            get { return _isKushite;}
            set { _isKushite = value;}
        }
        public bool IsStygian
        {
            get { return _isStygian;}
            set { _isStygian = value; }
        }
        public bool IsHimelian
        {
            get { return _isHimelian;}
            set { _isHimelian = value;}
        }

        public PlayerRace(string name, int hitChance, int block, int maxLife, RaceEnums playerRace, Weapon userChoice) : base(name, hitChance, block, maxLife, playerRace, userChoice)
        {
        }

    }
}
