using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaGrade =  { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewGrade =  { 92, 89, 81, 96, 90, 89 };
int[] emmaGrade = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganGrade =  { 90, 95, 87, 88, 96, 96 };  
int[] beckyGrade =  { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisGrade =  { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericGrade =  { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorGrade =  { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tGrade\n");
int[] studentScores = new int[10];
foreach (string name in studentNames)
{   
    int sumAssignment = 0;
    int totalAssignments = 0;
    decimal studentScore;
    string studentGrade;

    if (name == "Sophia")
        studentScores = sophiaGrade;

    else if (name == "Andrew")
        studentScores = andrewGrade;

    else if (name == "Emma")
        studentScores = emmaGrade;
    
    else if (name == "Logan")
        studentScores = loganGrade;
    
    else if (name == "Becky")
        studentScores = beckyGrade;

    else if (name == "Chris")
        studentScores = chrisGrade;

    else if (name == "Eric")
        studentScores = ericGrade;

    else if (name == "Gregor")
        studentScores = gregorGrade;

    else
        continue;

    foreach (int grade in studentScores)
    {
        totalAssignments++;
        if (totalAssignments <= currentAssignments)
        {
            sumAssignment += grade;
        }
        else{
            sumAssignment += grade / 10;
        }
        
    }
    studentScore = (decimal)sumAssignment / currentAssignments;

    if (studentScore >= 97 && studentScore <= 100)
    {
        studentGrade = "A+";
    }
    else if (studentScore >= 93 && studentScore < 97)
    {
        studentGrade = "A";
    }
    else if (studentScore >= 90 && studentScore < 93)
    {
        studentGrade = "A-";
    }
    else if (studentScore >= 87 && studentScore < 90)
    {
        studentGrade = "B+";
    }
    else if (studentScore >= 83 && studentScore < 87)
    {
        studentGrade = "B";
    }
    else if (studentScore >= 80 && studentScore < 83)
    {
        studentGrade = "B-";
    }
    else if (studentScore >= 77 && studentScore < 80)
    {
        studentGrade = "C+";
    }
    else if (studentScore >= 73 && studentScore < 77)
    {
        studentGrade = "C";
    }
    else if (studentScore >= 70 && studentScore < 73)
    {
        studentGrade = "C-";
    }
    else if (studentScore >= 67 && studentScore < 70)
    {
        studentGrade = "D+";
    }
    else if (studentScore >= 63 && studentScore < 67)
    {
        studentGrade = "D";
    }
    else if (studentScore >= 60 && studentScore < 63)
    {
        studentGrade = "D-";
    }
    else if (studentScore >= 0 && studentScore < 60)
    {
        studentGrade = "F";
    }
    else
    {
        studentGrade = "?";
    }
    
    Console.WriteLine($"{name}\t\t{studentScore}\t{studentGrade}");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
