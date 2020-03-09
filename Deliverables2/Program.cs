using System;
using System.Text;
using System.Linq;
namespace Deliverables2
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                Console.Write("What is your message?: ");

                String input = System.Console.ReadLine();
                String inputUp = input.ToUpper();

                //converting string to char[]
                char[] char_arr = inputUp.ToCharArray();
                foreach (char item in char_arr)
                {
                    Console.Write(item + " ");
                }

                foreach (char c in inputUp)

                {
                    Console.WriteLine((int)c - 64);
                }
                
                Console.WriteLine("str: " + inputUp);

                //printing char[]
                Console.WriteLine("char_arr...");
                
                Console.ReadLine();


            }
        }
    }
}





















  