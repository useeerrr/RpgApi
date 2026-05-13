using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpgApi.Data;
using RpgApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RpgApi.Controllers
{
    [Route("[controller]")]
    public class PersonagemHabilidadesController : Controller
    {
      private readonly DataContext _context;

      public PersonagemHabilidadesController(DataContext context)
        {
            _context = context;
        }


      [HttpPost]
      public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidades)
        {
            try
            {
                Personagem personagem = await _context.TB_PERSONAGENS
                    .Include(p => p.Arma)
                    .Include(p => p.PersonagemHabilidades).ThenInclude(ps => ps.Habilidade)
                    .FirstOrDefaultAsync(p => p.Id == novoPersonagemHabilidades.PersonagemId);

                if (personagem == null)
                    throw new System.Exception("Personagem não encontrado para o Id informado.");

                Habilidade habilidad = await _context.TB_HABILIDADES
                .FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidades.HabilidadeId);

                if(habilidad == null)
                throw new System.Exception("Habilidade não encontrada.");

                PersonagemHabilidade ph = new PersonagemHabilidade();
                ph.Personagem = personagem;
                ph.Habilidade = habilidad;
                await _context.TB_PERSONAGENS_HABILIDADES.AddAsync(ph);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);      
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}