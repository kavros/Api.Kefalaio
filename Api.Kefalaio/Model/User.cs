using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("USERS")]
    public partial class User
    {
        [Key]
        [Column("usgFileId")]
        public int UsgFileId { get; set; }
        [Column("usgData", TypeName = "text")]
        public string UsgData { get; set; }
    }
}
