using Microsoft.AspNetCore.Mvc;
using ProPlusApi.Models;
using ProPlusApi.Repository;
using ProPlusApi.Service;

namespace ProPlusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammerController : Controller
    {
        private readonly IProductService _productService;

        public ProgrammerController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programmer>>> GetProducts()
        {
            var programmers = await _productService.GetAllProgrammerAsync();
            return Ok(programmers);

        }
        [HttpPost]
        public async Task<ActionResult> createProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                return BadRequest("Not Found");
            }
            await _productService.AddProgrammerAsync(programmer);
            return Ok("Created sucessfully");
        }
    }
}
