using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Başlangıç tarihi hep Pazar gününün tarihi olmalı!

namespace NobetCizelgesi
{
    class Program
    {
        private static readonly List<string> _members = new List<string>() { "Abdullah Darçın", "Fatih Özkaya", "Oğuzhan Karakoç", "Muharrem Can Demir", "Mustafa Eraslan" };
        static DateTime _startDate = new DateTime(2021, 09, 26);

        static void Main(string[] args)
        {

            int loopNumber = 0;
            while (!Int32.TryParse(Console.ReadLine(), out loopNumber))
            {
                Console.WriteLine("Wrong input! Enter choice number again:");
            }

            WatchmanLoop(loopNumber);

            Console.ReadLine();
        }
        private static void WatchmanLoop(int loop)
        {
            var startDate = _startDate.AddDays(-1);
            var endDate = _startDate.AddDays(0);
            for (int k = 1; k < loop + 1; k++)
            {
                for (int i = 0; i < _members.Count(); i++)
                {
                    if (i == 0 && k == 1)
                    {
                        Console.WriteLine(_members[i] + " : " + startDate.ToString("dd MMMM yyyy dddd")
                  + " ve " + endDate.ToString("dd MMMM yyyy dddd") + " tarihleri arasında nöbetçidir!");
                    }
                    else
                    {
                        startDate = startDate.AddDays(7);
                        endDate = endDate.AddDays(7);
                        Console.WriteLine(_members[i] + " : " + startDate.ToString("dd MMMM yyyy dddd")
                       + " ve " + endDate.ToString("dd MMMM yyyy dddd") + " tarihleri arasında nöbetçidir!");
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("****************************************************************************************");
                Console.WriteLine("");

            }

        }
    }
}