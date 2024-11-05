using System;
using System.Net.WebSockets;

namespace test{
    class Program{
        static void Main (string[] args){
            const double PI = 3.14159;
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = PI * radius * radius;
            Console.WriteLine($"AREA={area}");
        }
    }
}