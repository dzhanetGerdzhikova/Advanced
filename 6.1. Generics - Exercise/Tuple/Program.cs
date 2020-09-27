using System;

namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = personInfo[0];
            string lastName = personInfo[1];
            string fullName = firstName + " " + lastName;
            string adress = personInfo[2];
            Tuple<string, string> personInformation = new Tuple<string, string>(fullName, adress);

            string[] personsBeerInfo = Console.ReadLine().Split(' ');
            string name = personsBeerInfo[0];
            int beerLitters = int.Parse(personsBeerInfo[1]);
            Tuple<string, int> personBeer = new Tuple<string, int>(name, beerLitters);

            string[] nums = Console.ReadLine().Split(' ');
            int first = int.Parse(nums[0]);
            double second = double.Parse(nums[1]);
            Tuple<int, double> number = new Tuple<int, double>(first, second);

            Console.WriteLine(personInformation.ToString());

            Console.WriteLine(personBeer.ToString());

            Console.WriteLine(number.ToString());
        }
    }
}