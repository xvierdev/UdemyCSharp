using System;
namespace FourthProblem{
    class Fourth{
        public static void FourthProblem(){
            const string PASSWORD = "2002";
            string pass;
            do{
                pass = Console.ReadLine();
                if (pass != PASSWORD){
                    Console.WriteLine("Senha Invalida");
                }
                else{
                    Console.WriteLine("Acesso Permitido");
                }
            }
            while(pass != PASSWORD);
        }
    }
}