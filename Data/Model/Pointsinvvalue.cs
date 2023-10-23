using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("POINTSINVVALUES")]
    public partial class Pointsinvvalue
    {
        [Key]
        [Column("pivFileId")]
        public int PivFileId { get; set; }
        [Column("pivInvoiceValue")]
        public double? PivInvoiceValue { get; set; }
        [Column("pivPoints")]
        public int? PivPoints { get; set; }
    }
}
