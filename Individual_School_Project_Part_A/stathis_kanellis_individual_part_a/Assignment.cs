using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public Course course;
        public Student student;

        public void Output()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ All Assignments ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Title: {Title} - Description: {Description} - Submission DateTime: {SubDateTime.ToString("d")} - Oral Mark: {OralMark} - Total Mark: {TotalMark}");
            Console.WriteLine();
            Console.WriteLine();

        }


    }
}
