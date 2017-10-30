using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            foreach (Course course in courses)
            {
                if (course.Name == name)
                {
                    return course;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double result = 0;
            foreach (Course course in courses)
            {
                result = result + Utility.GetValueOfCourse(course);
            }
            return result;
        }
        

    }
}
