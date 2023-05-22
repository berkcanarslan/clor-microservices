using System.Threading.Tasks;
using Clor.Services.Catalog.Dtos;
using Clor.Services.Catalog.Services;
using Clor.Shared.ControllerBases;
using Microsoft.AspNetCore.Mvc;

namespace Clor.Services.Catalog.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : CustomBaseController
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await _categoryService.GetAllAsync();
        return CreateActionResultInstance(categories);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        return CreateActionResultInstance(category);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CategoryDto categoryDto)
    {
        var response = await _categoryService.CreateAsync(categoryDto);
        return CreateActionResultInstance(response);
    }
}