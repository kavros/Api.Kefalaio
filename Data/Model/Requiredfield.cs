using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("REQUIREDFIELDS")]
    public partial class Requiredfield
    {
        [Key]
        public int RqdFileId { get; set; }
        [Column(TypeName = "text")]
        public string RqdData { get; set; }
    }
}
