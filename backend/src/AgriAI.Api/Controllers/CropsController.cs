using AgriAI.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CropsController : ControllerBase
{
    private readonly AppDbContext _db;

    public CropsController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var crops = await _db.Crops
            .AsNoTracking()
            .OrderBy(c => c.Id)
            .Select(c => new
            {
                c.Id,
                c.NameEn,
                c.NameAr,
                Diseases = c.Diseases
                    .OrderBy(d => d.Id)
                    .Select(d => new { d.Id, d.NameEn, d.NameAr, d.IsHealthy })
            })
            .ToListAsync();

        return Ok(crops);
    }

    [HttpGet("{id:int}/diseases")]
    public async Task<IActionResult> GetDiseases(int id)
    {
        var diseases = await _db.Diseases
            .AsNoTracking()
            .Where(d => d.CropId == id)
            .OrderBy(d => d.Id)
            .Select(d => new { d.Id, d.NameEn, d.NameAr, d.IsHealthy })
            .ToListAsync();

        return Ok(diseases);
    }
}