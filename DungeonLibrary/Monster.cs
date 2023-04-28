namespace DungeonLibrary
{
    public class Monster : Character
    {
        //Props
        //MinDamage int - Field - Business Rule : > 0 && < MaxDamage
        //MaxDamage int
        //Description string
        #region Potential Expansion
        //Add a WeaponType for a weakness. Or a resistance. Or both. If you care.
        //You could then add functionality to tomorrow's combat class to deal additional damage
        //if the monster is weak to the weapon you have
        #endregion

        //Fields
        private int _maxDamage;
        private int _minDamage;

        //Properties
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value < MaxDamage && value > 0 ? value : 1; }

        }//end props
        public string Description { get; set; }
        //Constructor
        public Monster (string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description)
            : base(name,
                 hitChance,
                 block,
                 maxLife)
        {
            if (maxDamage <= minDamage || minDamage <= 0)
            {
              
            }
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster()
        {
        }

        //default ctor so we can have default monsters later

        //Override the ToString() to include your new custom props.
        //Override CalcDamage()
        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} - {MaxDamage}\n{Description}";
        }
        public override int CalcDamage()
        {
            //return a random number between your min and max damage properties.
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

       

    }
}
