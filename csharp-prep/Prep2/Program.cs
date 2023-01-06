using System;

class Program
{
    static void Main(string[] args)
    {
        string val;
        int grade;
        
        Console.Write("What is the grade percentge?: ");
        val = Console.ReadLine();

        // convert to integer
        grade = Convert.ToInt32(val);
        
        if (grade >=  90)
        {
            Console.WriteLine("The grade is an 'A'");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("The grade is a 'B'");
        }
        else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine("The grade is a 'C'");
        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine("The grade is a 'D'");
        }
        else
        {
            Console.WriteLine("The grade is an 'F'");
        }
    }
}