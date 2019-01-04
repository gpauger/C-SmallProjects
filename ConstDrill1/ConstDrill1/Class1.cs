using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill1
{
    public class User
    {
        public string Name;
        public int ID;
        public int Trials;

        public User(string name) : this(name, 8675309, 3)
        {
            Name = name;

        }
        public User(string name, int iD, int trials)
        {
            Name = name;
            ID = iD;
            Trials = trials;
        }
       
                
    }

    
        
   
    
}
