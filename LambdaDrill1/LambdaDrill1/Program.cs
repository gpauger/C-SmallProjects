using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee() { FirstName = "Joe", LastName = "Johnson", Id = 1 };
            Employee two = new Employee() { FirstName = "Dan", LastName = "Schnider", Id = 2 };
            Employee three = new Employee() { FirstName = "Pete", LastName = "Quinn", Id = 3 };
            Employee four = new Employee() { FirstName = "Sarah", LastName = "Silverman", Id = 4 };
            Employee five = new Employee() { FirstName = "Jackie", LastName = "Robinson", Id = 5 };
            Employee six = new Employee() { FirstName = "Rayanne", LastName = "Swanson", Id = 6 };
            Employee seven = new Employee() { FirstName = "Joe", LastName = "Harper", Id = 7 };
            Employee eight = new Employee() { FirstName = "Kate", LastName = "Lillard", Id = 8 };
            Employee nine = new Employee() { FirstName = "Diego", LastName = "Ruiz", Id = 9 };
            Employee ten = new Employee() { FirstName = "Joe", LastName = "Fitzgerald", Id = 10 };

            List<Employee> employees = new List<Employee>()  //creates list of all employees
            {
                one, two, three, four, five, six, seven, eight, nine, ten
            };
            //creates a new list 'joes' to add all joes to
            List<Employee> joes = new List<Employee>();
                foreach (Employee person in employees)
                {
                     if (person.FirstName == "Joe")
                         {
                            joes.Add(person);
                         };
                };
            //creates a different list of joes using lambda expression
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();

            //creates list of employees whose Id is greater than 5
            List<Employee> bigId = employees.Where(x => x.Id > 5).ToList();

            //prints employees named "Joe" with Id from list joes 
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.Id);
            }

            //prints employees named "Joe" with Id from list joes2 
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.Id);
            }
            //prints employees named "Joe" with Id from list joes2 
            foreach (Employee emp in bigId)
            {
                Console.WriteLine(emp.FirstName + " " + emp.Id);
            }
            Console.ReadLine();

        }
    }
}
