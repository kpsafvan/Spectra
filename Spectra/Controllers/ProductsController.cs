using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spectra.Data;
using Spectra.Models;
using System.Threading.Tasks;

namespace Spectra.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : Controller
    {
        private readonly SpectraDbContext _spectraContext;

        public ProductsController(SpectraDbContext spectraDbContextContext)
        {
            _spectraContext = spectraDbContextContext;
        }
        // GET: Products
        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _spectraContext.Products.ToListAsync());
        }

        [HttpGet("{id}", Name = "GetProductsByID")]
        public async Task<IActionResult> FindByID(int Id)
        {
            return Ok(await _spectraContext.Products.FindAsync(Id));
        }

        [HttpPost(Name = "CreateProduct")]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (product == null || string.IsNullOrWhiteSpace(product.Name))
            {
                return BadRequest("Name is required.");
            }
            _spectraContext.Products.Add(product);
            await _spectraContext.SaveChangesAsync();
            return CreatedAtAction(nameof(FindByID), new { id = product.Id }, product);
        }

        [HttpPut("{id}",Name = "UpdateProduct")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product is required.");
            }
            var prod = await _spectraContext.Products.FindAsync(product.Id);
            prod.Name = product.Name;
            prod.Price = product.Price;
            _spectraContext.Products.Update(product);
            await _spectraContext.SaveChangesAsync();
            return (IActionResult)_spectraContext.Products.Find(product.Id);
        }
    }
}
