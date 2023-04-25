using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public virtual ICollection<TeacherCourse> TeacherCourses { get; set; } = new List<TeacherCourse>();

    public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
}
