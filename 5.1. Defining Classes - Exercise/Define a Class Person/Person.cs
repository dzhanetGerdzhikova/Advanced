namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int _age) : this()
        {
            this.Age = _age;
        }

        public Person(string _name, int age) : this(age)
        {
            this.Name = _name;
        }
    }
}