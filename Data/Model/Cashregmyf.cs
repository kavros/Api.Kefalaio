using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CASHREGMYF")]
    public partial class Cashregmyf
    {
        [Key]
        [Column("crFileId")]
        public int CrFileId { get; set; }
        [Column("crDescr")]
        [StringLength(19)]
        public string CrDescr { get; set; }
        [Column("crTaxCode")]
        [StringLength(39)]
        public string CrTaxCode { get; set; }
    }
}
