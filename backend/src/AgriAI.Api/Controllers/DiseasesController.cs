using AgriAI.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DiseasesController : ControllerBase
{
    private readonly AppDbContext _db;

    public DiseasesController(AppDbContext db) => _db = db;

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var disease = await _db.Diseases
            .AsNoTracking()
            .Where(d => d.Id == id)
            .Select(d => new
            {
                d.Id,
                d.NameEn,
                d.NameAr,
                d.IsHealthy,
                d.CropId,
                CropNameEn = d.Crop.NameEn,
                CropNameAr = d.Crop.NameAr,
                d.Symptoms,
                d.Causes,
                d.Prevention,
                d.Treatment
            })
            .FirstOrDefaultAsync();

        return disease is null ? NotFound() : Ok(disease);
    }
}