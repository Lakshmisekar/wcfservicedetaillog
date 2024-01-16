using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>
// Student.cs
[DataContract]
public class Student
{
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public DateTime DateOfBirth { get; set; }

    [DataMember]
    public bool IsMale { get; set; }

    [DataMember]
    public string PhoneNumber { get; set; }

    [DataMember]
    public StudentGroup Group { get; set; }
}

// StudentGroup.cs

