using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Examen_Torres_Reyes.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Torres_Reyes.Controllers
{
    public class ReportesController : Controller
    {
        private readonly BD_Vicente_TorresContext _context;

        public ReportesController(BD_Vicente_TorresContext context)
        {
            _context = context;
        }

        // GET: Reportes/ProveedoresPorUbicacion
        public async Task<IActionResult> ProveedoresPorUbicacion()
        {
            var reporte = await _context.Proveedors
                .Include(p => p.Ubicacion)
                .GroupBy(p => p.Ubicacion.Nombre)
                .Select(g => new
                {
                    Ubicacion = g.Key,
                    Proveedores = g.Count()
                })
                .ToListAsync();

            return View(reporte);
        }
    }
}
