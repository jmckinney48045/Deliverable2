using System;
using System.Text;
using System.Linq;


namespace TEST_GC_DEliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message? ");

            String input = System.Console.ReadLine();
            String inputUp = input.ToUpper();

            //converting string to char array

            char[] char_arr = inputUp.ToCharArray();

            foreach (char item in char_arr)

                Console.WriteLine();
            {
                foreach (char c in inputUp)

                {
                    Console.WriteLine("Your message is: " + ((int)c - 64));
                }
                string ids = String.Join("-", char_arr.Select(p => p.ToString()).ToArray());

                Console.WriteLine("Your message is " + ids);

            }
            string txt = inputUp;
            {
                int checksum = txt.Sum(b => b);

                Console.WriteLine("Message Checksum is:" + checksum);
            }

        }
    }
}
