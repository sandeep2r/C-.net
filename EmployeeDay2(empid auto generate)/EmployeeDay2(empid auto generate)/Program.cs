namespace EmployeeDay2_empid_auto_generate_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1;
            emp1 = new Employee("sandeep", 10000);
            //emp1.Name = "";
            //emp1.Empno = 999;
            System.Console.WriteLine(emp1.display());

        }


    }

    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptId;

        public static int EMPID = 5000;

        private Employee()
        {
            
        }


        public Employee(string name="name1", decimal basic=0, short deptId=0 )
        {
            this.Name = name;
            this.Empno = EMPID++;
            this.basic = basic;
            this.deptId = deptId;
        }

        public string Name
        {
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("name can't be blank");
                }

            }
            get
            {
                return name;
            }
        }
        public int Empno
        {
            set
            {
                if (value > 0)
                {
                    empNo = value;
                }
                else
                {
                    Console.WriteLine("emp id should not be negative");
                }
            }
            get
            {
                return empNo;
            }
        }


        public string display()
        {
            return "[Name : " + this.name + "]" + "[EmpNo : " + this.empNo + "]" + "[Basic : " + this.basic + "]" + "[DeptId : " + this.deptId + "]";
        }
    }
}