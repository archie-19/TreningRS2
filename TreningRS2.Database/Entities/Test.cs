using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public virtual TreningInstanca TreningInstanca { get; set; }
        [ForeignKey(nameof(TreningInstanca))]
        public int TreningInstancaId { get; set; }
        public DateTime DatumVrijemeIspita { get; set; }
        public string Lokacija { get; set; }
        public virtual List<TestPolaznikTreningInstanca> PolazniciNaTestu{ get; set; }
    }
}
