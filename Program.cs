using jogo_rpg.SRC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Knight knight = new Knight("Arus", 23, "Knight");
        Wizards wizard = new Wizards("Jenica", 23, "White Wizard");
        //Heros oponnet = new Heros("Maleficus", 99, "Devil");

        Console.WriteLine(wizard);
        Console.WriteLine(wizard.Attack(7));
        Console.WriteLine(knight);
        Console.WriteLine(knight.Attack());
        //Console.WriteLine(oponnet);
    }
}

