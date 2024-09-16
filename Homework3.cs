namespace Homework3;

class Program
{
    static void Main(string[] args)
    {   // Question 1
        Console.WriteLine("Please input value: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        if (x<=1){
            Console.WriteLine("Invalid value");
        }
        else if(x==2){
            Console.WriteLine($"{x} is a prime number");
        }
        else if(x%2 == 0){
            Console.WriteLine($"{x} is not a prime number");
        } 
        else{
            bool isPrime = true;
            for (int i = 3; i <= Math.Sqrt(x); i += 2){
                if (x%i == 0){
                    isPrime = false;
                    break;
                }
                
            }
            if (isPrime){
                Console.WriteLine($"{x} is a prime number");
            }
            else{
                Console.WriteLine($"{x} is not a prime number");
            }
            /* Lines 19-24 ChatGPT 2024, Sept 9th. I was very confused on how to do the loop in a way that would cover the non-special case numbers.
            I was missing the Math.Sqrt and bool value.*/
        }
        //Question 2
        Console.WriteLine("Please input value");
        int a = Convert.ToInt32(Console.ReadLine());
        for(int row = 0; row<a; row++){
            for(int col = 0; col<a; col++){
                Console.Write("=");
            }
            Console.WriteLine("");
        }
        //Question 3
        Console.WriteLine("Please input value");
        int b = Convert.ToInt32(Console.ReadLine());
        for(int row = 0; row<b; row++){
            for(int col = 0; col<b; col++){
                if(row>=col)
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        

        
    }
}
