using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CURRENTABLE")]
    [Index(nameof(XnCode), Name = "xnByCode", IsUnique = true)]
    public partial class Currentable
    {
        [Key]
        [Column("xnCurrenId")]
        public int XnCurrenId { get; set; }
        [Required]
        [Column("xnCode")]
        [StringLength(3)]
        public string XnCode { get; set; }
        [Column("xnDescr")]
        [StringLength(19)]
        public string XnDescr { get; set; }
        [Column("xnDecimal")]
        public int? XnDecimal { get; set; }
        [Column("xnLName")]
        [StringLength(3)]
        public string XnLname { get; set; }
        [Column("xnLRate")]
        public double? XnLrate { get; set; }
        [Column("xnISOCode")]
        [StringLength(3)]
        public string XnIsocode { get; set; }
    }
}
