using System;
using System.Collections.Generic;

namespace DB_First.Models;

public partial class Faculty
{
    public int FacultyId { get; set; }

    public string FacultyName { get; set; } = null!;

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
