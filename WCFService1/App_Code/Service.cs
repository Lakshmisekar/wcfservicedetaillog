using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IStudentService
{
    public void RegisterStudent(Student student)
    {
        using (var context = new StudentDbContext())
        {
            context.Students.Add(new StudentEntity
            {
                Name=student.Name,
                DateOfBirth = student.DateOfBirth,
                IsMale=student.IsMale,
                PhoneNumber=student.PhoneNumber,
                Group=student.Group
            });
            context.SaveChanges();
        }
        Console.WriteLine("registered successfully");
    }
}
