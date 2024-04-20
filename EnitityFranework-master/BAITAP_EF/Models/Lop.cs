using System.ComponentModel.DataAnnotations;

namespace BAITAP_EF.Models
{
    public class Lop
    {
        [Key]
        public int classID { get; set; }
        [Required]
        public string className { get; set; }
        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }

        public ICollection<Students> Students { get; set; } = new List<Students>();

        /*List<Lop> lops = new List<Lop>()
        {
            new Lop { classID = 1, className = "21T1", Faculty = new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So" } },
            new Lop { classID = 2, className = "21T2", Faculty = new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So" } },
            new Lop { classID = 3, className = "21T3", Faculty = new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So" } },
            new Lop {classID = 4, className = "20T3", Faculty = new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So" }}
        };*/

    }

}
