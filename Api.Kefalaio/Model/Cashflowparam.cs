using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CASHFLOWPARAMS")]
    public partial class Cashflowparam
    {
        [Key]
        [Column("cfgFileId")]
        public int CfgFileId { get; set; }
        [Column("cfgCode11")]
        [StringLength(15)]
        public string CfgCode11 { get; set; }
        [Column("cfgCode21")]
        [StringLength(15)]
        public string CfgCode21 { get; set; }
        [Column("cfgComm1")]
        [StringLength(39)]
        public string CfgComm1 { get; set; }
        [Column("cfgAct1")]
        [StringLength(1)]
        public string CfgAct1 { get; set; }
        [Column("cfgCode12")]
        [StringLength(15)]
        public string CfgCode12 { get; set; }
        [Column("cfgCode22")]
        [StringLength(15)]
        public string CfgCode22 { get; set; }
        [Column("cfgComm2")]
        [StringLength(39)]
        public string CfgComm2 { get; set; }
        [Column("cfgAct2")]
        [StringLength(1)]
        public string CfgAct2 { get; set; }
        [Column("cfgCode13")]
        [StringLength(15)]
        public string CfgCode13 { get; set; }
        [Column("cfgCode23")]
        [StringLength(15)]
        public string CfgCode23 { get; set; }
        [Column("cfgComm3")]
        [StringLength(39)]
        public string CfgComm3 { get; set; }
        [Column("cfgAct3")]
        [StringLength(1)]
        public string CfgAct3 { get; set; }
        [Column("cfgCode14")]
        [StringLength(15)]
        public string CfgCode14 { get; set; }
        [Column("cfgCode24")]
        [StringLength(15)]
        public string CfgCode24 { get; set; }
        [Column("cfgComm4")]
        [StringLength(39)]
        public string CfgComm4 { get; set; }
        [Column("cfgAct4")]
        [StringLength(1)]
        public string CfgAct4 { get; set; }
        [Column("cfgCode15")]
        [StringLength(15)]
        public string CfgCode15 { get; set; }
        [Column("cfgCode25")]
        [StringLength(15)]
        public string CfgCode25 { get; set; }
        [Column("cfgComm5")]
        [StringLength(39)]
        public string CfgComm5 { get; set; }
        [Column("cfgAct5")]
        [StringLength(1)]
        public string CfgAct5 { get; set; }
        [Column("cfgCode16")]
        [StringLength(15)]
        public string CfgCode16 { get; set; }
        [Column("cfgCode26")]
        [StringLength(15)]
        public string CfgCode26 { get; set; }
        [Column("cfgComm6")]
        [StringLength(39)]
        public string CfgComm6 { get; set; }
        [Column("cfgAct6")]
        [StringLength(1)]
        public string CfgAct6 { get; set; }
        [Column("cfgCode17")]
        [StringLength(15)]
        public string CfgCode17 { get; set; }
        [Column("cfgCode27")]
        [StringLength(15)]
        public string CfgCode27 { get; set; }
        [Column("cfgComm7")]
        [StringLength(39)]
        public string CfgComm7 { get; set; }
        [Column("cfgAct7")]
        [StringLength(1)]
        public string CfgAct7 { get; set; }
    }
}
