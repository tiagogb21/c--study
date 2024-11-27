using Microsoft.AspNetCore.Mvc;
using FirstProject.Communication.Requests;
using FirstProject.Communication.Responses;

namespace FirstProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet] // define o tipo de método - endpoint do tipo GET
    public IActionResult GetAll()
    {
        var response = new User
        {
            Id = 1,
            Age = 37,
            Name = "Tiago",
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJSON), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJSON request)
    {
        var response = new ResponseRegisterUserJSON{
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("id")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 37,
            Name = "Tiago",
        };

        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestRegisterUserJSON request
    ) {
        return NoContent();
    }

    // [HttpPut("change-password")]
    // [ProducesResponseType(StatusCodes.Status204NoContent)]
    // public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    // {
    //     return NoContent();
    // }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(
        [FromRoute] int id
    ) {
        return NoContent();
    }
}
