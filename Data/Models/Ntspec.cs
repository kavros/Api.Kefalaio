using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NTSPEC")]
    [Index(nameof(NstMpos), nameof(NstLno), Name = "nstByMPos", IsUnique = true)]
    [Index(nameof(SFileId), nameof(NstMpos), Name = "nstBysFileId")]
    public partial class Ntspec
    {
        [Key]
        [Column("nstFileId")]
        public int NstFileId { get; set; }
        [Column("nstMPos")]
        public int NstMpos { get; set; }
        [Column("nstLNo")]
        public int NstLno { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("nstQuant")]
        public double? NstQuant { get; set; }
        [Column("nstFyra")]
        public double? NstFyra { get; set; }
        [Column("nstYpop")]
        public short? NstYpop { get; set; }
    }
}
