using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class Termin
    {
        public int Id { get; set; }
        public virtual TreningInstanca TreningInstanca { get; set; }
        [ForeignKey(nameof(TreningInstanca))]
        public int TreningInstancaId { get; set; }
        public DateTime DatumVrijemeOdrzavanja { get; set; }
        public string Lokacija { get; set; }
        public string Opis { get; set; }
        public bool Odrzan { get; set; }
    }
}
