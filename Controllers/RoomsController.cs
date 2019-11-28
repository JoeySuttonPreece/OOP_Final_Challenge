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
    public class RoomsController : ControllerBase
    {
        private readonly civapiContext _context;

        public RoomsController(civapiContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public IEnumerable<Room> GetRooms()
        {
            return _context.Room;
        }

        [HttpGet("Unused")]
        public IEnumerable<Room> GetRoomsUnused()
        {
            return _context.Room
                .Where(r => r.Class.Count == 0);
        }

        [HttpGet("Used")]
        public IEnumerable<Room> GetRoomsUsed()
        {
            return _context.Room
                .Where(r => r.Class.Count > 0)
                .Include(r => r.Class);
        }

        [HttpGet("Computers")]
        public IEnumerable<Room> GetRoomsComputers()
        {
            return _context.Room
                .Where(r => r.Computer.Count > 0);
        }
    }
}