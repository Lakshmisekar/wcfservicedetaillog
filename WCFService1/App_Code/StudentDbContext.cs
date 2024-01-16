using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// <summary>
/// Summary description for StudentDbContext
/// </summary>
public class StudentDbContext : System.Data.Entity.DbContext
{
    public System.Data.Entity.DbSet<StudentEntity> Students { get; set; }

    public StudentDbContext() : base("name=StudentDbContext")
    {
    }
}