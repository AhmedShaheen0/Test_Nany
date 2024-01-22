using Microsoft.AspNetCore.Mvc;
using Test_NANY.Data.Models;
using Test_NANY.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Test_NANY.Data.ViewModels;

[ApiController]
[Route("[controller]")]
public class ChildProfilesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly IMapper _mapper;

    public ChildProfilesController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var child = await _context.ChildProfile.ToListAsync();
        if (child == null) return NotFound();
        var ViewModel = _mapper.Map<List<ChildViewModel>>(child);
        
        return Ok(ViewModel);
    }


    [HttpGet("Details/{id}")]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return BadRequest();
        }

        var child = await _context.ChildProfile.FindAsync(id);

        if (child == null)
        {
            return NotFound();
        }

        var viewModel = _mapper.Map<ChildViewModel>(child);
        viewModel.Gender.ToString();
        return Ok(viewModel);
    }


    [HttpPost]
    public async Task<IActionResult> Create(ChildViewModel ViewModel)
    {
        if (!ModelState.IsValid) return BadRequest();


        var child = _mapper.Map<ChildProfile>(ViewModel);



        _context.Add(child);
        await _context.SaveChangesAsync();
        return Ok(child);

    }
 
     
    [HttpPut("Edit/{id}")]
    public async Task<IActionResult> Edit(int id, [FromBody] ChildViewModel child_update)
    {
        if (id != child_update.Child_Id)    return BadRequest();

        if (!ModelState.IsValid)  return BadRequest(ModelState);

        var childProfile = await _context.ChildProfile.FindAsync(id);

        if (childProfile == null) return NotFound();
       

        /// mapping
        var ViewModel = _mapper.Map<ChildProfile>(child_update);
      
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

        var childProfile = await _context.ChildProfile.FirstOrDefaultAsync(c=>c.Child_Id==id);

        if (childProfile == null)
        {
            return NotFound();
        }

       
        _context.ChildProfile.Remove(childProfile);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
