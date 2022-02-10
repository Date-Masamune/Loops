using System;

namespace LoopsExercise
{
   class WeeklyTotal
   {
      static void Main(string[] args)
      {

         //initialization phase
         double total = 0; //intializes total earnings
         double earnings = 0.0;

         //processing phase
         //prompt for input and read item informtion from user
         Console.WriteLine("How many items do you want to enter");
         int itemNumb = int.Parse(Console.ReadLine());

         // loop until sentinal value is read from the user. 
         for (int i = 1; i  < itemNumb + 1; i++)
         {
            Console.WriteLine("Enter item value: ");
            double itemValue = double.Parse(Console.ReadLine());
            total = total + itemValue;


         }

         earnings = 200 + (0.09 * total);
         Console.WriteLine(earnings);
         

      }
   }
}
