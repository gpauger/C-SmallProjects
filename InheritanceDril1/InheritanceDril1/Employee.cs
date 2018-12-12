using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDril1
{
    class Employee : Person
    {
        public int Id { get; set; }

        
    public static Boolean operator== (Employee emp1, Employee emp2)
        {

            if (emp1.Id == emp2.Id)
            { return true; }
            else { return false; }
                    
           
        }
        public static Boolean operator!= (Employee emp1, Employee emp2)
        {

            if (emp1.Id != emp2.Id)
            { return true; }
            else { return false; }


        }
    }
}

