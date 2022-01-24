using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            Hero hero = new Hero(name,level);
            
            Elf elf = new Elf(name, level);
            MuseElf museElf = new MuseElf(name, level);
            Wizard wizard = new Wizard(name, level);
            DarkWizard darkWizard = new DarkWizard(name,level);
            SoulMaster soulMaster = new SoulMaster(name, level);
            Knight knight = new Knight(name, level);
            DarkKnight darkKnight = new DarkKnight(name, level);
            BladeKnight bladeKnight = new BladeKnight(name, level);

            Console.WriteLine(hero); 
            Console.WriteLine(elf); 
            Console.WriteLine(museElf); 
            Console.WriteLine(wizard); 
            Console.WriteLine(darkWizard); 
            Console.WriteLine(soulMaster); 
            Console.WriteLine(knight); 
            Console.WriteLine(darkKnight); 
            Console.WriteLine(bladeKnight); 
        }
    }
}