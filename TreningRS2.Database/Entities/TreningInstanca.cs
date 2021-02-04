using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class TreningInstanca
    {
        public int Id { get; set; }
        public virtual Trening Trening { get; set; }
        [ForeignKey(nameof(Trening))]
        public int TreningId { get; set; }
        public DateTime PocetakDatum { get; set; }
        public DateTime PrijaveDoDatum { get; set; }
        public DateTime? KrajDatum { get; set; }
        public int? Kapacitet { get; set; }
        public decimal? Cijena { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
        [ForeignKey(nameof(Uposlenik))]
        public int UposlenikId { get; set; }
        public int BrojCasova { get; set; }
        public virtual List<Termin> Termini { get; set; }
        public virtual List<PolaznikTreningInstanca> PolazniciNaTreningu{ get; set; }
    }
}
