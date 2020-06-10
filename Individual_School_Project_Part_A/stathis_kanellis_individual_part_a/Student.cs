using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public Course Course;
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Assignment> assignments { get; set; } = new List<Assignment>();





        public void Output()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ All Students ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"First Name: {FirstName} - Last Name: {LastName} - Date Of Birth: {DateOfBirth.ToString("d")} - Tuition Fees: {TuitionFees}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
