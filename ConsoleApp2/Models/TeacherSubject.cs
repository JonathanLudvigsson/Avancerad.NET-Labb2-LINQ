using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class TeacherSubject
{
    public int Id { get; set; }

    public int? TeacherId { get; set; }

    public int? SubjectId { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
