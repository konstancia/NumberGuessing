﻿// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;

namespace NumberGuessing;

public class Program
{
    static void Main(string[] args)
    {
        const int MAX_NUMBER = 99;
        const int NUMBER_OF_GUESSES = 5;
        const int DIFFERENCE_LOW = 5;
        const int DIFFERENCE_HIGH = 10;
        string answer = "yes";
        bool playAgain = true;
        bool isCorrectGuess = false;
        int numberOfTries = 0;
        Random rng = new Random();
        while (playAgain)
        {
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

                numberOfTries++;

                int difference = Math.Abs(randomNumber - number);

                if (difference <= DIFFERENCE_LOW)
                {
                    Console.WriteLine($"Very close! You're within {DIFFERENCE_LOW} of the correct number.");
                }
                else if (difference <= DIFFERENCE_HIGH)
                {
                    Console.WriteLine($"Close! You're within {DIFFERENCE_HIGH} of the correct number.");
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


            //while (playAgain) // Loop for restarting the game
            {
                //PlayGame(); // Call the game function

                Console.Write("\nDo you want to play again? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response == answer)

                {
                    playAgain = true; // Exit the loop if the user doesn't want to play again
                }
                else
                {
                    playAgain = false;
                }
            }
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}