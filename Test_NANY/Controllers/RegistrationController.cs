using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_NANY.Data;
using Test_NANY.Data.Models;
using Test_NANY.Data.ViewModels;
namespace Test_NANY.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public RegistrationController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Registration

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _context.Registration.ToListAsync();
            if (user == null) return NotFound();
            var ViewModel = _mapper.Map<List<Registration>>(user);

            return Ok(ViewModel);
        }
        // GET: Registration/Details/5

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _context.Registration.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<RegistrationViewModel>(user);
            return Ok(viewModel);
        }

        // POST: Registration/Create
        [HttpPost]
        public async Task<IActionResult> Create(NanyViewModel ViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();


            var user = _mapper.Map<Registration>(ViewModel);



            _context.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);

        }


        // POST: Registration/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] RegistrationViewModel user_update)
        {
            if (id != user_update.UserId) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _context.Registration.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            /// mapping
            var ViewModel = _mapper.Map<Registration>(user_update);

            _context.Update(ViewModel);
            await _context.SaveChangesAsync();

            return Ok();
        }


        // GET: Registration/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var user = await _context.Registration.FirstOrDefaultAsync(c => c.UserId == id);

            if (user == null)
            {
                return NotFound();
            }
            _context.Registration.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
