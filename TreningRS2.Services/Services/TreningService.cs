using AutoMapper;
using eTraining.Database.Entities;
using eTraining.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRS2.Models.Trening;
using TreningRS2.Services.Interface;

namespace TreningRS2.Services.Services
{
    public class TreningService:ITrening
    {
        private readonly TrainingContext _context;
        private readonly IMapper _mapper;

        public TreningService(TrainingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TreningModel> Add(TreningModel model)
        {
            try
            { 
                var noviTrening = _mapper.Map<Trening>(model);
                _context.Trening.Add(noviTrening);
                
                await _context.SaveChangesAsync();
                var returnModel = _mapper.Map<TreningModel>(noviTrening);
                
                return returnModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TreningModel>> Get()
        {
            try
            {
                var treninzi = await _context.Trening
                .ToListAsync();
               //var returnModel = new List<Trening>();
                return _mapper.Map<List<TreningModel>>(treninzi);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TreningModel Get(int id)
        {
            try
            {
                var trening = _context.Trening
                    .Where(k => k.Id == id)
                    .FirstOrDefault();
                var returnModel = _mapper.Map<TreningModel>(trening);
               
                return returnModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        List<TreningModel> ITrening.GetModel(TreningModelSearch search)
        {
            //var list = _ctx.ApplicationUser
            //    .Include(a => a.Opcina)
            //    .ToList();
            var querry = _context.Trening.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                querry = querry.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            
            var list = querry.ToList();
            return _mapper.Map<List<TreningModel>>(list);

        }
        public async Task<TreningModel> Update(int id, TreningModel model)
        {
            try
            {
                var trening = _context.Trening
                    .Where(k => k.Id == id)
                    .FirstOrDefault();
                _context.Set<Trening>().Attach(trening);
                _context.Set<Trening>().Update(trening);

                //_mapper.Map(model, kurs); ne prolazi zbog id-a pa cu manual
                trening.Naziv = model.Naziv;
                trening.SkraceniNaziv = model.SkraceniNaziv;
                trening.Opis = model.SkraceniNaziv;

                await _context.SaveChangesAsync();
                var returnModel = _mapper.Map<TreningModel>(trening);
                return returnModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}

