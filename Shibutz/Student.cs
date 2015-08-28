using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shibutz
{
    class Student
    {
        private int id;
        private String name;
        private List<Course> completedcourses;
        private int[] coursepointallocation;


        public Student(int idt, String namet)
        {
            id = idt;
            name = namet;
        }
        public int Get_id(){
            return id;
        }
        public void Set_id(int idt)
        {
            id = idt;
        }
        public String Get_name()
        {
            return name;
        }
        public void Set_name(String namet)
        {
            name = namet;
        }
        public void PrintStudent()
        {
            Console.WriteLine("id = " + id.ToString());
            Console.WriteLine("name = " + name);
        }

    }
}
