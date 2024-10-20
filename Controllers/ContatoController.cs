using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_api.Context;
using first_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace first_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato) 
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}