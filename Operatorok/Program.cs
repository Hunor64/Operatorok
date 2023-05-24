using System;
using System.Collections.Generic;
using System.IO;

namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = "Sources\\kifejezesek.txt";
            List<Operatorok> operatorLista = new List<Operatorok>();
            string[] lines = File.ReadAllLines(fileLocation);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                operatorLista.Add(new Operatorok(line));
            }
            //2
            int darabSzam = operatorLista.Count;
            Console.WriteLine($"2. Feladat: Kifejezések száma: {darabSzam}");

            //3
            int modSzamolva = 0;
            foreach (var item in operatorLista)
            {
                if (item.OperatorJel == "mod")
                {
                    modSzamolva++;
                }
            }
            Console.WriteLine($"3. Feladat: Kifejezések száma maradésos osztással: {modSzamolva}");

            //4
            bool vanEIlyen = false;
            foreach (var item in operatorLista)
            {
                if (item.ElsoElem%10==0&&item.MasodikElem%10==0)
                {
                    vanEIlyen = true;
                    break;
                }
            }
            Console.Write("4. Feladat: ");
            if (vanEIlyen)
            {
                Console.WriteLine("Van ilyen kifejezés!");
            }
            else
            {
                Console.WriteLine("Nincsen ilyen kifejezés!");
            }
        }
    }
}
