using System;
using System.Collections.Generic;

namespace fk_dfa.Models;

public partial class Course
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public int? Csid { get; set; }

    public virtual Student? Cs { get; set; }
}
