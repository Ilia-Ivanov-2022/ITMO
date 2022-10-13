using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MvcStudents.Models
{
    public class StudentDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student { Id = 1001, FirstName = "Андрей", LastName = "Ямпольский", AdoMark = 1, AspMark = 2, JavaMark = 3 });
            context.Students.Add(new Student { Id = 1002, FirstName = "Борис", LastName = "Юров", AdoMark = 4, AspMark = 5, JavaMark = 5 });
            context.Students.Add(new Student { Id = 1003, FirstName = "Вера", LastName = "Эйзенштейн", AdoMark = 4, AspMark = 3, JavaMark = 2 }); 
            context.Students.Add(new Student { Id = 1004, FirstName = "Галина", LastName = "Щербина", AdoMark = 1, AspMark = 1, JavaMark = 2 });
            context.Students.Add(new Student { Id = 1005, FirstName = "Дмитрий", LastName = "Шоколадов", AdoMark = 3, AspMark = 4, JavaMark = 5 });
            context.Students.Add(new Student { Id = 1006, FirstName = "Егор", LastName = "Чаплин", AdoMark = 5, AspMark = 4, JavaMark = 3 });
            context.Students.Add(new Student { Id = 1007, FirstName = "Жанна", LastName = "Цицкаридзе", AdoMark = 2, AspMark = 1, JavaMark = 1 }); 
            context.Students.Add(new Student { Id = 1008, FirstName = "Зоя", LastName = "Хорошева", AdoMark = 2, AspMark = 3, JavaMark = 4 }); 
            context.Students.Add(new Student { Id = 1009, FirstName = "Илья", LastName = "Фадеев", AdoMark = 5, AspMark = 5, JavaMark = 4 }); 
            context.Students.Add(new Student { Id = 1010, FirstName = "Константин", LastName = "Ухов", AdoMark = 3, AspMark = 2, JavaMark = 1 }); 
            base.Seed(context);
        }
    }
}