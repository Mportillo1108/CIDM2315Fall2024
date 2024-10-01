namespace Homework5;

class Program
{
    static void Main(string[] args)
    {   //question 1 and 2
        Console.WriteLine("Please input two values: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input four values: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
        int num5 = Convert.ToInt32(Console.ReadLine());
        int num6 = Convert.ToInt32(Console.ReadLine());

        int largest1 = FindLargest1(num1, num2);
        Console.WriteLine("The largest of the two values is: " + largest1);

        int largest2 = FindLargest1(num3, num4);
        int largest3 = FindLargest1(num5, num6);
        
        int max = FindLargest1(largest2, largest3);
        Console.WriteLine("The largest number of the four values is: " + max);
    
        Console.WriteLine("-------------------------------------------");
        //question 3

        Console.WriteLine("Welcome to the bank!");
        Console.WriteLine("In order to proceed with account creation, please input your birth year to verify your age: ");
        const int current_year = 2024;

        int birth_year = int.Parse(Console.ReadLine());
        //ChatGPT 2024, 9/30 
        //I got an error runnning line 38 and asked ChatGPT how to fix it. 
        int age = current_year - birth_year;
        if (checkAge(age))
        {

            Console.WriteLine("Please enter a username");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();
            Console.WriteLine("Please confirm your password");
            string password_confirm = Console.ReadLine();
            if (password_check(password, password_confirm)){
                Console.WriteLine("Account Created!");
            }
            else{
                Console.WriteLine("Account not created");
            }
            
        }
        else
        {
            Console.WriteLine("Account cannot be created");
        }
    }
    static int FindLargest1(int a, int b)
    {
        return (a>b) ? a : b;
    } 
    static bool checkAge(int age)
    {
        if (age > 18){
            Console.WriteLine("Proceed with the account creation");
            return true;
        }
        else{
            return false;
        }

    } 
    static bool password_check(string password, string password_confirm){
        if (password == password_confirm){
            Console.WriteLine("Passwords match");
            return true;
        }
        else {
            Console.WriteLine("Please check your password");
            return false;
        }
    }
}
