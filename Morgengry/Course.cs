using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }
        public Course(string name) :
            this(name, 0)
        {
        }


        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public override string ToString()
        {
            return String.Format("Name: {0}, Duration in Minutes: {1}", Name, DurationInMinutes);
        }
    }
}
