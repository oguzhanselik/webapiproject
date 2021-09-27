using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;


namespace Proje.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly DBInteractor _context;

        public StocksController(DBInteractor context)
        {
            _context = context;
        }

        // GET: api/Stocks
        [HttpGet]
        public async Task<JsonResult> GetStock()
        {
            List<Stock> stock = await _context.Stock.ToListAsync();
            Dictionary<string, int> kvpList = new Dictionary<string, int>();


            foreach (Stock st in stock)
            {
                if (st.Amount != 0)
                {
                    kvpList.Add(st.Name, st.Amount);
                }
            }
            return new JsonResult(kvpList);

        }
        // GET: api/Stocks/Name
        [HttpGet("{Name}")]
        public async Task<ActionResult<Stock>> GetStock(String Name)
        {
            Stock stock = await _context.Stock.FindAsync(Name);

            if (stock == null)
            {
                return NotFound();
            }

            return stock;

        }

        // PUT: api/Stocks/
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{Name}")]
        public async Task<IActionResult> PutStock(string Name, Stock stock)
        {
            if (Name != stock.Name)
            {
                return BadRequest();
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {               
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(Name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        public static bool HasPublicProperty(Type type, string name)
        {
            return type.GetProperty(name) != null;
        }


        // POST: api/Stocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stock>> PostStock(Stock stock)
        {
            
            if (StockExists(stock.Name))
            {
                return BadRequest("This item already exist.");
            }
            if (stock.Amount == 0)
            {
                stock.Amount = 1;
            }
            
                _context.Stock.Add(stock);
                await _context.SaveChangesAsync();

            return CreatedAtAction("GetStock", new { name = stock.Name }, stock);

        }

        // DELETE: api/Stocks/5
        [HttpDelete]
        public async Task<IActionResult> DeleteStock()
        {

            var st = await _context.Stock.ToListAsync();

            _context.Stock.RemoveRange(st);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StockExists(string Name)
        {
            return _context.Stock.Any(e => e.Name == Name);
        }
    }
}
