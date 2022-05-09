using StudentDatabaseEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseEFCore
{
    class StudentCRUD
    {
        StudentContext db = new StudentContext();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            Student output = db.Students.Find(id);
            if (output != null)
            {
                return output;
            }
            else
            {
                Student badNoodle = new Student();
                badNoodle.Name = $"No student was found at ID {id}";
                return badNoodle;
            }
        }

        public void AddStudent(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            Student studentToRemove = GetStudent(id);
            if (db.Students.Contains(studentToRemove))
            {
                db.Students.Remove(studentToRemove);
                db.SaveChanges();
            }
        }
    }
}
