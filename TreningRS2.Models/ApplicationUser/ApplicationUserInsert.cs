using eTraining.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TreningRS2.Models.ApplicationUser
{
    public class ApplicationUserInsert
    {
        [MinLength(4, ErrorMessage = "Username mora imati najmanje 4 karaktera.")]
        public string Username { get; set; }
        [EmailAddress(ErrorMessage = "Email nije ispravan")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        [Required]
        public int OpcinaId { get; set; }

        //public List<OpcineModel> Opcine { get; set; }
        [MinLength(13, ErrorMessage = "Neispravan JMBG.")]
        public string JMBG { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Spol { get; set; }
        public virtual string Password { get; set; }
        public virtual string PasswordConfirm { get; set; }
        public byte[] Slika { get; set; }
    }

    public class OpcineModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
