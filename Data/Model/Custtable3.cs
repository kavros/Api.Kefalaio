using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTTABLE3")]
    public partial class Custtable3
    {
        [Key]
        public int CuFileIdNo3 { get; set; }
        [StringLength(29)]
        public string CustDesc3 { get; set; }
    }
}
