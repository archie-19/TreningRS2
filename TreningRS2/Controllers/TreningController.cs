 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreningRS2.Models.Trening;
using TreningRS2.Services.Interface;

namespace TreningRS2.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreningController : ControllerBase
    {

        private readonly ITrening _treningService;

        public TreningController(ITrening treningService)
        {
            _treningService = treningService;
        }
        [Route("[action]")]
        //[HttpPost]
        [HttpGet]
        public async Task<ActionResult> GetTreninzi()
        {
            try
            {
                return Ok(await _treningService.Get());
            }
            catch (Exception)
            {
                throw new Exception("Greska trening controller get treninzi");
            }
        }
        [HttpGet]
        public ActionResult<List<TreningModel>> Get([FromQuery] TreningModelSearch search)
        {

            return _treningService.GetModel(search);
        }
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            try
            {
                return Ok(_treningService.Get(id));
            }
            catch (Exception ex)
            {
                throw new Exception("Greska trening controller get by id");
            }
        }
        //[Authorize(Roles = "AdministrativnoOsoblje, Predavač")]
        [HttpPost]
        public async Task<ActionResult> Add([FromBody] TreningModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = await _treningService.Add(model);
                    return Ok(item);
                }
                else
                {
                    return BadRequest(model);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska trening controller add");
            }
        }
       //[Authorize(Roles = "AdministrativnoOsoblje, Predavač")]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOsoblje(int id, [FromBody] TreningModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = await _treningService.Update(id, model);
                    return Ok(item);
                }
                else
                {
                    return BadRequest(model);
                }
            }
            catch (Exception )
            {
                throw new Exception("Greska trening controller update");
            }
        }
    }
}
