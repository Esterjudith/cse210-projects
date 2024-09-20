using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string studentGreadFromAns = Console.ReadLine();
        int studentGrade = int.Parse(studentGreadFromAns);
        
        string letter ;

        if (studentGrade >= 90)
        {
            letter = "A";
        } else if (studentGrade >= 80)
        {
            letter = "B";
        }else if (studentGrade >= 70)
        {
            letter = "C";
        }else if (studentGrade >= 60)
        {
            letter = "D";
        }else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is : {letter}");

        if(studentGrade >= 70){
            Console.WriteLine("Congratulations, you have passed the course!");
        }else 
        {
            Console.WriteLine("Better luck next time");
        }
    }
}