namespace Threeuple
{
    public class Threeuple<Item1, Item2, Item3>
    {
        public Threeuple(Item1 first, Item2 second, Item3 third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public Item1 First { get; set; }
        public Item2 Second { get; set; }
        public Item3 Third { get; set; }

        public override string ToString()
        {
            return $"{this.First} -> {this.Second} -> {this.Third}";
        }
    }
}