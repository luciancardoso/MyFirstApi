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

        var laptop = new Laptop();
        var model = laptop.GetModel();

        return Ok(model);
    }
}
