using System;

namespace C__Assignment_1
{
    class ReverseString
    {
        static void Main(string[] args){

                string str,
                revString = " ";

                  Console.Write("Enter a string to find the reverse : ");

            str = Console.ReadLine();
            

        for(int i = str.Length-1; i>=0; i--){
    
            revString = revString + str [i];
}
                Console.Write("The reverse string is : {0} ", revString);
}
    }
}