using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NETRKINDS")]
    public partial class Netrkind
    {
        [Key]
        public int NeTrKindsId { get; set; }
        [StringLength(29)]
        public string Data { get; set; }
        public int? FileType { get; set; }
        public int? FileOper { get; set; }
        public int? SetTrKind { get; set; }
        public int? TrState { get; set; }
        public int? Gltrkind { get; set; }
        public int? DebKind { get; set; }
        public int? CredKind { get; set; }
        [StringLength(25)]
        public string DebCode { get; set; }
        [StringLength(25)]
        public string CredCode { get; set; }
        public short? EtrToton { get; set; }
        public int? Minusbal { get; set; }
        public int? GlInsVoucher { get; set; }
        public int? FilByte { get; set; }
    }
}
