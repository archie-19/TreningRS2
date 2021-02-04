using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class TestPolaznikTreningInstanca
    {
        public int Id { get; set; }
        public virtual Test Test { get; set; }
        [ForeignKey(nameof(Test))]
        public int TestId { get; set; }
        public virtual PolaznikTreningInstanca PolaznikTreningInstanca { get; set; }
        [ForeignKey(nameof(PolaznikTreningInstanca))]
        public int KlijentKursInstancaId { get; set; }
        public bool Prisustvovao { get; set; }
        public decimal? Bodovi { get; set; }
    }
}
