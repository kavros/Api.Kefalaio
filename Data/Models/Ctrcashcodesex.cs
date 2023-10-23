using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CTRCASHCODESEX")]
    public partial class Ctrcashcodesex
    {
        [Key]
        [Column("ctcExFileId")]
        public int CtcExFileId { get; set; }
        [Column("ctcExDescr")]
        [StringLength(39)]
        public string CtcExDescr { get; set; }
        [Column("ctcExTrns1")]
        [StringLength(256)]
        public string CtcExTrns1 { get; set; }
        [Column("ctcExTrns2")]
        [StringLength(256)]
        public string CtcExTrns2 { get; set; }
        [Column("ctcExTrns3")]
        [StringLength(256)]
        public string CtcExTrns3 { get; set; }
        [Column("ctcExTrns4")]
        [StringLength(256)]
        public string CtcExTrns4 { get; set; }
    }
}
