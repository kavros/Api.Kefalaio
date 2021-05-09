using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BANKS")]
    public partial class Bank
    {
        [Key]
        public int BanFileIdNo { get; set; }
        [StringLength(19)]
        public string BankDescr { get; set; }
        [Column("BankGLCod")]
        [StringLength(25)]
        public string BankGlcod { get; set; }
    }
}
