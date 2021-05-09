using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("IRPARAMETERS")]
    public partial class Irparameter
    {
        [Key]
        [Column("IRParamsFileId")]
        public int IrparamsFileId { get; set; }
        [Column("IRParamsData", TypeName = "text")]
        public string IrparamsData { get; set; }
    }
}
