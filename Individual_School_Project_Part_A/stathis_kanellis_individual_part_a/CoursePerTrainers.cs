using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class CoursePerTrainers
    {
        Course Course;

        public CoursePerTrainers(Course course, List<Trainer> trainers)
        {
            Course = course;
            course.trainers = trainers;
            foreach (var item in trainers)
            {
                item.course = course;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Course Per Trainers ~~~~~~~~~~");
            Console.WriteLine($"  {Course.Title}  -------  {Course.Stream }  -------  {Course.Type}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Course.trainers)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.FirstName} {item.LastName} ");
            }
        }
    }
}
