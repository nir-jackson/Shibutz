using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shibutz
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(32, "nir jackson");
            s.PrintStudent();
            s.Set_id(18);
            s.Set_name("Fuck OFF!");
            s.PrintStudent();
        }
    }
}
