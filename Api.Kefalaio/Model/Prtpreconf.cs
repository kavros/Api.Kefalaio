using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRTPRECONF")]
    public partial class Prtpreconf
    {
        [Key]
        [Column("prcFileId")]
        public int PrcFileId { get; set; }
        [Column("descr")]
        [StringLength(25)]
        public string Descr { get; set; }
        [Column("kind")]
        public int? Kind { get; set; }
        [Column("do_title")]
        public short? DoTitle { get; set; }
        [Column("do_date")]
        public short? DoDate { get; set; }
        [Column("do_page")]
        public short? DoPage { get; set; }
        [Column("do_headers")]
        public short? DoHeaders { get; set; }
        [Column("do_flip")]
        public short? DoFlip { get; set; }
        [Column("do_comp")]
        public short? DoComp { get; set; }
        [Column("do_vcomp")]
        public short? DoVcomp { get; set; }
        [Column("do_bold")]
        public short? DoBold { get; set; }
        [Column("lins")]
        public int? Lins { get; set; }
        [Column("spc")]
        public int? Spc { get; set; }
        [Column("do_company")]
        public short? DoCompany { get; set; }
    }
}
