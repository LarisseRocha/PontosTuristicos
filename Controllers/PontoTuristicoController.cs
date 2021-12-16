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

         public async Task<ActionResult> CadastrarPontoTuristico(PontoTuristico model){

             model.Datacriacao = DateTime.Now;
             await _repositorioPontoTuristico.AddPontoTuristicoAsync(model);
             return Ok(model);
             
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

         [HttpGet]
         [Route("paginacao")]
         public async Task<ActionResult<IEnumerable<PontoTuristico>>>GetPontoTuristicoPag( int skip =0, int take =5){

             try
            {
                var PontoTuristicoRepositorio = await _repositorioPontoTuristico.GetPontoTuristicoPagAsync(skip, take);
                if (PontoTuristicoRepositorio == null) return NoContent();
                
                return Ok(PontoTuristicoRepositorio);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Falha ao tentar obter so produtos. Erro: {ex.Message}");
            }
            
         }
    }
}