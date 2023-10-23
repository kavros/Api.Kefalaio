using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEPORTFOLIOS")]
    public partial class Neportfolio
    {
        [Key]
        [Column("nepFileId")]
        public int NepFileId { get; set; }
        [Column("nepName")]
        [StringLength(25)]
        public string NepName { get; set; }
    }
}
