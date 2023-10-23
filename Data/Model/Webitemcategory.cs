using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("WEBITEMCATEGORY")]
    public partial class Webitemcategory
    {
        [Key]
        public int WbIcFileId { get; set; }
        [StringLength(31)]
        public string WbIcDescr { get; set; }
        [StringLength(31)]
        public string WbIcEnDescr { get; set; }
        [StringLength(13)]
        public string WbIcLogo { get; set; }
        public int? WbIcParent { get; set; }
    }
}
