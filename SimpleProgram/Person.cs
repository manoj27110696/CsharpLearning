using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    
    public class Person
    {
        private int Age = 25;
        public int getAge()
        {  
            return Age;          
        }

        public void setAge(int newAge)
        {
            Age=newAge;
        }

         static public void greet()
        {
            Console.WriteLine("hello");
        }
    }
}
