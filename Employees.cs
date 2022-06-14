using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayTranning
{
    public enum Gender {  Male ,Female}
    public enum Department { It,Comp,Electronics,Civil,Machanical}
    public class Employees
    {
        private int EmpId;
        private string Name, Dept;
        private float Salary;
        private Gender gender;
        private Department department;
        public Employees()
        {
            EmpId = 0;
            Name = "";
            Salary = 0.0f;

        }
        public Employees(int EmpId, string Name, Gender gender, Department department, float Salary)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.gender = gender;
            this.department = department;
            this.Salary = Salary;

        }
        public override string ToString()
        {
            return $" EmpId : {EmpId},Name : {Name},Gender : {gender}, Department : {department},Salary : {Salary}";
        }
       // public void Display()
        //{
        //  Console.WriteLine($" EmpId {EmpId},Name{Name}, Dept{Dept},Salary{Salary}");
        //}
    }
}

