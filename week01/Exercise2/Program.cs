using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string grade_text;

        Console.Write("Enter your grade percentage: ");
        grade_text = Console.ReadLine();
        float grade_float = float.Parse(grade_text);

        string grade_letter;

        if(grade_float >= 90)
        {
            grade_letter = "A";
        }
        else if(grade_float >= 80)
        {
            grade_letter = "B";
        }
        else if(grade_float >= 70)
        {
            grade_letter = "C";
        }
        else if(grade_float >= 60)
        {
            grade_letter = "D";
        }
        else if(grade_float >= 50)
        {
            grade_letter = "E";
        }
        else
        {
            grade_letter = "F";
        }

        if(grade_float > 70)
            Console.WriteLine("Your grade letter is " + grade_letter + ". COngratulations, you passed!");
        else
        {
            Console.WriteLine("Your grade letter is " + grade_letter + ". You don't passed! Next time you'll be best!");
        }
    }
}