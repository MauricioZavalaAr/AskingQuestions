bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{

string name3;
string wakeUp;

Console.WriteLine("What is your name?");
name3 = Console.ReadLine();


// The variable defined needs to be an int. If its defined as string will mark error.

Console.WriteLine("What time did you wake up?");
wakeUp = Console.ReadLine();

Console.WriteLine($"{name3} woke up at {wakeUp}");

validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}


