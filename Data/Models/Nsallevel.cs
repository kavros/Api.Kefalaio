using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSALLEVEL")]
    public partial class Nsallevel
    {
        [Key]
        [Column("slvFileId")]
        public int SlvFileId { get; set; }
        [Column("slvDescr")]
        [StringLength(39)]
        public string SlvDescr { get; set; }
    }
}
