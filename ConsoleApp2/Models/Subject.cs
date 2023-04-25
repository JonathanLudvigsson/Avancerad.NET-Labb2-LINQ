using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CourseSubject> CourseSubjects { get; set; } = new List<CourseSubject>();

    public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
}
