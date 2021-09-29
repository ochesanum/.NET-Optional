using System;

namespace lab1NET
{
    public class Manager : Employee
    {
       

        public Manager()
        {
        }

        public Manager(long id, string firstname, string lastname, DateTime startDate, DateTime endDate, int salary) //: base(id, firstname,  lastname,  startDate,  endDate,  salary)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            StartDate = startDate;
            EndDate = endDate;
            this.salary = salary;
        }

        public override String Salutations()
        {
            return "Hello Manager" + GetFullName();
        }
        
    }
}