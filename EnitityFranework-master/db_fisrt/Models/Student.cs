using System;
using System.Collections.Generic;

namespace db_fisrt.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Age { get; set; }

    public int ClassId { get; set; }

    public virtual Lop Class { get; set; } = null!;
}
