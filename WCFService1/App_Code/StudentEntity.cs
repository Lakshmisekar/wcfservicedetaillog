using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentEntity
/// </summary>
public class StudentEntity
{
    [Key]
    public int StudentId { get; set; }

    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public bool IsMale { get; set; }

    public string PhoneNumber { get; set; }

    public StudentGroup Group { get; set; }
}