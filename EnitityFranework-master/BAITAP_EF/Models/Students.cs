using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAITAP_EF.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        [ForeignKey("classID")]
        public int classID { get; set; }
        public Lop Class { get; set; }

       /* List<Students> students = new List<Students>()
         {
             new Students {Id = 1, Name = "Ho Dang Quoc Anh", Address = "Quang Trị", Phone = "0123456789", Age = 20, Class = new Lop {classID = 3, className = "21T3"}},
             new Students {Id = 2, Name = "Hoang Ngoc triet", Address = "Quang Trị", Phone = "1234567890", Age = 20, Class = new Lop {classID = 1, className = "21T1"}},
             new Students {Id = 3, Name = "Le Thi Hong Nhung", Address = "Quang Nam", Phone = "0123456789", Age = 20, Class = new Lop {classID = 2, className = "21T2"}},
             new Students {Id = 4, Name = "Nguyen Van A", Address = "Quang Nam", Phone = "1234567890", Age = 21, Class = new Lop {classID = 4, className = "20T3"}},

         };*/


    }
}
