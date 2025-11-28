using ASP.NETCore.ArticlesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ASP.NETCore.ArticlesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class TutorialsController : ControllerBase
    {
        private readonly TutorialsManagementApiContext _context;

        public TutorialsController(TutorialsManagementApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Tutorial>> Get()
        {
            return await _context.Tutorial.ToListAsync<Tutorial>();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Tutorial Tutorial)
        {
            await _context.Tutorial.AddAsync(Tutorial);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = Tutorial.id }, Tutorial);
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Tutorial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Tutorial.FindAsync(id);
            return user == null ? NotFound() : Ok(user);
        }

        /*
        [HttpGet]
        public async Task<IEnumerable<Profile>> Get()
        {
            return await _context.Users.ToListAsync<Profile>();
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Profile), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Profile user)
        {
            if (id != user.Id) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Profile user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null) return NotFound();
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        */
    }
}
