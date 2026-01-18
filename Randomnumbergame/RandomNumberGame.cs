using System;

namespace RandomNumberGame{
    class Program{
        static void Main(string[] args){
            Random randomNum = new Random();
            int RandNum = randomNum.Next(1,101),pick;

            Console.WriteLine("A random number has been genrated between 1-100");
            Console.Write("Guess the number: ");
            pick = Convert.ToInt32(Console.ReadLine());
            
            while(pick != RandNum){
               if (pick > RandNum){
                    Console.WriteLine("Guess too high");
                    Console.Write("Guess again: ");
                    pick = Convert.ToInt32(Console.ReadLine());
               }else if (pick < RandNum){   
                    Console.WriteLine("Guess too low");
                    Console.Write("Guess again: ");
                    pick =Convert.ToInt32(Console.ReadLine());
               }else{
                    Console.WriteLine("Well done the number was "+RandNum+"!");
                }
            }
        }
    }
}