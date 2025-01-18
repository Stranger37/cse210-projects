using System;

class Program
{
    static void Main(string[] args)
    {
        static void displayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }

        static string promptUserName(){
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int promptUserNumber(){
            Console.Write("Please enter your favorite integer number: ");
            int favorite = int.Parse(Console.ReadLine());
            return favorite;
        }

        static void displayResults(string userName, int favorite){
            double favoriteSquare = Math.Pow(favorite, 2);
            Console.WriteLine($"{userName}, the square of your number is {favoriteSquare}");
        }

        displayWelcome();
        string userName = promptUserName();
        int favorite = promptUserNumber();
        displayResults(userName,favorite);
    }
}