namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first value");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the second value");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int largest = FindLargest(num1, num2);
        Console.WriteLine("The largest number is " + largest);

        Console.WriteLine("Please input value");
        string input_num = Console.ReadLine();
        int N = Convert.ToInt32(input_num);
        Console.WriteLine("Please input shape");
        string input_shape = Console.ReadLine();
        Question2(N, input_shape);
    }
    static int FindLargest(int a, int b)
    {
        return (a>b) ? a : b;
    } 
      static void Question2(int N, string shape)
    {
        if(shape=="right")
        {
            for(int row = 1; row <= N; row++)
            {
                for(int col = 1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "left")
        {
            for (int row = 1; row <= N; row++)
            {
                for (int space = N; space > row; space--)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }   
        }
        else{
            Console.WriteLine("Invalid shape");
        } 
    }
 }  
