using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Prueba_técnica_.net_SICE.Classes;
using Prueba_técnica_.net_SICE.Context;

namespace Prueba_técnica_.net_SICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalesClassesController : ControllerBase
    {
        private readonly TodoContext _context;


        public TerminalesClassesController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TerminalesClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TerminalesClass>>> GetTerminales()
        {
            return await _context.Terminales.ToListAsync();
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetTerminalesName(int id)
        {
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (model == null)
            {
                model = await _context.Terminales.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
            }

            return model.terminal_name;
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetTerminalesDescripcion(int id)
        {
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (model == null)
            {
                model = await _context.Terminales.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
            }

            return model.terminal_desc;
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetNombreFabricante(int id)
        {
            FabricantesClass fabricanteClass = MemoryCache.Default["fabricanteClass"] as FabricantesClass;
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (fabricanteClass == null)
            {
                if (model == null)
                {
                    model = await _context.Terminales.FindAsync(id);
                    if (model == null)
                    {
                        return NotFound();
                    }
                }
                fabricanteClass = await _context.Fabricantes.FindAsync(model.id_fab);
            }

            return fabricanteClass.fab_name;
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetNombreEstado(int id)
        {

            EstadoClass estadoClass = MemoryCache.Default["fabricanteClass"] as FabricantesClass;
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (estadoClass == null)
            {
                if (model == null)
                {
                    model = await _context.Terminales.FindAsync(id);
                    if (model == null)
                    {
                        return NotFound();
                    }
                }
                estadoClass = await _context.Estado.FindAsync(model.id_fab);
            }
            return estadoClass.estado_name;
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetFechaFabricacion(int id)
        {
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (model == null)
            {
                model = await _context.Terminales.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
            }

            return model.fecha_fabricacion.ToString("yyyyMMdd");
        }

        // GET: api/TerminalesClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetFechaEstado(int id)
        {
            TerminalesClass model = MemoryCache.Default["terminal_key"] as TerminalesClass;

            if (model == null)
            {
                model = await _context.Terminales.FindAsync(id);
                if (model == null)
                {
                    return NotFound();
                }
            }

            return model.fecha_estado.ToString("yyyyMMdd");
        }


        private bool TerminalesClassExists(int id)
        {
            return _context.Terminales.Any(e => e.id_terminal == id);
        }
    }
}
