using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("SALESMEN")]
    [Index(nameof(Sellcode), Name = "selByCode")]
    [Index(nameof(Sellkind), Name = "selByKind")]
    [Index(nameof(Sellmanag), nameof(Sellcode), Name = "selByManag")]
    [Index(nameof(SellnameSrt), Name = "selByName")]
    public partial class Salesman
    {
        [Key]
        [Column("sellFileID")]
        public int SellFileId { get; set; }
        [Column("sellcode")]
        [StringLength(15)]
        public string Sellcode { get; set; }
        [Column("sellname")]
        [StringLength(39)]
        public string Sellname { get; set; }
        [Column("sellname_srt")]
        [StringLength(39)]
        public string SellnameSrt { get; set; }
        [Column("sellkind")]
        public int? Sellkind { get; set; }
        [Column("sellmanag")]
        public int? Sellmanag { get; set; }
        [Column("sellgroup")]
        public int? Sellgroup { get; set; }
        [Column("selarea")]
        [StringLength(3)]
        public string Selarea { get; set; }
        [Column("selladdr")]
        [StringLength(19)]
        public string Selladdr { get; set; }
        [Column("sellzip")]
        [StringLength(9)]
        public string Sellzip { get; set; }
        [Column("sellcity")]
        [StringLength(19)]
        public string Sellcity { get; set; }
        [Column("selltel")]
        [StringLength(13)]
        public string Selltel { get; set; }
        [Column("sellarea")]
        [StringLength(19)]
        public string Sellarea { get; set; }
        [Column("sellfax")]
        [StringLength(13)]
        public string Sellfax { get; set; }
        [Column("sellcomm")]
        [StringLength(39)]
        public string Sellcomm { get; set; }
        [Column("sellperc")]
        public double? Sellperc { get; set; }
        [Column("sellprom1")]
        public double? Sellprom1 { get; set; }
        [Column("sellprom2")]
        public double? Sellprom2 { get; set; }
        [Column("sellprom3")]
        public double? Sellprom3 { get; set; }
        [Column("sellprom4")]
        public double? Sellprom4 { get; set; }
        [Column("sellprom5")]
        public double? Sellprom5 { get; set; }
        [Column("sellprom6")]
        public double? Sellprom6 { get; set; }
        [Column("sellprom7")]
        public double? Sellprom7 { get; set; }
        [Column("sellprom8")]
        public double? Sellprom8 { get; set; }
        [Column("sellprom9")]
        public double? Sellprom9 { get; set; }
        [Column("sellprom10")]
        public double? Sellprom10 { get; set; }
        [Column("sellprom11")]
        public double? Sellprom11 { get; set; }
        [Column("sellprom12")]
        public double? Sellprom12 { get; set; }
        [Column("sellprom13")]
        public double? Sellprom13 { get; set; }
        [Column("sellprom14")]
        public double? Sellprom14 { get; set; }
        [Column("sellprom15")]
        public double? Sellprom15 { get; set; }
        [Column("sellprom16")]
        public double? Sellprom16 { get; set; }
        [Column("sellprom17")]
        public double? Sellprom17 { get; set; }
        [Column("sellprom18")]
        public double? Sellprom18 { get; set; }
        [Column("sellprom19")]
        public double? Sellprom19 { get; set; }
        [Column("sellprom20")]
        public double? Sellprom20 { get; set; }
        [Column("sellinv1")]
        public double? Sellinv1 { get; set; }
        [Column("sellinv2")]
        public double? Sellinv2 { get; set; }
        [Column("sellinv3")]
        public double? Sellinv3 { get; set; }
        [Column("sellinv4")]
        public double? Sellinv4 { get; set; }
        [Column("sellinv5")]
        public double? Sellinv5 { get; set; }
        [Column("sellinv6")]
        public double? Sellinv6 { get; set; }
        [Column("sellinv7")]
        public double? Sellinv7 { get; set; }
        [Column("sellinv8")]
        public double? Sellinv8 { get; set; }
        [Column("sellinv9")]
        public double? Sellinv9 { get; set; }
        [Column("sellinv10")]
        public double? Sellinv10 { get; set; }
        [Column("sellinv11")]
        public double? Sellinv11 { get; set; }
        [Column("sellinv12")]
        public double? Sellinv12 { get; set; }
        [Column("sellsales001")]
        public double? Sellsales001 { get; set; }
        [Column("sellsales011")]
        public double? Sellsales011 { get; set; }
        [Column("sellsales021")]
        public double? Sellsales021 { get; set; }
        [Column("sellsales031")]
        public double? Sellsales031 { get; set; }
        [Column("sellsales041")]
        public double? Sellsales041 { get; set; }
        [Column("sellsales051")]
        public double? Sellsales051 { get; set; }
        [Column("sellsales061")]
        public double? Sellsales061 { get; set; }
        [Column("sellsales071")]
        public double? Sellsales071 { get; set; }
        [Column("sellsales081")]
        public double? Sellsales081 { get; set; }
        [Column("sellsales091")]
        public double? Sellsales091 { get; set; }
        [Column("sellsales101")]
        public double? Sellsales101 { get; set; }
        [Column("sellsales111")]
        public double? Sellsales111 { get; set; }
        [Column("sellsales121")]
        public double? Sellsales121 { get; set; }
        [Column("sellsales131")]
        public double? Sellsales131 { get; set; }
        [Column("sellsales141")]
        public double? Sellsales141 { get; set; }
        [Column("sellsales151")]
        public double? Sellsales151 { get; set; }
        [Column("sellsales161")]
        public double? Sellsales161 { get; set; }
        [Column("sellsales171")]
        public double? Sellsales171 { get; set; }
        [Column("sellsales181")]
        public double? Sellsales181 { get; set; }
        [Column("sellsales191")]
        public double? Sellsales191 { get; set; }
        [Column("sellsales201")]
        public double? Sellsales201 { get; set; }
        [Column("sellsales002")]
        public double? Sellsales002 { get; set; }
        [Column("sellsales012")]
        public double? Sellsales012 { get; set; }
        [Column("sellsales022")]
        public double? Sellsales022 { get; set; }
        [Column("sellsales032")]
        public double? Sellsales032 { get; set; }
        [Column("sellsales042")]
        public double? Sellsales042 { get; set; }
        [Column("sellsales052")]
        public double? Sellsales052 { get; set; }
        [Column("sellsales062")]
        public double? Sellsales062 { get; set; }
        [Column("sellsales072")]
        public double? Sellsales072 { get; set; }
        [Column("sellsales082")]
        public double? Sellsales082 { get; set; }
        [Column("sellsales092")]
        public double? Sellsales092 { get; set; }
        [Column("sellsales102")]
        public double? Sellsales102 { get; set; }
        [Column("sellsales112")]
        public double? Sellsales112 { get; set; }
        [Column("sellsales122")]
        public double? Sellsales122 { get; set; }
        [Column("sellsales132")]
        public double? Sellsales132 { get; set; }
        [Column("sellsales142")]
        public double? Sellsales142 { get; set; }
        [Column("sellsales152")]
        public double? Sellsales152 { get; set; }
        [Column("sellsales162")]
        public double? Sellsales162 { get; set; }
        [Column("sellsales172")]
        public double? Sellsales172 { get; set; }
        [Column("sellsales182")]
        public double? Sellsales182 { get; set; }
        [Column("sellsales192")]
        public double? Sellsales192 { get; set; }
        [Column("sellsales202")]
        public double? Sellsales202 { get; set; }
        [Column("sellsales003")]
        public double? Sellsales003 { get; set; }
        [Column("sellsales013")]
        public double? Sellsales013 { get; set; }
        [Column("sellsales023")]
        public double? Sellsales023 { get; set; }
        [Column("sellsales033")]
        public double? Sellsales033 { get; set; }
        [Column("sellsales043")]
        public double? Sellsales043 { get; set; }
        [Column("sellsales053")]
        public double? Sellsales053 { get; set; }
        [Column("sellsales063")]
        public double? Sellsales063 { get; set; }
        [Column("sellsales073")]
        public double? Sellsales073 { get; set; }
        [Column("sellsales083")]
        public double? Sellsales083 { get; set; }
        [Column("sellsales093")]
        public double? Sellsales093 { get; set; }
        [Column("sellsales103")]
        public double? Sellsales103 { get; set; }
        [Column("sellsales113")]
        public double? Sellsales113 { get; set; }
        [Column("sellsales123")]
        public double? Sellsales123 { get; set; }
        [Column("sellsales133")]
        public double? Sellsales133 { get; set; }
        [Column("sellsales143")]
        public double? Sellsales143 { get; set; }
        [Column("sellsales153")]
        public double? Sellsales153 { get; set; }
        [Column("sellsales163")]
        public double? Sellsales163 { get; set; }
        [Column("sellsales173")]
        public double? Sellsales173 { get; set; }
        [Column("sellsales183")]
        public double? Sellsales183 { get; set; }
        [Column("sellsales193")]
        public double? Sellsales193 { get; set; }
        [Column("sellsales203")]
        public double? Sellsales203 { get; set; }
        [Column("sellsales004")]
        public double? Sellsales004 { get; set; }
        [Column("sellsales014")]
        public double? Sellsales014 { get; set; }
        [Column("sellsales024")]
        public double? Sellsales024 { get; set; }
        [Column("sellsales034")]
        public double? Sellsales034 { get; set; }
        [Column("sellsales044")]
        public double? Sellsales044 { get; set; }
        [Column("sellsales054")]
        public double? Sellsales054 { get; set; }
        [Column("sellsales064")]
        public double? Sellsales064 { get; set; }
        [Column("sellsales074")]
        public double? Sellsales074 { get; set; }
        [Column("sellsales084")]
        public double? Sellsales084 { get; set; }
        [Column("sellsales094")]
        public double? Sellsales094 { get; set; }
        [Column("sellsales104")]
        public double? Sellsales104 { get; set; }
        [Column("sellsales114")]
        public double? Sellsales114 { get; set; }
        [Column("sellsales124")]
        public double? Sellsales124 { get; set; }
        [Column("sellsales134")]
        public double? Sellsales134 { get; set; }
        [Column("sellsales144")]
        public double? Sellsales144 { get; set; }
        [Column("sellsales154")]
        public double? Sellsales154 { get; set; }
        [Column("sellsales164")]
        public double? Sellsales164 { get; set; }
        [Column("sellsales174")]
        public double? Sellsales174 { get; set; }
        [Column("sellsales184")]
        public double? Sellsales184 { get; set; }
        [Column("sellsales194")]
        public double? Sellsales194 { get; set; }
        [Column("sellsales204")]
        public double? Sellsales204 { get; set; }
        [Column("sellsales005")]
        public double? Sellsales005 { get; set; }
        [Column("sellsales015")]
        public double? Sellsales015 { get; set; }
        [Column("sellsales025")]
        public double? Sellsales025 { get; set; }
        [Column("sellsales035")]
        public double? Sellsales035 { get; set; }
        [Column("sellsales045")]
        public double? Sellsales045 { get; set; }
        [Column("sellsales055")]
        public double? Sellsales055 { get; set; }
        [Column("sellsales065")]
        public double? Sellsales065 { get; set; }
        [Column("sellsales075")]
        public double? Sellsales075 { get; set; }
        [Column("sellsales085")]
        public double? Sellsales085 { get; set; }
        [Column("sellsales095")]
        public double? Sellsales095 { get; set; }
        [Column("sellsales105")]
        public double? Sellsales105 { get; set; }
        [Column("sellsales115")]
        public double? Sellsales115 { get; set; }
        [Column("sellsales125")]
        public double? Sellsales125 { get; set; }
        [Column("sellsales135")]
        public double? Sellsales135 { get; set; }
        [Column("sellsales145")]
        public double? Sellsales145 { get; set; }
        [Column("sellsales155")]
        public double? Sellsales155 { get; set; }
        [Column("sellsales165")]
        public double? Sellsales165 { get; set; }
        [Column("sellsales175")]
        public double? Sellsales175 { get; set; }
        [Column("sellsales185")]
        public double? Sellsales185 { get; set; }
        [Column("sellsales195")]
        public double? Sellsales195 { get; set; }
        [Column("sellsales205")]
        public double? Sellsales205 { get; set; }
        [Column("sellsales006")]
        public double? Sellsales006 { get; set; }
        [Column("sellsales016")]
        public double? Sellsales016 { get; set; }
        [Column("sellsales026")]
        public double? Sellsales026 { get; set; }
        [Column("sellsales036")]
        public double? Sellsales036 { get; set; }
        [Column("sellsales046")]
        public double? Sellsales046 { get; set; }
        [Column("sellsales056")]
        public double? Sellsales056 { get; set; }
        [Column("sellsales066")]
        public double? Sellsales066 { get; set; }
        [Column("sellsales076")]
        public double? Sellsales076 { get; set; }
        [Column("sellsales086")]
        public double? Sellsales086 { get; set; }
        [Column("sellsales096")]
        public double? Sellsales096 { get; set; }
        [Column("sellsales106")]
        public double? Sellsales106 { get; set; }
        [Column("sellsales116")]
        public double? Sellsales116 { get; set; }
        [Column("sellsales126")]
        public double? Sellsales126 { get; set; }
        [Column("sellsales136")]
        public double? Sellsales136 { get; set; }
        [Column("sellsales146")]
        public double? Sellsales146 { get; set; }
        [Column("sellsales156")]
        public double? Sellsales156 { get; set; }
        [Column("sellsales166")]
        public double? Sellsales166 { get; set; }
        [Column("sellsales176")]
        public double? Sellsales176 { get; set; }
        [Column("sellsales186")]
        public double? Sellsales186 { get; set; }
        [Column("sellsales196")]
        public double? Sellsales196 { get; set; }
        [Column("sellsales206")]
        public double? Sellsales206 { get; set; }
        [Column("sellsales007")]
        public double? Sellsales007 { get; set; }
        [Column("sellsales017")]
        public double? Sellsales017 { get; set; }
        [Column("sellsales027")]
        public double? Sellsales027 { get; set; }
        [Column("sellsales037")]
        public double? Sellsales037 { get; set; }
        [Column("sellsales047")]
        public double? Sellsales047 { get; set; }
        [Column("sellsales057")]
        public double? Sellsales057 { get; set; }
        [Column("sellsales067")]
        public double? Sellsales067 { get; set; }
        [Column("sellsales077")]
        public double? Sellsales077 { get; set; }
        [Column("sellsales087")]
        public double? Sellsales087 { get; set; }
        [Column("sellsales097")]
        public double? Sellsales097 { get; set; }
        [Column("sellsales107")]
        public double? Sellsales107 { get; set; }
        [Column("sellsales117")]
        public double? Sellsales117 { get; set; }
        [Column("sellsales127")]
        public double? Sellsales127 { get; set; }
        [Column("sellsales137")]
        public double? Sellsales137 { get; set; }
        [Column("sellsales147")]
        public double? Sellsales147 { get; set; }
        [Column("sellsales157")]
        public double? Sellsales157 { get; set; }
        [Column("sellsales167")]
        public double? Sellsales167 { get; set; }
        [Column("sellsales177")]
        public double? Sellsales177 { get; set; }
        [Column("sellsales187")]
        public double? Sellsales187 { get; set; }
        [Column("sellsales197")]
        public double? Sellsales197 { get; set; }
        [Column("sellsales207")]
        public double? Sellsales207 { get; set; }
        [Column("sellsales008")]
        public double? Sellsales008 { get; set; }
        [Column("sellsales018")]
        public double? Sellsales018 { get; set; }
        [Column("sellsales028")]
        public double? Sellsales028 { get; set; }
        [Column("sellsales038")]
        public double? Sellsales038 { get; set; }
        [Column("sellsales048")]
        public double? Sellsales048 { get; set; }
        [Column("sellsales058")]
        public double? Sellsales058 { get; set; }
        [Column("sellsales068")]
        public double? Sellsales068 { get; set; }
        [Column("sellsales078")]
        public double? Sellsales078 { get; set; }
        [Column("sellsales088")]
        public double? Sellsales088 { get; set; }
        [Column("sellsales098")]
        public double? Sellsales098 { get; set; }
        [Column("sellsales108")]
        public double? Sellsales108 { get; set; }
        [Column("sellsales118")]
        public double? Sellsales118 { get; set; }
        [Column("sellsales128")]
        public double? Sellsales128 { get; set; }
        [Column("sellsales138")]
        public double? Sellsales138 { get; set; }
        [Column("sellsales148")]
        public double? Sellsales148 { get; set; }
        [Column("sellsales158")]
        public double? Sellsales158 { get; set; }
        [Column("sellsales168")]
        public double? Sellsales168 { get; set; }
        [Column("sellsales178")]
        public double? Sellsales178 { get; set; }
        [Column("sellsales188")]
        public double? Sellsales188 { get; set; }
        [Column("sellsales198")]
        public double? Sellsales198 { get; set; }
        [Column("sellsales208")]
        public double? Sellsales208 { get; set; }
        [Column("sellsales009")]
        public double? Sellsales009 { get; set; }
        [Column("sellsales019")]
        public double? Sellsales019 { get; set; }
        [Column("sellsales029")]
        public double? Sellsales029 { get; set; }
        [Column("sellsales039")]
        public double? Sellsales039 { get; set; }
        [Column("sellsales049")]
        public double? Sellsales049 { get; set; }
        [Column("sellsales059")]
        public double? Sellsales059 { get; set; }
        [Column("sellsales069")]
        public double? Sellsales069 { get; set; }
        [Column("sellsales079")]
        public double? Sellsales079 { get; set; }
        [Column("sellsales089")]
        public double? Sellsales089 { get; set; }
        [Column("sellsales099")]
        public double? Sellsales099 { get; set; }
        [Column("sellsales109")]
        public double? Sellsales109 { get; set; }
        [Column("sellsales119")]
        public double? Sellsales119 { get; set; }
        [Column("sellsales129")]
        public double? Sellsales129 { get; set; }
        [Column("sellsales139")]
        public double? Sellsales139 { get; set; }
        [Column("sellsales149")]
        public double? Sellsales149 { get; set; }
        [Column("sellsales159")]
        public double? Sellsales159 { get; set; }
        [Column("sellsales169")]
        public double? Sellsales169 { get; set; }
        [Column("sellsales179")]
        public double? Sellsales179 { get; set; }
        [Column("sellsales189")]
        public double? Sellsales189 { get; set; }
        [Column("sellsales199")]
        public double? Sellsales199 { get; set; }
        [Column("sellsales209")]
        public double? Sellsales209 { get; set; }
        [Column("sellsales0010")]
        public double? Sellsales0010 { get; set; }
        [Column("sellsales0110")]
        public double? Sellsales0110 { get; set; }
        [Column("sellsales0210")]
        public double? Sellsales0210 { get; set; }
        [Column("sellsales0310")]
        public double? Sellsales0310 { get; set; }
        [Column("sellsales0410")]
        public double? Sellsales0410 { get; set; }
        [Column("sellsales0510")]
        public double? Sellsales0510 { get; set; }
        [Column("sellsales0610")]
        public double? Sellsales0610 { get; set; }
        [Column("sellsales0710")]
        public double? Sellsales0710 { get; set; }
        [Column("sellsales0810")]
        public double? Sellsales0810 { get; set; }
        [Column("sellsales0910")]
        public double? Sellsales0910 { get; set; }
        [Column("sellsales1010")]
        public double? Sellsales1010 { get; set; }
        [Column("sellsales1110")]
        public double? Sellsales1110 { get; set; }
        [Column("sellsales1210")]
        public double? Sellsales1210 { get; set; }
        [Column("sellsales1310")]
        public double? Sellsales1310 { get; set; }
        [Column("sellsales1410")]
        public double? Sellsales1410 { get; set; }
        [Column("sellsales1510")]
        public double? Sellsales1510 { get; set; }
        [Column("sellsales1610")]
        public double? Sellsales1610 { get; set; }
        [Column("sellsales1710")]
        public double? Sellsales1710 { get; set; }
        [Column("sellsales1810")]
        public double? Sellsales1810 { get; set; }
        [Column("sellsales1910")]
        public double? Sellsales1910 { get; set; }
        [Column("sellsales2010")]
        public double? Sellsales2010 { get; set; }
        [Column("sellsales0011")]
        public double? Sellsales0011 { get; set; }
        [Column("sellsales0111")]
        public double? Sellsales0111 { get; set; }
        [Column("sellsales0211")]
        public double? Sellsales0211 { get; set; }
        [Column("sellsales0311")]
        public double? Sellsales0311 { get; set; }
        [Column("sellsales0411")]
        public double? Sellsales0411 { get; set; }
        [Column("sellsales0511")]
        public double? Sellsales0511 { get; set; }
        [Column("sellsales0611")]
        public double? Sellsales0611 { get; set; }
        [Column("sellsales0711")]
        public double? Sellsales0711 { get; set; }
        [Column("sellsales0811")]
        public double? Sellsales0811 { get; set; }
        [Column("sellsales0911")]
        public double? Sellsales0911 { get; set; }
        [Column("sellsales1011")]
        public double? Sellsales1011 { get; set; }
        [Column("sellsales1111")]
        public double? Sellsales1111 { get; set; }
        [Column("sellsales1211")]
        public double? Sellsales1211 { get; set; }
        [Column("sellsales1311")]
        public double? Sellsales1311 { get; set; }
        [Column("sellsales1411")]
        public double? Sellsales1411 { get; set; }
        [Column("sellsales1511")]
        public double? Sellsales1511 { get; set; }
        [Column("sellsales1611")]
        public double? Sellsales1611 { get; set; }
        [Column("sellsales1711")]
        public double? Sellsales1711 { get; set; }
        [Column("sellsales1811")]
        public double? Sellsales1811 { get; set; }
        [Column("sellsales1911")]
        public double? Sellsales1911 { get; set; }
        [Column("sellsales2011")]
        public double? Sellsales2011 { get; set; }
        [Column("sellsales0012")]
        public double? Sellsales0012 { get; set; }
        [Column("sellsales0112")]
        public double? Sellsales0112 { get; set; }
        [Column("sellsales0212")]
        public double? Sellsales0212 { get; set; }
        [Column("sellsales0312")]
        public double? Sellsales0312 { get; set; }
        [Column("sellsales0412")]
        public double? Sellsales0412 { get; set; }
        [Column("sellsales0512")]
        public double? Sellsales0512 { get; set; }
        [Column("sellsales0612")]
        public double? Sellsales0612 { get; set; }
        [Column("sellsales0712")]
        public double? Sellsales0712 { get; set; }
        [Column("sellsales0812")]
        public double? Sellsales0812 { get; set; }
        [Column("sellsales0912")]
        public double? Sellsales0912 { get; set; }
        [Column("sellsales1012")]
        public double? Sellsales1012 { get; set; }
        [Column("sellsales1112")]
        public double? Sellsales1112 { get; set; }
        [Column("sellsales1212")]
        public double? Sellsales1212 { get; set; }
        [Column("sellsales1312")]
        public double? Sellsales1312 { get; set; }
        [Column("sellsales1412")]
        public double? Sellsales1412 { get; set; }
        [Column("sellsales1512")]
        public double? Sellsales1512 { get; set; }
        [Column("sellsales1612")]
        public double? Sellsales1612 { get; set; }
        [Column("sellsales1712")]
        public double? Sellsales1712 { get; set; }
        [Column("sellsales1812")]
        public double? Sellsales1812 { get; set; }
        [Column("sellsales1912")]
        public double? Sellsales1912 { get; set; }
        [Column("sellsales2012")]
        public double? Sellsales2012 { get; set; }
        [Column("sellrecei1")]
        public double? Sellrecei1 { get; set; }
        [Column("sellrecei2")]
        public double? Sellrecei2 { get; set; }
        [Column("sellrecei3")]
        public double? Sellrecei3 { get; set; }
        [Column("sellrecei4")]
        public double? Sellrecei4 { get; set; }
        [Column("sellrecei5")]
        public double? Sellrecei5 { get; set; }
        [Column("sellrecei6")]
        public double? Sellrecei6 { get; set; }
        [Column("sellrecei7")]
        public double? Sellrecei7 { get; set; }
        [Column("sellrecei8")]
        public double? Sellrecei8 { get; set; }
        [Column("sellrecei9")]
        public double? Sellrecei9 { get; set; }
        [Column("sellrecei10")]
        public double? Sellrecei10 { get; set; }
        [Column("sellrecei11")]
        public double? Sellrecei11 { get; set; }
        [Column("sellrecei12")]
        public double? Sellrecei12 { get; set; }
        [Column("selfutinv1")]
        public double? Selfutinv1 { get; set; }
        [Column("selfutinv2")]
        public double? Selfutinv2 { get; set; }
        [Column("selfutinv3")]
        public double? Selfutinv3 { get; set; }
        [Column("selfutinv4")]
        public double? Selfutinv4 { get; set; }
        [Column("selfutinv5")]
        public double? Selfutinv5 { get; set; }
        [Column("selfutinv6")]
        public double? Selfutinv6 { get; set; }
        [Column("selfutinv7")]
        public double? Selfutinv7 { get; set; }
        [Column("selfutinv8")]
        public double? Selfutinv8 { get; set; }
        [Column("selfutinv9")]
        public double? Selfutinv9 { get; set; }
        [Column("selfutinv10")]
        public double? Selfutinv10 { get; set; }
        [Column("selfutinv11")]
        public double? Selfutinv11 { get; set; }
        [Column("selfutinv12")]
        public double? Selfutinv12 { get; set; }
        [Column("selfutsal1")]
        public double? Selfutsal1 { get; set; }
        [Column("selfutsal2")]
        public double? Selfutsal2 { get; set; }
        [Column("selfutsal3")]
        public double? Selfutsal3 { get; set; }
        [Column("selfutsal4")]
        public double? Selfutsal4 { get; set; }
        [Column("selfutsal5")]
        public double? Selfutsal5 { get; set; }
        [Column("selfutsal6")]
        public double? Selfutsal6 { get; set; }
        [Column("selfutsal7")]
        public double? Selfutsal7 { get; set; }
        [Column("selfutsal8")]
        public double? Selfutsal8 { get; set; }
        [Column("selfutsal9")]
        public double? Selfutsal9 { get; set; }
        [Column("selfutsal10")]
        public double? Selfutsal10 { get; set; }
        [Column("selfutsal11")]
        public double? Selfutsal11 { get; set; }
        [Column("selfutsal12")]
        public double? Selfutsal12 { get; set; }
        [Column("selfutrec1")]
        public double? Selfutrec1 { get; set; }
        [Column("selfutrec2")]
        public double? Selfutrec2 { get; set; }
        [Column("selfutrec3")]
        public double? Selfutrec3 { get; set; }
        [Column("selfutrec4")]
        public double? Selfutrec4 { get; set; }
        [Column("selfutrec5")]
        public double? Selfutrec5 { get; set; }
        [Column("selfutrec6")]
        public double? Selfutrec6 { get; set; }
        [Column("selfutrec7")]
        public double? Selfutrec7 { get; set; }
        [Column("selfutrec8")]
        public double? Selfutrec8 { get; set; }
        [Column("selfutrec9")]
        public double? Selfutrec9 { get; set; }
        [Column("selfutrec10")]
        public double? Selfutrec10 { get; set; }
        [Column("selfutrec11")]
        public double? Selfutrec11 { get; set; }
        [Column("selfutrec12")]
        public double? Selfutrec12 { get; set; }
        [Column("selprevsa1")]
        public double? Selprevsa1 { get; set; }
        [Column("selprevsa2")]
        public double? Selprevsa2 { get; set; }
        [Column("selprevsa3")]
        public double? Selprevsa3 { get; set; }
        [Column("selprevsa4")]
        public double? Selprevsa4 { get; set; }
        [Column("selprevsa5")]
        public double? Selprevsa5 { get; set; }
        [Column("selprevsa6")]
        public double? Selprevsa6 { get; set; }
        [Column("selprevsa7")]
        public double? Selprevsa7 { get; set; }
        [Column("selprevsa8")]
        public double? Selprevsa8 { get; set; }
        [Column("selprevsa9")]
        public double? Selprevsa9 { get; set; }
        [Column("selprevsa10")]
        public double? Selprevsa10 { get; set; }
        [Column("selprevsa11")]
        public double? Selprevsa11 { get; set; }
        [Column("selprevsa12")]
        public double? Selprevsa12 { get; set; }
        [Column("selglcode")]
        [StringLength(15)]
        public string Selglcode { get; set; }
        [Column("sellpercSales")]
        public double? SellpercSales { get; set; }
        [Column("sellemail")]
        [StringLength(59)]
        public string Sellemail { get; set; }
    }
}
