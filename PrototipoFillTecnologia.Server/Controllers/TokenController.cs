﻿using Api.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrototipoFillTecnologia.Server.Token;
using PrototipoFillTecnologia.Server.Models;

namespace PrototipoFillTecnologia.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public TokenController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] InputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.Email) || string.IsNullOrWhiteSpace(input.Password))
            {
                return Unauthorized();
            }

            var result = await _signInManager.PasswordSignInAsync(input.Email, input.Password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var token = new TokenJwtBuilder()
                 .AddSecurityKey(JwtSecurityKey.Create("Secret_Key-12345678"))
                 .AddSubject("Prototipo Fill Tecnologia")
                 .AddIssuer("Teste.Securiry.Bearer")
                 .AddAudience("Teste.Securiry.Bearer")
                 .AddClaim("UsuarioAPINumero", "1")
                 .AddExperiInMinutes(5)
                 .Builder();

                return Ok(token.value);

            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
