using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("GLKFORMS")]
    [Index(nameof(GlfFormType), nameof(GlfPeriod), Name = "glfByType")]
    public partial class Glkform
    {
        [Key]
        [Column("glfId")]
        public int GlfId { get; set; }
        [Column("glfFormType")]
        public int? GlfFormType { get; set; }
        [Column("glfKefFormId")]
        public int? GlfKefFormId { get; set; }
        [Column("glfPeriod")]
        public int? GlfPeriod { get; set; }
        [Column("glfFieldId")]
        public int? GlfFieldId { get; set; }
        [Column("glfFieldDType")]
        public int? GlfFieldDtype { get; set; }
        [Column("glfFieldDescr")]
        [StringLength(255)]
        public string GlfFieldDescr { get; set; }
        [Column("glfFieldValue")]
        [StringLength(255)]
        public string GlfFieldValue { get; set; }
        [Column("glfFormIndex")]
        public int? GlfFormIndex { get; set; }
        [Column("glfFormName")]
        [StringLength(39)]
        public string GlfFormName { get; set; }
        [Column("glfFormCount")]
        public int? GlfFormCount { get; set; }
    }
}
