using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("STRNINV")]
    [Index(nameof(SivSpaceId), nameof(SFileId), nameof(SivScolor), nameof(SivSsize), Name = "sivBySpace")]
    public partial class Strninv
    {
        [Key]
        [Column("sivFileId")]
        public int SivFileId { get; set; }
        [Column("sivSpaceId")]
        public int SivSpaceId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Column("sivQuant1")]
        public double? SivQuant1 { get; set; }
        [Column("sivQuant2")]
        public double? SivQuant2 { get; set; }
        [Column("sivSColor")]
        public int? SivScolor { get; set; }
        [Column("sivSSize")]
        public int? SivSsize { get; set; }

        [ForeignKey(nameof(SFileId))]
        [InverseProperty(nameof(Smast.Strninvs))]
        public virtual Smast SFile { get; set; }
        [ForeignKey(nameof(SivSpaceId))]
        [InverseProperty(nameof(Stockspace.Strninvs))]
        public virtual Stockspace SivSpace { get; set; }
    }
}
