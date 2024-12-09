using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Linq;
using YalabenaApi.Data;
using YalabenaApi.Models;
using YalabenaApi.DTOs;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
namespace YalabenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        // Hash Password
       

    private readonly YalabenaDbContext _context;
        private readonly IConfiguration _configuration;

        public AccountsController(YalabenaDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // POST api/accounts/register
        [HttpPost("register")]
        public async Task<IActionResult> Register(AccountDto accountDto)
        {
            if (await AccountExists(accountDto.Email))
            {
                return BadRequest("Account already exists.");
            }

            var account = new Account
            {
                Username = accountDto.Username,
                Email = accountDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(accountDto.Password),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Account registered successfully!" });
        }

        // POST api/accounts/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(AccountLoginDto loginDto)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Email == loginDto.Email);

            if (account == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, account.PasswordHash))
            {
                return Unauthorized("Invalid credentials.");
            }

            var token = GenerateJwtToken(account);
            return Ok(new { token });
        }

        private async Task<bool> AccountExists(string email)
        {
            return await _context.Accounts.AnyAsync(a => a.Email == email);
        }

        private string GenerateJwtToken(Account account)
        {
            var claims = new[]
            {
            new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, account.Username),
            new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Email, account.Email),
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

}
