// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;

namespace NumberGuessing;


public class Program
{

    static void Main(string[] args)
    {

        const int MAX_NUMBER = 100;
        const int NUMBER_OF_GUESSES = 5;
        bool playAgain = true;
        bool isCorrectGuess = false;
        string response;
        int numberOfTries = 0;
        Random rng = new Random();
        int randomNumber = rng.Next(0, MAX_NUMBER);


        Console.WriteLine("This exercise is about number guessing");
        Console.WriteLine(($"Please enter a number between 0-{MAX_NUMBER}:"));

        for (int i = 1; i <= NUMBER_OF_GUESSES; i++)
        {
            Console.WriteLine($"\nAttempt {i} of {NUMBER_OF_GUESSES}:");

            //convert number to int32
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You have entered: {number}");

            if (number == randomNumber)
            {
                Console.WriteLine("Your number is correct");
                break;
            }
            else if (number > randomNumber)
            {
                Console.WriteLine("Your number is too high");
            }
            else if (number < randomNumber)
            {

                Console.WriteLine("Your guess is too low");
            }

            int difference = Math.Abs(randomNumber - number);

            if (difference <= 5)
            {
                Console.WriteLine("Very close! You're within 5 of the correct number.");
            }
            else if (difference <= 10)
            {
                Console.WriteLine("Close! You're within 10 of the correct number.");
            }
            else
            {
                Console.WriteLine("Not close! Keep trying.");
            }

            Console.WriteLine($"Attempts left: {NUMBER_OF_GUESSES - numberOfTries}");
        }

     if (!isCorrectGuess)
{
    Console.WriteLine($"\nGame over! The correct number was {randomNumber}.");
}

Console.WriteLine("Thanks for playing!");
    

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








/* if (number_Of_Tries == allowed_Tries) ;
{
Console.WriteLine($"The number was: {randomNumber}");
playAgain = false;
}
*/