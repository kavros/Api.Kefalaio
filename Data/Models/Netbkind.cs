using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NETBKINDS")]
    public partial class Netbkind
    {
        [Key]
        [Column("netbPos")]
        public int NetbPos { get; set; }
        [StringLength(39)]
        public string Data { get; set; }
        public int? FileType { get; set; }
        public int? FileOper { get; set; }
        [StringLength(256)]
        public string NetrKinds { get; set; }
        [Column("tmp_1")]
        public int? Tmp1 { get; set; }
        [Column("tmp_2")]
        public int? Tmp2 { get; set; }
        [Column("tmp_3")]
        public int? Tmp3 { get; set; }
        [StringLength(256)]
        public string NetrStatus { get; set; }
    }
}
