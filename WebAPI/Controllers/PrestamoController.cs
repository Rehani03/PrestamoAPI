using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrestamoAPI.BLL;
using PrestamoAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        // GET: api/Prestamo
        [HttpGet]
        public ActionResult<List<Prestamo>> Get()
        {
            return PrestamosBLL.GetPrestamos();
        }

        // GET: api/Prestamo/1
        [HttpGet("{id}")]
        public ActionResult<Prestamo> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        [HttpPost]
        public void Post([FromBody] Prestamo prestamo)
        {
            bool paso = PrestamosBLL.Guardar(prestamo);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PrestamosBLL.Eliminar(id);
        }
    }
}
