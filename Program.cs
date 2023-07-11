using System;

namespace Playing
{
    class Program
    {
        static void Main()
        {
            byte smallNumber = 2;
            int count = 999;
            float price = 82.99f;
            var maybeADouble = 1.1;
            char firstLetter = 'A';
            string action = "run";
            bool correct = false;

            Console.WriteLine(smallNumber);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(maybeADouble);
            Console.WriteLine(firstLetter);
            Console.WriteLine(action);
            Console.WriteLine(correct);

            try
            {
                int bigNumber = 1239;
                byte s = (byte) bigNumber;
                byte x = Convert.ToByte(bigNumber);
                Console.WriteLine(s);
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
