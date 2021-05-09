using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPPLTABLE1")]
    public partial class Suppltable1
    {
        [Key]
        public int SuFileIdNo1 { get; set; }
        [StringLength(29)]
        public string SuppllDesc1 { get; set; }
    }
}
