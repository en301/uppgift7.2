using System;
using System.Collections.Generic;

namespace uppgift_7_2
{
    class program
    {
        static void Main(string[] args)
        {
            List<int> nummerLista = new List<int>();
            nummerLista.Add(4);
            nummerLista.Add(5);

            Max(nummerLista);
            Console.ReadKey();
        }
        static void Max(List<int> nummerlista)
        {
            nummerlista.Sort();
            nummerlista.RemoveRange(0, nummerlista.Count-1);
            foreach (int nummer in nummerlista)
            {
                Console.WriteLine(nummer);
            }
        }
    }
}
