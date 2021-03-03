using eTraining.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreningRS2.Models.ApplicationUser;

namespace TreningRS2.Services.Interface
{
    public interface IApplicationUser
    {
        List<Models.ApplicationUser.ApplicationUser> Get(ApplicationUserSearch search);
        Models.ApplicationUser.ApplicationUser GetById(int id);

        Models.ApplicationUser.ApplicationUser Insert(ApplicationUserInsert insert);
        Models.ApplicationUser.ApplicationUser Update(int id,ApplicationUserInsert update);
        Task<Models.ApplicationUser.ApplicationUserModel> Authenticiraj(string username, string pass);

        //Models.ApplicationUser.ApplicationUser Authenticiraj(string username, string pass);
    }
}
