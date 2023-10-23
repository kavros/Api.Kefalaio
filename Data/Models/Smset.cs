using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SMSET")]
    [Index(nameof(SmsCode1), nameof(SmsCode2), Name = "smsByCode1", IsUnique = true)]
    [Index(nameof(SmsCode2), nameof(SmsCode1), Name = "smsByCode2", IsUnique = true)]
    public partial class Smset
    {
        [Key]
        [Column("smsFileId")]
        public int SmsFileId { get; set; }
        [Required]
        [Column("smsCode1")]
        [StringLength(25)]
        public string SmsCode1 { get; set; }
        [Required]
        [Column("smsCode2")]
        [StringLength(25)]
        public string SmsCode2 { get; set; }
        [Column("smsFQuant")]
        public double? SmsFquant { get; set; }
        [Column("smsQuant")]
        public double? SmsQuant { get; set; }
        [Column("smsQuant2")]
        public double? SmsQuant2 { get; set; }
    }
}
