using Clor.Services.Catalog.Dtos;
using Clor.Services.Catalog.Models;
using Clor.Shared.Dtos;

namespace Clor.Services.Catalog.Services;

public interface ICategoryService
{
    Task<Response<List<CategoryDto>>> GetAllAsync();
    Task<Response<CategoryDto>> CreateAsync(Category category);
    Task<Response<CategoryDto>> GetByIdAsync(string id);
}