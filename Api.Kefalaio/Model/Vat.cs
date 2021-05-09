using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VAT")]
    [Index(nameof(FpaCode), Name = "VATByCode", IsUnique = true)]
    public partial class Vat
    {
        public Vat()
        {
            Strns = new HashSet<Strn>();
        }

        [Key]
        public int FpaId { get; set; }
        [Required]
        [StringLength(3)]
        public string FpaCode { get; set; }
        public double? FpaData { get; set; }
        public int? FpaFiler { get; set; }
        public int? FpaFile { get; set; }

        [InverseProperty(nameof(Strn.StVat))]
        public virtual ICollection<Strn> Strns { get; set; }
    }
}
