using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SERIAL")]
    [Index(nameof(SnSerialC), Name = "snBySerialC")]
    [Index(nameof(SFileId), nameof(SnSerialC), Name = "snBySm", IsUnique = true)]
    public partial class Serial
    {
        public Serial()
        {
            Extexts = new HashSet<Extext>();
        }

        [Key]
        [Column("snFileId")]
        public int SnFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        [Required]
        [Column("snSerialC")]
        [StringLength(25)]
        public string SnSerialC { get; set; }
        [Column("snDate1", TypeName = "datetime")]
        public DateTime? SnDate1 { get; set; }
        [Column("snInvoice1")]
        [StringLength(9)]
        public string SnInvoice1 { get; set; }
        [Column("snTrKind1")]
        public int? SnTrKind1 { get; set; }
        [Column("snPersCode1")]
        [StringLength(15)]
        public string SnPersCode1 { get; set; }
        [Column("snPersName1")]
        [StringLength(39)]
        public string SnPersName1 { get; set; }
        [Column("snSpace1")]
        public int? SnSpace1 { get; set; }
        [Column("snDate2", TypeName = "datetime")]
        public DateTime? SnDate2 { get; set; }
        [Column("snInvoice2")]
        [StringLength(9)]
        public string SnInvoice2 { get; set; }
        [Column("snTrKind2")]
        public int? SnTrKind2 { get; set; }
        [Column("snPersCode2")]
        [StringLength(15)]
        public string SnPersCode2 { get; set; }
        [Column("snPersName2")]
        [StringLength(39)]
        public string SnPersName2 { get; set; }
        [Column("snSpace2")]
        public int? SnSpace2 { get; set; }
        [Column("snDate3", TypeName = "datetime")]
        public DateTime? SnDate3 { get; set; }
        [Column("snInvoice3")]
        [StringLength(9)]
        public string SnInvoice3 { get; set; }
        [Column("snTrKind3")]
        public int? SnTrKind3 { get; set; }
        [Column("snPersCode3")]
        [StringLength(15)]
        public string SnPersCode3 { get; set; }
        [Column("snPersName3")]
        [StringLength(39)]
        public string SnPersName3 { get; set; }
        [Column("snSpace3")]
        public int? SnSpace3 { get; set; }
        [Column("snComment")]
        [StringLength(39)]
        public string SnComment { get; set; }
        [Column("snTextHandle")]
        public int? SnTextHandle { get; set; }

        [InverseProperty(nameof(Extext.SnFile))]
        public virtual ICollection<Extext> Extexts { get; set; }
    }
}
