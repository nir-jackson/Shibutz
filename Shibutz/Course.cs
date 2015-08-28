using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shibutz
{
    class Course 
    {
        private int id , maxstudent;
        private String name, desc;
        private List<Course> prereqs;
        private List<Student> whofinishedthiscourse; 
    }
}
