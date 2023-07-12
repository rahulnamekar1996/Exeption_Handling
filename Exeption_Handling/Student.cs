using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handling
{
    public class NameExeption:Exception

    {
        public NameExeption(string Massage):base(Massage)
        {
        }


    }
    public class Student
    {
        private string name;
        private int age;

        public void AcceptDetails(string name,int age)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NameExeption("name is required");

            }

            else
            {
                this.name= name; 
                this.age= age;
            }
        }
        
    }


}

