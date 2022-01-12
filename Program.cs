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

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}

