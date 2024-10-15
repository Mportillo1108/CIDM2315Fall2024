namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.teachClass = "Java";
        p1.SetSalary(9000);
        p1.GetSalary();

        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.teachClass = "Math";
        p2.SetSalary(8000);
        p2.GetSalary();

        p1.SalaryDiff(p2);

        Student s1 = new Student();
        s1.name = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.GetGrade();

        Student s2 = new Student();
        s2.name = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.GetGrade();

        s1.GradeSum(s2);


    }
}
class Professor
{
    public string name;
    public string teachClass;

    private double salary;

    public void GetSalary()
    {
        Console.WriteLine($"The salary of {name} is ${salary}");
    }
    public void SetSalary(double amount)
    {
        salary = amount;
    }
    public void SalaryDiff(Professor other)
    {
        double diff = salary - other.salary; 
        Console.WriteLine($"The difference in salary between {name} and {other.name} is {diff}");
    }
}
class Student
{
    public string name;
    public string classEnroll;
    private double Grade;

    public void SetGrade(double gradeValue)
    {
        Grade = gradeValue;
        
    }
    public double GetGrade()
    {
        Console.WriteLine($"The grade {name} is {Grade}");
        return Grade;
    }
     public void GradeSum(Student other)
    {
        double sum = Grade + other.Grade; // Use the grade of the other student
        Console.WriteLine($"The sum of grades is {sum}");
    }
}