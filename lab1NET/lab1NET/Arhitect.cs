using System;

namespace lab1NET
{
    public class Arhitect : Employee 
    {
        public Arhitect()
        {
        }

        public Arhitect(long id, string firstname, string lastname, DateTime startDate, DateTime endDate, int salary)
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
            return "Hello Arhitect " + GetFullName() ;
        }
    }
}