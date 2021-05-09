using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRODUCTIONSTATE")]
    public partial class Productionstate
    {
        [Key]
        [Column("prstFileId")]
        public int PrstFileId { get; set; }
        [Column("prstName")]
        [StringLength(17)]
        public string PrstName { get; set; }
        [Column("prstNo1")]
        public int? PrstNo1 { get; set; }
        [Column("prstNo2")]
        public int? PrstNo2 { get; set; }
    }
}
