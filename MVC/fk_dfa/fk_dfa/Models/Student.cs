using System;
using System.Collections.Generic;

namespace fk_dfa.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string Sname { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
