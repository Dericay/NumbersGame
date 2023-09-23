using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGame                                           //Anton Larsson SUT23
{
    internal class Program
    {
        public static bool playAgain = true;                    //Made variable static so all methods can reach it
            
        static void Main(string[] args)
        {
            Random random = new Random();                   //Generates a random number
            int guess;
            int number;                                     
            int guesses;
            
           while (playAgain)            //Will continue to loop until it gets returend false
            {
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får 5 försök.");
                guess = 0;
                guesses = 0;                
                number = random.Next(1, 20);            //Random number between 1-20
                while (guesses != 5)                    //When it loops 5 times i will go to the next method which means you have 5 tries
                {
                    guess = Convert.ToInt32(Console.ReadLine());


                    if (guess > number)                 //If statment, will tell you if you guess too high, low or if you guess right
                    {
                        Console.WriteLine("Tyvärr du gissa för högt!");

                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Tyvärr du gissa för lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        break;
                    }
                    guesses++;
                }
                PlayAgain();                            //To call for the method "PlayAgain" from below
            }
      
        }
        public static void PlayAgain()              //Method outside of main
        {
            string response;           
            
            Console.WriteLine("Vill du spela igen? Y/N");
            response = Console.ReadLine();
            if (response == "Y")
            {
                playAgain = true;                   //If true the program starts from the beginning if false it stops
                
            }
            else
            {
                 playAgain = false;              
                Console.WriteLine("Tack för att du spela!");
                
            }
               

            
        }
     
    } 
}




    





