using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using wa_pelis.Models;
using System.Text;

namespace wa_pelis.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AutenticacionController : ControllerBase
	{
		private readonly string secretKey;

		public AutenticacionController(IConfiguration configuration)
		{
			secretKey = configuration.GetSection("settings").GetSection("secretKey").ToString();
		}

		[HttpPost]
		[Route("Validar")]

		public IActionResult Validar([FromBody] Usuario request)
		{
			if(request.correo == "cbedoya@gmail.com" && request.clave == "123")
			{
				var keyBytes = Encoding.ASCII.GetBytes(secretKey);
				var claims = new ClaimsIdentity();
				claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, request.correo));
				var tokenDescriptor = new SecurityTokenDescriptor
				{
					Subject = claims,
					Expires = DateTime.UtcNow.AddMinutes(5),
					SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
				};

				var tokenHandler = new JwtSecurityTokenHandler();
				var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

				string tokenCreado = tokenHandler.WriteToken(tokenConfig);

				return StatusCode(StatusCodes.Status200OK, new {token = tokenCreado});
			}else
			{
				return StatusCode(StatusCodes.Status401Unauthorized, new { token = "" });
			}
		}

	}
}
