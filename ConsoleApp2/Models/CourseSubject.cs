using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class CourseSubject
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public int? SubjectId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Subject? Subject { get; set; }
}
