 using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high ");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                //} while (userInput !=favNumber);

                //Switch-Case
                Console.WriteLine("What is your favorite subject?");

                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "math":
                        Console.WriteLine("I hate Math!");
                        break;
                    case "science":
                        Console.WriteLine("I love Science!");
                        break;
                    case "pe":
                        Console.WriteLine("PE is the beset!!");
                        break;
                    case "history":
                        Console.WriteLine("History is fun.");
                        break;
                    case "english":
                        Console.WriteLine("English is boring.");
                        break;
                      default:
                        Console.WriteLine("I dont know that subject.");
                        break;

                }
            }
        }
    }   
}
