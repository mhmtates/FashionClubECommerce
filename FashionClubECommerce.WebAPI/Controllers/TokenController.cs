using FashionClubECommerce.Entities.Dto;
using FashionClubECommerce.Entities.Dto.DtoUserAdmin;
using FashionClubECommerce.WebAPI.JwtAuthorizeToken.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FashionClubECommerce.WebAPI.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IAuthService service;
        public TokenController(IAuthService _service)
        {
            service = _service;
        }
        [HttpPost]
        public IActionResult Post(UserApiLoginDto user)
        {
            var Token = service.Authenticate(user.EMail, user.Password);
            if (Token == null)
            {
                return BadRequest(Token);
            }
            else
            {
                return Ok(Token);
            }
        }
    }
}
