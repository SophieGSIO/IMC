using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int poids;
            double tailleEnCm, tailleEnM, imc;
            string prenom;
            while (true)
            {
                Console.Write("Entrez votre prénom : ");
                prenom = Console.ReadLine();
                Console.Write("Entrez votre poids (en kg) : ");
                poids = int.Parse(Console.ReadLine());
                Console.Write("Entrez votre taille (en cm) : ");
                tailleEnCm = double.Parse(Console.ReadLine());
                tailleEnM = tailleEnCm / 100;
                imc = poids / (tailleEnM * tailleEnM);
                Console.WriteLine("L'IMC de {0} est de {1}", prenom, imc);
                if (imc >= 18.5 && imc <= 25)
                    Console.WriteLine("IMC normal");
                else
                    Console.WriteLine("IMC anormal"); 
            }
            Console.ReadLine();
        }
    }
}
