using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SUPPLTABLE3")]
    public partial class Suppltable3
    {
        [Key]
        public int SuFileIdNo3 { get; set; }
        [StringLength(29)]
        public string SuppllDesc3 { get; set; }
    }
}
