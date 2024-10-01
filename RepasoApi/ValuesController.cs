using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Negocio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepasoApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ProductosApi api=new ProductosApi();
        // GET: api/<ValuesController>
        [HttpGet]
        public List<Producto> Get()
        {
            ProductosApi Productoapi=new ProductosApi();
            //var products= Productoapi.GetAll(); Forma Larga
            return Productoapi.GetAll();
;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var producto = api.GetById(id);
            return Ok(producto);

            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Producto Post([FromBody] Producto producto)
        {
            ProductosApi pApi = new ProductosApi();
            Producto producto1 = pApi.Post(producto);
            return producto1;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Producto Put(int id, [FromBody] Producto producto)
        {
            producto.Id = id;
            var ProductoModificado=api.Put(producto);
            return ProductoModificado;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = api.Delete(id); 

            if (producto == null)
            {
                return NotFound(); 
            }

            api.Delete(id); 

            return NoContent(); 
        }
    }
}
