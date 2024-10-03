using ProPlusApi.Models;
using ProPlusApi.Repository;

namespace ProPlusApi.Service
{
    public class ProductService : IProductService
    {
        private readonly IProgrammer _iprogrammer;
        public ProductService(IProgrammer iprogrammer)
        {
            _iprogrammer = iprogrammer;
        }
        public async Task AddProgrammerAsync(Programmer programmer)
        {
            await _iprogrammer.createAsync(programmer);
        }

        public async Task<IEnumerable<Programmer>> GetAllProgrammerAsync()
        {
            return await _iprogrammer.GetAllAsync();
        }

    }
}
