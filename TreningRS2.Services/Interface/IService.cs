using System;
using System.Collections.Generic;
using System.Text;

namespace TreningRS2.Services.Interface
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);

        T GetById(int id);
    }
}
