using Disaheim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses { get; set; }

        public CourseRepository()
        {
            courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                { return courses[i]; }
            }
            return null;

        }

        public double GetTotalValue()
        {
            double total = 0;

            Utility utility = new Utility();
            foreach (Course course in courses)
            {
                total += utility.GetValueOfCourse(course);
            }
            return total;
        }

    }
}
