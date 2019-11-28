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
    [Route("api/[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private readonly civapiContext _context;

        public ComputersController(civapiContext context)
        {
            _context = context;
        }

        // GET: api/Computers
        [HttpGet]
        public IEnumerable<Computer> GetComputer()
        {
            return _context.Computer;
        }
    }
}