using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SHORTCUT")]
    [Index(nameof(DscUserId), nameof(DscDesktopId), nameof(DscRowPos), nameof(DscColPos), Name = "dscByUser", IsUnique = true)]
    [Index(nameof(DscUserId), nameof(DscDesktopId), Name = "dscByUser2")]
    public partial class Shortcut
    {
        [Key]
        [Column("dscFileId")]
        public int DscFileId { get; set; }
        [Column("dscUserId")]
        public int DscUserId { get; set; }
        [Column("dscDesktopId")]
        public int DscDesktopId { get; set; }
        [Column("dscCaption")]
        [StringLength(79)]
        public string DscCaption { get; set; }
        [Column("dscRowPos")]
        public int DscRowPos { get; set; }
        [Column("dscColPos")]
        public int DscColPos { get; set; }
        [Column("dscKernelJob")]
        public int? DscKernelJob { get; set; }
        [Column("dscIncoPath")]
        [StringLength(255)]
        public string DscIncoPath { get; set; }
        [Column("dscType")]
        public int? DscType { get; set; }
        [Column("dscData", TypeName = "text")]
        public string DscData { get; set; }
    }
}
