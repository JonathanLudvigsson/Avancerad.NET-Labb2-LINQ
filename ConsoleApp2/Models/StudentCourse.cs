using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class StudentCourse
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Student? Student { get; set; }
}
