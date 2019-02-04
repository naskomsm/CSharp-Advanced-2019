namespace CompanyRoster
{
    using System.Text;
    using System;

    public class Employee
    {
        public Employee(string name, double salary, string position, string department,string email , int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department, string email):this(name, salary,  position,  department,  email, -1)
        {
        }
        
        public Employee(string name, double salary, string position, string department, int age):this(name,salary,position,department,"n/a",age)
        {
        }

        public Employee(string name, double salary, string position, string department) : this(name, salary, position, department, "n/a", -1)
        {
        }
       


        public string Name { get; set; }

        public double Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }



        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{this.Name} ");
            builder.Append($"{this.Salary:F2} ");
            builder.Append($"{(this.Email == null ? "n/a" : this.Email)} ");
            builder.Append($"{(this.Age == null ? -1 : this.Age)}");

            return builder.ToString();
        }

    }
}
