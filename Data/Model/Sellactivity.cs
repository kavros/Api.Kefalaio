using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SELLACTIVITY")]
    public partial class Sellactivity
    {
        [Key]
        [Column("sellActId")]
        public int SellActId { get; set; }
        [Column("sellActDescr")]
        [StringLength(25)]
        public string SellActDescr { get; set; }
    }
}
