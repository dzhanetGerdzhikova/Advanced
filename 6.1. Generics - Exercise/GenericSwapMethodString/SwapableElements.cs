using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class SwapableElements<T>
    {
        public SwapableElements()
        {
            this.Inputs = new List<T>();
        }

        public List<T> Inputs { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < this.Inputs.Count && secondIndex >= 0 && secondIndex < this.Inputs.Count)
            {
                T firstElement = this.Inputs[firstIndex];
                this.Inputs[firstIndex] = this.Inputs[secondIndex];
                this.Inputs[secondIndex] = firstElement;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var element in this.Inputs)
            {
                result.AppendLine($"{element.GetType()}: {element.ToString()}");
            }
            return result.ToString().TrimEnd();
        }
    }
}