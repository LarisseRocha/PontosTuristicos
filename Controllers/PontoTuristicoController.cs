using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteNewcon.Interfaces;
using TesteNewcon.Models;

namespace TesteNewcon.Controllers
{
    [ApiController]
    [Route("api/PontoTuristico")]
    public class PontoTuristicoController : ControllerBase
    {
        private IPontoTuristico _repositorioPontoTuristico;
        public PontoTuristicoController(IPontoTuristico repositorioPontoTuristico){

                _repositorioPontoTuristico = repositorioPontoTuristico;

        }

         [HttpPost]
         [Route("Cadastrar")]

         public async Task<ActionResult> CadastrarPontoTuristico([FromForm] PontoTuristico model){

             var pontoTuristico = new PontoTuristico();
             pontoTuristico.Descricao = model.Descricao;
             pontoTuristico.Endereco = model.Endereco;
             /*pontoTuristico.Endereco.Bairro = model.Endereco.Bairro;
             pontoTuristico.Endereco.Cidade = model.Endereco.Cidade;
             pontoTuristico.Endereco.Estado = model.Endereco.Estado;
             pontoTuristico.Datacriacao = DateTime.Now;*/
             await _repositorioPontoTuristico.AddPontoTuristicoAsync(pontoTuristico);
             return Ok(pontoTuristico);
             
         }

        [HttpGet]
         public async Task<ActionResult<IEnumerable<PontoTuristico>>>GetPontoTuristico(){

             try{
                    var listaPontosTur = await _repositorioPontoTuristico.GetTodosOsPontosAsync();
                    return Ok(listaPontosTur);
             }
             catch{
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                         "Falha ao obter os pontos turísticos! Erro:{execao.message}");                          
             }
             
         }
    }
}