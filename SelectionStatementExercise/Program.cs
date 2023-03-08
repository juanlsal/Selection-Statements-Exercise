using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {

        //exercise 1
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 10);
            Console.WriteLine("guess my number its 1-10");
            int userInput = 0;
            while (userInput != favNumber)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                }
                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                }
                if (userInput == favNumber)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }
            
     
            //exercise 2
            Console.WriteLine("What is your favorite school subject?");
            string FavSub = Console.ReadLine();
            switch (FavSub)
            {
                case "math":
                    Console.WriteLine("math is cool!");
                    break;
            
                case "science":
                    Console.WriteLine("math is cool!");
                    break;

                case "history":
                    Console.WriteLine("history is cool!");
                    break;

                case "english":
                    Console.WriteLine("english is cool!");
                    break;

                case "lunch":
                    Console.WriteLine("lunch is awesome!");
                    break;

                default:
                    Console.WriteLine("Try again");
                    Repeat();
                    break;

            }
        }

        static void Repeat()
        {
            Console.WriteLine("What is your favorite school subject?");
            string FavSub = Console.ReadLine();
            switch (FavSub)
            {
                case "math":
                    Console.WriteLine("math is cool!");
                    break;

                case "science":
                    Console.WriteLine("math is cool!");
                    break;

                case "history":
                    Console.WriteLine("history is cool!");
                    break;

                case "english":
                    Console.WriteLine("english is cool!");
                    break;

                case "lunch":
                    Console.WriteLine("lunch is awesome!");
                    break;

                default:
                    Console.WriteLine("Try again");
                    Repeat();
                    break;

            }
        }
    }
}
