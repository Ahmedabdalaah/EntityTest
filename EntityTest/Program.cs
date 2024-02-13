// See https://aka.ms/new-console-template for more information
using EntityTest;
using EntityTest.Models;
using System.ComponentModel.DataAnnotations;

using var db = new APPDBContext();
var department = new Department()
{
    Name = "Computer Science",
    Describtion = "123412323"
};
var context = new ValidationContext(department);
var errors = new List<ValidationResult>();
if (!Validator.TryValidateObject(department, context, errors, true)){
    foreach (var error in errors)
    {
        Console.WriteLine(error);
    }
}
else
{
    db.departments.Add(department);
    db.SaveChanges();
}

