using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
