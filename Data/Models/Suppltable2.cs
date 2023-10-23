using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPPLTABLE2")]
    public partial class Suppltable2
    {
        [Key]
        public int SuFileIdNo2 { get; set; }
        [StringLength(29)]
        public string SuppllDesc2 { get; set; }
    }
}
