using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_NANY.Data;
using Test_NANY.Data.Models;
using Test_NANY.Data.ViewModels;

namespace Test_NANY.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NanySchedulesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public NanySchedulesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET: NanySchedules
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var schedule = await _context.NanySchedule.ToListAsync();
            if (schedule == null) return NotFound();
            var ViewModel = _mapper.Map<List<NanyScheduleViewModel>>(schedule);

            return Ok(ViewModel);
        }

        //  GET: NanySchedules/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var schedule = await _context.NanySchedule.FindAsync(id);

            if (schedule == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<NanyScheduleViewModel>(schedule);
            return Ok(viewModel);
        }

        // GET: NanySchedules/Create
        [HttpPost]
        public async Task<IActionResult> Create(NanyScheduleViewModel ViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();


            var schedule = _mapper.Map<NanySchedule>(ViewModel);

            _context.Add(schedule);
            await _context.SaveChangesAsync();
            return Ok(schedule);

        }



        // POST: NanySchedules/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] NanyScheduleViewModel schedule_update)
        {
            if (id != schedule_update.Nany_Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var schedule = await _context.NanySchedule.FindAsync(id);

            if (schedule == null)
            {
                return NotFound();
            }

            /// mapping
            var ViewModel = _mapper.Map<NanySchedule>(schedule_update);

            _context.Update(ViewModel);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // Delete: NanySchedules/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var schedule = await _context.NanySchedule.FirstOrDefaultAsync(c => c.Nany_Id == id);

            if (schedule == null)
            {
                return NotFound();
            }


            _context.NanySchedule.Remove(schedule);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
