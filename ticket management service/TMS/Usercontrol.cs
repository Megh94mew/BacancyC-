using Microsoft.AspNetCore.Mvc;
using TMS.DTOs;
using TMS.Services.Interfaces;

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {
            await _service.CreateUserAsync(dto);
            return Ok("User Created Successfully");
        }
    }
}

// ------------------- Filter 

User.FindFirst(ClaimTypes.Role)?.Value