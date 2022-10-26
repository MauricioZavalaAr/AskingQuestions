bool playAgain = true;
string race;
string name1;
string name2;
string random1;
string random2;
string random3;
string random4;
string instrument1;
string instrument2;
string number1;

string userAnswer;

while(playAgain == true)
{
Console.WriteLine("Enter a lord of the rings race:");
race = Console.ReadLine();

Console.WriteLine("Enter a random name1:");
name1 = Console.ReadLine();

Console.WriteLine("Enter a random name2:");
name2 = Console.ReadLine();

Console.WriteLine("Enter a random word1:");
random1 = Console.ReadLine();

Console.WriteLine("Enter a random word2:");
random2 = Console.ReadLine();

Console.WriteLine("Enter a random word3:");
random3 = Console.ReadLine();

Console.WriteLine("Enter a random word4:");
random4 = Console.ReadLine();

Console.WriteLine("Enter a random instrument1");
instrument1 = Console.ReadLine();

Console.WriteLine("Enter a random instrument2");
instrument2 = Console.ReadLine();

Console.WriteLine("Enter a random number");
number1 = Console.ReadLine();

Console.WriteLine($"A {race} with the name of {name1}, who lived in {random1}, he wanted to play {instrument1} or {instrument2}, at the end he decided to play {instrument2}, for this he decided to get a new teacher called the Master {name2}. After {number1} years of training he decided to get his first song called {random2} from his first album called {random3}. He made his debut live on the mythical {random4} stadium. People says he has future, they expect the best.");

Console.WriteLine("Do you want to play again? Type Y if Yes or N if No");

userAnswer = Console.ReadLine().ToUpper();

if(userAnswer=="Y")
{
    playAgain = true;
}
else
{
    playAgain = false;
}
}
