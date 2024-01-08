using Api.Domain.Interfaces.InterfacesServices;
using Api.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PrototipoFillTecnologia.Server.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ImobilesController : ControllerBase
    {
        private readonly IimobileService _IimobileService;
        public ImobilesController(IimobileService iImobileService)
        {
            _IimobileService = iImobileService;
        }

        [Produces("application/json")]
        [HttpPost("/api/CreateImobile")]
        public async Task<IActionResult> CreateImobile([FromBody] ImobileEntity imobile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            try
            {
                await _IimobileService.AddImobile(imobile);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpPut("/api/UpdateImobile")]
        public async Task<IActionResult> UpdateImobile([FromBody] ImobileEntity imobile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _IimobileService.UpdateImobile(imobile);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpGet("/api/GetAllImobiles")]
        public async Task<IActionResult> GetAllImobiles()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _IimobileService.List());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Produces("application/json")]
        [HttpGet("/api/GetImobileById")]
        public async Task<IActionResult> GetImobileById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _IimobileService.GetImobileById(id);
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
