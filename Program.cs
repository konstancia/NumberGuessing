// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

namespace NumberGuessing;
//test

public class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("This exercise is about number guessing");
        Console.WriteLine(("Please enter a number between 0-10:"));

        //convert number to int32
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"You have entered: {number}");

        Random rng = new Random();
        int randomNumber = rng.Next(0, 10);
        bool playAgain = true;
        const int allowedTries = 5;
        const int numberOfTries = 0;
        string response;
        

        
        if (number == randomNumber)
        {
            Console.WriteLine("You guessed the correct number");
        }
        else if (number < randomNumber)
        {
            Console.WriteLine("Your number is too low");
        }
        else if (number > randomNumber)
        {
            Console.WriteLine("Your number is too high");

        }
        
        if (numberOfTries == allowedTries)
        {
            Console.WriteLine($"The number was: {randomNumber}");
            playAgain = false;
        }

        Console.WriteLine($"The correct number is {randomNumber}");

        Console.WriteLine("Would you like to play again (Y/N)");
        response = Console.ReadLine();
        response = response.ToUpper();

        if (response == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
        }

        Console.WriteLine("Thank you for playing");

    }

}