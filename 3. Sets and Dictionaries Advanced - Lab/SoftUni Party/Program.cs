using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> reservation = new HashSet<string>();

            while (input != "PARTY")
            {
                if (!reservation.Contains(input))
                {
                    reservation.Add(input);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "END")
            {
                if (reservation.Contains(input))
                {
                    reservation.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{reservation.Count}");
            IEnumerable<string> vip = reservation.Where(x => x[0] >= '0' && x[0] <= '9');
            var regular = reservation.Except(vip);

            foreach (var reserve in vip)
            {
                Console.WriteLine(reserve);
            }

            foreach (var reserve in regular)
            {
                Console.WriteLine(reserve);
            }
        }
    }
}