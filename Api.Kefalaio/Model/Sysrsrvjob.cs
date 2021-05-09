using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SYSRSRVJOBS")]
    public partial class Sysrsrvjob
    {
        [Key]
        [Column("srjFileid")]
        public int SrjFileid { get; set; }
        [Column("srjData", TypeName = "text")]
        public string SrjData { get; set; }
    }
}
