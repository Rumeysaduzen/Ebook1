using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Ebook1.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var Faculty = new List<Faculty>
            {
                new Faculty() { FacultyName="Mühendislik Fakültesi"},
            };
        

            var departments = new List<Department>
            {
                new Department() { DepartmentName="Bilgisayar Mühendisliği"},
                 new Department() { DepartmentName="Gıda Mühendisliği"},
                  new Department() { DepartmentName="Makine Mühendisliği"},
                   new Department() { DepartmentName="Elektrik Elektronik Mühendisliği"},
            };
            foreach (var item in departments)
            {
                context.Departments.Add(item);

            }
            context.SaveChanges();

            var lessons = new List<Lesson>
            {
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş", DepartmanID=1,},

            };
            foreach (var item in lessons)
            {
                context.Lessons.Add(item);

            }
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book() { BookName="BMG ", Comment="bmg Kitabı", Price=30, Image="book.jpg", LessonID=1,   },
            };
            foreach (var item in books)
            {
                context.Books.Add(item);

            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}