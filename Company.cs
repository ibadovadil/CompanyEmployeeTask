namespace Company_Project
{
    public class Company
    {
        public string Name { get; }
        private Employee[] Employees;

        public Company(string name)
        {
            Name = name;
            Employees = new Employee[0];
        }

        public void AddUser(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
            Console.WriteLine("Employee added!");
        }



        public Employee GetUser(string username)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.Username == username) { return emp; }
            }
            Console.WriteLine("Employee not found");
            return null;
        }

        public void GetAllUsers()
        {
            foreach (Employee user in Employees)
            {
                Console.WriteLine("Username: " + user.Username);
            }
        }
    }
}