using System;
using System.Text;
namespace C__Assignment_1
{
    class subString
    {
        static void Main(string[] args)
        {
                  Console.Write("Enter a String : ");

            string inputString = Console.ReadLine();
           
                  Console.WriteLine("All possible substrings are : ");
            
            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);

            for (int j = i; j < inputString.Length; ++j)
            
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + "\n");
                }
            }
            Console.ReadKey();
        }
    }
}