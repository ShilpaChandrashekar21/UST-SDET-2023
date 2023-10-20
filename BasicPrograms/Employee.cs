using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Employee
    {
        private int emp_id;
        private string? ename, dept;
        private double basic_pay;

        public Employee(int emp_id, string? ename, string? dept, double basic_pay)
        {
            Emp_id = emp_id;
            Ename = ename;
            Dept = dept;
            Basic_pay = basic_pay;
        }


        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string? Ename { get => ename; set => ename = value; }
        public string? Dept { get => dept; set => dept = value; }
        public double Basic_pay { get => basic_pay; set => basic_pay = value; }

        public double CalculateSalary()
        {
            double gross_salary, net_salary;
            double allowances = Basic_pay * 0.3 + Basic_pay * 0.2 + Basic_pay * 0.15;
            gross_salary = Basic_pay + allowances;
            double deductions = Basic_pay * 0.1;
            net_salary = gross_salary - deductions;
            return net_salary;
        }
    }
}
