using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipList = new HashSet<string>();
            HashSet<string> regularList = new HashSet<string>();

            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(guest, 0) && guest.Length == 8)
                {
                    vipList.Add(guest);
                }
                else if (char.IsLetter(guest, 0) && guest.Length == 8)
                {
                    regularList.Add(guest);
                }

            }

            while (true)
            {
                string guestsWhoCame = Console.ReadLine();
                if (guestsWhoCame == "END")
                {
                    break;
                }
                if (vipList.Contains(guestsWhoCame))
                {
                    vipList.Remove(guestsWhoCame);
                }
                if (regularList.Contains(guestsWhoCame))
                {
                    regularList.Remove(guestsWhoCame);
                }
            }
            int guestsWhoDidntCome = vipList.Count + regularList.Count;

            Console.WriteLine(guestsWhoDidntCome);
            foreach (var vip in vipList)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularList)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
