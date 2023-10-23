using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NSPALCODE")]
    public partial class Nspalcode
    {
        [Key]
        [Column("sacFileId")]
        public int SacFileId { get; set; }
        [Column("sacMaterAcc")]
        [StringLength(25)]
        public string SacMaterAcc { get; set; }
        [Column("sacLaborAcc")]
        [StringLength(25)]
        public string SacLaborAcc { get; set; }
        [Column("sacOtherAcc")]
        [StringLength(25)]
        public string SacOtherAcc { get; set; }
    }
}
