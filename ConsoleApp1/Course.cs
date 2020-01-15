using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    public class Course
    {
        /// <summary>
        /// name of the course
        /// ex. Programming Fundamentals
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// the text description of the course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the auto incremented Course ID
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// how many credits the course offers
        /// </summary>
        public byte Credits { get; set; }
    }
}
