using StudentDatabaseEFCore;
using StudentDatabaseEFCore.Models;

StudentContext db = new StudentContext();

List<Student> students = db.Students.ToList();

StudentCRUD sc = new StudentCRUD();

//Student Paul = new Student() { Name = "Paul", Hometown = "South Lyon", FavoriteColor = "Orange", FavoriteFood = "Panda Express" };
//sc.AddStudent(Paul);

//Student x = new Student() { Name = "x", Hometown = "y", FavoriteFood = "rocks", FavoriteColor = "blind" };
//sc.AddStudent(x);

Console.WriteLine("Name/Hometown/FavFood/FavColor\n");
foreach (Student s in sc.GetStudents())
{
    Console.WriteLine($"{s.Name}/{s.Hometown}/{s.FavoriteFood}/{s.FavoriteColor}");
}

//sc.DeleteStudent(5);
