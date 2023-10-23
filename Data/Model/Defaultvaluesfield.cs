using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("DEFAULTVALUESFIELDS")]
    public partial class Defaultvaluesfield
    {
        [Key]
        public int DfvFileId { get; set; }
        [Column(TypeName = "text")]
        public string DfvData { get; set; }
    }
}
