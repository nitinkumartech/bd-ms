using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDE.Repository;

namespace PDE.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MineController : Controller
    {
        // GET: api/Mine

        private readonly IMineRepository _mineRepository;
        public MineController(IMineRepository mineRepository)
        {
            _mineRepository = mineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _mineRepository.GetAllDetails());
        }

    }
}
