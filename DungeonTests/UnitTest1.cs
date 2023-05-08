using DungeonLibrary;
using Xunit;
namespace DungeonTests
{
    public class UnitTest1
    {
        [Fact]
        public void Damage_ShouldBeBetweenMinAndMax()
        {
            string weaponName = "Broadsword";
            int minDamage = 1;
            int maxDamage = 8;
            int bonusHitChance = 10;
            bool isTwoHanded = false;
            WeaponType weaponType = WeaponType.Broadsword;

            Weapon weapon = new Weapon(weaponName, minDamage, maxDamage, bonusHitChance, isTwoHanded, weaponType);

            int damage = 5;
            bool isInRange = damage >= weapon.MinDamage && damage <= weapon.MaxDamage;

            Assert.True(isInRange);
        }

        [Fact]
        public void Damage_ShouldNotBeBelowMin()
        {
            string weaponName = "Broadsword";
            int minDamage = 1;
            int maxDamage = 8;
            int bonusHitChance = 10;
            bool isTwoHanded = false;
            WeaponType weaponType = WeaponType.Broadsword;

            Weapon weapon = new Weapon(weaponName, minDamage, maxDamage, bonusHitChance, isTwoHanded, weaponType);

            int damage = 0;
            bool isInRange = damage >= weapon.MinDamage && damage <= weapon.MaxDamage;

            Assert.False(isInRange);
        }
        
        [Fact]
        public void Damage_ShouldNotBeGreaterThanMax()
        {
            string weaponName = "Broadsword";
            int minDamage = 1;
            int maxDamage = 8;
            int bonusHitChance = 10;
            bool isTwoHanded = false;
            WeaponType weaponType = WeaponType.Broadsword;

            Weapon weapon = new Weapon(weaponName, minDamage, maxDamage, bonusHitChance, isTwoHanded, weaponType);

            int damage = 9;
            bool isInRange = damage >= weapon.MinDamage && damage <= weapon.MaxDamage;

            Assert.False(isInRange);
        }
    }
}