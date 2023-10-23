using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PDFPARAMS")]
    public partial class Pdfparam
    {
        [Key]
        [Column("pdfFileId")]
        public int PdfFileId { get; set; }
        [Column("pdfData", TypeName = "text")]
        public string PdfData { get; set; }
    }
}
