using Microsoft.AspNetCore.Mvc;

namespace dotnet_six_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private static Character _knight = new Character();

    [HttpGet]
    public ActionResult<Character> Get()
    {
        return Ok(_knight);
    }
}