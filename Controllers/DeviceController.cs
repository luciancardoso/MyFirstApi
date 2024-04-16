using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

//[Route("api/[controller]")]
//[ApiController]
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var Author = "Maria";

        return Ok(Author);
    }
}
