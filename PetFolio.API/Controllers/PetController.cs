using Microsoft.AspNetCore.Mvc;
using PetFolio.Communication.Requests;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(PetResponse), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RegisterPet request)
    {
        return Created();
    }
}
