// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace NumberGuessing;


public class Program
{

    static void Main(string[] args)
    {

        bool playAgain = true;
        bool isCorrectGuess = false;
        string response;
        int numberOfGuesses = 5;
        Random rng = new Random();
        int randomNumber = rng.Next(0, 10);



        for (int i = 1; i <= numberOfGuesses; i++)
        {

            Console.WriteLine("This exercise is about number guessing");
            Console.WriteLine(("Please enter a number between 0-10:"));
            Console.WriteLine($"\nAttempt {i} of {numberOfGuesses}:");

            //convert number to int32
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You have entered: {number}");

            if (number < randomNumber)
            {
                Console.WriteLine("Your number is too low");
            }

            else if (number > randomNumber)
            {
                Console.WriteLine("Your number is too high");
            }
            else if (number == randomNumber)

                Console.WriteLine("Your guess is correct");

            Console.WriteLine($"The correct number is {randomNumber}");

        }
    }

}



/* Console.WriteLine("Would you like to play again (Y/N)");
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
}







/* if (number_Of_Tries == allowed_Tries) ;
{
Console.WriteLine($"The number was: {randomNumber}");
playAgain = false;
}
*/