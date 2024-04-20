
using Microsoft.EntityFrameworkCore;

namespace BAITAP_EF.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Lop> Lops { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>().HasData(
                               new Faculty { FacultyID = 1, FacultyName = "Cong Nghe So" },
                                              new Faculty { FacultyID = 2, FacultyName = "Co Khi" },
                                                             new Faculty { FacultyID = 3, FacultyName = "Dien-Dien Tu" }
                                                                        );
            modelBuilder.Entity<Lop>().HasData(
                               new Lop { classID = 1, className = "21T1", FacultyID = 1 },
                                              new Lop { classID = 2, className = "21T2", FacultyID = 1 },
                                                             new Lop { classID = 3, className = "21T3", FacultyID = 1 },
                                                                            new Lop { classID = 4, className = "20T3", FacultyID = 1 }
                                                                                       );
            modelBuilder.Entity<Students>().HasData(
                                              new Students { Id = 1, Name = "Le Phuoc Duc", Address = "Quang Trị", Phone = "0123456789", Age = 20, classID = 3 },
                                                                                           new Students { Id = 2, Name = "Hoang Ngoc triet", Address = "Quang Trị", Phone = "1234567890", Age = 20, classID = 1 },
                                                                                                                                                       new Students { Id = 3, Name = "Le Thi Hong Nhung", Address = "Quang Nam", Phone = "0123456789", Age = 20, classID = 2 },
                                                                                                                                                                                                                                  new Students { Id = 4, Name = "Nguyen Van A", Address = "Quang Nam", Phone = "1234567890", Age = 21, classID = 4 }
                                                                                                                                                                                                                                                                                                                        );
        }
        

    }
}
