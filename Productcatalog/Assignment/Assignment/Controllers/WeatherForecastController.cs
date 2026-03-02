using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
namespace ProductCatalogApi.Models;
namespace TrainingManagementSystem.DTOs

{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: /api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductReadDto>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        // GET: /api/products/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductReadDto>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            return Ok(_mapper.Map<ProductReadDto>(product));
        }

        // POST: /api/products
        [HttpPost]
        public async Task<ActionResult<ProductReadDto>> CreateProduct(ProductCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = _mapper.Map<ProductCreateDto>(dto);

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var readDto = _mapper.Map<ProductReadDto>(product);

            return CreatedAtAction(nameof(GetProduct), new { id = product.id }, readDto);
        }

        // PUT: /api/products/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            _mapper.Map(dto, product);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

    public class ProductCreateDto
    {
        public object id { get; internal set; }
    }

    internal class ProductReadDto
    {
    }

    public class ProductUpdateDto
    {
    }
}