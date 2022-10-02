using System;
using System.Text;

namespace ChessBoard   // Elin Linderholm SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.OutputEncoding = System.Text.Encoding.UTF8; //behövs för att kunna använda schackbrädesymbolerna

            Console.WriteLine("Var god skriv in en siffra:");
            string text = Console.ReadLine();
            int number = Int32.Parse(text);           
            int varv = 0; //för att kunna styra att det blir varannan svart och varannan vit ruta

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {                  
                    if ((i + j) % 2 == 0)  //vid jämna nummer
                    {
                        Console.Write("□" + " ");
                        varv++;

                    }
                    else  // annars om ojämnt
                    {
                        Console.Write("■" + " ");
                        varv--;
                    }




                }
                Console.WriteLine();    
        }
        }
    }
}
