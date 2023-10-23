using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("MYFMONTH")]
    [Index(nameof(MyfYear), nameof(MyfMonth1), nameof(MyfFileType), Name = "myfByYearMonthType", IsUnique = true)]
    public partial class Myfmonth
    {
        [Key]
        [Column("myfFileId")]
        public int MyfFileId { get; set; }
        [Column("myfFileType")]
        public int MyfFileType { get; set; }
        [Column("myfYear")]
        public int MyfYear { get; set; }
        [Column("myfMonth")]
        public int MyfMonth1 { get; set; }
        [Column("myfUploadID")]
        public int? MyfUploadId { get; set; }
        [Column("myfCreatedUserID")]
        public int MyfCreatedUserId { get; set; }
        [Column("myfCreatedDate", TypeName = "datetime")]
        public DateTime MyfCreatedDate { get; set; }
        [Column("myfLastModifyUserID")]
        public int MyfLastModifyUserId { get; set; }
        [Column("myfLastModifyDate", TypeName = "datetime")]
        public DateTime MyfLastModifyDate { get; set; }
        [Column("myfUploadUserID")]
        public int? MyfUploadUserId { get; set; }
        [Column("myfUploadDate", TypeName = "datetime")]
        public DateTime? MyfUploadDate { get; set; }
        [Column("myfUploadStatus")]
        public int? MyfUploadStatus { get; set; }
    }
}
