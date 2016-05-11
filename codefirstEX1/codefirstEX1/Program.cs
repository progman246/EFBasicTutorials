using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace firstproject
{
    class Program
    {
        public class Student
        {
            public Student() { }
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public byte Photo { get; set; }
            public int Weight { get; set; }
            public int Height { get; set; }
            public Standard Standard { get; set; }
        }
        public class Standard
        {
            public Standard() { }
            public int StandardID { get; set; }
            public string StandardName { get; set; }
            public ICollection<Student> students { get; set; }

        }
        public class SchoolContext : DbContext
        {
            public SchoolContext() : base()
            { }
            public DbSet<Student> Students { get; set; }
            public DbSet<Standard> Standards { get; set; }

        }
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "new Student" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
