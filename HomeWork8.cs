using System;
using System.Linq;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
            Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
            Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
            Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
            Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
            Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
            Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
            Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

            Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

            TotalCredits(customer_list);
            AmarilloAverageAge(customer_list);
            CanyonAge(customer_list);
        }

        public static void TotalCredits(Customer[] customer_list)
        {
            double totalCredits = 0;
            foreach (Customer customer in customer_list)
            {
                totalCredits += customer.customerCredit;
            }
            Console.WriteLine($"The total customer credit is: {totalCredits}");
        }

        public static void AmarilloAverageAge(Customer[] customer_list)
        {
            double totalAge = 0;
            int countCustomer = 0;
            foreach (var customer in customer_list)
            {
                if (customer.customerCity == "Amarillo")
                {
                    totalAge += customer.customerAge;
                    countCustomer++;
                }
            }
            if (countCustomer > 0)
            {
                double amarilloAverageAge = totalAge / countCustomer;
                Console.WriteLine($"The average age in Amarillo is: {amarilloAverageAge}");
            }
            else
            {
                Console.WriteLine("No customers found in Amarillo.");
            }
        }

        public static void CanyonAge(Customer[] customer_list)
        {
            var canyonCustomers = customer_list
                .Where(c => c.customerCity == "Canyon" && c.customerAge >= 30)
                .OrderBy(c => c.customerAge)
                .ToArray();
                    // ChatGPT 10/28/2024. I had trouble getting lines 61 - 64 to work so I asked ChatGPT to help fix it. 
            Console.WriteLine("Customers in Canyon who are 30 and older:");
            foreach (var customer in canyonCustomers)
            {
                Console.WriteLine($"{customer.customerName}, Age: {customer.customerAge}");
            }
        }
    }

    class Customer
    {
        public string customerName;
        public int customerAge;
        public string customerCity;
        public double customerCredit;

        public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerCity = customerCity;
            this.customerCredit = customerCredit;
        }
    }
}
