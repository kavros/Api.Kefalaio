using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FYTAPRESCRIBERS")]
    [Index(nameof(PreCode), Name = "preByCode", IsUnique = true)]
    public partial class Fytaprescriber
    {
        [Key]
        [Column("preFileId")]
        public int PreFileId { get; set; }
        [Required]
        [Column("preCode")]
        [StringLength(5)]
        public string PreCode { get; set; }
        [Column("preUsername")]
        [StringLength(15)]
        public string PreUsername { get; set; }
        [Column("preVATNo")]
        [StringLength(9)]
        public string PreVatno { get; set; }
        [Column("preDescr")]
        [StringLength(39)]
        public string PreDescr { get; set; }
        [Column("preAM")]
        [StringLength(15)]
        public string PreAm { get; set; }
        [Column("preActive")]
        public short? PreActive { get; set; }
    }
}
