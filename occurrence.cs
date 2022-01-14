using System;
using System.Collections.Generic;

namespace C__Assignment_1
{
    class Occurence
    {
        static void Main(string[] args)
        {
              Console.Write("Enter a string : ");

            string str = Console.ReadLine();

                 Dictionary<char, int> charCount = new Dictionary<char, int>();

              Console.WriteLine("\r\nThe Occurence of the Character :\r\n ");
           
            foreach(var character in  str)

            {

                if(character!=' ')

                {

                    if(!charCount.ContainsKey(character))

                    {
                        charCount.Add(character, 1);

                    }
                    else
                    {
                        charCount[character]++;
                    }
                }
            }
            foreach(var character in charCount)

            { 
            
                Console.WriteLine(" {0}   is  {1}", character.Key, character.Value);
            }
            Console.ReadLine();
        }

    }

}