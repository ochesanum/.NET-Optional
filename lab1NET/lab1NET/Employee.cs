using System;
namespace lab1NET
{
    public abstract class Employee
    {
        protected long id;
        protected String firstname;
        protected String lastname;
        protected DateTime StartDate;
        protected DateTime EndDate;
        protected int salary;
        
        public String GetFullName()
        {
            return firstname + " " + lastname;
        }
        
        public String IsActive()
        {
            if ((EndDate.Ticks - StartDate.Ticks) < 0)
                return "Inactive";

            return "Active";

        }


        public abstract String Salutations();
    }
}