using System;

namespace  C__Assignment_1
{
    
}
 class secLarge
{
	      static void Main(string[] args){
	
	           int[] myArray = new int[] { 67, 8, 24, 50, 13, 10, 5 };

                    int largest = int.MinValue;
                    int second = int.MinValue;
            foreach (int i in myArray)
        {
            if (i > largest)
        {
                second = largest;
                largest = i;
        }
            else if (i > second)
                second = i;
        }

            System.Console.WriteLine("The second Largest number is : " + second);
          }
}