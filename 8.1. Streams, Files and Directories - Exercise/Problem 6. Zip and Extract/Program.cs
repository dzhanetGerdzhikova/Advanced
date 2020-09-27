using System.IO.Compression;

namespace Problem_6._Zip_and_Extract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("Folder", "NewZipDir/CopyMe.zip");
            ZipFile.ExtractToDirectory("NewZipDir/CopyMe.zip", "Extract Folder");
        }
    }
}