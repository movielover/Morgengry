using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public static class Utility
    {
        public static double  GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;
                default:
                    return 0;
            }
        }
        public static double   GetValueOfCourse(Course course)
        {
            double hours = course.DurationInMinutes / 60.0;
            return (Math.Floor(hours) * 875.00);
        }
    }
}
