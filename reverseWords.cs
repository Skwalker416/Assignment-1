using System;
using System.Text;
namespace  C__Assignment_1
{
    class ReverseWords
{
    static void Main(String [] args){

                 string str;

                Console.Write("Enter a sentence: ");

              str = Console.ReadLine();
		     int i;
	  
	         StringBuilder reverseSentence = new StringBuilder();
		    
			int Start = str.Length - 1;
		    int End = str.Length - 1;
	
		while (Start > 0)
		{
			if (str[Start] == ' ')
			{
				i = Start + 1;
				while (i <= End)
				{
					reverseSentence.Append(str[i]);
					i++;
				}

				reverseSentence.Append(' ');
				End = Start - 1;
			}

			Start--;
		}

		for (i = 0; i <= End; i++)
		{
			reverseSentence.Append(str[i]);
		}
        Console.Write("The reversed sentence is: ");
		Console.WriteLine(reverseSentence.ToString());
	}
		
}
}