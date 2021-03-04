using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TreningRS2.Models.Trening
{
    public class TreningModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string SkraceniNaziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
    }
}
