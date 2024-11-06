// Classe principal do projeto de heróis.
using System;
using HeroNamespace;

namespace Rpg{
    class Program{
        static void Main (string[] args){
            Console.WriteLine("RPG GAME");
            Hero hero = new Hero();
            hero.name = Console.ReadLine();
            hero.age = 32;
            Console.WriteLine($"Hero name is {hero.name}");
        }
    }
}