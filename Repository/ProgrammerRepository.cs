using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProPlusApi.Data;
using ProPlusApi.Models;

namespace ProPlusApi.Repository
{
    public class ProgrammerRepository : IProgrammer
    {
        private readonly AppDbContext _appDbContext;
        public ProgrammerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task createAsync(Programmer programmer)
        {
            await _appDbContext.ProgrammerData.AddAsync(programmer);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Programmer>> GetAllAsync()
        {
           return await _appDbContext.ProgrammerData.ToListAsync();
        }
    }
}
