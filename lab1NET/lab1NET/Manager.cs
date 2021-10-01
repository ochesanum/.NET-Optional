using System;

namespace lab1NET
{
    public class Manager : Employee   //mosteneste pe Employee (va avea toate metodele si variabilele clasei baza)
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

        public override String Salutations() //face override la metoda abstracta din clasa parinte si afiseaza si numele
        {
            return "Hello Manager " + GetFullName();
        }
        
    }
}