using System;
using System.Collections.Generic;
using System.Text;
using TreningRS2.Services.Interface;

namespace TreningRS2.Services.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {
        T Insert(TInsert request);

        T Update(int id, TUpdate request);
    }
}
