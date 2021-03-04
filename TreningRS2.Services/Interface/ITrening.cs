using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreningRS2.Models.Trening;

namespace TreningRS2.Services.Interface
{
    public interface ITrening
    {
        Task<List<TreningModel>> Get();
        TreningModel Get(int id);
        Task<TreningModel> Add(TreningModel model);
        Task<TreningModel> Update(int id, TreningModel model);
        List<TreningModel> GetModel(TreningModelSearch search);

    }
}
