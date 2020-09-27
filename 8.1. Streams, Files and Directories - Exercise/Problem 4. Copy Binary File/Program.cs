using System.IO;
using System.Linq;

namespace Problem_4._Copy_Binary_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using FileStream file = new FileStream("copyMe.png", FileMode.OpenOrCreate);
            byte[] buffer = new byte[4096];
            using FileStream result = new FileStream("result.png", FileMode.Create);

            while (file.CanRead)
            {
                int readsBytes = file.Read(buffer, 0, buffer.Length);

                if (readsBytes < buffer.Length)
                {
                    buffer = buffer.Take(readsBytes).ToArray();
                }

                result.Write(buffer, 0, readsBytes);

                if (readsBytes == 0)
                {
                    break;
                }
            }
        }
    }
}