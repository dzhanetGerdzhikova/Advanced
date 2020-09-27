namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int heath)
        {
            Name = name;
            Element = element;
            Heath = heath;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Element
        {
            get { return element; }
            set { this.element = value; }
        }

        public int Heath
        {
            get { return health; }
            set { this.health = value; }
        }
    }
}