using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Employee2
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;//25000//house rent 5000//convence allowance...
        double TaxDeduction = 0.1;
        double netSalary;
        public Employee2(int EmpId, string EmpName, double GrossPay)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.GrossPay = GrossPay;
        }
        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is :  " + netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is :  " + GrossPay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id is : " +this.EmpId);
            Console.WriteLine("Employee Name is : " +this .EmpName);
            this.CalculateSalary();
        }

        static void Main(string[] args)
        {
            Employee2 e1 = new Employee2(12345,"Sneha", 20000);
            e1.ShowEmployeeDetails();

        }



          

    }
}
