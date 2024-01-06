using Api.Domain.Interfaces.InterfacesServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

    }
}
