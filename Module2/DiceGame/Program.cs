// DiceGame


// Get 3 random dice rolls
Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"The dice rolled {roll1}, {roll2}, {roll3} for a total of {total}.");

// Calculating the bonuses

int bonus = 0;

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll2) 
{
    bonus = 2;
} else if (roll1 == roll2 && roll1 == roll2)
{
    bonus = 4;
}

int totalScore = total + bonus;

// Calculate game result

if (totalScore >= 15) 
{
    Console.WriteLine($"Player wins a car !!!");
} 
else if (totalScore >= 10)
{
    Console.WriteLine($"Player wins a laptop !!!");
} 
else if (totalScore == 7)
{
    Console.WriteLine($"Player wins a trip !!!");
} 
else
{
    Console.WriteLine("Player wins a kitten !!!");
}