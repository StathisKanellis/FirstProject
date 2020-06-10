using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class StudentsPerCourses
    {
        Student Student;
        Course Course;

        public StudentsPerCourses(Student student, Course course)
        {
            Student = student;
            Course = course;
            Student.courses.Add(course);
            Course.students.Add(student);
        }

    }
}
