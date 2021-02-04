using eTraining.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreningRS2.Models.ApplicationUser
{
    
        public class ApplicationUser
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Opcina { get; set; }
        public int OpcinaId { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public bool Active { get; set; }
        public byte[] Slika { get; set; }

    }
}
