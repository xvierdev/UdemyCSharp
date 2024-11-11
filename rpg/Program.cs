// Classe principal do projeto de heróis.
using System;
using RpgHero;

namespace Rpg{
    class Program{
        static Hero CreateHero (){
            string[] heroInfo = Console.ReadLine().Split(' ');
            Hero hero = new Hero(heroInfo[0], int.Parse(heroInfo[1]));
            return hero;
        }
        static void Main (string[] args){
            Console.WriteLine("RPG GAME");
            Hero newHero = CreateHero();
            Console.WriteLine($"The hero is {newHero.Name} and hero age is {newHero.Age()}");
        }
    }
}