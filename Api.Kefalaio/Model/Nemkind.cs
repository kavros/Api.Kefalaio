using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEMKINDS")]
    public partial class Nemkind
    {
        [Key]
        public int NemKindsId { get; set; }
        [StringLength(29)]
        public string Data { get; set; }
        public int? CashType { get; set; }
        public int? FileType { get; set; }
        public int? FileOper { get; set; }
        public int? Gltrkind { get; set; }
        public int? DebdKind { get; set; }
        public int? CredKind { get; set; }
        [StringLength(15)]
        public string DebCode { get; set; }
        [StringLength(15)]
        public string CredCode { get; set; }
        public short? EmtoTon { get; set; }
        public int? FreeDays { get; set; }
        public double? IntRate { get; set; }
        public int? Trnp1 { get; set; }
        public int? Trnp2 { get; set; }
        public int? Trnp3 { get; set; }
        public int? EtrnKind { get; set; }
    }
}
