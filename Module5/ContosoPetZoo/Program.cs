using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

Console.Clear();
PlanSchoolVisit("A", 6);
PlanSchoolVisit("B", 3);
PlanSchoolVisit("C", 2);



void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine($"School {schoolName}");
    PrintGroup(group);
}



void RandomizeAnimals()
{
    Random random = new Random();
    
    for(int i = 0; i < pettingZoo.Length; i++)
    {
        int index = random.Next(pettingZoo.Length);

        string temp = pettingZoo[index];
        pettingZoo[index] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int count = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = pettingZoo[count++];
        }
    }

    return result;
}

void PrintGroup(string [,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group{i}: ");
        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write($"{groups[i,j]} ");
        }
        Console.WriteLine();
    }


}