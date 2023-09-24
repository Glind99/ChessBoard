using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    internal class Program // Gustav Lind Net23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till ChessBoard!"); //welcome message
            Console.WriteLine("Vänligen mata in en siffra");
            int number = Int32.Parse(Console.ReadLine()); // give the players number/input a value

            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            for (int row = 0; row < number; row++)  // loop for each row 
            {

                for (int column = 0; column < number; column++) // nested forloop for each column
                {

                    if ((row + column) % 2 == 0)    //check if the sum of row and column is even
                    {
                        Console.Write("□ "); //if even print white square      
                    }
                    else
                    {
                        Console.Write("■ "); //if odd, print black square
                    }



                }
                Console.WriteLine(); //next row
            }

            Console.WriteLine("Tryck valfri knapp för att avsluta!"); //tell the user to press a key to exit the program. makes is more clear its over :)
            Console.ReadKey();
        }
    }

}
