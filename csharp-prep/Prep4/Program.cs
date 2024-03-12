using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        Console.WriteLine("Please enter a series of number. Press 0 to stop.");
        
        int enteredNum = -100;
        do
        {
            Console.Write("Enter a number: ");

            string userNum =Console.ReadLine();
            enteredNum = int.Parse(userNum);
            if (enteredNum !=0)
            {
                numbers.Add(enteredNum);
            }

    
        }while (enteredNum != 0);


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");

        int closePositive = max;

        foreach (int number in numbers )
        {
            if (number < closePositive && number > 0)
            {
                closePositive = number;
            }
        }
        Console.WriteLine($"The closest positive to zero is: {closePositive}");

        numbers.Sort();
        

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}