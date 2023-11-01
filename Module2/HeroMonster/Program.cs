// Hero monster game

int playerHealth = 10;
int monsterHealth = 10;

Random dice = new Random();
int roll = 0;

do 
{
    roll = dice.Next(1,11);
    monsterHealth -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth}.");

    if (monsterHealth < 1)
        break;
    
    roll = dice.Next(1,11);
    playerHealth -= roll;
    Console.WriteLine($"Player was damaged and lost {roll} health and now has {playerHealth}.");

} while (playerHealth > 0);

Console.WriteLine( (monsterHealth > playerHealth) ? "Monster Wins !!!" : "Player Wins");

// Code Project 1

Console.WriteLine("Enter a whole number between 5 and 10");
int number = 0;
bool validNumber = false;

do
{
    validNumber = int.TryParse(Console.ReadLine(), out number);

    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number. please try again");
        continue;
    }
    else if (number > 5 && number < 10) 
    {
        break;
    }
    else
    {
        Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10");
        validNumber = false;
    }
    
} while (!validNumber);

Console.WriteLine($"You input value ({number}) has been accepted.");


// Code Project 2

string role = "";
string[] roleChoices = {"administrator", "manager", "user"};
Console.WriteLine("Choose one of these roles: Administrator | Manager | User");
do 
{
    role = Console.ReadLine();

    if (roleChoices.Contains(role.Trim().ToLower())) break;
    
    Console.WriteLine($"The role that you have entered {role} is not valid. Enter your role name Administrator | Manager | User");
    
} while (true);

Console.WriteLine($"Your input value ({role.ToLower()}) has been accepted."); 


// Code Project 3


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    String tempString = myString;

    while (periodLocation != -1)
    {
        String sentence = tempString.Substring(0, periodLocation);
        tempString = tempString.Remove(0, periodLocation + 1).Trim();
        periodLocation = tempString.IndexOf(".");

        Console.WriteLine(sentence);
    }
    Console.WriteLine(tempString);
    
}