using System;
using System.Linq;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = personInfo[0];
            string lastName = personInfo[1];
            string fullName = firstName + " " + lastName;
            string address = personInfo[2];
            var town = personInfo.Skip(3);
            Threeuple<string, string, string> personInformation = new Threeuple<string, string, string>(fullName, address, string.Join(' ', town));

            string[] personsBeerLitters = Console.ReadLine().Split(' ');
            string name = personsBeerLitters[0];
            int littersBeer = int.Parse(personsBeerLitters[1]);
            string isDrunk = personsBeerLitters[2] == "drunk" ? "True" : "False";

            Threeuple<string, int, string> personBeer = new Threeuple<string, int, string>(name, littersBeer, isDrunk);

            string[] personBankAccountInfo = Console.ReadLine().Split(' ');
            string nameOfPerson = personBankAccountInfo[0];
            double accountBalance = double.Parse(personBankAccountInfo[1]);
            string bankName = personBankAccountInfo[2];
            Threeuple<string, double, string> personBankInfo = new Threeuple<string, double, string>(nameOfPerson, accountBalance, bankName);

            Console.WriteLine(personInformation.ToString());
            Console.WriteLine(personBeer.ToString());
            Console.WriteLine(personBankInfo.ToString());
        }
    }
}