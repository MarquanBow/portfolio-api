using Microsoft.AspNetCore.Mvc;
using DevPortfolioApi.Models;
using DevPortfolioApi.Data;

namespace DevPortfolioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SkillsController : ControllerBase
{
    private readonly PortfolioDbContext _context;

    public SkillsController(PortfolioDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var skills = _context.Skills.ToList();
        return Ok(skills);
    }
}
