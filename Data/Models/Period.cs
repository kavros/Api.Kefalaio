using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PERIODS")]
    public partial class Period
    {
        [Key]
        public int PerFileIdNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrvDateSta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrvDateEnd { get; set; }
        [StringLength(13)]
        public string DescPeriod { get; set; }
    }
}
