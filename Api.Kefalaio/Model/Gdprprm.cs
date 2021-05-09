using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GDPRPRMS")]
    public partial class Gdprprm
    {
        [Key]
        [Column("gdpFileId")]
        public int GdpFileId { get; set; }
        [Column("gdpActive")]
        public short? GdpActive { get; set; }
        [Column("gdpUsers", TypeName = "text")]
        public string GdpUsers { get; set; }
        [Column("gdpFields", TypeName = "text")]
        public string GdpFields { get; set; }
        [Column("gdpJobs", TypeName = "text")]
        public string GdpJobs { get; set; }
    }
}
