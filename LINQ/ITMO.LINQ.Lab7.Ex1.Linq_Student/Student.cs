using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.LINQ.Lab7.Ex1.Linq_Student
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;

        // Initialize list of students.
        public static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111,
                Scores= new List<int>{ 97, 92, 81, 60 } },
            new Student {First="Xavier", Last="Solana", ID=112,
                Scores= new List<int>{ 91, 84, 91, 39 } },
            new Student {First="Clair", Last="O'Donnell", ID=113,
                Scores= new List<int>{ 84, 87, 75, 57 } },
            new Student {First="Neil", Last="Armstrong", ID=114,
                Scores= new List<int>{ 78, 95, 79, 75 } },
            new Student {First="Leonid", Last="Brezhnev", ID=115,
                Scores= new List<int>{ 91, 35, 63, 64 } },
        };
    }
}
