using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_NANY.Data;
using Test_NANY.Data.Models;
using Test_NANY.Data.ViewModels;
namespace Test_NANY.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ShiftsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public ShiftsController(ApplicationDbContext context, IMapper mapper)
        {
            context = context;
            _mapper = mapper;
        }

        // GET: Shifts
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shift = await _context.Shift.ToListAsync();
            if (shift == null) return NotFound();
            var ViewModel = _mapper.Map<List<ShiftViewModel>>(shift);

            return Ok(ViewModel);
        }



        // GET: Shifts/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shift
                .FindAsync(id);
            if (shift == null)
            {
                return NotFound();
            }
            var viewModel = _mapper.Map<ShiftViewModel>(shift);

            return View(viewModel);
        }



        [HttpPost]
        public async Task<IActionResult> Create(ShiftViewModel viewModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var shift = _mapper.Map<Shift>(viewModel);

            _context.Add(shift);
            await _context.SaveChangesAsync();
            return View(shift);
        }

        // GET: Shifts/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] ShiftViewModel shift_update)
        {
            if (id != shift_update.Shift_Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var shift = await _context.Shift.FindAsync(id);

            if (shift == null) return NotFound();

            /// mapping
            var ViewModel = _mapper.Map<Shift>(shift_update);

            _context.Update(ViewModel);
            await _context.SaveChangesAsync();

            return Ok();
        }




        // POST: Shifts/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var shift = await _context.Shift.FirstOrDefaultAsync(c => c.Shift_Id == id);
            if (shift == null) return NotFound();

            _context.Shift.Remove(shift);
            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}
