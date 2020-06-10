using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stathis_kanellis_individual_part_a
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Student> students { get; set; } = new List<Student>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Assignment> assigments { get; set; } = new List<Assignment>();

        public void Output()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ All Courses ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Title: {Title} -  Stream: { Stream} - Type: {Type} - Start Date: {StartDate.ToString("d")} - End Date: {EndDate.ToString("d")}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
