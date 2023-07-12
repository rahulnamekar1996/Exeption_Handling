using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            try
            {
                student.AcceptDetails("", 19);

            }

            catch(NameExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
            }   
    }
}
