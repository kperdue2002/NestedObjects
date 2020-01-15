using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Course cpw212 = new Course()
            {
                CourseID = 1,
                CourseTitle = "Advanced >NET",
                Credits = 5,
                Description = "Advanced C#"
            };
            s.Schedule.Add(cpw212);

            List<Course> courses = s.Schedule;
            courses.Add(cpw212);
            courses.Add(cpw212);

        }
    }
}
