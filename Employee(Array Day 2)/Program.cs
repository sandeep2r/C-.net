using System;

namespace Employee_Array_Day_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee[] empArr= new Employee[3];
            int empid = 0;
            string? empname = "";
            int salary = 0;
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("Enter the emp id");
                empid  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the emp name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter the emp salary");
                salary= Convert.ToInt32(Console.ReadLine());


                empArr[i] = new Employee(empid, empname,salary);
                
               


            }
            Console.WriteLine(empArr[0].Name + " " + empArr[0].Id + " " + empArr[0].Salary);
            Console.WriteLine(empArr[1].Name + " " + empArr[1].Id + " " + empArr[1].Salary);
            Console.WriteLine(empArr[2].Name + " " + empArr[2].Id + " " + empArr[2].Salary);


        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary= salary;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
    }
}