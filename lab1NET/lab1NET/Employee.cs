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
            if ((EndDate.Ticks - StartDate.Ticks) > (DateTime.Now.Ticks - StartDate.Ticks))
                return "Active";

            return "Inactive";

        }


        public abstract String Salutations();
        //clasa Employee este clasa parinte si nu avem nevoie sa o instantiem, de aceea am folosit abstract
        //fiecare copil isi implementeaza metoda Salutations dupa comportamentul necesar (ex: Hello Arhitect/Hello Manager) 
        //in caz ca am utiliza keywordul 'virtual' ar trebui sa facem un default implementation in clasa parinte, lucru care nu este necesar
    }
}