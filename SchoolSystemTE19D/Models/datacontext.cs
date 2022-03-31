using Microsoft.EntityFrameworkCore;
using TE19DWEBAPIKURS.Models;

namespace SchoolSystemTE19D.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet <Student> students {get;set;}
    }
}