using Microsoft.AspNetCore.Mvc;
using ProPlusApi.Models;

namespace ProPlusApi.Repository
{
    public interface IProgrammer
    {
        Task <IEnumerable<Programmer>> GetAllAsync();
        Task createAsync (Programmer programmer);
    }
}
