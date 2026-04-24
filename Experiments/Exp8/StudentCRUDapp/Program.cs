using System;
using System.Linq;
using StudentCRUDapp.Data;


class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // CREATE
            var student = new Student
            {
                Name = "Siddhi",
                Age = 21,
                Course = "AIML"
            };
            context.Students.Add(student);  //Students object of Student table //student - newly created object
            context.SaveChanges();

            Console.WriteLine("Student Added!");

            // READ
            var students = context.Students.ToList(); 
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name}");
            }

            // UPDATE
            var firstStudent = context.Students.FirstOrDefault();
            if (firstStudent != null)
            {
                firstStudent.Name = "Updated Siddhi";
                context.SaveChanges();
                Console.WriteLine("Student Updated!");
            }

            // DELETE
            var deleteStudent = context.Students.FirstOrDefault();
            if (deleteStudent != null)
            {
                context.Students.Remove(deleteStudent);
                context.SaveChanges();
                Console.WriteLine("Student Deleted!");
            }
        }
    }
}

