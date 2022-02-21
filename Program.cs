using System;
using Desafio_AbstraindoRPG.src.Entities;

namespace Desafio_AbstraindoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, 469, 749, 72, 72);
            Ninja ninja = new Ninja("Wedge", 42, 292, 574, 89, 89);
            WhiteWizard whiteWizard = new WhiteWizard("Jenica", 42, 325, 601, 474, 482);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, 106, 385, 611, 641);

            System.Console.WriteLine($"{knight}\n");
            System.Console.WriteLine($"{ninja}\n");
            System.Console.WriteLine($"{whiteWizard}\n");
            System.Console.WriteLine($"{blackWizard}\n");
        }
    }
}
