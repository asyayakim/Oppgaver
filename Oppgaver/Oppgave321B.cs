namespace Oppgaver
{
    internal class Oppgave321B
    {
        public class Employee
        {
            private readonly string? _name;
            private readonly int _age;
            private readonly string _jobTitle;

            public Employee(string? name, int age, string jobTitle)
            {
                _name = name;
                _age = age;
                _jobTitle = jobTitle;
            }

            public string GetInfo()
            {
                return $"Name: {_name}, Age: {_age}, Job Title: {_jobTitle}";
            }
        }

        public void Run()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Alice", 30, "Software Developer"),
                new Employee("Bob", 25, "Data Analyst"),
                new Employee("Charlie", 35, "Project Manager"),
                new Employee("Diana", 28, "UI/UX Designer")
            };

            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1: Add Employee");
                Console.WriteLine("2: See the list of employees");
                Console.WriteLine("3: Find Employee");
                Console.WriteLine("4: Exit");
                string? choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Enter name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Enter job title: ");
                    string jobTitle = Console.ReadLine() ?? string.Empty;
                    Employee newEmployee = new Employee(name, age, jobTitle);
                    employees.Add(newEmployee);

                    Console.WriteLine("Employee added successfully!\n");
                }
                else if (choice == "2")
                {
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees added yet.\n");
                    }
                    else
                    {
                        Console.WriteLine("Employees:");
                        foreach (var employee in employees)
                        {
                            Console.WriteLine(employee.GetInfo());
                        }
                        Console.WriteLine();
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Enter the name of the employee you want to find:");
                    string findEmployee = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < employees.Count; i++)
                    {
                        if (employees[i].GetInfo().Contains($"Name: {findEmployee},"))
                        {
                            Console.WriteLine("Employee found:");
                            Console.WriteLine(employees[i].GetInfo());
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("No employee found with that name.\n");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.\n");
                }
            }
        }
    }
}