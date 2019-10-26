using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the big-win-bingo");
            Console.WriteLine("Enter five numbers: ");
            BingoGame();
        }

        public static void BingoGame()
        {
            Random rand = new Random();
            int[,] GenerateBingo = new int[5,5];
            for (int j = 0; j < GenerateBingo.GetLength(1); j++)
            {
                for (int i = 0; i < GenerateBingo.GetLength(0); i++)
                {
                    GenerateBingo[j, i] = rand.Next(1, 25);
                    //Console.Write("   {0}", String.Join(" ", GenerateBingo[j, i].ToString()));  // for test resualt 
                }
                //Console.WriteLine();
            }
            
            int[] UserInput = new int[5];
            for (int j = 0; j < UserInput.Length; j++)
            {
                UserInput[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nYou got the following numbers: ");
            foreach (int SaveArrayInput in UserInput)
            {
                Console.Write(" " + SaveArrayInput);
            }

            Console.WriteLine("\n\nPreass any key to see results... ");
            Console.ReadKey();

            foreach (int a in GenerateBingo)
                foreach (int b in UserInput)
                {
                    if (a == b)
                    {
                        Console.WriteLine("bingo");
                    }
                    else
                    {
                        Console.WriteLine("Not Bingo");
                    }
                    Console.ReadLine();
                }
            Console.ReadLine();
        }
    }
}
