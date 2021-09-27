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
    public class SalesController : ControllerBase
    {
        private readonly DBInteractor _context;
        public SalesController(DBInteractor context)
        {
            _context = context;
        }
        // GET: api/Sales       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sales>>> GetSales()
        {
            return await _context.Sales.ToListAsync();
        }
        // GET: api/Sales/
        [HttpGet("{id}")]
        public async Task<ActionResult<Sales>> GetSales(int id)
        {
            var sales = await _context.Sales.FindAsync(id);
            if (sales == null)
            {
                return NotFound();
            }
            return sales;
        }
        // PUT: api/Sales/
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{Name}")]
        public async Task<IActionResult> PutSales(string Name, Sales sales)
        {
            if (Name != sales.Name)
            {
                return BadRequest();
            }
            _context.Entry(sales).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesExists(Name))
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
        // POST: api/Sales Name, Amount, Price and TotalPrice 
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sales>> PostSales(Sales sales)
        {           
            Stock stock = _context.Stock.Find(sales.Name);
            if (stock == null)
            {
                return BadRequest("This item not available in the stock");
            }
            else
            {               
                if (sales.Amount == 0)
                {
                    sales.Amount = 1;
                }

                if (stock.Amount >= sales.Amount && stock.Amount >= 1)
                {                   
                        stock.Amount = stock.Amount - sales.Amount;
                        sales.TotalPrice = sales.Amount * sales.Price;
                        sales.TotalPrice = Math.Round(sales.TotalPrice, 2, MidpointRounding.ToEven);
                        _context.Sales.Add(sales);
                        _context.Stock.Update(stock);
                        await _context.SaveChangesAsync();
                        return CreatedAtAction("GetSales", new { Name = sales.Name }, sales);                                    
                }
                else
                {                    
                    return BadRequest();
                }
            }          
        }
        // DELETE: api/Sales/5
        [HttpDelete]
        public async Task<IActionResult> DeleteSales()
        {
            var sales = await _context.Sales.ToListAsync();           
            foreach (var sl in sales)
            {
                _context.Sales.RemoveRange(sl);            
            }
            await _context.SaveChangesAsync();
            return Ok("Success");
        }
        private bool SalesExists(string Name)
        {
            return _context.Sales.Any(e => e.Name == Name);
        }
    }
}
