using actividad04.Models;
using actividad04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace actividad04.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IGenericRepository<Product> _productRepo;

    public ProductController(IGenericRepository<Product> productRepo)
    {
        _productRepo = productRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _productRepo.GetAllAsync();
        return Ok(products);
    }
    
    
}