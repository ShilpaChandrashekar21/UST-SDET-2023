using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeD
    {
        public EmployeeD(int employeeId, string? employeeName, int performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int PerformanceRating { get; set; }

        public static double BonusCalculation(EmployeeD employee)
        {
            double bonusCalculation ;

            if (employee.PerformanceRating > 1 &&
                employee.PerformanceRating <= 2)
            {
                bonusCalculation =
                    employee.PerformanceRating * 100000;
            }
            else if (employee.PerformanceRating > 3
                && employee.PerformanceRating <= 4)
            {
                bonusCalculation =
                    employee.PerformanceRating * 200000;
            }
            else
            {
                bonusCalculation =
                    employee.PerformanceRating * 300000;
            }

            return bonusCalculation;
        }
    }
}
