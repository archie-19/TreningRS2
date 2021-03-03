using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreningRS2.Models.Općina;
using TreningRS2.Services.Interface;

namespace TreningRS2.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OpcinaController : BaseController<OpcinaModel, object>
    {
        public OpcinaController(IService<OpcinaModel, object> service) : base(service)
        {
        }
    }
}
