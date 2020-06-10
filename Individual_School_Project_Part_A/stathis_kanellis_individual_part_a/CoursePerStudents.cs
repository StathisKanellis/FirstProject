using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class CoursePerStudents
    {
        Course Course;

        public CoursePerStudents(Course course, List<Student> students)
        {
            Course = course;
            course.students = students;
            foreach (var item in students)
            {
                item.Course = course;
            }
        }
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Students ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  {Course.Stream }  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Course.students)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.FirstName} {item.LastName} ");
            }
            Console.WriteLine();
        }
    }
}
