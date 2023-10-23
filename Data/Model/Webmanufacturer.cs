using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("WEBMANUFACTURER")]
    public partial class Webmanufacturer
    {
        [Key]
        public int WbMfFileId { get; set; }
        [StringLength(63)]
        public string WbMfDescr { get; set; }
        [StringLength(13)]
        public string WbMfLogo { get; set; }
    }
}
