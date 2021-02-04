using AutoMapper;
using eTraining.Database.Entities;
using eTraining.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreningRS2.Services.Interface;

namespace TreningRS2.Services.Services
{
    public class OpcinaService : BaseService<Models.Općina.OpcinaModel, object, Opcina>, IService<Models.Općina.OpcinaModel,object>
    {
        public OpcinaService(TrainingContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Models.Općina.OpcinaModel GetById(int id)
        {
            //var entity = _ctx.ApplicationUser.Find(id);
            var entity = _context.Opcina.Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<Models.Općina.OpcinaModel>(entity);
        }
    }
}
