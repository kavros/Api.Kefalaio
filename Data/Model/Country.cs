using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("COUNTRY")]
    [Index(nameof(CountryCo), Name = "CountryByCode", IsUnique = true)]
    [Index(nameof(CountEok), Name = "CountryByEokCode")]
    public partial class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [StringLength(3)]
        public string CountryCo { get; set; }
        [StringLength(19)]
        public string CountName { get; set; }
        [StringLength(3)]
        public string CountEok { get; set; }
    }
}
