using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eTraining.Database.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreningRS2.Models;
using TreningRS2.Models.ApplicationUser;
using TreningRS2.Services.Interface;

namespace TreningRS2.WebAPI.Controllers
{
   //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUser _service;

        public ApplicationUserController(IApplicationUser service)
        {
            _service = service;
        }

       

        [HttpGet]
        public ActionResult<List<Models.ApplicationUser.ApplicationUser>>Get([FromQuery]ApplicationUserSearch search)
        {
            
            return _service.Get(search) ;
        }
        [HttpGet("{id}")]
        public ActionResult <Models.ApplicationUser.ApplicationUser> GetById(int id)
        {

            return _service.GetById(id);
        }
        [HttpPost]

        public Models.ApplicationUser.ApplicationUser Insert(Models.ApplicationUser.ApplicationUserInsert insert)
        {
            return _service.Insert(insert);
        }
        [HttpPut("{id}")]
        public Models.ApplicationUser.ApplicationUser Update(int id,Models.ApplicationUser.ApplicationUserInsert update)
        {
            return _service.Update(id,update);
        }
    }

}
