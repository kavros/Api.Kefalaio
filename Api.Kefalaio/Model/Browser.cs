using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("BROWSERS")]
    [Index(nameof(BrowFileId), nameof(BrowUserId), Name = "BrowByUser", IsUnique = true)]
    public partial class Browser
    {
        [Key]
        public int BrowserId { get; set; }
        public int? BrowFileId { get; set; }
        public int? BrowUserId { get; set; }
        [Column(TypeName = "text")]
        public string BrowFilters { get; set; }
        [Column(TypeName = "text")]
        public string BrowData { get; set; }
    }
}
