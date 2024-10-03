using Microsoft.EntityFrameworkCore;
using ProPlusApi.Models;

namespace ProPlusApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opt):base(opt)
        {
            
        }
        public DbSet<Programmer> ProgrammerData {  get; set; }
    }
}
