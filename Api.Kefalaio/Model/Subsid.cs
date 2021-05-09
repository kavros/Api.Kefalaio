using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUBSIDS")]
    public partial class Subsid
    {
        [Key]
        public int SubFileIdNo { get; set; }
        [StringLength(25)]
        public string SubName { get; set; }
        public int? SubSpace { get; set; }
        [StringLength(15)]
        public string SubRtlCustCode { get; set; }
        [Column("SubsVDef1")]
        [StringLength(3)]
        public string SubsVdef1 { get; set; }
        [Column("SubsRDef")]
        [StringLength(3)]
        public string SubsRdef { get; set; }
        [Column("SubsVDef2")]
        [StringLength(3)]
        public string SubsVdef2 { get; set; }
        [StringLength(15)]
        public string SubsMinagricShop { get; set; }
        [StringLength(15)]
        public string SubsMinagricUser { get; set; }
    }
}
