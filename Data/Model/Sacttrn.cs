using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SACTTRN")]
    [Index(nameof(SatSellActPos), Name = "satBySellAct")]
    [Index(nameof(SatVm1pos), Name = "satByVM1Pos")]
    [Index(nameof(SatVm2pos), Name = "satByVM2Pos")]
    public partial class Sacttrn
    {
        [Key]
        [Column("satFileId")]
        public int SatFileId { get; set; }
        [Column("satSellActPos")]
        public int? SatSellActPos { get; set; }
        [Column("satVM1Pos")]
        public int? SatVm1pos { get; set; }
        [Column("satVM2Pos")]
        public int? SatVm2pos { get; set; }
        [Column("satCtPos")]
        public int? SatCtPos { get; set; }
        [Column("satNelmPos")]
        public int? SatNelmPos { get; set; }
    }
}
