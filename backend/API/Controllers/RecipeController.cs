using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("recipes")]
public class RecipeController : ControllerBase
{
    public ActionResult Index()
    {
        return Ok("[WIP] will return saved recipes.");
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult Create(Recipe recipe)
    {
        Console.WriteLine(recipe.Name);
        return Ok();
    }
}