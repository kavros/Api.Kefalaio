using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("POL1214PARAMS")]
    public partial class Pol1214param
    {
        [Key]
        [Column("polFileId")]
        public int PolFileId { get; set; }
        [Column("polCustInvTransSet", TypeName = "text")]
        public string PolCustInvTransSet { get; set; }
        [Column("polCustCollTransSet", TypeName = "text")]
        public string PolCustCollTransSet { get; set; }
        [Column("polCustGLTrCode")]
        public int? PolCustGltrCode { get; set; }
        [Column("polSuplInvTransSet", TypeName = "text")]
        public string PolSuplInvTransSet { get; set; }
        [Column("polSuplPayTransSet", TypeName = "text")]
        public string PolSuplPayTransSet { get; set; }
        [Column("polSuplGLTrCode")]
        public int? PolSuplGltrCode { get; set; }
    }
}
