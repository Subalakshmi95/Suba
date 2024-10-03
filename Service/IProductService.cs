using ProPlusApi.Models;

namespace ProPlusApi.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Programmer>> GetAllProgrammerAsync();
        Task AddProgrammerAsync (Programmer programmer);
        
    }
}
