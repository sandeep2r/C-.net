using System.Diagnostics.CodeAnalysis;

namespace Employee_Multiple_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager objManage = new Manager("aman", 1, 300000.0m, "Manager");
            Console.WriteLine("manager data");
            Console.WriteLine(objManage.Name + " " + objManage.EmpNo + " " + objManage.DeptNo + " " + objManage.Basic + " " + objManage.CalcNetSalary() + " " + objManage.Designation);
            GeneralManager objGeneral = new GeneralManager("swati", 2, 400000.0m,"general manager 1" ,"mercedes car");
            Console.WriteLine("general manager");
            Console.WriteLine(objGeneral.Name + " " + objGeneral.EmpNo + " " + objGeneral.DeptNo + " " + objGeneral.Basic + " " + objGeneral.CalcNetSalary() +" "+ objGeneral.Designation+" " + objGeneral.perks);
            GeneralManager objGeneral1 = new GeneralManager("atharva", 3, 200000.0m,"general manager 2","bmw car");
            Console.WriteLine("general manager");
            Console.WriteLine(objGeneral1.Name + " " + objGeneral1.EmpNo + " " + objGeneral1.DeptNo + " " + objGeneral1.Basic + " " + objGeneral1.CalcNetSalary() +" "+ objGeneral.Designation + " "+ objGeneral1.perks);
        }
    }

    public interface IDbFunctions{
        public abstract decimal CalcNetSalary();
    }


    public abstract class Employee
    {
        string? name;
        protected int empNo;
        short deptNo;
        protected decimal basic;
        protected static int EMPNO = 1000;


        public Employee(string Name, short DeptNo, decimal Basic)
        {
            this.Name = Name;
            this.empNo = ++EMPNO;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value?.Trim().Length > 0)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name input is invalid");
                }

            }
        }
        public int EmpNo
        {
            get
            { 
                return empNo;
            }
        }
        public short DeptNo
        {
            get 
            { 
                return deptNo;
            }
            set 
            { 
                if(value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("department input is invalid");
                }
               
            }
        }

        public abstract decimal Basic { get; set; }

        public abstract decimal CalcNetSalary();


    }


    public class Manager : Employee, IDbFunctions
    {
        string? designation;

        public Manager(string Name, short DeptNo, decimal Basic, string? designation) : base(Name, DeptNo, Basic)
        {
           
            this.Designation = designation;
        }

        public string? Designation
        {
            get
            {
                return designation;
            }
            set
            {
                if(value?.Trim().Length > 0)
                {
                    designation = value.Trim();
                }
                else
                {
                    Console.WriteLine("designation value is invalid");
                }
            }
        }
        public override decimal Basic { get; set; }

        decimal sum = 0.0m;
        public override decimal CalcNetSalary()
        {
            sum = Basic + 12000.0m;


            return sum;
        }
    }

    public class GeneralManager : Manager, IDbFunctions
    {
        public string? perks;

        public GeneralManager(string Name, short DeptNo, decimal Basic, string? designation, string? perks) : base(Name, DeptNo, Basic, designation)
        {
            this.Perks = perks;
        }

        public string? Perks
        {
            get 
            { 
                return perks;
            }
            set
            {
                perks = value?.Trim();
            }
        }

        public override decimal Basic { get ; set ; }

        public override decimal CalcNetSalary()
        {
            return Basic + 24000.0m;
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public CEO(string Name, short DeptNo, decimal Basic) : base(Name, DeptNo, Basic)
        {

        }

        public override decimal Basic { get ; set ; }

        public override sealed decimal CalcNetSalary()
        {
           return Basic + 50000.0m;
        }
    }


}