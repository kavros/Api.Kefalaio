using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Api.Kefalaio.Model
{
    [Table("PRLSTS")]
    public partial class Prlst
    {
        [Key]
        [Column("plsFileId")]
        public int PlsFileId { get; set; }
        [Column("plsDescr")]
        [StringLength(29)]
        public string PlsDescr { get; set; }
        [Column("plsBrPoint1")]
        public double? PlsBrPoint1 { get; set; }
        [Column("plsBrPoint2")]
        public double? PlsBrPoint2 { get; set; }
        [Column("plsBrPoint3")]
        public double? PlsBrPoint3 { get; set; }
        [Column("plsBrPoint4")]
        public double? PlsBrPoint4 { get; set; }
        [Column("plsBrPoint5")]
        public double? PlsBrPoint5 { get; set; }
        [Column("plsDisc011")]
        public double? PlsDisc011 { get; set; }
        [Column("plsDisc012")]
        public double? PlsDisc012 { get; set; }
        [Column("plsDisc013")]
        public double? PlsDisc013 { get; set; }
        [Column("plsDisc014")]
        public double? PlsDisc014 { get; set; }
        [Column("plsDisc015")]
        public double? PlsDisc015 { get; set; }
        [Column("plsDisc016")]
        public double? PlsDisc016 { get; set; }
        [Column("plsDisc021")]
        public double? PlsDisc021 { get; set; }
        [Column("plsDisc022")]
        public double? PlsDisc022 { get; set; }
        [Column("plsDisc023")]
        public double? PlsDisc023 { get; set; }
        [Column("plsDisc024")]
        public double? PlsDisc024 { get; set; }
        [Column("plsDisc025")]
        public double? PlsDisc025 { get; set; }
        [Column("plsDisc026")]
        public double? PlsDisc026 { get; set; }
        [Column("plsDisc031")]
        public double? PlsDisc031 { get; set; }
        [Column("plsDisc032")]
        public double? PlsDisc032 { get; set; }
        [Column("plsDisc033")]
        public double? PlsDisc033 { get; set; }
        [Column("plsDisc034")]
        public double? PlsDisc034 { get; set; }
        [Column("plsDisc035")]
        public double? PlsDisc035 { get; set; }
        [Column("plsDisc036")]
        public double? PlsDisc036 { get; set; }
        [Column("plsDisc041")]
        public double? PlsDisc041 { get; set; }
        [Column("plsDisc042")]
        public double? PlsDisc042 { get; set; }
        [Column("plsDisc043")]
        public double? PlsDisc043 { get; set; }
        [Column("plsDisc044")]
        public double? PlsDisc044 { get; set; }
        [Column("plsDisc045")]
        public double? PlsDisc045 { get; set; }
        [Column("plsDisc046")]
        public double? PlsDisc046 { get; set; }
        [Column("plsDisc051")]
        public double? PlsDisc051 { get; set; }
        [Column("plsDisc052")]
        public double? PlsDisc052 { get; set; }
        [Column("plsDisc053")]
        public double? PlsDisc053 { get; set; }
        [Column("plsDisc054")]
        public double? PlsDisc054 { get; set; }
        [Column("plsDisc055")]
        public double? PlsDisc055 { get; set; }
        [Column("plsDisc056")]
        public double? PlsDisc056 { get; set; }
        [Column("plsDisc061")]
        public double? PlsDisc061 { get; set; }
        [Column("plsDisc062")]
        public double? PlsDisc062 { get; set; }
        [Column("plsDisc063")]
        public double? PlsDisc063 { get; set; }
        [Column("plsDisc064")]
        public double? PlsDisc064 { get; set; }
        [Column("plsDisc065")]
        public double? PlsDisc065 { get; set; }
        [Column("plsDisc066")]
        public double? PlsDisc066 { get; set; }
        [Column("plsDisc071")]
        public double? PlsDisc071 { get; set; }
        [Column("plsDisc072")]
        public double? PlsDisc072 { get; set; }
        [Column("plsDisc073")]
        public double? PlsDisc073 { get; set; }
        [Column("plsDisc074")]
        public double? PlsDisc074 { get; set; }
        [Column("plsDisc075")]
        public double? PlsDisc075 { get; set; }
        [Column("plsDisc076")]
        public double? PlsDisc076 { get; set; }
        [Column("plsDisc081")]
        public double? PlsDisc081 { get; set; }
        [Column("plsDisc082")]
        public double? PlsDisc082 { get; set; }
        [Column("plsDisc083")]
        public double? PlsDisc083 { get; set; }
        [Column("plsDisc084")]
        public double? PlsDisc084 { get; set; }
        [Column("plsDisc085")]
        public double? PlsDisc085 { get; set; }
        [Column("plsDisc086")]
        public double? PlsDisc086 { get; set; }
        [Column("plsDisc091")]
        public double? PlsDisc091 { get; set; }
        [Column("plsDisc092")]
        public double? PlsDisc092 { get; set; }
        [Column("plsDisc093")]
        public double? PlsDisc093 { get; set; }
        [Column("plsDisc094")]
        public double? PlsDisc094 { get; set; }
        [Column("plsDisc095")]
        public double? PlsDisc095 { get; set; }
        [Column("plsDisc096")]
        public double? PlsDisc096 { get; set; }
        [Column("plsDisc0101")]
        public double? PlsDisc0101 { get; set; }
        [Column("plsDisc0102")]
        public double? PlsDisc0102 { get; set; }
        [Column("plsDisc0103")]
        public double? PlsDisc0103 { get; set; }
        [Column("plsDisc0104")]
        public double? PlsDisc0104 { get; set; }
        [Column("plsDisc0105")]
        public double? PlsDisc0105 { get; set; }
        [Column("plsDisc0106")]
        public double? PlsDisc0106 { get; set; }
        [Column("plsDisc0111")]
        public double? PlsDisc0111 { get; set; }
        [Column("plsDisc0112")]
        public double? PlsDisc0112 { get; set; }
        [Column("plsDisc0113")]
        public double? PlsDisc0113 { get; set; }
        [Column("plsDisc0114")]
        public double? PlsDisc0114 { get; set; }
        [Column("plsDisc0115")]
        public double? PlsDisc0115 { get; set; }
        [Column("plsDisc0116")]
        public double? PlsDisc0116 { get; set; }
        [Column("plsDisc0121")]
        public double? PlsDisc0121 { get; set; }
        [Column("plsDisc0122")]
        public double? PlsDisc0122 { get; set; }
        [Column("plsDisc0123")]
        public double? PlsDisc0123 { get; set; }
        [Column("plsDisc0124")]
        public double? PlsDisc0124 { get; set; }
        [Column("plsDisc0125")]
        public double? PlsDisc0125 { get; set; }
        [Column("plsDisc0126")]
        public double? PlsDisc0126 { get; set; }
        [Column("plsDisc0131")]
        public double? PlsDisc0131 { get; set; }
        [Column("plsDisc0132")]
        public double? PlsDisc0132 { get; set; }
        [Column("plsDisc0133")]
        public double? PlsDisc0133 { get; set; }
        [Column("plsDisc0134")]
        public double? PlsDisc0134 { get; set; }
        [Column("plsDisc0135")]
        public double? PlsDisc0135 { get; set; }
        [Column("plsDisc0136")]
        public double? PlsDisc0136 { get; set; }
        [Column("plsDisc0141")]
        public double? PlsDisc0141 { get; set; }
        [Column("plsDisc0142")]
        public double? PlsDisc0142 { get; set; }
        [Column("plsDisc0143")]
        public double? PlsDisc0143 { get; set; }
        [Column("plsDisc0144")]
        public double? PlsDisc0144 { get; set; }
        [Column("plsDisc0145")]
        public double? PlsDisc0145 { get; set; }
        [Column("plsDisc0146")]
        public double? PlsDisc0146 { get; set; }
        [Column("plsDisc0151")]
        public double? PlsDisc0151 { get; set; }
        [Column("plsDisc0152")]
        public double? PlsDisc0152 { get; set; }
        [Column("plsDisc0153")]
        public double? PlsDisc0153 { get; set; }
        [Column("plsDisc0154")]
        public double? PlsDisc0154 { get; set; }
        [Column("plsDisc0155")]
        public double? PlsDisc0155 { get; set; }
        [Column("plsDisc0156")]
        public double? PlsDisc0156 { get; set; }
        [Column("plsDisc0161")]
        public double? PlsDisc0161 { get; set; }
        [Column("plsDisc0162")]
        public double? PlsDisc0162 { get; set; }
        [Column("plsDisc0163")]
        public double? PlsDisc0163 { get; set; }
        [Column("plsDisc0164")]
        public double? PlsDisc0164 { get; set; }
        [Column("plsDisc0165")]
        public double? PlsDisc0165 { get; set; }
        [Column("plsDisc0166")]
        public double? PlsDisc0166 { get; set; }
        [Column("plsDisc0171")]
        public double? PlsDisc0171 { get; set; }
        [Column("plsDisc0172")]
        public double? PlsDisc0172 { get; set; }
        [Column("plsDisc0173")]
        public double? PlsDisc0173 { get; set; }
        [Column("plsDisc0174")]
        public double? PlsDisc0174 { get; set; }
        [Column("plsDisc0175")]
        public double? PlsDisc0175 { get; set; }
        [Column("plsDisc0176")]
        public double? PlsDisc0176 { get; set; }
        [Column("plsDisc0181")]
        public double? PlsDisc0181 { get; set; }
        [Column("plsDisc0182")]
        public double? PlsDisc0182 { get; set; }
        [Column("plsDisc0183")]
        public double? PlsDisc0183 { get; set; }
        [Column("plsDisc0184")]
        public double? PlsDisc0184 { get; set; }
        [Column("plsDisc0185")]
        public double? PlsDisc0185 { get; set; }
        [Column("plsDisc0186")]
        public double? PlsDisc0186 { get; set; }
        [Column("plsDisc0191")]
        public double? PlsDisc0191 { get; set; }
        [Column("plsDisc0192")]
        public double? PlsDisc0192 { get; set; }
        [Column("plsDisc0193")]
        public double? PlsDisc0193 { get; set; }
        [Column("plsDisc0194")]
        public double? PlsDisc0194 { get; set; }
        [Column("plsDisc0195")]
        public double? PlsDisc0195 { get; set; }
        [Column("plsDisc0196")]
        public double? PlsDisc0196 { get; set; }
        [Column("plsDisc0201")]
        public double? PlsDisc0201 { get; set; }
        [Column("plsDisc0202")]
        public double? PlsDisc0202 { get; set; }
        [Column("plsDisc0203")]
        public double? PlsDisc0203 { get; set; }
        [Column("plsDisc0204")]
        public double? PlsDisc0204 { get; set; }
        [Column("plsDisc0205")]
        public double? PlsDisc0205 { get; set; }
        [Column("plsDisc0206")]
        public double? PlsDisc0206 { get; set; }
        [Column("plsDisc111")]
        public double? PlsDisc111 { get; set; }
        [Column("plsDisc112")]
        public double? PlsDisc112 { get; set; }
        [Column("plsDisc113")]
        public double? PlsDisc113 { get; set; }
        [Column("plsDisc114")]
        public double? PlsDisc114 { get; set; }
        [Column("plsDisc115")]
        public double? PlsDisc115 { get; set; }
        [Column("plsDisc116")]
        public double? PlsDisc116 { get; set; }
        [Column("plsDisc121")]
        public double? PlsDisc121 { get; set; }
        [Column("plsDisc122")]
        public double? PlsDisc122 { get; set; }
        [Column("plsDisc123")]
        public double? PlsDisc123 { get; set; }
        [Column("plsDisc124")]
        public double? PlsDisc124 { get; set; }
        [Column("plsDisc125")]
        public double? PlsDisc125 { get; set; }
        [Column("plsDisc126")]
        public double? PlsDisc126 { get; set; }
        [Column("plsDisc131")]
        public double? PlsDisc131 { get; set; }
        [Column("plsDisc132")]
        public double? PlsDisc132 { get; set; }
        [Column("plsDisc133")]
        public double? PlsDisc133 { get; set; }
        [Column("plsDisc134")]
        public double? PlsDisc134 { get; set; }
        [Column("plsDisc135")]
        public double? PlsDisc135 { get; set; }
        [Column("plsDisc136")]
        public double? PlsDisc136 { get; set; }
        [Column("plsDisc141")]
        public double? PlsDisc141 { get; set; }
        [Column("plsDisc142")]
        public double? PlsDisc142 { get; set; }
        [Column("plsDisc143")]
        public double? PlsDisc143 { get; set; }
        [Column("plsDisc144")]
        public double? PlsDisc144 { get; set; }
        [Column("plsDisc145")]
        public double? PlsDisc145 { get; set; }
        [Column("plsDisc146")]
        public double? PlsDisc146 { get; set; }
        [Column("plsDisc151")]
        public double? PlsDisc151 { get; set; }
        [Column("plsDisc152")]
        public double? PlsDisc152 { get; set; }
        [Column("plsDisc153")]
        public double? PlsDisc153 { get; set; }
        [Column("plsDisc154")]
        public double? PlsDisc154 { get; set; }
        [Column("plsDisc155")]
        public double? PlsDisc155 { get; set; }
        [Column("plsDisc156")]
        public double? PlsDisc156 { get; set; }
        [Column("plsDisc161")]
        public double? PlsDisc161 { get; set; }
        [Column("plsDisc162")]
        public double? PlsDisc162 { get; set; }
        [Column("plsDisc163")]
        public double? PlsDisc163 { get; set; }
        [Column("plsDisc164")]
        public double? PlsDisc164 { get; set; }
        [Column("plsDisc165")]
        public double? PlsDisc165 { get; set; }
        [Column("plsDisc166")]
        public double? PlsDisc166 { get; set; }
        [Column("plsDisc171")]
        public double? PlsDisc171 { get; set; }
        [Column("plsDisc172")]
        public double? PlsDisc172 { get; set; }
        [Column("plsDisc173")]
        public double? PlsDisc173 { get; set; }
        [Column("plsDisc174")]
        public double? PlsDisc174 { get; set; }
        [Column("plsDisc175")]
        public double? PlsDisc175 { get; set; }
        [Column("plsDisc176")]
        public double? PlsDisc176 { get; set; }
        [Column("plsDisc181")]
        public double? PlsDisc181 { get; set; }
        [Column("plsDisc182")]
        public double? PlsDisc182 { get; set; }
        [Column("plsDisc183")]
        public double? PlsDisc183 { get; set; }
        [Column("plsDisc184")]
        public double? PlsDisc184 { get; set; }
        [Column("plsDisc185")]
        public double? PlsDisc185 { get; set; }
        [Column("plsDisc186")]
        public double? PlsDisc186 { get; set; }
        [Column("plsDisc191")]
        public double? PlsDisc191 { get; set; }
        [Column("plsDisc192")]
        public double? PlsDisc192 { get; set; }
        [Column("plsDisc193")]
        public double? PlsDisc193 { get; set; }
        [Column("plsDisc194")]
        public double? PlsDisc194 { get; set; }
        [Column("plsDisc195")]
        public double? PlsDisc195 { get; set; }
        [Column("plsDisc196")]
        public double? PlsDisc196 { get; set; }
        [Column("plsDisc1201")]
        public double? PlsDisc1201 { get; set; }
        [Column("plsDisc1202")]
        public double? PlsDisc1202 { get; set; }
        [Column("plsDisc1203")]
        public double? PlsDisc1203 { get; set; }
        [Column("plsDisc1204")]
        public double? PlsDisc1204 { get; set; }
        [Column("plsDisc1205")]
        public double? PlsDisc1205 { get; set; }
        [Column("plsDisc1206")]
        public double? PlsDisc1206 { get; set; }
        [Column("plsDisc1211")]
        public double? PlsDisc1211 { get; set; }
        [Column("plsDisc1212")]
        public double? PlsDisc1212 { get; set; }
        [Column("plsDisc1213")]
        public double? PlsDisc1213 { get; set; }
        [Column("plsDisc1214")]
        public double? PlsDisc1214 { get; set; }
        [Column("plsDisc1215")]
        public double? PlsDisc1215 { get; set; }
        [Column("plsDisc1216")]
        public double? PlsDisc1216 { get; set; }
        [Column("plsDisc1221")]
        public double? PlsDisc1221 { get; set; }
        [Column("plsDisc1222")]
        public double? PlsDisc1222 { get; set; }
        [Column("plsDisc1223")]
        public double? PlsDisc1223 { get; set; }
        [Column("plsDisc1224")]
        public double? PlsDisc1224 { get; set; }
        [Column("plsDisc1225")]
        public double? PlsDisc1225 { get; set; }
        [Column("plsDisc1226")]
        public double? PlsDisc1226 { get; set; }
        [Column("plsDisc1231")]
        public double? PlsDisc1231 { get; set; }
        [Column("plsDisc1232")]
        public double? PlsDisc1232 { get; set; }
        [Column("plsDisc1233")]
        public double? PlsDisc1233 { get; set; }
        [Column("plsDisc1234")]
        public double? PlsDisc1234 { get; set; }
        [Column("plsDisc1235")]
        public double? PlsDisc1235 { get; set; }
        [Column("plsDisc1236")]
        public double? PlsDisc1236 { get; set; }
        [Column("plsDisc1241")]
        public double? PlsDisc1241 { get; set; }
        [Column("plsDisc1242")]
        public double? PlsDisc1242 { get; set; }
        [Column("plsDisc1243")]
        public double? PlsDisc1243 { get; set; }
        [Column("plsDisc1244")]
        public double? PlsDisc1244 { get; set; }
        [Column("plsDisc1245")]
        public double? PlsDisc1245 { get; set; }
        [Column("plsDisc1246")]
        public double? PlsDisc1246 { get; set; }
        [Column("plsDisc1251")]
        public double? PlsDisc1251 { get; set; }
        [Column("plsDisc1252")]
        public double? PlsDisc1252 { get; set; }
        [Column("plsDisc1253")]
        public double? PlsDisc1253 { get; set; }
        [Column("plsDisc1254")]
        public double? PlsDisc1254 { get; set; }
        [Column("plsDisc1255")]
        public double? PlsDisc1255 { get; set; }
        [Column("plsDisc1256")]
        public double? PlsDisc1256 { get; set; }
        [Column("plsDisc1261")]
        public double? PlsDisc1261 { get; set; }
        [Column("plsDisc1262")]
        public double? PlsDisc1262 { get; set; }
        [Column("plsDisc1263")]
        public double? PlsDisc1263 { get; set; }
        [Column("plsDisc1264")]
        public double? PlsDisc1264 { get; set; }
        [Column("plsDisc1265")]
        public double? PlsDisc1265 { get; set; }
        [Column("plsDisc1266")]
        public double? PlsDisc1266 { get; set; }
        [Column("plsDisc1271")]
        public double? PlsDisc1271 { get; set; }
        [Column("plsDisc1272")]
        public double? PlsDisc1272 { get; set; }
        [Column("plsDisc1273")]
        public double? PlsDisc1273 { get; set; }
        [Column("plsDisc1274")]
        public double? PlsDisc1274 { get; set; }
        [Column("plsDisc1275")]
        public double? PlsDisc1275 { get; set; }
        [Column("plsDisc1276")]
        public double? PlsDisc1276 { get; set; }
        [Column("plsDisc1281")]
        public double? PlsDisc1281 { get; set; }
        [Column("plsDisc1282")]
        public double? PlsDisc1282 { get; set; }
        [Column("plsDisc1283")]
        public double? PlsDisc1283 { get; set; }
        [Column("plsDisc1284")]
        public double? PlsDisc1284 { get; set; }
        [Column("plsDisc1285")]
        public double? PlsDisc1285 { get; set; }
        [Column("plsDisc1286")]
        public double? PlsDisc1286 { get; set; }
        [Column("plsDisc1291")]
        public double? PlsDisc1291 { get; set; }
        [Column("plsDisc1292")]
        public double? PlsDisc1292 { get; set; }
        [Column("plsDisc1293")]
        public double? PlsDisc1293 { get; set; }
        [Column("plsDisc1294")]
        public double? PlsDisc1294 { get; set; }
        [Column("plsDisc1295")]
        public double? PlsDisc1295 { get; set; }
        [Column("plsDisc1296")]
        public double? PlsDisc1296 { get; set; }
        [Column("plsDisc1301")]
        public double? PlsDisc1301 { get; set; }
        [Column("plsDisc1302")]
        public double? PlsDisc1302 { get; set; }
        [Column("plsDisc1303")]
        public double? PlsDisc1303 { get; set; }
        [Column("plsDisc1304")]
        public double? PlsDisc1304 { get; set; }
        [Column("plsDisc1305")]
        public double? PlsDisc1305 { get; set; }
        [Column("plsDisc1306")]
        public double? PlsDisc1306 { get; set; }
    }
}
