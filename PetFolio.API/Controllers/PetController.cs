using Microsoft.AspNetCore.Mvc;
using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(PetRegisterResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RegisterPet request)
    {
        return Created(string.Empty, request);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RegisterPet request)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(AllPetsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(PetResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]

    public IActionResult Get(int id)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }

}
