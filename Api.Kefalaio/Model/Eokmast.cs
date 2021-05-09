using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("EOKMAST")]
    public partial class Eokmast
    {
        [Key]
        [Column("eokFileId")]
        public int EokFileId { get; set; }
        [Column("eokCode")]
        [StringLength(15)]
        public string EokCode { get; set; }
        [Column("eokName1")]
        [StringLength(39)]
        public string EokName1 { get; set; }
        [Column("eokName2")]
        [StringLength(39)]
        public string EokName2 { get; set; }
        [Column("eokName3")]
        [StringLength(39)]
        public string EokName3 { get; set; }
        [Column("eokName4")]
        [StringLength(39)]
        public string EokName4 { get; set; }
        [Column("eokMM")]
        [StringLength(15)]
        public string EokMm { get; set; }
    }
}
