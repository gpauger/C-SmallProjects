using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDrill1

{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates the class: Employee
            Employee<string> sample = new Employee<string>();
            sample.Things = new List<string>()
            {
                 "computer", "charger", "notebook", "pen"    
            };
            Employee<int> sample2 = new Employee<int>();
            sample2.Things = new List<int>()
            {
                8, 6, 7, 5, 3, 0, 9
            };


            
            //Calls the method listThings from class: Employee
            
            sample.listThings();
            sample2.listThings();
            Console.ReadLine();
        }
    }
}
