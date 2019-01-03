using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill1
{
    public class User
    {
        public string name { get; set; }
        public int ID { get; set; }
        public int trials { get; set; }

        public User(string name) : this(name, 8675309, 3)
        { }
        public User(string name, int ID, int trials)
        { }
       
                
    }

    
        
   
    
}
