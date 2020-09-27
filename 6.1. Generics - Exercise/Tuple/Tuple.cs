namespace Tuple
{
    public class Tuple<Item1, Item2>
    {
        public Tuple(Item1 first, Item2 second)
        {
            this.FirstItem = first;
            this.SecondItem = second;
        }

        public Item1 FirstItem { get; set; }
        public Item2 SecondItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}