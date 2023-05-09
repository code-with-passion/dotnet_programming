// initialize variables - graded assignments
using System.Collections.ObjectModel;

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the exam scores
    decimal examScore = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;
    
    // initialize/reset a counter of the number of extra credit scores
    int extraCreditCounter = 0;

    // initialize/reset the sum of extra credit scores / 10
    decimal extraCreditPoints = 0;

    // initialize/reset the extra credit points
    decimal extraCreditScore = 0;

    // initialize/reset the sum of the exam scores + extra credit scores 
    decimal finalStudentGrade = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            // add the exam score to the sum
            sumAssignmentScores += score;
            examScore = (decimal)sumAssignmentScores / gradedAssignments;
        }
        else
        {
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            extraCreditScore += score;
            extraCreditCounter++;
        } 
    }

    // totalAssigmentCounter = examAssignments + extraCreditCounter;
    extraCreditScore = (extraCreditScore / extraCreditCounter);
    extraCreditPoints = extraCreditScore / examAssignments;
    
    currentStudentGrade = (decimal)(sumAssignmentScores + extraCreditScore);
    finalStudentGrade = (decimal)(currentStudentGrade) / examAssignments;


    if (finalStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (finalStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (finalStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (finalStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (finalStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (finalStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (finalStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (finalStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (finalStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (finalStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (finalStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (finalStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{finalStudentGrade}\t{currentStudentLetterGrade}\t{extraCreditScore} ({extraCreditPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

