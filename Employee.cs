namespace Company_Project
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; }
        public int Age { get; set; }

        public Employee(string name, string surname, int age, string username)
        {
            Name = name;
            Surname = surname;
            Username = GenerateUsername(name, surname);
            Age = age;
        }

        private string GenerateUsername(string name, string surname)
        {
            string formattedName = char.ToUpper(name[0]) + name.Substring(1);
            string formattedSurname = char.ToUpper(surname[0]) + surname.Substring(1);
            return formattedName + "_" + formattedSurname;
        }
    }
}
