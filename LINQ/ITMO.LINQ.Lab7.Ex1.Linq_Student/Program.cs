// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace ITMO.LINQ.Lab7.Ex1.Linq_Student
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ *****");

            // Exercise 1.
            //IEnumerable<Student> studentQuery = from student in Student.students
            //                                    where student.Scores[0] > 90 && student.Scores[3] < 80
            //                                    orderby student.Scores[0] descending
            //                                    select student;

            //foreach (Student student in studentQuery)
            //{
            //    Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
            //}

            // Exercise 2.
            // Grouping results.
            //var studentQuery2 = from student in Student.students
            //                    group student by student.Last[0];
            //foreach (var studentGroup in studentQuery2)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach (Student student in studentGroup)
            //    {
            //        Console.WriteLine("{0}, {1}", student.Last, student.First);
            //    }
            //}

            // Exercise 3.
            // Grouping results. Assigning an implicit variable.
            //var studentQuery3 = from student in Student.students
            //                    group student by student.Last[0];
            //foreach (var groupOfStudents in studentQuery3)
            //{
            //    Console.WriteLine(groupOfStudents.Key);
            //    foreach(var student in groupOfStudents)
            //    {
            //        Console.WriteLine("{0}, {1}", student.Last, student.First);
            //    }
            //}
            // Arrange groups by their key value.
            //var studentQuery4 = from student in Student.students
            //                    group student by student.Last[0] into studentGroup
            //                    orderby studentGroup.Key
            //                    select studentGroup;

            //foreach (var groupOfStudents in studentQuery4)
            //{
            //    Console.WriteLine(groupOfStudents.Key);
            //    foreach (var student in groupOfStudents)
            //    {
            //        Console.WriteLine("{0}, {1}", student.Last, student.First);
            //    }
            //}

            // Identifier 'let'.
            //var studentQuery5 = from student in Student.students
            //                     let totalScore = let totalScore = student.Scores[0] + student.Scores[1] +
            //                     student.Scores[2] + student.Scores[3]
            //                     where totalScore / 4 < student.Scores[0]
            //                     select student.Last + " " + student.First;
            //foreach (var student in studentQuery5)
            //{
            //    Console.WriteLine(student);
            //}

            //// Using method syntax in a query expression.
            //var studentQuery6 = from student in Student.students
            //                    let totalScore = student.Scores.Sum()
            //                    select totalScore;

            //double aversgeScore = studentQuery6.Average();
            //Console.WriteLine("The students average score is {0}", aversgeScore);

            // Conversion or projection in a select sentence.

            var studentQuery8 = from student in Student.students
                                let x = student.Scores.Sum()
                                where x > student.Scores.Average()
                                select new { id = student.ID, score = x };
                        
            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }

        }
    }
}