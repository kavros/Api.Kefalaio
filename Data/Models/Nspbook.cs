using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPBOOK")]
    public partial class Nspbook
    {
        [Key]
        [Column("sboFileId")]
        public int SboFileId { get; set; }
        [Column("sboData")]
        [StringLength(256)]
        public string SboData { get; set; }
    }
}
