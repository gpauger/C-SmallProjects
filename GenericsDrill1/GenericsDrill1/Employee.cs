using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDrill1

{
    public class Employee<T>  //class takes generic type parameter
    {
        
        //creates a generic property- list of things
        public List<T> Things { get; set; }

        //Creates a function to loop through list "Things" and print each item
        public void listThings()
        {
            int i = 0;
            while (i < Things.Count)
            {
                Console.WriteLine(Things[i]);
                i++;
            }
        }


        //public static Boolean operator ==(Employee emp1, Employee emp2)
        //{

        //    if (emp1.Id == emp2.Id)
        //    { return true; }
        //    else { return false; }


        //}
        //public static Boolean operator !=(Employee emp1, Employee emp2)
        //{

        //    if (emp1.Id != emp2.Id)
        //    { return true; }
        //    else { return false; }


        //}
    }
}

