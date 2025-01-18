using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int addNumber = -1;
        float sum = 0;
        int largest = 0;
        float average = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(addNumber != 0){
            Console.Write("Enter a Number: ");
            addNumber = int.Parse(Console.ReadLine());
            if(addNumber != 0){
                numbers.Add(addNumber);
            }
        }

        for(int i = 0; i < numbers.Count; i++){
            int actual_number = numbers[i];
            sum = sum + actual_number;
            if(actual_number > largest){
                largest = actual_number;
            }
        }

        average = sum/numbers.Count;

        Console.WriteLine("The Sum is: "+sum);
        Console.WriteLine("The Average is: "+average);
        Console.WriteLine("The Largest number is: "+largest);
    }
}