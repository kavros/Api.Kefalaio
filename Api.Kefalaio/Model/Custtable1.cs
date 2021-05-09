using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("CUSTTABLE1")]
    public partial class Custtable1
    {
        [Key]
        public int CuFileIdNo1 { get; set; }
        [StringLength(29)]
        public string CustDesc1 { get; set; }
    }
}
