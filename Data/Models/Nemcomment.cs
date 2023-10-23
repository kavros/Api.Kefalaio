using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NEMCOMMENTS")]
    public partial class Nemcomment
    {
        [Key]
        [Column("nmcmFileId")]
        public int NmcmFileId { get; set; }
        [Column("nmcmData")]
        [StringLength(39)]
        public string NmcmData { get; set; }
    }
}
