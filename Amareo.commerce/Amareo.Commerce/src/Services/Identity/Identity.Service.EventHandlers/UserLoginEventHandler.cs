using Identity.Domain;
using Identity.Service.EventHandlers.Commands;
using System;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Identity.Service.EventHandlers.Responses;
using Microsoft.Extensions.Configuration;
using Identity.Persistence.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Identity.Service.EventHandlers
{
    public class UserLoginEventHandler : IRequestHandler<UserLoginCommand,IdentityAccess>
    {
        private readonly SignInManager<ApplicationUser> _sigInManager;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public UserLoginEventHandler(SignInManager<ApplicationUser> sigInManager , ApplicationDbContext context , IConfiguration configuration)
        {
            _sigInManager = sigInManager;
            _context = context;
            _configuration = configuration;
        }
        

        async Task<IdentityAccess> IRequestHandler<UserLoginCommand, IdentityAccess>.Handle(UserLoginCommand notification, CancellationToken cancellationToken)
        {
            var result = new IdentityAccess();
            var user = await _context.Users.SingleAsync(x => x.Email == notification.Email);

            var response = await _sigInManager.CheckPasswordSignInAsync(user, notification.Password, false); //El ultimo parámetro en false indica que si no esta correcta la password se bloquea el acceso al usuario

            if (response.Succeeded)
            {
                result.Succeeded = true;
                await GenerateToken(user, result);
            }

            return result;
        }

        private async Task GenerateToken(ApplicationUser user, IdentityAccess identity)
        {

            var secretKey = _configuration.GetValue<string>("SecretKey");
            var key = Encoding.ASCII.GetBytes(secretKey);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName)
            };

            var roles = await _context.Roles
                                    .Where(x => x.UserRoles.Any(y => y.UserId == user.Id))
                                    .ToListAsync();

            foreach (var role in roles)
            {
                claims.Add(
                    new Claim(ClaimTypes.Role, role.Name)
                );
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            identity.AccessToken = tokenHandler.WriteToken(createdToken);
        
    }
    }
}
