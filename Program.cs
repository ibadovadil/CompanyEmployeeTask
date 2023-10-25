using Company_Project;

class Program
{
    static void Main(string[] args)
    {
        Company company = null;

        while (true)
        {
            Console.WriteLine("1. Create a company");
            Console.WriteLine("2. Create an employee");
            Console.WriteLine("3. Delete employee");
            Console.WriteLine("4. Update employee");
            Console.WriteLine("5. See all employees");
            Console.WriteLine("6. See employee");
            Console.WriteLine("-------------------------------");

            char option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    Console.WriteLine("Enter company name:");
                    string companyName = Console.ReadLine();
                    company = new Company(companyName);
                    Console.WriteLine("Company created: " + company.Name);
                    break;
                case '2':
                    if (company == null)
                    {
                        Console.WriteLine("Create a company first.");
                    }
                    else
                    {
                        Console.WriteLine("Enter employee name:");
                        string empName = Console.ReadLine();
                        Console.WriteLine("Enter employee surname:");
                        string empSurname = Console.ReadLine();
                        Console.WriteLine("Enter employee age:");
                        int empAge = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter employee username:");
                        string empUsername = Console.ReadLine();

                        Employee newEmployee = new Employee(empName, empSurname, empAge, empUsername);
                        company.AddUser(newEmployee);
                        Console.WriteLine("Employee added: " + newEmployee.Username);
                    }
                    break;
                case '3':
                    //I couldn't write delete user method
                    break;
                case '4':
                    if (company == null)
                    {
                        Console.WriteLine("Create a company first.");
                    }
                    else
                    {
                        Console.WriteLine("Enter employee username to update:");
                        string usernameToUpdate = Console.ReadLine();
                        Employee employeeToUpdate = company.GetUser(usernameToUpdate);

                        if (employeeToUpdate != null)
                        {
                            Console.WriteLine("Select an option to update:");
                            Console.WriteLine("1. Update Name");
                            Console.WriteLine("2. Update Surname");
                            Console.WriteLine("3. Update Age");

                            char updateOption = Convert.ToChar(Console.ReadLine());

                            switch (updateOption)
                            {
                                case '1':
                                    Console.WriteLine("Enter new name:");
                                    string newName = Console.ReadLine();
                                    employeeToUpdate.Name = newName;
                                    break;
                                case '2':
                                    Console.WriteLine("Enter new surname:");
                                    string newSurname = Console.ReadLine();
                                    employeeToUpdate.Surname = newSurname;
                                    break;
                                case '3':
                                    Console.WriteLine("Enter new age:");
                                    int newAge = Convert.ToInt32(Console.ReadLine());
                                    employeeToUpdate.Age = newAge;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                    }
                    break;
                case '5':
                    if (company == null)
                    {
                        Console.WriteLine("Create a company first.");
                    }
                    else
                    {
                        company.GetAllUsers();
                    }
                    break;
                case '6':
                    if (company == null)
                    {
                        Console.WriteLine("Create a company first.");
                    }
                    else
                    {
                        Console.WriteLine("Enter employee username to see:");
                        string usernameToSee = Console.ReadLine();
                        Employee employeeToSee = company.GetUser(usernameToSee);

                        if (employeeToSee != null)
                        {
                            Console.WriteLine("Employee Details:");
                            Console.WriteLine("Name: " + employeeToSee.Name);
                            Console.WriteLine("Surname: " + employeeToSee.Surname);
                            Console.WriteLine("Age: " + employeeToSee.Age);
                            Console.WriteLine("Username: " + employeeToSee.Username);
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}