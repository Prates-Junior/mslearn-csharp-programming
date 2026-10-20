// Set up the game
Random random = new Random();
int secretnumber = random.Next(1,21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine("I'm thinking of a number between 1 and 20.");
Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");


// Ask the player to guess
while (guessCount < maxGuesses)
{
  guessCount++;
  Console.Write($"\n Guess #{guessCount} ");
  int guess = Convert.ToInt32(Console.ReadLine());



// Check the guess and give feedback
if (guess == secretnumber)
{
    Console.WriteLine($"Correct! you got it in {guessCount} guesses");
    hasWon = true;
    break;

}
else if (guess < secretnumber)
{
    Console.WriteLine("Too Low");
}
else
{
        Console.WriteLine("Too High");
}
}   


// Announce the result
if (!hasWon)
{
    Console.WriteLine($"\nOut of guesses! The number is {secretnumber}. ");
}
