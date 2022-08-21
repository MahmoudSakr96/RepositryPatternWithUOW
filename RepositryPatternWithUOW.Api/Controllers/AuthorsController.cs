using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositryPatternWithUOW.core.Models;
using RepositryPatternWithUOW.core.Repositories.Interfaces;

namespace RepositryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseRepository<Author> _authorsRepository;

        public AuthorsController(IBaseRepository<Author> authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_authorsRepository.GetById(1));
        }


        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync()
        {
            return Ok(_authorsRepository.GetByIdAsync(1));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_authorsRepository.GetAll());
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_authorsRepository.Find(b => b.Name == "new Title", new[] { "Name1" }));
        }
    }
}
