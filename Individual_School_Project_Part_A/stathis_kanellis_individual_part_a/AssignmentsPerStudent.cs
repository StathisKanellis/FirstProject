using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class AssignmentsPerStudent
    {
        Student Student;


        public AssignmentsPerStudent(Student student, List<Assignment> assignments)
        {

            Student = student;

            student.assignments = assignments;
            foreach (var item in assignments)
            {
                item.student = student;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~ Assignments Per Students ~~~~~~~~~~");
            
            Console.WriteLine($"Course: {Student.Course.Title} - {Student.Course.Stream} - {Student.Course.Type} ");
            Console.WriteLine($"Student: {Student.FirstName}  {Student.LastName}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in Student.assignments)
            {
                Console.Write("\t");
                Console.WriteLine($" {item.Title}   {item.Description} ");
            }

        }
    }
}
