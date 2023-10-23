using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NMSPEC")]
    [Index(nameof(NspecCode), Name = "nsmByCode", IsUnique = true)]
    [Index(nameof(NspecNameSrt), Name = "nsmByName")]
    [Index(nameof(SFileId), Name = "nsmBysFileId")]
    public partial class Nmspec
    {
        [Key]
        [Column("nspecFileId")]
        public int NspecFileId { get; set; }
        [Required]
        [Column("nspecCode")]
        [StringLength(15)]
        public string NspecCode { get; set; }
        [Column("nspecName")]
        [StringLength(39)]
        public string NspecName { get; set; }
        [Column("nspecName_srt")]
        [StringLength(39)]
        public string NspecNameSrt { get; set; }
        [Column("nspecDate", TypeName = "datetime")]
        public DateTime? NspecDate { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("nspecQuant")]
        public double? NspecQuant { get; set; }
        [Column("nspecFyra")]
        public double? NspecFyra { get; set; }
        [Column("nspecWhours")]
        public double? NspecWhours { get; set; }
        [Column("nspecHcost")]
        public double? NspecHcost { get; set; }
        [Column("nspecSpend")]
        public double? NspecSpend { get; set; }
        [Column("nspecInsdat", TypeName = "datetime")]
        public DateTime? NspecInsdat { get; set; }
        [Column("nspecUserId")]
        public int? NspecUserId { get; set; }
        [Column("nspecComm")]
        [StringLength(37)]
        public string NspecComm { get; set; }
        [Column("nspecEnable")]
        public short? NspecEnable { get; set; }
    }
}
