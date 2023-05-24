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
                if (item.ElsoElem % 10 == 0 && item.MasodikElem % 10 == 0)
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

            //7
            List<String> eredmenyekLista = new List<String>();
            while (true)
            {
                Console.Write($"7. Feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                string sor = Console.ReadLine();
                if (sor.ToLower() == "vége")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\t{Kiszamol(sor)}");
                    eredmenyekLista.Add(Kiszamol(sor));
                }
            }

            //8
            File.WriteAllLines("eredmenyek.txt", eredmenyekLista);
            Console.WriteLine("8. Feladat: eredmenyek.txt");
        }

        //6
        static string Kiszamol(string input)
        {
            string eredmeny = "";
            var felbont = input.Split(' ');
            int elsoElem = int.Parse(felbont[0]);
            string operatorJel = felbont[1];
            int masodikElem = int.Parse(felbont[2]);
            var szamolasEredmeny = "";
            if (operatorJel == "mod")
            {
                try
                {
                    int szamolasEredmenye = elsoElem / masodikElem;
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }
            }
            else if (operatorJel == "/")
            {
                try
                {
                    double szamolasEredmenye = Convert.ToDouble(elsoElem) / Convert.ToDouble(masodikElem);
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }

            }
            else if (operatorJel == "div")
            {
                try
                {
                    double szamolasEredmenye = Convert.ToDouble(elsoElem) / Convert.ToDouble(masodikElem);
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }
            }
            else if (operatorJel == "-")
            {
                try
                {
                    double szamolasEredmenye = Convert.ToDouble(elsoElem) - Convert.ToDouble(masodikElem);
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }
            }
            else if (operatorJel == "*")
            {
                try
                {
                    double szamolasEredmenye = Convert.ToDouble(elsoElem) * Convert.ToDouble(masodikElem);
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }
            }
            else if (operatorJel == "+")
            {
                try
                {
                    double szamolasEredmenye = Convert.ToDouble(elsoElem) + Convert.ToDouble(masodikElem);
                    szamolasEredmeny = szamolasEredmenye.ToString();
                }
                catch (Exception)
                {
                    szamolasEredmeny = "Egyéb Hiba!";
                    throw;
                }
            }

            eredmeny = $"{elsoElem} {operatorJel} {masodikElem} = {szamolasEredmeny}";
            return eredmeny;
        }
    }
}
