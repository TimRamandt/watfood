using backend.Models;
using backend.Models.DTO;

namespace backend.Domain.Repository;

public interface IRecipeRepository
{
    Task AddRecipeAsync(RecipeDTO recipeDto);
}