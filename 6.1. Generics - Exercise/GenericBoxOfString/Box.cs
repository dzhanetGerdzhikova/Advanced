namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box(T info)
        {
            this.SavedInfo = info;
        }

        public T SavedInfo { get; set; }

        public override string ToString()
        {
            return $"{this.SavedInfo.GetType()}: {this.SavedInfo}";
        }
    }
}