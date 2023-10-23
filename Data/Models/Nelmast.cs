using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("NELMAST")]
    [Index(nameof(NlmDate), nameof(NlmDoc), Name = "nlmByDate", IsUnique = true)]
    [Index(nameof(NlmDoc), nameof(NlmDate), Name = "nlmByDoc", IsUnique = true)]
    public partial class Nelmast
    {
        [Key]
        [Column("nlmFileId")]
        public int NlmFileId { get; set; }
        [Column("nlmDate", TypeName = "datetime")]
        public DateTime NlmDate { get; set; }
        [Required]
        [Column("nlmDoc")]
        [StringLength(9)]
        public string NlmDoc { get; set; }
        [Column("nlmKind")]
        public int? NlmKind { get; set; }
        [Column("nlmTrNumsId")]
        public int? NlmTrNumsId { get; set; }
        [Column("nlmFlags1")]
        public int? NlmFlags1 { get; set; }
        [Column("nlmFlags2")]
        public int? NlmFlags2 { get; set; }
        [Column("nlmFlags3")]
        public int? NlmFlags3 { get; set; }
        [Column("nlmFlags4")]
        public int? NlmFlags4 { get; set; }
        [Column("nlmShop")]
        [StringLength(5)]
        public string NlmShop { get; set; }

        [ForeignKey(nameof(NlmTrNumsId))]
        [InverseProperty(nameof(Trnum.Nelmasts))]
        public virtual Trnum NlmTrNums { get; set; }
    }
}
