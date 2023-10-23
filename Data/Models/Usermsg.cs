using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("USERMSG")]
    public partial class Usermsg
    {
        [Key]
        [Column("umsFileId")]
        public int UmsFileId { get; set; }
        [Column("umsData")]
        [StringLength(30)]
        public string UmsData { get; set; }
    }
}
