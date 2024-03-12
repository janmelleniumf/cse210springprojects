using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userAns = Console.ReadLine();
        int grade = int.Parse(userAns);
        int lastDigit = grade%10;

        string gradeletter = "";

        if (grade >= 90 )
            {
                gradeletter = "A";
            }
        else if (grade >= 80 )
            {
                gradeletter = "B";
            }
        else if (grade >= 90 )
            {
                gradeletter = "C";
            }
        else if ( grade >= 60)
            {
                gradeletter = "D";
            }
        else
            {
                gradeletter = "F";
            }

        string sign = "";
        if (lastDigit >= 7 && grade < 90 && grade >= 60)
            {
                sign = "+";
            }
        else if (lastDigit >= 3 && lastDigit < 7 && grade >= 60)
            {
                sign = "";
            }
        else if (lastDigit >= 3 && grade >= 60 && grade >= 90)
            {
                sign = "";
            }
        else if (grade < 60)
            {
                sign = "";
            }
        else
            {
                sign = "-";
            }
        
        Console.WriteLine($"Your grade percentage is equivalent to {gradeletter}{sign}!");

        if (grade >= 70)
            {
                Console.WriteLine("Therefore, you PASSED!");
            }
        else
            {
                Console.WriteLine("Therefore, you failed. Better Luck Next Time!");
            }
    }
}