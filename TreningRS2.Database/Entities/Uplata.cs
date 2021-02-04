using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class Uplata
    {
        public int Id { get; set; }
        public virtual TipUplate TipUplate { get; set; }
        [ForeignKey(nameof(TipUplate))]
        public int TipUplateId { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }
        public virtual Polaznik Polaznik { get; set; }
        [ForeignKey(nameof(Polaznik))]
        public int PolaznikId { get; set; }
        public TreningInstanca TreningInstanca { get; set; }
        [ForeignKey(nameof(TreningInstanca))]
        public int? TreningInstancaId { get; set; }
    }
}
