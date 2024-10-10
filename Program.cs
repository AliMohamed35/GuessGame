Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int number;
int guess;
int guesses;
string response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max);

    while (guess != number)
    {
        Console.WriteLine("Please enter a number between " + min + " - " + max);
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
        guesses++;
    }
    Console.WriteLine("The number is: " + guess);
    Console.WriteLine("YOU WIN!");
    Console.WriteLine("Guesses: " + guesses);
    Console.WriteLine("Would you like to play again? (Y/N)");

    response = Console.ReadLine();
    response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
        Console.WriteLine("So u Liked it i guess :)");
    }
    else
    {
        playAgain = false;
        Console.WriteLine("Thank you for playing!");
    }
}


























//Random random = new Random();
//bool playAgain = true;
//int min = 1;
//int max = 100;
//int guess;
//int number;
//int guesses;
//String response;

//while (playAgain)
//{
//    guess = 0;
//    guesses = 0;
//    number = random.Next(min, max + 1);

//    while (guess != number)
//    {

//        Console.WriteLine("Guess number between " + min + " and " + max + " :");
//        guess = Convert.ToInt32(Console.ReadLine());

//        if (guess > number)
//        {
//            Console.WriteLine(guess + " is too high! ");
//        }
//        else if (guess < number)
//        {
//            Console.WriteLine(guess + " is too low! ");
//        }
//        guesses++;
//    }
//    Console.WriteLine("Number:" + number);
//    Console.WriteLine("YOU WIN!");
//    Console.WriteLine("Guesses:" + guesses);
//    Console.WriteLine("would you like to play again? (Y/N)");

//    response = Console.ReadLine();
//    response = response.ToUpper();

//    if (response == "Y")
//    {
//        playAgain = true;
//    }
//    else
//    {
//        playAgain = false;
//    }
//}