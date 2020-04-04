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
            foreach (var item in Faculty)
            {
                context.Faculties.Add(item);

            }
            context.SaveChanges();

            var Department = new List<Department>
            {
                new Department() { DepartmentName="Bilgisayar Mühendisliği"},
                 new Department() { DepartmentName="Gıda Mühendisliği"},
                  new Department() { DepartmentName="Makine Mühendisliği"},
                   new Department() { DepartmentName="Elektrik Elektronik Mühendisliği"},
            };
            foreach (var item in Department)
            {
                context.Departments.Add(item);

            }
            context.SaveChanges();

            var Lesson = new List<Lesson>
            {
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş"},
                new Lesson() { LessonName="C ile Programlama"},
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş"},
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş"},
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş"},
                new Lesson() { LessonName="Bilgisayar Mühendisliğine Giriş"},
            };
            foreach (var item in Lesson)
            {
                context.Lessons.Add(item);

            }
            context.SaveChanges();

            var Book = new List<Book>
            {
                new Book() { BookName="BMG ", Comment="bmg Kitabı", Price=30,Image="book.jpg",DepartmentID=1,FacultyID=1,LessonID=1 },
            };
            foreach (var item in Book)
            {
                context.Books.Add(item);

            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}