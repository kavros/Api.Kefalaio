using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("FEATNAMES")]
    public partial class Featname
    {
        [Key]
        [Column("ftnFileId")]
        public int FtnFileId { get; set; }
        [Column("ftnDescr")]
        [StringLength(15)]
        public string FtnDescr { get; set; }
    }
}
