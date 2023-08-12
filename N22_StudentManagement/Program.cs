using N22_StudentManagement;
using System.Threading.Channels;

Student<Guid, string> student1 = new Student<Guid, string>(Guid.NewGuid(),"Hoshimjon Ruziyev", "Middle");

Course course1 = new Course("Dotnet Booutcamp");

University<Student<Guid, string>, Guid, string> university = new University<Student<Guid, string>, Guid, string>();

university.EnrollStudent(student1, course1);

university.Students.ForEach(x => Console.WriteLine(x.Grade + x.Name + x.Grade));
university.Cousrces.ForEach(x => Console.WriteLine($"{x.Title} : {x.CourceId}"));


// Derectory va DirectoryInfo 
// File va FileInfo
// StreamWriter va StreamReader
// 



