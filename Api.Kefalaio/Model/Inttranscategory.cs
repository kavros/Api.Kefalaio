using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("INTTRANSCATEGORIES")]
    public partial class Inttranscategory
    {
        [Key]
        [Column("intTrnFileId")]
        public int IntTrnFileId { get; set; }
        [Column("intTrnCatId")]
        [StringLength(3)]
        public string IntTrnCatId { get; set; }
        [Column("intTrnCatDescription")]
        [StringLength(39)]
        public string IntTrnCatDescription { get; set; }
        [Column("intTrnColorId")]
        public int? IntTrnColorId { get; set; }
        [Column("intTrncatImage")]
        [StringLength(255)]
        public string IntTrncatImage { get; set; }
        [Column("intTrnPos")]
        public int? IntTrnPos { get; set; }
    }
}
