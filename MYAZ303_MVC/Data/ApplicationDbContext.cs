using Microsoft.EntityFrameworkCore;
using myaz303.Models;
using MYAZ303_MVC.Models;

namespace MYAZ303_MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


        public DbSet<Film> Filmler
        {
            get; set;
        }
    }   
}
