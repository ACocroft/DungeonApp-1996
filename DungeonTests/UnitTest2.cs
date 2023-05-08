using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTests
{
    public class UnitTest2
    {
        private readonly Weapon equippedWeapon;

        [Fact]
        public void Life_CannotExceedMaxLife()
        {
            string name = "Test";
            int hitChance = 1;
            int block = 1;
            int maxLife = 100;
            int life = 80;

            Character character = new Player("name",1,1,100,RaceEnums.Cimmerian,equippedWeapon);
            character.Life = life + 50;

            Assert.Equal(maxLife, character.Life);
        }
    }
}
