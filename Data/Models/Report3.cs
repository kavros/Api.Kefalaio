using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("REPORT3")]
    public partial class Report3
    {
        [Key]
        public int Rep3Id { get; set; }
        public int? Rep3FileId { get; set; }
        [StringLength(79)]
        public string Rep3Title { get; set; }
        [Column(TypeName = "text")]
        public string Rep3Rights { get; set; }
        [Column(TypeName = "text")]
        public string Rep3Links { get; set; }
        [Column(TypeName = "text")]
        public string Rep3Filters { get; set; }
        [Column(TypeName = "text")]
        public string Rep3Data { get; set; }
    }
}
