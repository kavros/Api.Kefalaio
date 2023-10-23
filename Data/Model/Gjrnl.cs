using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GJRNLS")]
    public partial class Gjrnl
    {
        [Key]
        [Column("gjrFileId")]
        public int GjrFileId { get; set; }
        [Column("gjrName")]
        [StringLength(39)]
        public string GjrName { get; set; }
        [Column("gjrIsAnl")]
        public short? GjrIsAnl { get; set; }
    }
}
