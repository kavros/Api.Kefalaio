using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLREFORMCATEGS")]
    [Index(nameof(RfCode), Name = "rfByCode", IsUnique = true)]
    public partial class Glreformcateg
    {
        [Key]
        [Column("rfId")]
        public int RfId { get; set; }
        [Required]
        [Column("rfCode")]
        [StringLength(3)]
        public string RfCode { get; set; }
        [Required]
        [Column("rfDescr")]
        [StringLength(39)]
        public string RfDescr { get; set; }
        [Column("rfGroup")]
        public int RfGroup { get; set; }
        [Column("rfFactor")]
        public double? RfFactor { get; set; }
        [Column("rfWorkers")]
        public int? RfWorkers { get; set; }
        [Column("rfMobiles")]
        public int? RfMobiles { get; set; }
        [Column("rfDebGLCode")]
        [StringLength(25)]
        public string RfDebGlcode { get; set; }
        [Column("rfCredGLCode")]
        [StringLength(25)]
        public string RfCredGlcode { get; set; }
        [Column("rfPermanent")]
        public short? RfPermanent { get; set; }
        [Column("rfTaxDiffGLCode")]
        [StringLength(25)]
        public string RfTaxDiffGlcode { get; set; }
    }
}
