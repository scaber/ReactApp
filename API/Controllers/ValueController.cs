using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase 
    {
        private readonly DataContext _context;
        public ValueController(DataContext context)
        {
            this._context=context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get(){
            var values= await _context.Values.ToListAsync();
            return Ok(values);
        }
        
    }
}