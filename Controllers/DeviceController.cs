using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

//[Route("api/[controller]")]
//[ApiController]
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        //var Author = "Maria";

        //return Ok(Author);

        var laptop = new Smartphone();
        var model = laptop.GetBrand();

        return Ok(model);
    }
}
