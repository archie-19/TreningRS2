﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class PolaznikTreningInstanca
    {
        public int Id { get; set; }
        public virtual Polaznik Klijent { get; set; }
        [ForeignKey(nameof(Klijent))]
        public int KlijentId { get; set; }
        public virtual TreningInstanca TreningInstanca { get; set; }
        [ForeignKey(nameof(TreningInstanca))]
        public int TreningInstancaId { get; set; }
        public bool Active { get; set; }
        public bool? UplataIzvrsena { get; set; }
        public bool? Polozen { get; set; }
        public int? Rejting { get; set; }
    }
}
