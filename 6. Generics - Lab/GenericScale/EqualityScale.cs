namespace GenericScale
{
    public class EqualityScale<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public bool AreEqual()
        {
            return this.Left.Equals(this.Right);
        }
    }
}