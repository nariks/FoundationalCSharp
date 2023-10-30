//Student Grading application that automates the calculation of grades for each student
using System;
using System.Data.Common;
using System.Runtime.InteropServices;

// initialize variables - graded assignments 
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  

//decimal[] studentScores = new decimal[4];
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    int[] studentScores = new int[5];

    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;
    else if (name == "Becky")
        studentScores = beckyScores;
    else if (name == "Chris")
        studentScores = chrisScores;
    else if (name == "Eric")
        studentScores = ericScores;
    else if (name == "Gregor")
        studentScores = gregorScores;
    else
        continue;
    
    int scoreSum = 0;
    int assignmentCount = 0;

    foreach (int score in studentScores)
    {
        assignmentCount += 1;

        if (assignmentCount <= examAssignments)
            scoreSum += score;

        else
            scoreSum += score / 10;
    }
        
    decimal averageScore = (decimal)scoreSum / examAssignments;

    string studentGrade = "";

    if (averageScore >= 97)
        studentGrade = "A+";

    else if (averageScore >= 93)
        studentGrade = "A";

    else if (averageScore >= 90)
        studentGrade = "A-";

    else if (averageScore >= 87)
        studentGrade = "B+";

    else if (averageScore >= 83)
        studentGrade = "B";

    else if (averageScore >= 80)
        studentGrade = "B-";

    else if (averageScore >= 77)
        studentGrade = "C+";

    else if (averageScore >= 73)
        studentGrade = "C";

    else if (averageScore >= 70)
        studentGrade = "C-";

    else if (averageScore >= 67)
        studentGrade = "D+";

    else if (averageScore >= 63)
        studentGrade = "D";

    else if (averageScore >= 60)
        studentGrade = "D-";

    else 
        studentGrade = "F";
    
    Console.WriteLine($"{name}:\t\t {averageScore} \t{studentGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


