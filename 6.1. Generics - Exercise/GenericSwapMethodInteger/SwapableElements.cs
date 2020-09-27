using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class SwapableElements<T>
    {
        public SwapableElements()
        {
            this.Infos = new List<T>();
        }

        public List<T> Infos { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < this.Infos.Count && secondIndex >= 0 && secondIndex < this.Infos.Count)
            {
                T firstElement = this.Infos[firstIndex];
                this.Infos[firstIndex] = this.Infos[secondIndex];
                this.Infos[secondIndex] = firstElement;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var element in this.Infos)
            {
                result.AppendLine($"{element.GetType()}: {element.ToString()}");
            }
            return result.ToString().TrimEnd();
        }
    }
}