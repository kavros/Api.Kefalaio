using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTTABLE2")]
    public partial class Custtable2
    {
        [Key]
        public int CuFileIdNo2 { get; set; }
        [StringLength(29)]
        public string CustDesc2 { get; set; }
    }
}
