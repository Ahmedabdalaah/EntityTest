// See https://aka.ms/new-console-template for more information
using EntityTest;
using EntityTest.Models;

var database = new APPDBContext();
//var department = new Department()
//{
//    Name = "Information Analysis" , Describtion ="IA",
//    students = new List<Student>() {
//    new Student() {Name="Mona" , Age=20 , BirthDate = DateTime.Now , Email="mona@yahoo.com",Grade=2 },
//    new Student() {Name="Maha" , Age=25 , BirthDate = DateTime.Now , Email="maha@yahoo.com",Grade=2 }
//    }
//};
//database.Add(department);
//var student = new Student()
//{
//    Id = 10,
//    Name = "Mahitab",
//    Age = 40,
//    BirthDate = DateTime.Now,
//    Email = "mahitab@yahoo.com",
//    Grade = 2,
//    departmentId = 7
//};
//database.Entry(database.students.Find(10)).CurrentValues.SetValues(student);
//database.Entry(database.students.Find(10)).Property(m => m.Name).IsModified=false;
var student = database.students.SingleOrDefault(x => x.Id == 10);
database.Remove(student);
database.SaveChanges();

