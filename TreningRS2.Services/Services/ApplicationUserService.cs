using eTraining.Database.Entities;
using eTraining.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreningRS2.Services.Interface;
using AutoMapper;
using TreningRS2.Models.ApplicationUser;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TreningRS2.Services.Services
{
    public class ApplicationUserService : IApplicationUser
    {
        private readonly TrainingContext _ctx;
        private readonly IMapper _mapper;

        public ApplicationUserService(TrainingContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public async Task<Models.ApplicationUser.ApplicationUserModel> Authenticiraj(string username, string pass)
        {
            var user = await _ctx.ApplicationUser.FirstOrDefaultAsync(x => x.Username == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);
                if (newHash == user.PasswordHash)
                {
                    return new ApplicationUserModel
                    {
                        Id = user.Id,
                        Username = user.Username
                    };
                }
            }
            return null;
        }

        public Models.ApplicationUser.ApplicationUser GetById(int id)
        {
            var entity = _ctx.ApplicationUser.Include(x => x.Opcina).Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<Models.ApplicationUser.ApplicationUser>(entity); 
        }

        public Models.ApplicationUser.ApplicationUser Insert(ApplicationUserInsert insert)
        {
            var entity = _mapper.Map<eTraining.Database.Entities.ApplicationUser>(insert);
            if(insert.Password!=insert.PasswordConfirm)
            {
                throw new Exception("Passwordi se ne slazu.");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt,insert.Password);
            _ctx.ApplicationUser.Add(entity);
            _ctx.SaveChanges();
            return _mapper.Map<Models.ApplicationUser.ApplicationUser>(entity);
        }

        public Models.ApplicationUser.ApplicationUser Update(int id, ApplicationUserInsert update)
        {
            
            var entity = _ctx.ApplicationUser.Include(x => x.Opcina).Where(x => x.Id == id).FirstOrDefault();

            _mapper.Map(update, entity);
            if(!string.IsNullOrWhiteSpace(update.Password))
            {
                if (update.Password != update.PasswordConfirm)
                {
                    throw new Exception("Passwordi se ne slazu.");
                }
                //TODO:update pass

            }
            _ctx.SaveChanges();
            return _mapper.Map<Models.ApplicationUser.ApplicationUser>(entity);

        }

        List<Models.ApplicationUser.ApplicationUser> IApplicationUser.Get(ApplicationUserSearch search)
        {
            //var list = _ctx.ApplicationUser
            //    .Include(a => a.Opcina)
            //    .ToList();
            var querry = _ctx.ApplicationUser.Include(a => a.Opcina).AsQueryable();
            if(!string.IsNullOrWhiteSpace(search?.Ime))
            {
                querry = querry.Where(x => x.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                querry = querry.Where(x => x.Prezime.StartsWith(search.Prezime));
            }
            var list = querry.ToList();
            return _mapper.Map<List<Models.ApplicationUser.ApplicationUser>>(list);

        }
    }
}
