using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRICELISTSAREA")]
    public partial class Pricelistsarea
    {
        [Key]
        [Column("plaFileId")]
        public int PlaFileId { get; set; }
        [Column("plaAreaDescr")]
        [StringLength(19)]
        public string PlaAreaDescr { get; set; }
    }
}
