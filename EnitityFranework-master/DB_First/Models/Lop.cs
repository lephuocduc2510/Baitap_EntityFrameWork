using System;
using System.Collections.Generic;

namespace DB_First.Models;

public partial class Lop
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public int FacultyId { get; set; }

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
