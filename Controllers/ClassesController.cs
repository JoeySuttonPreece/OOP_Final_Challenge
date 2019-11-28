using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OOP_Final_Challenge;

namespace OOP_Final_Challenge.Controllers
{
    [Route("api/Class")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly civapiContext _context;

        public ClassesController(civapiContext context)
        {
            _context = context;
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClass([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @class = await _context.Class.FindAsync(id);

            if (@class == null)
            {
                return NotFound();
            }

            return Ok(@class);
        }
    }
}