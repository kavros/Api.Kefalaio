using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("VGLINFO")]
    public partial class Vglinfo
    {
        [Key]
        [Column("vgliFileId")]
        public int VgliFileId { get; set; }
        [Column("vgliOrder1")]
        public int? VgliOrder1 { get; set; }
        [Column("vgliOrder2")]
        public int? VgliOrder2 { get; set; }
        [Column("vgliOrder3")]
        public int? VgliOrder3 { get; set; }
        [Column("vgliOrder4")]
        public int? VgliOrder4 { get; set; }
        [Column("vgliOrder5")]
        public int? VgliOrder5 { get; set; }
        [Column("vgliOrder6")]
        public int? VgliOrder6 { get; set; }
        [Column("vgliOrder7")]
        public int? VgliOrder7 { get; set; }
        [Column("vgliOrder8")]
        public int? VgliOrder8 { get; set; }
        [Column("vgliOrder9")]
        public int? VgliOrder9 { get; set; }
        [Column("vgliOrder10")]
        public int? VgliOrder10 { get; set; }
        [Column("vgliNoVATCode")]
        [StringLength(15)]
        public string VgliNoVatcode { get; set; }
        [Column("vgliEFKCode")]
        [StringLength(15)]
        public string VgliEfkcode { get; set; }
    }
}
