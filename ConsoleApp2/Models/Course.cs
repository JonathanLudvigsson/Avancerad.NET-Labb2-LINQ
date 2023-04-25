using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<CourseSubject> CourseSubjects { get; set; } = new List<CourseSubject>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<TeacherCourse> TeacherCourses { get; set; } = new List<TeacherCourse>();
}
