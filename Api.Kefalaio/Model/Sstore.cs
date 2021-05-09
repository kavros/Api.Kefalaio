using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SSTORE")]
    [Index(nameof(SFileId), nameof(SpaFileIdNo), Name = "sstBysFileId", IsUnique = true)]
    public partial class Sstore
    {
        [Key]
        [Column("sstFileId")]
        public int SstFileId { get; set; }
        [Column("sFileId")]
        public int SFileId { get; set; }
        public int SpaFileIdNo { get; set; }
        [Column("sstRemain1")]
        public double? SstRemain1 { get; set; }
        [Column("sstRemain2")]
        public double? SstRemain2 { get; set; }
        [Column("sstApogr1")]
        public double? SstApogr1 { get; set; }
        [Column("sstApogr2")]
        public double? SstApogr2 { get; set; }
        [Column("sstWaiting1")]
        public double? SstWaiting1 { get; set; }
        [Column("sstWaiting2")]
        public double? SstWaiting2 { get; set; }
        [Column("sstOrdered1")]
        public double? SstOrdered1 { get; set; }
        [Column("sstOrdered2")]
        public double? SstOrdered2 { get; set; }
    }
}
