using backend.Domain.Repository;
using backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("recipes")]
public class RecipeController: ControllerBase
{
    private readonly IRecipeRepository _recipeRepository;
    
    public RecipeController(IRecipeRepository recipeRepository)
    {
       _recipeRepository = recipeRepository; 
    }


    public ActionResult Index()
    {
        return Ok("[WIP] will return saved recipes.");
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult> CreateAsync(RecipeDTO recipeDto)
    {
        try
        {
            await _recipeRepository.AddRecipeAsync(recipeDto);
        }
        catch (Exception e)
        {
           return BadRequest(e.Message); 
        }
        return Created();
    }
}