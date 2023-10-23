using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SGLGROUP")]
    public partial class Sglgroup
    {
        [Key]
        [Column("sGlPos")]
        public int SGlPos { get; set; }
        [Column("sGlGrDescr")]
        [StringLength(19)]
        public string SGlGrDescr { get; set; }
        [Column("sGlDbCode")]
        [StringLength(15)]
        public string SGlDbCode { get; set; }
        [Column("sGlCrCode")]
        [StringLength(15)]
        public string SGlCrCode { get; set; }
        [Column("sGlImCode")]
        [StringLength(15)]
        public string SGlImCode { get; set; }
        [Column("sGlExCode")]
        [StringLength(15)]
        public string SGlExCode { get; set; }
    }
}
