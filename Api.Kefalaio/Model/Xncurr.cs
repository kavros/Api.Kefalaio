using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("XNCURR")]
    [Index(nameof(CrDate), Name = "crByDate", IsUnique = true)]
    public partial class Xncurr
    {
        [Key]
        [Column("crFileId")]
        public int CrFileId { get; set; }
        [Column("crDate", TypeName = "datetime")]
        public DateTime CrDate { get; set; }
        [Column("crCurr1")]
        public double? CrCurr1 { get; set; }
        [Column("crVatDate1", TypeName = "datetime")]
        public DateTime? CrVatDate1 { get; set; }
        [Column("crVat1")]
        public double? CrVat1 { get; set; }
        [Column("crCurr2")]
        public double? CrCurr2 { get; set; }
        [Column("crVatDate2", TypeName = "datetime")]
        public DateTime? CrVatDate2 { get; set; }
        [Column("crVat2")]
        public double? CrVat2 { get; set; }
        [Column("crCurr3")]
        public double? CrCurr3 { get; set; }
        [Column("crVatDate3", TypeName = "datetime")]
        public DateTime? CrVatDate3 { get; set; }
        [Column("crVat3")]
        public double? CrVat3 { get; set; }
        [Column("crCurr4")]
        public double? CrCurr4 { get; set; }
        [Column("crVatDate4", TypeName = "datetime")]
        public DateTime? CrVatDate4 { get; set; }
        [Column("crVat4")]
        public double? CrVat4 { get; set; }
        [Column("crCurr5")]
        public double? CrCurr5 { get; set; }
        [Column("crVatDate5", TypeName = "datetime")]
        public DateTime? CrVatDate5 { get; set; }
        [Column("crVat5")]
        public double? CrVat5 { get; set; }
        [Column("crCurr6")]
        public double? CrCurr6 { get; set; }
        [Column("crVatDate6", TypeName = "datetime")]
        public DateTime? CrVatDate6 { get; set; }
        [Column("crVat6")]
        public double? CrVat6 { get; set; }
        [Column("crCurr7")]
        public double? CrCurr7 { get; set; }
        [Column("crVatDate7", TypeName = "datetime")]
        public DateTime? CrVatDate7 { get; set; }
        [Column("crVat7")]
        public double? CrVat7 { get; set; }
        [Column("crCurr8")]
        public double? CrCurr8 { get; set; }
        [Column("crVatDate8", TypeName = "datetime")]
        public DateTime? CrVatDate8 { get; set; }
        [Column("crVat8")]
        public double? CrVat8 { get; set; }
        [Column("crCurr9")]
        public double? CrCurr9 { get; set; }
        [Column("crVatDate9", TypeName = "datetime")]
        public DateTime? CrVatDate9 { get; set; }
        [Column("crVat9")]
        public double? CrVat9 { get; set; }
        [Column("crCurr10")]
        public double? CrCurr10 { get; set; }
        [Column("crVatDate10", TypeName = "datetime")]
        public DateTime? CrVatDate10 { get; set; }
        [Column("crVat10")]
        public double? CrVat10 { get; set; }
        [Column("crCurr11")]
        public double? CrCurr11 { get; set; }
        [Column("crVatDate11", TypeName = "datetime")]
        public DateTime? CrVatDate11 { get; set; }
        [Column("crVat11")]
        public double? CrVat11 { get; set; }
        [Column("crCurr12")]
        public double? CrCurr12 { get; set; }
        [Column("crVatDate12", TypeName = "datetime")]
        public DateTime? CrVatDate12 { get; set; }
        [Column("crVat12")]
        public double? CrVat12 { get; set; }
        [Column("crCurr13")]
        public double? CrCurr13 { get; set; }
        [Column("crVatDate13", TypeName = "datetime")]
        public DateTime? CrVatDate13 { get; set; }
        [Column("crVat13")]
        public double? CrVat13 { get; set; }
        [Column("crCurr14")]
        public double? CrCurr14 { get; set; }
        [Column("crVatDate14", TypeName = "datetime")]
        public DateTime? CrVatDate14 { get; set; }
        [Column("crVat14")]
        public double? CrVat14 { get; set; }
        [Column("crCurr15")]
        public double? CrCurr15 { get; set; }
        [Column("crVatDate15", TypeName = "datetime")]
        public DateTime? CrVatDate15 { get; set; }
        [Column("crVat15")]
        public double? CrVat15 { get; set; }
        [Column("crCurr16")]
        public double? CrCurr16 { get; set; }
        [Column("crVatDate16", TypeName = "datetime")]
        public DateTime? CrVatDate16 { get; set; }
        [Column("crVat16")]
        public double? CrVat16 { get; set; }
        [Column("crCurr17")]
        public double? CrCurr17 { get; set; }
        [Column("crVatDate17", TypeName = "datetime")]
        public DateTime? CrVatDate17 { get; set; }
        [Column("crVat17")]
        public double? CrVat17 { get; set; }
        [Column("crCurr18")]
        public double? CrCurr18 { get; set; }
        [Column("crVatDate18", TypeName = "datetime")]
        public DateTime? CrVatDate18 { get; set; }
        [Column("crVat18")]
        public double? CrVat18 { get; set; }
        [Column("crCurr19")]
        public double? CrCurr19 { get; set; }
        [Column("crVatDate19", TypeName = "datetime")]
        public DateTime? CrVatDate19 { get; set; }
        [Column("crVat19")]
        public double? CrVat19 { get; set; }
        [Column("crCurr20")]
        public double? CrCurr20 { get; set; }
        [Column("crVatDate20", TypeName = "datetime")]
        public DateTime? CrVatDate20 { get; set; }
        [Column("crVat20")]
        public double? CrVat20 { get; set; }
        [Column("crCurr21")]
        public double? CrCurr21 { get; set; }
        [Column("crVatDate21", TypeName = "datetime")]
        public DateTime? CrVatDate21 { get; set; }
        [Column("crVat21")]
        public double? CrVat21 { get; set; }
        [Column("crCurr22")]
        public double? CrCurr22 { get; set; }
        [Column("crVatDate22", TypeName = "datetime")]
        public DateTime? CrVatDate22 { get; set; }
        [Column("crVat22")]
        public double? CrVat22 { get; set; }
        [Column("crCurr23")]
        public double? CrCurr23 { get; set; }
        [Column("crVatDate23", TypeName = "datetime")]
        public DateTime? CrVatDate23 { get; set; }
        [Column("crVat23")]
        public double? CrVat23 { get; set; }
        [Column("crCurr24")]
        public double? CrCurr24 { get; set; }
        [Column("crVatDate24", TypeName = "datetime")]
        public DateTime? CrVatDate24 { get; set; }
        [Column("crVat24")]
        public double? CrVat24 { get; set; }
        [Column("crCurr25")]
        public double? CrCurr25 { get; set; }
        [Column("crVatDate25", TypeName = "datetime")]
        public DateTime? CrVatDate25 { get; set; }
        [Column("crVat25")]
        public double? CrVat25 { get; set; }
        [Column("crCurr26")]
        public double? CrCurr26 { get; set; }
        [Column("crVatDate26", TypeName = "datetime")]
        public DateTime? CrVatDate26 { get; set; }
        [Column("crVat26")]
        public double? CrVat26 { get; set; }
        [Column("crCurr27")]
        public double? CrCurr27 { get; set; }
        [Column("crVatDate27", TypeName = "datetime")]
        public DateTime? CrVatDate27 { get; set; }
        [Column("crVat27")]
        public double? CrVat27 { get; set; }
        [Column("crCurr28")]
        public double? CrCurr28 { get; set; }
        [Column("crVatDate28", TypeName = "datetime")]
        public DateTime? CrVatDate28 { get; set; }
        [Column("crVat28")]
        public double? CrVat28 { get; set; }
        [Column("crCurr29")]
        public double? CrCurr29 { get; set; }
        [Column("crVatDate29", TypeName = "datetime")]
        public DateTime? CrVatDate29 { get; set; }
        [Column("crVat29")]
        public double? CrVat29 { get; set; }
        [Column("crCurr30")]
        public double? CrCurr30 { get; set; }
        [Column("crVatDate30", TypeName = "datetime")]
        public DateTime? CrVatDate30 { get; set; }
        [Column("crVat30")]
        public double? CrVat30 { get; set; }
        [Column("crCurr31")]
        public double? CrCurr31 { get; set; }
        [Column("crVatDate31", TypeName = "datetime")]
        public DateTime? CrVatDate31 { get; set; }
        [Column("crVat31")]
        public double? CrVat31 { get; set; }
        [Column("crCurr32")]
        public double? CrCurr32 { get; set; }
        [Column("crVatDate32", TypeName = "datetime")]
        public DateTime? CrVatDate32 { get; set; }
        [Column("crVat32")]
        public double? CrVat32 { get; set; }
        [Column("crCurr33")]
        public double? CrCurr33 { get; set; }
        [Column("crVatDate33", TypeName = "datetime")]
        public DateTime? CrVatDate33 { get; set; }
        [Column("crVat33")]
        public double? CrVat33 { get; set; }
        [Column("crCurr34")]
        public double? CrCurr34 { get; set; }
        [Column("crVatDate34", TypeName = "datetime")]
        public DateTime? CrVatDate34 { get; set; }
        [Column("crVat34")]
        public double? CrVat34 { get; set; }
        [Column("crCurr35")]
        public double? CrCurr35 { get; set; }
        [Column("crVatDate35", TypeName = "datetime")]
        public DateTime? CrVatDate35 { get; set; }
        [Column("crVat35")]
        public double? CrVat35 { get; set; }
        [Column("crCurr36")]
        public double? CrCurr36 { get; set; }
        [Column("crVatDate36", TypeName = "datetime")]
        public DateTime? CrVatDate36 { get; set; }
        [Column("crVat36")]
        public double? CrVat36 { get; set; }
        [Column("crCurr37")]
        public double? CrCurr37 { get; set; }
        [Column("crVatDate37", TypeName = "datetime")]
        public DateTime? CrVatDate37 { get; set; }
        [Column("crVat37")]
        public double? CrVat37 { get; set; }
        [Column("crCurr38")]
        public double? CrCurr38 { get; set; }
        [Column("crVatDate38", TypeName = "datetime")]
        public DateTime? CrVatDate38 { get; set; }
        [Column("crVat38")]
        public double? CrVat38 { get; set; }
        [Column("crCurr39")]
        public double? CrCurr39 { get; set; }
        [Column("crVatDate39", TypeName = "datetime")]
        public DateTime? CrVatDate39 { get; set; }
        [Column("crVat39")]
        public double? CrVat39 { get; set; }
        [Column("crCurr40")]
        public double? CrCurr40 { get; set; }
        [Column("crVatDate40", TypeName = "datetime")]
        public DateTime? CrVatDate40 { get; set; }
        [Column("crVat40")]
        public double? CrVat40 { get; set; }
        [Column("crCurr41")]
        public double? CrCurr41 { get; set; }
        [Column("crVatDate41", TypeName = "datetime")]
        public DateTime? CrVatDate41 { get; set; }
        [Column("crVat41")]
        public double? CrVat41 { get; set; }
        [Column("crCurr42")]
        public double? CrCurr42 { get; set; }
        [Column("crVatDate42", TypeName = "datetime")]
        public DateTime? CrVatDate42 { get; set; }
        [Column("crVat42")]
        public double? CrVat42 { get; set; }
        [Column("crCurr43")]
        public double? CrCurr43 { get; set; }
        [Column("crVatDate43", TypeName = "datetime")]
        public DateTime? CrVatDate43 { get; set; }
        [Column("crVat43")]
        public double? CrVat43 { get; set; }
        [Column("crCurr44")]
        public double? CrCurr44 { get; set; }
        [Column("crVatDate44", TypeName = "datetime")]
        public DateTime? CrVatDate44 { get; set; }
        [Column("crVat44")]
        public double? CrVat44 { get; set; }
        [Column("crCurr45")]
        public double? CrCurr45 { get; set; }
        [Column("crVatDate45", TypeName = "datetime")]
        public DateTime? CrVatDate45 { get; set; }
        [Column("crVat45")]
        public double? CrVat45 { get; set; }
        [Column("crCurr46")]
        public double? CrCurr46 { get; set; }
        [Column("crVatDate46", TypeName = "datetime")]
        public DateTime? CrVatDate46 { get; set; }
        [Column("crVat46")]
        public double? CrVat46 { get; set; }
        [Column("crCurr47")]
        public double? CrCurr47 { get; set; }
        [Column("crVatDate47", TypeName = "datetime")]
        public DateTime? CrVatDate47 { get; set; }
        [Column("crVat47")]
        public double? CrVat47 { get; set; }
        [Column("crCurr48")]
        public double? CrCurr48 { get; set; }
        [Column("crVatDate48", TypeName = "datetime")]
        public DateTime? CrVatDate48 { get; set; }
        [Column("crVat48")]
        public double? CrVat48 { get; set; }
        [Column("crCurr49")]
        public double? CrCurr49 { get; set; }
        [Column("crVatDate49", TypeName = "datetime")]
        public DateTime? CrVatDate49 { get; set; }
        [Column("crVat49")]
        public double? CrVat49 { get; set; }
        [Column("crCurr50")]
        public double? CrCurr50 { get; set; }
        [Column("crVatDate50", TypeName = "datetime")]
        public DateTime? CrVatDate50 { get; set; }
        [Column("crVat50")]
        public double? CrVat50 { get; set; }
        [Column("crCurr51")]
        public double? CrCurr51 { get; set; }
        [Column("crVatDate51", TypeName = "datetime")]
        public DateTime? CrVatDate51 { get; set; }
        [Column("crVat51")]
        public double? CrVat51 { get; set; }
        [Column("crCurr52")]
        public double? CrCurr52 { get; set; }
        [Column("crVatDate52", TypeName = "datetime")]
        public DateTime? CrVatDate52 { get; set; }
        [Column("crVat52")]
        public double? CrVat52 { get; set; }
        [Column("crCurr53")]
        public double? CrCurr53 { get; set; }
        [Column("crVatDate53", TypeName = "datetime")]
        public DateTime? CrVatDate53 { get; set; }
        [Column("crVat53")]
        public double? CrVat53 { get; set; }
        [Column("crCurr54")]
        public double? CrCurr54 { get; set; }
        [Column("crVatDate54", TypeName = "datetime")]
        public DateTime? CrVatDate54 { get; set; }
        [Column("crVat54")]
        public double? CrVat54 { get; set; }
        [Column("crCurr55")]
        public double? CrCurr55 { get; set; }
        [Column("crVatDate55", TypeName = "datetime")]
        public DateTime? CrVatDate55 { get; set; }
        [Column("crVat55")]
        public double? CrVat55 { get; set; }
        [Column("crCurr56")]
        public double? CrCurr56 { get; set; }
        [Column("crVatDate56", TypeName = "datetime")]
        public DateTime? CrVatDate56 { get; set; }
        [Column("crVat56")]
        public double? CrVat56 { get; set; }
        [Column("crCurr57")]
        public double? CrCurr57 { get; set; }
        [Column("crVatDate57", TypeName = "datetime")]
        public DateTime? CrVatDate57 { get; set; }
        [Column("crVat57")]
        public double? CrVat57 { get; set; }
        [Column("crCurr58")]
        public double? CrCurr58 { get; set; }
        [Column("crVatDate58", TypeName = "datetime")]
        public DateTime? CrVatDate58 { get; set; }
        [Column("crVat58")]
        public double? CrVat58 { get; set; }
        [Column("crCurr59")]
        public double? CrCurr59 { get; set; }
        [Column("crVatDate59", TypeName = "datetime")]
        public DateTime? CrVatDate59 { get; set; }
        [Column("crVat59")]
        public double? CrVat59 { get; set; }
        [Column("crCurr60")]
        public double? CrCurr60 { get; set; }
        [Column("crVatDate60", TypeName = "datetime")]
        public DateTime? CrVatDate60 { get; set; }
        [Column("crVat60")]
        public double? CrVat60 { get; set; }
        [Column("crCurr61")]
        public double? CrCurr61 { get; set; }
        [Column("crVatDate61", TypeName = "datetime")]
        public DateTime? CrVatDate61 { get; set; }
        [Column("crVat61")]
        public double? CrVat61 { get; set; }
        [Column("crCurr62")]
        public double? CrCurr62 { get; set; }
        [Column("crVatDate62", TypeName = "datetime")]
        public DateTime? CrVatDate62 { get; set; }
        [Column("crVat62")]
        public double? CrVat62 { get; set; }
        [Column("crCurr63")]
        public double? CrCurr63 { get; set; }
        [Column("crVatDate63", TypeName = "datetime")]
        public DateTime? CrVatDate63 { get; set; }
        [Column("crVat63")]
        public double? CrVat63 { get; set; }
        [Column("crCurr64")]
        public double? CrCurr64 { get; set; }
        [Column("crVatDate64", TypeName = "datetime")]
        public DateTime? CrVatDate64 { get; set; }
        [Column("crVat64")]
        public double? CrVat64 { get; set; }
        [Column("crCurr65")]
        public double? CrCurr65 { get; set; }
        [Column("crVatDate65", TypeName = "datetime")]
        public DateTime? CrVatDate65 { get; set; }
        [Column("crVat65")]
        public double? CrVat65 { get; set; }
        [Column("crCurr66")]
        public double? CrCurr66 { get; set; }
        [Column("crVatDate66", TypeName = "datetime")]
        public DateTime? CrVatDate66 { get; set; }
        [Column("crVat66")]
        public double? CrVat66 { get; set; }
        [Column("crCurr67")]
        public double? CrCurr67 { get; set; }
        [Column("crVatDate67", TypeName = "datetime")]
        public DateTime? CrVatDate67 { get; set; }
        [Column("crVat67")]
        public double? CrVat67 { get; set; }
        [Column("crCurr68")]
        public double? CrCurr68 { get; set; }
        [Column("crVatDate68", TypeName = "datetime")]
        public DateTime? CrVatDate68 { get; set; }
        [Column("crVat68")]
        public double? CrVat68 { get; set; }
        [Column("crCurr69")]
        public double? CrCurr69 { get; set; }
        [Column("crVatDate69", TypeName = "datetime")]
        public DateTime? CrVatDate69 { get; set; }
        [Column("crVat69")]
        public double? CrVat69 { get; set; }
        [Column("crCurr70")]
        public double? CrCurr70 { get; set; }
        [Column("crVatDate70", TypeName = "datetime")]
        public DateTime? CrVatDate70 { get; set; }
        [Column("crVat70")]
        public double? CrVat70 { get; set; }
        [Column("crCurr71")]
        public double? CrCurr71 { get; set; }
        [Column("crVatDate71", TypeName = "datetime")]
        public DateTime? CrVatDate71 { get; set; }
        [Column("crVat71")]
        public double? CrVat71 { get; set; }
        [Column("crCurr72")]
        public double? CrCurr72 { get; set; }
        [Column("crVatDate72", TypeName = "datetime")]
        public DateTime? CrVatDate72 { get; set; }
        [Column("crVat72")]
        public double? CrVat72 { get; set; }
        [Column("crCurr73")]
        public double? CrCurr73 { get; set; }
        [Column("crVatDate73", TypeName = "datetime")]
        public DateTime? CrVatDate73 { get; set; }
        [Column("crVat73")]
        public double? CrVat73 { get; set; }
        [Column("crCurr74")]
        public double? CrCurr74 { get; set; }
        [Column("crVatDate74", TypeName = "datetime")]
        public DateTime? CrVatDate74 { get; set; }
        [Column("crVat74")]
        public double? CrVat74 { get; set; }
        [Column("crCurr75")]
        public double? CrCurr75 { get; set; }
        [Column("crVatDate75", TypeName = "datetime")]
        public DateTime? CrVatDate75 { get; set; }
        [Column("crVat75")]
        public double? CrVat75 { get; set; }
        [Column("crCurr76")]
        public double? CrCurr76 { get; set; }
        [Column("crVatDate76", TypeName = "datetime")]
        public DateTime? CrVatDate76 { get; set; }
        [Column("crVat76")]
        public double? CrVat76 { get; set; }
        [Column("crCurr77")]
        public double? CrCurr77 { get; set; }
        [Column("crVatDate77", TypeName = "datetime")]
        public DateTime? CrVatDate77 { get; set; }
        [Column("crVat77")]
        public double? CrVat77 { get; set; }
        [Column("crCurr78")]
        public double? CrCurr78 { get; set; }
        [Column("crVatDate78", TypeName = "datetime")]
        public DateTime? CrVatDate78 { get; set; }
        [Column("crVat78")]
        public double? CrVat78 { get; set; }
        [Column("crCurr79")]
        public double? CrCurr79 { get; set; }
        [Column("crVatDate79", TypeName = "datetime")]
        public DateTime? CrVatDate79 { get; set; }
        [Column("crVat79")]
        public double? CrVat79 { get; set; }
        [Column("crCurr80")]
        public double? CrCurr80 { get; set; }
        [Column("crVatDate80", TypeName = "datetime")]
        public DateTime? CrVatDate80 { get; set; }
        [Column("crVat80")]
        public double? CrVat80 { get; set; }
        [Column("crCurr81")]
        public double? CrCurr81 { get; set; }
        [Column("crVatDate81", TypeName = "datetime")]
        public DateTime? CrVatDate81 { get; set; }
        [Column("crVat81")]
        public double? CrVat81 { get; set; }
        [Column("crCurr82")]
        public double? CrCurr82 { get; set; }
        [Column("crVatDate82", TypeName = "datetime")]
        public DateTime? CrVatDate82 { get; set; }
        [Column("crVat82")]
        public double? CrVat82 { get; set; }
        [Column("crCurr83")]
        public double? CrCurr83 { get; set; }
        [Column("crVatDate83", TypeName = "datetime")]
        public DateTime? CrVatDate83 { get; set; }
        [Column("crVat83")]
        public double? CrVat83 { get; set; }
        [Column("crCurr84")]
        public double? CrCurr84 { get; set; }
        [Column("crVatDate84", TypeName = "datetime")]
        public DateTime? CrVatDate84 { get; set; }
        [Column("crVat84")]
        public double? CrVat84 { get; set; }
        [Column("crCurr85")]
        public double? CrCurr85 { get; set; }
        [Column("crVatDate85", TypeName = "datetime")]
        public DateTime? CrVatDate85 { get; set; }
        [Column("crVat85")]
        public double? CrVat85 { get; set; }
        [Column("crCurr86")]
        public double? CrCurr86 { get; set; }
        [Column("crVatDate86", TypeName = "datetime")]
        public DateTime? CrVatDate86 { get; set; }
        [Column("crVat86")]
        public double? CrVat86 { get; set; }
        [Column("crCurr87")]
        public double? CrCurr87 { get; set; }
        [Column("crVatDate87", TypeName = "datetime")]
        public DateTime? CrVatDate87 { get; set; }
        [Column("crVat87")]
        public double? CrVat87 { get; set; }
        [Column("crCurr88")]
        public double? CrCurr88 { get; set; }
        [Column("crVatDate88", TypeName = "datetime")]
        public DateTime? CrVatDate88 { get; set; }
        [Column("crVat88")]
        public double? CrVat88 { get; set; }
        [Column("crCurr89")]
        public double? CrCurr89 { get; set; }
        [Column("crVatDate89", TypeName = "datetime")]
        public DateTime? CrVatDate89 { get; set; }
        [Column("crVat89")]
        public double? CrVat89 { get; set; }
        [Column("crCurr90")]
        public double? CrCurr90 { get; set; }
        [Column("crVatDate90", TypeName = "datetime")]
        public DateTime? CrVatDate90 { get; set; }
        [Column("crVat90")]
        public double? CrVat90 { get; set; }
    }
}
