using System;
using Letters;

namespace Open_Lab_04._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string original = Console.ReadLine();

            Console.WriteLine("Enter number:");
            int howmanytimes = Convert.ToInt32(Console.ReadLine());

            MoreLetters moreletters = new MoreLetters();
            Console.WriteLine(moreletters.GetNewWord(original, howmanytimes));
        }
    }
}
