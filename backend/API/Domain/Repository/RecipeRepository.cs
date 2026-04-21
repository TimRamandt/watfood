using backend.Domain.Entity;
using backend.Models.DTO;

namespace backend.Domain.Repository;

public class RecipeRepository : IRecipeRepository
{
    private readonly ApiDbContext _dbContext;
    
    public RecipeRepository(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddRecipeAsync(RecipeDTO recipeDto)
    {
        var recipe = new Recipe()
        {
            Name = recipeDto.Name
        };
        await _dbContext.Recipes.AddAsync(recipe);
        await _dbContext.SaveChangesAsync();
    }
}