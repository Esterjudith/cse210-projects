using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Andrew", "Multiplication");
        // Console.WriteLine(assignment.GetSummary());

        // MathAssignment mathAssignment= new MathAssignment("Section 7.3", "Problems 8-19","Andrew", "Fractions");

        // Console.WriteLine(mathAssignment.GetSummary());
        // Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignemt writingAssignemt= new WritingAssignemt("The Causes of WW II", "Mary Walters", "European History");
        Console.WriteLine(writingAssignemt.GetSummary());
        Console.WriteLine(writingAssignemt.GetWrittingInformation());
    }
}