﻿using System;
using System.Collections.Generic;

namespace Labb2LINQ.Models;

public partial class TeacherCourse
{
    public int Id { get; set; }

    public int? TeacherId { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
