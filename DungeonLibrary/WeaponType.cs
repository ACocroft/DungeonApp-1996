using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Weapon will include a WeaponType, make it public, and make it an Enum.
    //Add at least 5 types of weapons.
    //The intent of this is to provide potential expansions, such as a monster being weak to
    //a particular type of weapon, or resistant, or both.
    internal enum WeaponType
    {
        Scimitar,
        Broadsword,
        Greatsword,
        Axe,
        Fists
    }
}
