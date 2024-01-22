using Microsoft.AspNetCore.Mvc;
using Test_NANY.Data.Models;
using Test_NANY.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Test_NANY.Data.ViewModels;

[ApiController]
[Route("[controller]")]
public class NanyProfilesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly IMapper _mapper;

    public NanyProfilesController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var nany = await _context.NanyProfile.ToListAsync();
        if (nany == null) return NotFound();
        var ViewModel = _mapper.Map<List<NanyViewModel>>(nany);
        
        return Ok(ViewModel);
    }


    [HttpGet("Details/{id}")]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return BadRequest();
        }

        var nany = await _context.NanyProfile.FindAsync(id);

        if (nany == null)
        {
            return NotFound();
        }

        var viewModel = _mapper.Map<NanyViewModel>(nany);
        viewModel.NGender.ToString();
        return Ok(viewModel);
    }


    [HttpPost]
    public async Task<IActionResult> Create(NanyViewModel ViewModel)
    {
        if (!ModelState.IsValid) return BadRequest();


        var nany = _mapper.Map<NanyProfile>(ViewModel);



        _context.Add(nany);
        await _context.SaveChangesAsync();
        return Ok(nany);

    }
 
     
    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, [FromBody] NanyViewModel nany_update)
    {
        if (id != nany_update.Nany_Id)    return BadRequest();

        if (!ModelState.IsValid)  return BadRequest(ModelState);

        var nanyProfile = await _context.NanyProfile.FindAsync(id);

        if (nanyProfile == null)
        {
            return NotFound();
        }

        /// mapping
        var ViewModel = _mapper.Map<NanyProfile>(nany_update);
      
        _context.Update(ViewModel);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var nanyProfile = await _context.NanyProfile.FirstOrDefaultAsync(c=>c.Nany_Id==id);

        if (nanyProfile == null)
        {
            return NotFound();
        }

       
        _context.NanyProfile.Remove(nanyProfile);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
