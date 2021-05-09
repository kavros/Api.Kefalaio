using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LNLEDGER")]
    public partial class Lnledger
    {
        [Key]
        [Column("lglFileId")]
        public int LglFileId { get; set; }
        [Column("lglName")]
        [StringLength(39)]
        public string LglName { get; set; }
        [Column("lglTrns")]
        [StringLength(256)]
        public string LglTrns { get; set; }
    }
}
