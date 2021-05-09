using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SDEPARTMENTS")]
    public partial class Sdepartment
    {
        [Key]
        [Column("sdptFileId")]
        public int SdptFileId { get; set; }
        [Column("sdptData")]
        [StringLength(39)]
        public string SdptData { get; set; }
    }
}
