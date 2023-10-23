using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MODEM")]
    public partial class Modem
    {
        [Key]
        [Column("mdmFileId")]
        public int MdmFileId { get; set; }
        [Column("mdmDescr")]
        [StringLength(39)]
        public string MdmDescr { get; set; }
        [Column("mdmModem")]
        public int? MdmModem { get; set; }
        [Column("mdmPhone1")]
        [StringLength(20)]
        public string MdmPhone1 { get; set; }
        [Column("mdmRepeat1")]
        public int? MdmRepeat1 { get; set; }
        [Column("mdmPhone2")]
        [StringLength(20)]
        public string MdmPhone2 { get; set; }
        [Column("mdmRepeat2")]
        public int? MdmRepeat2 { get; set; }
        [Column("mdmPhone3")]
        [StringLength(20)]
        public string MdmPhone3 { get; set; }
        [Column("mdmRepeat3")]
        public int? MdmRepeat3 { get; set; }
        [Column("mdmSplit")]
        public short? MdmSplit { get; set; }
        [Column("mdmCincular")]
        public int? MdmCincular { get; set; }
        [Column("mdmPack")]
        public short? MdmPack { get; set; }
        [Column("mdmDelay")]
        public int? MdmDelay { get; set; }
        [Column("mdmFileDescr")]
        [StringLength(80)]
        public string MdmFileDescr { get; set; }
    }
}
