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

            //5
            int modSzam = 0;
            int osztasSzam = 0;
            int egeszOsztasSzam = 0;
            int kivonasSzam = 0;
            int szorzasSzam = 0;
            int osszeadasSzam = 0;
            foreach (var item in operatorLista)
            {
                if (item.OperatorJel == "mod")
                {
                    modSzam++;
                }
                else if (item.OperatorJel == "/")
                {
                    osztasSzam++;
                }
                else if (item.OperatorJel == "div")
                {
                    egeszOsztasSzam++;
                }
                else if (item.OperatorJel == "-")
                {
                    kivonasSzam++;
                }
                else if (item.OperatorJel == "*")
                {
                    szorzasSzam++;
                }
                else if (item.OperatorJel == "+")
                {
                    osszeadasSzam++;
                }

            }
            Console.WriteLine("5. Feladat: Statisztika");
            Console.WriteLine($"\tmod -> {modSzam} db");
            Console.WriteLine($"\t/ -> {osztasSzam} db");
            Console.WriteLine($"\tdiv -> {egeszOsztasSzam} db");
            Console.WriteLine($"\t- -> {kivonasSzam} db");
            Console.WriteLine($"\t* -> {szorzasSzam} db");
            Console.WriteLine($"\t+ -> {osszeadasSzam} db");

        }
       public string Kiszamol(string input)
        {
            string eredmeny = "";

            return eredmeny;
        }
    }
}
