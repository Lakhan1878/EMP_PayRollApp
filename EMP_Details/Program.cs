using System.Collections;

namespace EMP_Details
{
    public class Employee
    {
        public static int emp_id_count = 0;
        public int emp_id;
        public string emp_name;
        public int emp_bsalary;

      
        public  void Emp_Data(String ename,int bsalary)
        {
            emp_id = ++emp_id_count;
            emp_name = ename;
            emp_bsalary = bsalary;
        }

        public double calculate_salary()
        {
            double salary = emp_bsalary - (emp_bsalary * 0.2);
            return salary;
        }

    }

    public class Programmer : Employee
    {
        public void Emp_Data(String ename, int bsalary) {
            base.Emp_Data(ename,bsalary);

        }

        public double calculate_salary()
        {
            double salary = base.calculate_salary();
            double hra = emp_bsalary * 0.05;
            double net_sal =salary + hra;
            return net_sal;
        }
    }

    public class Manager : Employee
    {
        public void Emp_Data(String ename, int bsalary)
        {
            base.Emp_Data(ename, bsalary);

        }

        public double calculate_salary()
        {
            double salary = base.calculate_salary();
            double bonus = emp_bsalary * 0.1;
            Double net_sal= salary + bonus;
            return net_sal;
        }
    }

    public class SalesExec : Employee
    {
        public void Emp_Data(String ename, int bsalary)
        {
            base.Emp_Data(ename, bsalary);

        }

        public double calculate_salary()
        {
            double salary = base.calculate_salary();
            double travel_allowance = emp_bsalary * 0.15;
            double net_sal= salary + travel_allowance;
            return net_sal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList ele = new ArrayList();
            Programmer p1 = new Programmer();
            p1.Emp_Data("Ajay",600000);
            Manager m1 = new Manager();
            m1.Emp_Data("Amit",100000);
            SalesExec s1 = new SalesExec();
            s1.Emp_Data("Lakhan",90000);
            Employee e1 = p1;
            Employee e2 = m1;
            Employee e3 = s1;
            ele.Add(e1);
            ele.Add(e2);
            ele.Add(e3);
            foreach (Employee emp in ele)
            {
                
                Console.WriteLine("Salary= "+emp.calculate_salary());
            }
        }
    }



  
}