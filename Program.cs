using ProjetoJogoRPG.Entities;
using System;

namespace ProjetoJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight", 540, 80);
            WhiteWizard wizard = new WhiteWizard("Jennica", 24, "White Wizard", 495, 75);
            BlackWizard wizard1 = new BlackWizard("Topapa", 26, "Black Wizard", 501, 96);
            Ninja ninja = new Ninja("Wedge", 20, "Ninja", 325, 68);

            Console.WriteLine("- Ora ora quem esta aqui, o que voces querem em minhas terras?");
            Console.WriteLine("- Nos Viemos buscar o que e nosso Arus!");
            Console.WriteLine("- Voces tem certeza que querem batalhar comigo? Lembram quem eu sou?");
            Console.WriteLine(knight);
            Console.WriteLine("\n- Nos nao temos medo de voce Arus! Caso voce nao se lembre..");
            Console.WriteLine(wizard);
            Console.WriteLine(wizard1);
            Console.WriteLine(ninja);
            Console.WriteLine("\n- 3, 2, 1.. ATACAR!!");
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine("- Voces nao vao conseguir me deter!");
            Console.WriteLine("- Oh nao, me ajude Wedge!");
            Console.WriteLine("- Deixa comigo!");
            Console.WriteLine(ninja.Attack(10));
            Console.WriteLine(knight.Attack(20));
            Console.WriteLine(wizard.Attack(18));
            Console.WriteLine("- Voces nao vao conseguir me derrotar!");
            Console.WriteLine("- Tem certeza Arus? ATAQUE ELE TOPAPA!");
            Console.WriteLine(wizard1.Attack(16));
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(ninja.Attack(12));
            Console.WriteLine("- Voce nao tem mais chances Arus, desista!");
            Console.WriteLine("\nArus foi derrotado!");

            Console.WriteLine("FIM DE JOGO!");
            
        }
    }
}
