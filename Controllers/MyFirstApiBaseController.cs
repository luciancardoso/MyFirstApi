using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("aduana/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Lucian Cardoso";
}
