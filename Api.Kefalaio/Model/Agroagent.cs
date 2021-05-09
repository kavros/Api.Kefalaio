using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("AGROAGENTS")]
    public partial class Agroagent
    {
        [Key]
        [Column("agFileId")]
        public int AgFileId { get; set; }
        [Column("agAgentName")]
        [StringLength(29)]
        public string AgAgentName { get; set; }
    }
}
