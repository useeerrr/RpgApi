using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PersonagensExercicioController : ControllerBase
  {
    private static List<Personagem> personagens = new List<Personagem>()
        {
          //Personagem aqui 
        new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
        new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
        new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
        new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
        new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
        new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
        new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };



    [HttpGet("GetByName/{nome}")]
    public IActionResult ExercicioA(string nome)
    {
      Personagem pBusca = personagens.FirstOrDefault(pe => pe.Nome == nome);
      if (pBusca == null)
        return NotFound("Personagem não encontrado");

      return Ok(pBusca);
    }
    [HttpGet("GetClerigoMago")]
    public IActionResult GetClerigoMago()
    {
      var lista = personagens
          .Where(p => p.Classe != ClasseEnum.Cavaleiro)
          .OrderByDescending(p => p.PontosVida)
          .ToList();

      return Ok(lista);
    }


    [HttpGet("GetEstatisticas")]
    public IActionResult GetEstatisticas()
    {
      int qtd = personagens.Count;
      int somainteligencia = personagens.Sum(laranja => laranja.Inteligencia);

      return Ok("quantidade: " + qtd + " Soma das Inteligencias: " + somainteligencia);
    }

    [HttpPost("PostValidacao")]
    public IActionResult PostValidacao(Personagem novoPersonagem)
    {
      if (novoPersonagem.Defesa < 10)
      {
        return BadRequest("O valor de Defesa não pode ser menor que 10.");
      }

      if (novoPersonagem.Inteligencia > 30)
      {
        return BadRequest("O valor de Inteligência não pode ser maior que 30.");
      }

      personagens.Add(novoPersonagem);

      return Ok(novoPersonagem);
    }

    [HttpPost("PostValidacaoMago")]
    public IActionResult PostValidacaoMago([FromBody] Personagem p)
    {
      if (p.Classe == ClasseEnum.Mago && p.Inteligencia < 35)
        return BadRequest("Magos não podem ter Inteligência menor que 35");

      personagens.Add(p);
      return Ok(personagens);
    }

    [HttpGet("GetByClasse/{enumid}")]

    public IActionResult GetByClasse(int enumid)
    {
      ClasseEnum enumDigitado = (ClasseEnum)enumid;

      List<Personagem> bsuca = personagens.FindAll(x => x.Classe == enumDigitado);

      return Ok(bsuca);
    }






  }
}
