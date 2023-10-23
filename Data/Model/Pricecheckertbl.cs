using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRICECHECKERTBL")]
    public partial class Pricecheckertbl
    {
        [Key]
        [Column("pckFileId")]
        public int PckFileId { get; set; }
        [Column("pckDriver")]
        [StringLength(20)]
        public string PckDriver { get; set; }
        [Column("pckDescription")]
        [StringLength(20)]
        public string PckDescription { get; set; }
        [Column("pckSearchCode")]
        public int? PckSearchCode { get; set; }
        [Column("pckAdditionalSearchCode")]
        public short? PckAdditionalSearchCode { get; set; }
        [Column("pckSearchCustomerPriceFlag")]
        public short? PckSearchCustomerPriceFlag { get; set; }
        [Column("pckLines1")]
        [StringLength(40)]
        public string PckLines1 { get; set; }
        [Column("pckLines2")]
        [StringLength(40)]
        public string PckLines2 { get; set; }
        [Column("pckLines3")]
        [StringLength(40)]
        public string PckLines3 { get; set; }
        [Column("pckLines4")]
        [StringLength(40)]
        public string PckLines4 { get; set; }
        [Column("pckLines5")]
        [StringLength(40)]
        public string PckLines5 { get; set; }
        [Column("pckAlterDescript")]
        public short? PckAlterDescript { get; set; }
        [Column("pckAlterDescSelec")]
        public int? PckAlterDescSelec { get; set; }
        public int? DefaultPrice { get; set; }
    }
}
