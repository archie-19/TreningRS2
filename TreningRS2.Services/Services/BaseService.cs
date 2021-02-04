using AutoMapper;
using eTraining.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreningRS2.Services.Interface;

namespace TreningRS2.Services.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected readonly TrainingContext _context;
        protected readonly IMapper _mapper;
        public BaseService(TrainingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
