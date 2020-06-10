using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class CoursePerAssignments
    {
        Course Course;

        public CoursePerAssignments(Course course, List<Assignment> assignments)
        {
            Course = course;
            Course.assigments = assignments;
            foreach (var item in assignments)
            {
                item.course = course;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Assignments ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  { Course.Stream}  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Course.assigments)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.Title}   {item.Description} ");
            }

        }
    }
}
