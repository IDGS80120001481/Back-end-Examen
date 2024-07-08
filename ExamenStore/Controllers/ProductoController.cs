using ExamenStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamenStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruductoController : ControllerBase
    {

        private readonly TiendaBoxeoContext _basedatos;

        public PruductoController(TiendaBoxeoContext basedatos)
        {
            _basedatos = basedatos;
        }

        //Metodo GET ListaProductos que devuelve la lista de todas las tareas en la BD
        [HttpGet]
        [Route("ListProductos")]
        public async Task<IActionResult> Lista()
        {
            var listaProductos = await
                _basedatos.Productos.ToListAsync();
            return Ok(listaProductos);
        }
    }
    }
