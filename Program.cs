namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new();
            while (true)
            {
                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string first = Console.ReadLine();
                if (first == "")
                {
                    break;
                }
                Console.Write("Please enter a last name: ");
                string last = Console.ReadLine();
                Console.Write("Please enter an ID: ");
                int userId = Int32.Parse(Console.ReadLine());
                Console.Write("Please enter a photo url: ");
                string url = Console.ReadLine();

                Employee currentEmployee = new(first, last, userId, url);
                employees.Add(currentEmployee);
            }

            return employees;
        }



        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}

