using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("LEDGERINFO")]
    public partial class Ledgerinfo
    {
        [Key]
        [Column("lgiFileId")]
        public int LgiFileId { get; set; }
        [Column("lgiEdDate", TypeName = "datetime")]
        public DateTime? LgiEdDate { get; set; }
        [Column("lgiPrevDate", TypeName = "datetime")]
        public DateTime? LgiPrevDate { get; set; }
        [Column("lgiSothDate", TypeName = "datetime")]
        public DateTime? LgiSothDate { get; set; }
        [Column("lgiQothDate", TypeName = "datetime")]
        public DateTime? LgiQothDate { get; set; }
        [Column("lgiVothDate", TypeName = "datetime")]
        public DateTime? LgiVothDate { get; set; }
        [Column("lgiCothDate", TypeName = "datetime")]
        public DateTime? LgiCothDate { get; set; }
        [Column("lgiPothDate", TypeName = "datetime")]
        public DateTime? LgiPothDate { get; set; }
        [Column("lgiV1othDate", TypeName = "datetime")]
        public DateTime? LgiV1othDate { get; set; }
        [Column("lgiB1othDate", TypeName = "datetime")]
        public DateTime? LgiB1othDate { get; set; }
    }
}
