using Microsoft.AspNetCore.Mvc;
using DevPortfolioApi.Models;
using DevPortfolioApi.Data;

namespace DevPortfolioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly PortfolioDbContext _context;

    public ProjectsController(PortfolioDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var projects = _context.Projects.ToList();
        return Ok(projects);
    }
}
