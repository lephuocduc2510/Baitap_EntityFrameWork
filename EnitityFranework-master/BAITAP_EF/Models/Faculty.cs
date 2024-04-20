using System.ComponentModel.DataAnnotations;

namespace BAITAP_EF.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }
        [Required]
        public string FacultyName { get; set; }

        public ICollection<Lop> Lops { get; set; } = new List<Lop>();
        /*List<Faculty> facultys = new List<Faculty>()
        {
            new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So"},
            new Faculty { FacultyID = 2, FacultyName = "Co Khi" },
            new Faculty { FacultyID = 3, FacultyName = "Dien-Dien Tu" }
        };*/
        

    }
}
