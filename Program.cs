// // V6.0
// Console.WriteLine("Hello, World!");


//V5.?
using System.Collections.Generic;


namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>(){
                "Adam",
                "Alex",
                "Bryan",
                "Dan",
                "Dom",
                "JP",
                "Wils"
            };

            employees.Add("Brooke");
            employees.Add("Link");

            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }

            // for (int i = 0; i < employees.Count; i++)
            // {
            //     Console.WriteLine(employees[i]);
            // }
        }
    }
}

