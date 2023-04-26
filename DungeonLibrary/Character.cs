namespace DungeonLibrary
{
    public class Character
    {
        public static void Header(string title)
        {
            Console.Title = title.ToUpper();
            Console.WriteLine("CSF2: " + title.ToUpper());
        }//end header
        /*
           Create Fields and Properties for each of the following attributes.
           life – int
           name – string
           hitChance – int
           block – int
           maxLife – int

            Include a business rule that Life cannot be more than MaxLife. If it is, set it equal to
            MaxLife
         */
        //funny
        //FIELDS

        //people
        //PROPERTIES

        //collect
        //CONSTRUCTORS - Life = life; -> Life = maxLife.
        //No matter what, assign MaxLife BEFORE Life.

        //monkeys 
        //METHODS

        private int _life;
        private int _maxLife;
        private int _hitChance;
        private int _block;
        private string _name;

        public int Life
        {
            get { return _life; }
            set
            {
                if (value > _maxLife)
                    _life = _maxLife;
                else
                    _life = value;
            }
        }
        public int MaxLife 
        {   get { return _maxLife; }
            set { _maxLife = value; }
        }
        public string Name 
        {   get { return _name; } 
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _hitChance = value; }
        }
        public Character(int life, string name, int hitChance, int block, int maxLife)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
        }

        public Character()
        {
        }
    }//end class
}//end space