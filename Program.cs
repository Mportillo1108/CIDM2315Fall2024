namespace Homework2._0;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
       Console.WriteLine("Please input letter grade:");
        string grade = Console.ReadLine();
        if (grade == "A")
        {
           Console.WriteLine("GPA Point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA Point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA Point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA Point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA Point: 0");
        }
        else
        {
            Console.WriteLine("Wrong letter grade!");
        }

       
       //Question 2
       Console.WriteLine("Plase input the first num");
       string run1 = Console.ReadLine();
       int run1_int = Convert.ToInt32(run1);

       Console.WriteLine("Plase input the second num");
       string run2 = Console.ReadLine();
       int run2_int = Convert.ToInt32(run2);

       Console.WriteLine("Plase input the third num");
       string run3 = Console.ReadLine();
       int run3_int = Convert.ToInt32(run3);

       if (run1_int < run2_int && run1_int < run3_int)
       {
        Console.WriteLine($"the smallest value is {run1_int}");
       }
       else if (run2_int < run1_int && run2_int < run3_int)
       {
        Console.WriteLine($"The smallest value is {run2_int}");
       }
       else
       {
        Console.WriteLine ($"The smallest value is {run3_int}");
       }


    }
}
