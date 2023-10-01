using ENSI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ENSI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly DbToufoulaProdContext _context;

        public TokenController(IConfiguration config, DbToufoulaProdContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SecuriteDirecteur _userData)
        {
            if (_userData != null && _userData.Login != null && _userData.Pwd != null)
            {
                var user = await GetUser(_userData.Login, _userData.Pwd);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Login", user.Login),
                        new Claim("Pwd", user.Pwd),
                        new Claim("Nom", user.Nom),
                        new Claim("Prenom", user.Prenom),
                        new Claim("CodeEtab", user.CodeEtab),
                        new Claim("Role", user.Role),
                        new Claim("Etat", user.Etat.ToString()),
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token).ToString());
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<SecuriteDirecteur> GetUser(string login, string password)
        {
            return await _context.SecuriteDirecteurs.FirstOrDefaultAsync(u => u.Login == login && u.Pwd == password);
        }
    }
}
