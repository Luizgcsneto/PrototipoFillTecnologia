using Api.Domain.Interfaces.InterfacesServices;
using Api.Domain.Services;
using Api.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PrototipoFillTecnologia.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [Produces("application/json")]
        [HttpPost("/api/CreateAddress")]
        public async Task<IActionResult> CreateAddress([FromBody] AddressEntity address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _addressService.AddAddress(address);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpPut("/api/UpdateAddress")]
        public async Task<IActionResult> UpdateAddress([FromBody] AddressEntity address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _addressService.UpdateAddress(address);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpGet("/api/GetAllAddress")]
        public async Task<IActionResult> GetAllAddress()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _addressService.List());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpGet("/api/GetAddressById")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _addressService.GetAddressById(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
