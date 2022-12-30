namespace EmpoyeeDay2c
{
    internal class EmpoloyeeTester
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee("sandeep", 1001, 12000.0m, 1);
            Employee obj2 = new Employee("rakesh", 1002, 14000.0m, 2);
            Employee obj3 = new Employee("pratik", 1003, 16000.0m, 3);
            Employee obj4 = new Employee("aman", 1004, 18000.0m, 4);
            Employee obj5 = new Employee("yashvi", 1005, 20000.0m, 5);
            Employee obj6 = new Employee("mitali", 1006, 22000.0m, 6);

            LinkedList<Employee> list = new LinkedList<Employee>(); 
            list.AddLast(obj1);
            list.AddLast(obj2);
                list.AddLast(obj3);
            list.AddLast(obj4);
                list.AddLast(obj5);
            list.AddLast(obj6);
            foreach (Employee e in list)
            {
                Console.WriteLine(e.display());
            }
            
            //Console.WriteLine(obj1.display());
            //Console.WriteLine(obj2.display());
            //Console.WriteLine(obj3.display());
            //Console.WriteLine(obj4.display());
            //Console.WriteLine(obj5.display());
            //Console.WriteLine(obj6.display());
            Console.ReadLine();
        }

        public class Employee
        {
            public string name;
            public int empNo;
            public decimal basic;
            public short deptId;
            
            public Employee(string name, int empNo, decimal basic,short deptId)
            {
                this.name = name;
                this.empNo = empNo;
                this.basic = basic;
                this.deptId = deptId;

            }

            public string display()
            {
                return "[Name : " + this.name +"]"+ "[EmpNo : " + this.empNo + "]" + "[Basic : " + this.basic + "]" + "[DeptId : " + this.deptId + "]";
            }

        }

    }
}