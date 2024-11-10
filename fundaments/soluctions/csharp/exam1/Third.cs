using System;
namespace ThirdProblem{
    class Third{
        public static void ThirdProblem(){
            double a, b, c, delta;
            string sentence = " ";
            sentence = Console.ReadLine();
            string[] terms =  sentence.Split(' ');
            a = Convert.ToDouble(terms[0]);
            b = Convert.ToDouble(terms[1]);
            c = Convert.ToDouble(terms[2]);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0){
                Console.WriteLine("Impossível calcular");
            }
            else if(delta == 0){
                double X1, X2;
                X1 = -b/(2*a);
                X2 = X1;
                Console.WriteLine($"X1 = {X1:F5}\nX2 = {X2:F5}");
            }
            else{
                double X1, X2, rootDelta;
                rootDelta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                X1 = (-b + rootDelta) / (2 * a);
                X2 = (-b - rootDelta) / (2 * a);
                Console.WriteLine($"X1 = {X1:F5}\nX2 = {X2:F5}");
            }
        }
    }
}