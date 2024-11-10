using System;
namespace FifthProblem{
    public class Fifth{
        public static void FifthProblem(){
            int quantity = int.Parse(Console.ReadLine());
            int inside = 0, outside = 0;
            for(int i = 0; i < quantity; i++){
                int number = int.Parse(Console.ReadLine());
                if(10 <= number && number <= 20){
                    inside++;
                }
                else{
                    outside++;
                }
            }
            Console.WriteLine($"{inside} in\n{outside} out");
        }
    }
}