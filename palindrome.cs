using System;
namespace C__Assignment_1
{
class palindrome{

static void Main (string [] args){
        string str,
        revString = "";
            
            Console.WriteLine("Please Enter a String : ");
        
            str = Console.ReadLine();
            
            for(int i=str.Length-1; i>=0; i--)
            {
                revString = revString + str[i];
            }

            if(str==revString){

                Console.WriteLine("The string is a palindrome");
            }
            else

                Console.WriteLine("The string is not a palindrome.");
         
            Console.ReadLine();
        }
    }
}
