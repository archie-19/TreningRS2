using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eTraining.Database.Entities
{
    public class Polaznik
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [ForeignKey(nameof(ApplicationUser))]
        public int ApplicationUserId { get; set; }
        public virtual List<PolaznikTreningInstanca> TreninziPolaznika{ get; set; }
        public virtual List<Uplata> UplatePolaznika { get; set; }
        public virtual List<Clanarina> ClanarinePolaznika{ get; set; }
    }
}
