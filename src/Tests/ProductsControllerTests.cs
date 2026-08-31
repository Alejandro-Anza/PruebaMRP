using Microsoft.AspNetCore.Mvc;
using PruebaMRP.Controllers;
using PruebaMRP.Models;
using Xunit;

namespace Tests;

public class ProductsControllerTests
{
    private readonly ProductsController _controller = new();

    [Fact]
    public void GetAll_ReturnsOkResult()
    {
        var result = _controller.GetAll();
        Assert.IsType<OkObjectResult>(result.Result);
    }

    [Fact]
    public void Create_ReturnsCreatedAtAction()
    {
        var dto = new CreateProductDto
        {
            Name = "Test Product",
            Description = "Description",
            Price = 99.99m,
            Stock = 10
        };

        var result = _controller.Create(dto);
        Assert.IsType<CreatedAtActionResult>(result.Result);
    }
}