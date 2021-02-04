using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class Clanarina
    {
        public int Id { get; set; }
        public virtual Polaznik Polaznik { get; set; }
        [ForeignKey(nameof(Polaznik))]
        public int PolaznikId { get; set; }
        public DateTime DatumIsteka { get; set; }
        public virtual Uplata Uplata { get; set; }
        [ForeignKey(nameof(Uplata))]
        public int UplataId { get; set; }
    }
}
