using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9October2020
{
    class Student
    {
        int employeeId;
        public string employeeName;
        public string employeeDepartment;
        //public Student() { }
        public Student(int employeeId, string employeeName, string employeeDeparment)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeDepartment = employeeDeparment;
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter ID");
            employeeId = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter Department");
            employeeDepartment = Console.ReadLine();

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("ID is : {0}", employeeId);
            Console.WriteLine("Name is : {0}", employeeName);
            Console.WriteLine("Department is : {0}", employeeDepartment);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Paras", "hr");
            //student1.GetEmployeeDetails();
            //student1.DisplayEmployeeDetails();
            Student student2 = new Student(1, "Ajay", "IT");
            // student2.DisplayEmployeeDetails();
            Console.WriteLine("DETAILS OF STUDENT1");
            Console.WriteLine(student1.employeeName);
            Console.WriteLine(student1.employeeDepartment);
            Console.WriteLine("DETAILS OF STUDENT2");
            Console.WriteLine(student2.employeeName);
            Console.WriteLine(student2.employeeDepartment);

            student1 = student2;
            Console.WriteLine("After copying values");
            Console.WriteLine("DETAILS OF STUDENT1");
            Console.WriteLine(student1.employeeName);
            Console.WriteLine(student1.employeeDepartment);
            Console.WriteLine("DETAILS OF STUDENT2");
            Console.WriteLine(student2.employeeName);
            Console.WriteLine(student2.employeeDepartment);

            student1.employeeName = "DEEPAK";
            student1.employeeDepartment = "HR";
            Console.WriteLine("After changing values");
            Console.WriteLine("DETAILS OF STUDENT1");
            Console.WriteLine(student1.employeeName);
            Console.WriteLine(student1.employeeDepartment);
            Console.WriteLine("DETAILS OF STUDENT2");
            Console.WriteLine(student2.employeeName);
            Console.WriteLine(student2.employeeDepartment);

        }
    }

}
