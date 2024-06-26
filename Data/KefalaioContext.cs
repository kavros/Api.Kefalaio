using Api.Kefalaio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

#nullable disable

namespace Data
{
    public class MyDataFailedImports
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string SCode { get; set; }
        public string Response { get; set; }
    }
    public partial class KefalaioContext : DbContext
    {

        private readonly string _connectionString;
        public virtual DbSet<MyDataFailedImports> FailedImports { get; set; }
        public virtual DbSet<ATestParastatika> ATestParastatikas { get; set; }
        public virtual DbSet<Abcanalysiscust> Abcanalysiscusts { get; set; }
        public virtual DbSet<Abcanalysisstock> Abcanalysisstocks { get; set; }
        public virtual DbSet<Agroagent> Agroagents { get; set; }
        public virtual DbSet<Agroparam> Agroparams { get; set; }
        public virtual DbSet<Apothemat> Apothemats { get; set; }
        public virtual DbSet<Asdepartement> Asdepartements { get; set; }
        public virtual DbSet<Asposition> Aspositions { get; set; }
        public virtual DbSet<Assettrndesc> Assettrndescs { get; set; }
        public virtual DbSet<Astable1> Astable1s { get; set; }
        public virtual DbSet<Astable2> Astable2s { get; set; }
        public virtual DbSet<Astable3> Astable3s { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Barcodeparam> Barcodeparams { get; set; }
        public virtual DbSet<Bcomment> Bcomments { get; set; }
        public virtual DbSet<Bglbridge> Bglbridges { get; set; }
        public virtual DbSet<Bglinfo> Bglinfos { get; set; }
        public virtual DbSet<Bgmast> Bgmasts { get; set; }
        public virtual DbSet<Bgtrn> Bgtrns { get; set; }
        public virtual DbSet<Bline2> Bline2s { get; set; }
        public virtual DbSet<Bm2c> Bm2cs { get; set; }
        public virtual DbSet<Bmast1> Bmast1s { get; set; }
        public virtual DbSet<Bmast2> Bmast2s { get; set; }
        public virtual DbSet<Browser> Browsers { get; set; }
        public virtual DbSet<Btodiscscenario> Btodiscscenarios { get; set; }
        public virtual DbSet<Bxgl> Bxgls { get; set; }
        public virtual DbSet<Cashdesktbl> Cashdesktbls { get; set; }
        public virtual DbSet<Cashflowparam> Cashflowparams { get; set; }
        public virtual DbSet<Cashregmyf> Cashregmyfs { get; set; }
        public virtual DbSet<Cashtrn> Cashtrns { get; set; }
        public virtual DbSet<Cashtrnparam> Cashtrnparams { get; set; }
        public virtual DbSet<Causetable> Causetables { get; set; }
        public virtual DbSet<Ccomment> Ccomments { get; set; }
        public virtual DbSet<Cextrafield> Cextrafields { get; set; }
        public virtual DbSet<Cgraph> Cgraphs { get; set; }
        public virtual DbSet<Cjrnl> Cjrnls { get; set; }
        public virtual DbSet<Clabel> Clabels { get; set; }
        public virtual DbSet<Cledger> Cledgers { get; set; }
        public virtual DbSet<Cmast> Cmasts { get; set; }
        public virtual DbSet<Colorsset> Colorssets { get; set; }
        public virtual DbSet<Companyinfo> Companyinfos { get; set; }
        public virtual DbSet<Companyparam> Companyparams { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Costostable> Costostables { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Cpopen> Cpopens { get; set; }
        public virtual DbSet<Ctrcashcode> Ctrcashcodes { get; set; }
        public virtual DbSet<Ctrcashcodesex> Ctrcashcodesexes { get; set; }
        public virtual DbSet<Ctrcustcode> Ctrcustcodes { get; set; }
        public virtual DbSet<Ctrn> Ctrns { get; set; }
        public virtual DbSet<Currentable> Currentables { get; set; }
        public virtual DbSet<Custfeat1> Custfeat1s { get; set; }
        public virtual DbSet<Custfeat2> Custfeat2s { get; set; }
        public virtual DbSet<Custtable1> Custtable1s { get; set; }
        public virtual DbSet<Custtable2> Custtable2s { get; set; }
        public virtual DbSet<Custtable3> Custtable3s { get; set; }
        public virtual DbSet<Custtaxkind> Custtaxkinds { get; set; }
        public virtual DbSet<Custtrndesc> Custtrndescs { get; set; }
        public virtual DbSet<Cwinlabel> Cwinlabels { get; set; }
        public virtual DbSet<Defaultvaluesfield> Defaultvaluesfields { get; set; }
        public virtual DbSet<Eokmast> Eokmasts { get; set; }
        public virtual DbSet<Extext> Extexts { get; set; }
        public virtual DbSet<Featname> Featnames { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<Fiscalprt> Fiscalprts { get; set; }
        public virtual DbSet<Forecast> Forecasts { get; set; }
        public virtual DbSet<Fytaaity> Fytaaities { get; set; }
        public virtual DbSet<Fytadimoi> Fytadimois { get; set; }
        public virtual DbSet<Fytakalliergeie> Fytakalliergeies { get; set; }
        public virtual DbSet<Fytamonade> Fytamonades { get; set; }
        public virtual DbSet<Fytaperifereium> Fytaperifereia { get; set; }
        public virtual DbSet<Fytaprescriber> Fytaprescribers { get; set; }
        public virtual DbSet<Gantijrnl> Gantijrnls { get; set; }
        public virtual DbSet<Gcomment> Gcomments { get; set; }
        public virtual DbSet<Gdprlog> Gdprlogs { get; set; }
        public virtual DbSet<Gdprprm> Gdprprms { get; set; }
        public virtual DbSet<Gextrafield> Gextrafields { get; set; }
        public virtual DbSet<Ggraph> Ggraphs { get; set; }
        public virtual DbSet<Gjrnl> Gjrnls { get; set; }
        public virtual DbSet<Glatable1> Glatable1s { get; set; }
        public virtual DbSet<Glatable2> Glatable2s { get; set; }
        public virtual DbSet<Glatable3> Glatable3s { get; set; }
        public virtual DbSet<Gledger> Gledgers { get; set; }
        public virtual DbSet<Glkform> Glkforms { get; set; }
        public virtual DbSet<Glreformcateg> Glreformcategs { get; set; }
        public virtual DbSet<Gltrndesc> Gltrndescs { get; set; }
        public virtual DbSet<Glvat> Glvats { get; set; }
        public virtual DbSet<Glvatrecordsparam> Glvatrecordsparams { get; set; }
        public virtual DbSet<Gmastb> Gmastbs { get; set; }
        public virtual DbSet<Gmastum> Gmasta { get; set; }
        public virtual DbSet<Gtrna> Gtrnas { get; set; }
        public virtual DbSet<Gtrnb> Gtrnbs { get; set; }
        public virtual DbSet<Gtskel> Gtskels { get; set; }
        public virtual DbSet<Gtskelln> Gtskellns { get; set; }
        public virtual DbSet<Holyday> Holydays { get; set; }
        public virtual DbSet<Idophone> Idophones { get; set; }
        public virtual DbSet<Indexingfield> Indexingfields { get; set; }
        public virtual DbSet<Inttranscategory> Inttranscategories { get; set; }
        public virtual DbSet<Intvrtl> Intvrtls { get; set; }
        public virtual DbSet<Irparameter> Irparameters { get; set; }
        public virtual DbSet<Itf14qty> Itf14qties { get; set; }
        public virtual DbSet<Itvrtlcategory> Itvrtlcategories { get; set; }
        public virtual DbSet<Kfsledger> Kfsledgers { get; set; }
        public virtual DbSet<Lcategtable> Lcategtables { get; set; }
        public virtual DbSet<Ledgerinfo> Ledgerinfos { get; set; }
        public virtual DbSet<Lextrafield> Lextrafields { get; set; }
        public virtual DbSet<Linkdatum> Linkdata { get; set; }
        public virtual DbSet<Linkdoc> Linkdocs { get; set; }
        public virtual DbSet<Llabel> Llabels { get; set; }
        public virtual DbSet<Lnledger> Lnledgers { get; set; }
        public virtual DbSet<Lnmast> Lnmasts { get; set; }
        public virtual DbSet<Lnmastum> Lnmasta { get; set; }
        public virtual DbSet<Lntrn> Lntrns { get; set; }
        public virtual DbSet<Lntrna> Lntrnas { get; set; }
        public virtual DbSet<Lotmast> Lotmasts { get; set; }
        public virtual DbSet<Lwinlabel> Lwinlabels { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Medicmb> Medicmbs { get; set; }
        public virtual DbSet<Medicrop> Medicrops { get; set; }
        public virtual DbSet<Medidra> Medidras { get; set; }
        public virtual DbSet<Medikal> Medikals { get; set; }
        public virtual DbSet<Mmast> Mmasts { get; set; }
        public virtual DbSet<Modem> Modems { get; set; }
        public virtual DbSet<Monthkepyoparam> Monthkepyoparams { get; set; }
        public virtual DbSet<Myfmonth> Myfmonths { get; set; }
        public virtual DbSet<Neledger> Neledgers { get; set; }
        public virtual DbSet<Nelmast> Nelmasts { get; set; }
        public virtual DbSet<Neltrn> Neltrns { get; set; }
        public virtual DbSet<Nemast> Nemasts { get; set; }
        public virtual DbSet<Nemcomment> Nemcomments { get; set; }
        public virtual DbSet<Nemkind> Nemkinds { get; set; }
        public virtual DbSet<Nemschedsetting> Nemschedsettings { get; set; }
        public virtual DbSet<Nepartpay> Nepartpays { get; set; }
        public virtual DbSet<Neportfolio> Neportfolios { get; set; }
        public virtual DbSet<Neprt> Neprts { get; set; }
        public virtual DbSet<Netbkind> Netbkinds { get; set; }
        public virtual DbSet<Netrkind> Netrkinds { get; set; }
        public virtual DbSet<Netrn> Netrns { get; set; }
        public virtual DbSet<Nlcost> Nlcosts { get; set; }
        public virtual DbSet<Nmcost> Nmcosts { get; set; }
        public virtual DbSet<Nmspec> Nmspecs { get; set; }
        public virtual DbSet<Nofpalaw> Nofpalaws { get; set; }
        public virtual DbSet<Nsalgroup> Nsalgroups { get; set; }
        public virtual DbSet<Nsallevel> Nsallevels { get; set; }
        public virtual DbSet<Nsalscale> Nsalscales { get; set; }
        public virtual DbSet<Nspalcode> Nspalcodes { get; set; }
        public virtual DbSet<Nspbook> Nspbooks { get; set; }
        public virtual DbSet<Nspcost> Nspcosts { get; set; }
        public virtual DbSet<Nspinvtype> Nspinvtypes { get; set; }
        public virtual DbSet<Nspmcst> Nspmcsts { get; set; }
        public virtual DbSet<Nspminv> Nspminvs { get; set; }
        public virtual DbSet<Nspphase> Nspphases { get; set; }
        public virtual DbSet<Nsptinv> Nsptinvs { get; set; }
        public virtual DbSet<Ntcost> Ntcosts { get; set; }
        public virtual DbSet<Ntspec> Ntspecs { get; set; }
        public virtual DbSet<Paymode> Paymodes { get; set; }
        public virtual DbSet<Pcomment> Pcomments { get; set; }
        public virtual DbSet<Pdfparam> Pdfparams { get; set; }
        public virtual DbSet<Perinf> Perinfs { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<Pextrafield> Pextrafields { get; set; }
        public virtual DbSet<Pgraph> Pgraphs { get; set; }
        public virtual DbSet<Pjrnl> Pjrnls { get; set; }
        public virtual DbSet<Plabel> Plabels { get; set; }
        public virtual DbSet<Pledger> Pledgers { get; set; }
        public virtual DbSet<Pmast> Pmasts { get; set; }
        public virtual DbSet<Pointsinvvalue> Pointsinvvalues { get; set; }
        public virtual DbSet<Pointsitemuse> Pointsitemuses { get; set; }
        public virtual DbSet<Pointsparameter> Pointsparameters { get; set; }
        public virtual DbSet<Pointsuselevel> Pointsuselevels { get; set; }
        public virtual DbSet<Pol1214param> Pol1214params { get; set; }
        public virtual DbSet<Prchordmi> Prchordmis { get; set; }
        public virtual DbSet<Prgmask> Prgmasks { get; set; }
        public virtual DbSet<Pricecheckertbl> Pricecheckertbls { get; set; }
        public virtual DbSet<Pricelistsarea> Pricelistsareas { get; set; }
        public virtual DbSet<Printrep> Printreps { get; set; }
        public virtual DbSet<Prlst> Prlsts { get; set; }
        public virtual DbSet<Productionstate> Productionstates { get; set; }
        public virtual DbSet<Prtinfo> Prtinfos { get; set; }
        public virtual DbSet<Prtpreconf> Prtpreconfs { get; set; }
        public virtual DbSet<Ptrn> Ptrns { get; set; }
        public virtual DbSet<Purchdesc> Purchdescs { get; set; }
        public virtual DbSet<Purchexpen> Purchexpens { get; set; }
        public virtual DbSet<Purchmi> Purchmis { get; set; }
        public virtual DbSet<Pwinlabel> Pwinlabels { get; set; }
        public virtual DbSet<Report1> Report1s { get; set; }
        public virtual DbSet<Report3> Report3s { get; set; }
        public virtual DbSet<Requiredfield> Requiredfields { get; set; }
        public virtual DbSet<Roundinfo> Roundinfos { get; set; }
        public virtual DbSet<Sacttrn> Sacttrns { get; set; }
        public virtual DbSet<Salesdesc> Salesdescs { get; set; }
        public virtual DbSet<Salesexpen> Salesexpens { get; set; }
        public virtual DbSet<Salesman> Salesmen { get; set; }
        public virtual DbSet<Salesmi> Salesmis { get; set; }
        public virtual DbSet<Scolor> Scolors { get; set; }
        public virtual DbSet<Scomment> Scomments { get; set; }
        public virtual DbSet<Scppric> Scpprics { get; set; }
        public virtual DbSet<Sdepartment> Sdepartments { get; set; }
        public virtual DbSet<Selectorfield> Selectorfields { get; set; }
        public virtual DbSet<Sellact> Sellacts { get; set; }
        public virtual DbSet<Sellactivity> Sellactivities { get; set; }
        public virtual DbSet<Sellactparam> Sellactparams { get; set; }
        public virtual DbSet<Sellactrelative> Sellactrelatives { get; set; }
        public virtual DbSet<Sellstatus> Sellstatuses { get; set; }
        public virtual DbSet<Sendmode> Sendmodes { get; set; }
        public virtual DbSet<Serial> Serials { get; set; }
        public virtual DbSet<Sextrafield> Sextrafields { get; set; }
        public virtual DbSet<Sglbridge> Sglbridges { get; set; }
        public virtual DbSet<Sglcost> Sglcosts { get; set; }
        public virtual DbSet<Sglgroup> Sglgroups { get; set; }
        public virtual DbSet<Sglproinfo> Sglproinfos { get; set; }
        public virtual DbSet<Sgraph> Sgraphs { get; set; }
        public virtual DbSet<Shortcut> Shortcuts { get; set; }
        public virtual DbSet<Slabel> Slabels { get; set; }
        public virtual DbSet<Sledger> Sledgers { get; set; }
        public virtual DbSet<Slordmi> Slordmis { get; set; }
        public virtual DbSet<Smast> Smasts { get; set; }
        public virtual DbSet<Smc> Smcs { get; set; }
        public virtual DbSet<Smcode> Smcodes { get; set; }
        public virtual DbSet<Smrel> Smrels { get; set; }
        public virtual DbSet<Smset> Smsets { get; set; }
        public virtual DbSet<Smweb> Smwebs { get; set; }
        public virtual DbSet<Snomast> Snomasts { get; set; }
        public virtual DbSet<Snotrn> Snotrns { get; set; }
        public virtual DbSet<Sseazon> Sseazons { get; set; }
        public virtual DbSet<Ssize> Ssizes { get; set; }
        public virtual DbSet<Sstore> Sstores { get; set; }
        public virtual DbSet<Stc> Stcs { get; set; }
        public virtual DbSet<Stockspace> Stockspaces { get; set; }
        public virtual DbSet<Stocktable1> Stocktable1s { get; set; }
        public virtual DbSet<Stocktable2> Stocktable2s { get; set; }
        public virtual DbSet<Stocktable3> Stocktable3s { get; set; }
        public virtual DbSet<Stocktax> Stocktaxes { get; set; }
        public virtual DbSet<Stockunit> Stockunits { get; set; }
        public virtual DbSet<Storfeat1> Storfeat1s { get; set; }
        public virtual DbSet<Storfeat2> Storfeat2s { get; set; }
        public virtual DbSet<Stortrndesc> Stortrndescs { get; set; }
        public virtual DbSet<Strn> Strns { get; set; }
        public virtual DbSet<Strninv> Strninvs { get; set; }
        public virtual DbSet<Subsid> Subsids { get; set; }
        public virtual DbSet<Suplfeat1> Suplfeat1s { get; set; }
        public virtual DbSet<Suplfeat2> Suplfeat2s { get; set; }
        public virtual DbSet<Supltrndescr> Supltrndescrs { get; set; }
        public virtual DbSet<Suppltable1> Suppltable1s { get; set; }
        public virtual DbSet<Suppltable2> Suppltable2s { get; set; }
        public virtual DbSet<Suppltable3> Suppltable3s { get; set; }
        public virtual DbSet<Suppltaxkind> Suppltaxkinds { get; set; }
        public virtual DbSet<Swinlabel> Swinlabels { get; set; }
        public virtual DbSet<Sysrsrvjob> Sysrsrvjobs { get; set; }
        public virtual DbSet<Tpetrelaioparam> Tpetrelaioparams { get; set; }
        public virtual DbSet<Tracejob> Tracejobs { get; set; }
        public virtual DbSet<Trade> Trades { get; set; }
        public virtual DbSet<Tradeline> Tradelines { get; set; }
        public virtual DbSet<Tradingcause> Tradingcauses { get; set; }
        public virtual DbSet<Transfor> Transfors { get; set; }
        public virtual DbSet<Travelinfo> Travelinfos { get; set; }
        public virtual DbSet<Trnum> Trnums { get; set; }
        public virtual DbSet<Txtlabel> Txtlabels { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Usermsg> Usermsgs { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }
        public virtual DbSet<Vcomment> Vcomments { get; set; }
        public virtual DbSet<VersionInfo> VersionInfos { get; set; }
        public virtual DbSet<Vglbridge> Vglbridges { get; set; }
        public virtual DbSet<Vglinfo> Vglinfos { get; set; }
        public virtual DbSet<Vline2> Vline2s { get; set; }
        public virtual DbSet<Vm2c> Vm2cs { get; set; }
        public virtual DbSet<Vmast1> Vmast1s { get; set; }
        public virtual DbSet<Vmast2> Vmast2s { get; set; }
        public virtual DbSet<Vtodiscscenario> Vtodiscscenarios { get; set; }
        public virtual DbSet<Vxgl> Vxgls { get; set; }
        public virtual DbSet<Webitemcategory> Webitemcategories { get; set; }
        public virtual DbSet<Webmanufacturer> Webmanufacturers { get; set; }
        public virtual DbSet<Xncurr> Xncurrs { get; set; }

        public KefalaioContext(DbContextOptions<KefalaioContext> options, IOptions<Configuration> configuration)
            : base(options)
        {
            _connectionString = configuration.Value.ConnectionString;
        }

        
        public KefalaioContext(DbContextOptions<KefalaioContext> options): base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(_connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Greek_CI_AI");

            modelBuilder.Entity<ATestParastatika>(entity =>
            {
                entity.ToView("a_testParastatika");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SfactCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sname)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StAitia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StAnamoni)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCertOper)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCombined)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCustSuppl)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDimos)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDosage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDrastiki)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StForCncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StFreeText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StInSpray)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StKalliergeia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StLotCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPerifereia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescLineId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescriber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPressureApplied)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StQuanPsekDial)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StStadio)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StrSearchCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });
            modelBuilder.Entity<MyDataFailedImports>(x =>
            {
                x.HasKey(x => x.Id);
                x.ToTable("myDataFailedImports");
                x.Property(e => e.SCode)
                .IsUnicode(false)
                .UseCollation("Greek_BIN");

            });
            modelBuilder.Entity<Abcanalysiscust>(entity =>
            {
                entity.HasKey(e => e.AbcFileId)
                    .HasName("abcCustByPos");

                entity.Property(e => e.AbcFileId).ValueGeneratedNever();

                entity.Property(e => e.AbcName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Abcanalysisstock>(entity =>
            {
                entity.HasKey(e => e.AbcFileId)
                    .HasName("abcStockByPos");

                entity.Property(e => e.AbcFileId).ValueGeneratedNever();

                entity.Property(e => e.AbcName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Agroagent>(entity =>
            {
                entity.HasKey(e => e.AgFileId)
                    .HasName("AgentByPos");

                entity.Property(e => e.AgFileId).ValueGeneratedNever();

                entity.Property(e => e.AgAgentName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Agroparam>(entity =>
            {
                entity.HasKey(e => e.AgFileId)
                    .HasName("agBypos");

                entity.Property(e => e.AgFileId).ValueGeneratedNever();

                entity.Property(e => e.AgExtraOthExpTrans).UseCollation("Greek_BIN");

                entity.Property(e => e.AgFpacode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.AgInvoicesSet).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Apothemat>(entity =>
            {
                entity.HasKey(e => e.ApoFileId)
                    .HasName("apoByPos");

                entity.Property(e => e.ApoFileId).ValueGeneratedNever();

                entity.Property(e => e.ApoName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ApoValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Asdepartement>(entity =>
            {
                entity.HasKey(e => e.AdpFileId)
                    .HasName("adpByPos");

                entity.Property(e => e.AdpFileId).ValueGeneratedNever();

                entity.Property(e => e.AdpCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.AdpName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Asposition>(entity =>
            {
                entity.HasKey(e => e.ApsFileId)
                    .HasName("apsByPos");

                entity.Property(e => e.ApsFileId).ValueGeneratedNever();

                entity.Property(e => e.ApsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ApsName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Assettrndesc>(entity =>
            {
                entity.HasKey(e => e.AtdFileId)
                    .HasName("atdByPos");

                entity.Property(e => e.AtdFileId).ValueGeneratedNever();

                entity.Property(e => e.AtdDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.AtdSeira)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.AtdTrConf)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Astable1>(entity =>
            {
                entity.HasKey(e => e.AsFileIdNo1)
                    .HasName("As1ByPos");

                entity.Property(e => e.AsFileIdNo1).ValueGeneratedNever();

                entity.Property(e => e.AsDesc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Astable2>(entity =>
            {
                entity.HasKey(e => e.AsFileIdNo2)
                    .HasName("As2ByPos");

                entity.Property(e => e.AsFileIdNo2).ValueGeneratedNever();

                entity.Property(e => e.AsDesc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Astable3>(entity =>
            {
                entity.HasKey(e => e.AsFileIdNo3)
                    .HasName("As3ByPos");

                entity.Property(e => e.AsFileIdNo3).ValueGeneratedNever();

                entity.Property(e => e.AsDesc3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.BanFileIdNo)
                    .HasName("BanksByPos");

                entity.Property(e => e.BanFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.BankDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BankGlcod)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Barcodeparam>(entity =>
            {
                entity.HasKey(e => e.BcpFileId)
                    .HasName("bcpByPos");

                entity.Property(e => e.BcpFileId).ValueGeneratedNever();

                entity.Property(e => e.Bcode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bcprefix)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Eanquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto0).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facto9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Praxi0)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Praxi9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quant).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bcomment>(entity =>
            {
                entity.HasKey(e => e.BcmFileId)
                    .HasName("bcmByPos");

                entity.Property(e => e.BcmFileId).ValueGeneratedNever();

                entity.Property(e => e.BcmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Bglbridge>(entity =>
            {
                entity.HasKey(e => e.BgbFileId)
                    .HasName("bgbByPos");

                entity.Property(e => e.BgbFileId).ValueGeneratedNever();

                entity.Property(e => e.BgbCpCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgbGcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Bglinfo>(entity =>
            {
                entity.HasKey(e => e.BgliFileId)
                    .HasName("bgliByPos");

                entity.Property(e => e.BgliFileId).ValueGeneratedNever();

                entity.Property(e => e.BgliEfkcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgliNoVatcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Bgmast>(entity =>
            {
                entity.HasKey(e => e.BgfileId)
                    .HasName("BGByFileId");

                entity.Property(e => e.Bgcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bgcomment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Bgdescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgdescrSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgtrnCodeSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Bgtrn>(entity =>
            {
                entity.HasKey(e => e.BgtrFileId)
                    .HasName("BGTrByFileId");

                entity.Property(e => e.BgtrCalcedQt1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedQt9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrCalcedVal9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrDim1Code)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgtrDim2Code)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BgtrPrevQt1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevQt9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrPrevVal9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealQt9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal11).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal12).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BgtrRealVal9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bline2>(entity =>
            {
                entity.HasKey(e => e.PloFileId)
                    .HasName("ploByPos");

                entity.Property(e => e.PloComm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PloDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloDisc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloDisc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloLot)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PloPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloSearchCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PloTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.PloWeight).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bm2c>(entity =>
            {
                entity.HasKey(e => e.Bm2csFileId)
                    .HasName("bm2csByFileId");

                entity.Property(e => e.Bm2csSize10Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize10Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize11Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize12Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize13Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize14Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize15Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize16Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize17Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize18Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize19Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize1Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize20Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize2Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize3Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize4Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize5Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize6Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize7Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize8Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bm2csSize9Colour9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bmast1>(entity =>
            {
                entity.HasKey(e => e.PdFileId)
                    .HasName("pdByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdAfm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdCommision).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdCostVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdCurrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdDeadWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdDelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdDetailFile).UseCollation("Greek_BIN");

                entity.Property(e => e.PdDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdDocum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdEdicode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdEeccrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdEecdeliv)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdEecexp).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdEeckind)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdExpenses1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdExpenses2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdGrossVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdGrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdPerDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdReceivable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdRelDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdSentToShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdSubsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxAgentCopiesSign1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxAgentCopiesSign2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxAgentCopiesSign3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxAgentCopiesSign4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxAgentSign)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTaxCard)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdTotEta).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdTotVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatval).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl13).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl14).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl15).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl16).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl17).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl18).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl19).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl20).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl21).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl22).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl23).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl24).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl25).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl26).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl27).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl28).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl29).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl30).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl31).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl32).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl33).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl34).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl35).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl36).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl37).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl38).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl39).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl40).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVatvl9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdVlPrVat1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat13).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat14).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat15).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat16).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat17).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat18).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat19).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat20).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat21).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat22).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat23).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat24).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat25).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat26).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat27).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat28).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat29).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat30).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat31).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat32).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat33).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat34).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat35).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat36).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat37).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat38).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat39).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat40).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdVlPrVat9).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PdTrNums)
                    .WithMany(p => p.Bmast1s)
                    .HasForeignKey(d => d.PdTrNumsId)
                    .HasConstraintName("pdToNums");
            });

            modelBuilder.Entity<Bmast2>(entity =>
            {
                entity.HasKey(e => e.PoFileId)
                    .HasName("pofxByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoAfm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoCommision).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoCostVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoCurrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoDeadWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoDelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoDocum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoEdicode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoEeccrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoEecdeliv)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoEecexp).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoEeckind)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoExpenses1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoExpenses2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoGrossVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoGrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoPerDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoReceivable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoRelDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoSentToShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoSubsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxAgentCopiesSign1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxAgentCopiesSign2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxAgentCopiesSign3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxAgentCopiesSign4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxAgentSign)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTaxCard)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoTotEta).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoTotVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatval).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl13).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl14).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl15).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl16).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl17).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl18).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl19).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl20).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl21).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl22).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl23).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl24).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl25).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl26).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl27).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl28).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl29).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl30).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl31).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl32).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl33).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl34).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl35).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl36).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl37).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl38).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl39).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl40).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVatvl9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PoVlPrVat1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat13).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat14).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat15).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat16).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat17).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat18).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat19).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat20).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat21).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat22).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat23).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat24).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat25).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat26).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat27).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat28).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat29).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat30).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat31).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat32).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat33).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat34).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat35).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat36).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat37).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat38).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat39).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat40).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoVlPrVat9).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PoTrNums)
                    .WithMany(p => p.Bmast2s)
                    .HasForeignKey(d => d.PoTrNumsId)
                    .HasConstraintName("pofxToNums");
            });

            modelBuilder.Entity<Browser>(entity =>
            {
                entity.Property(e => e.BrowData).UseCollation("Greek_BIN");

                entity.Property(e => e.BrowFilters).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Btodiscscenario>(entity =>
            {
                entity.HasKey(e => e.BdsFileId)
                    .HasName("bdsByPos");

                entity.Property(e => e.BdsFileId).ValueGeneratedNever();

                entity.Property(e => e.BdsDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BdsLimit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsLimit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc10).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc5).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc6).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc7).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc8).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdsPrc9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bxgl>(entity =>
            {
                entity.HasKey(e => e.BglFileId)
                    .HasName("bglByPos");

                entity.Property(e => e.BglFileId).ValueGeneratedNever();

                entity.Property(e => e.InvSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Xglc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Xgld)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cashdesktbl>(entity =>
            {
                entity.HasKey(e => e.CdFileId)
                    .HasName("CashDeskByPos");

                entity.Property(e => e.CdFileId).ValueGeneratedNever();

                entity.Property(e => e.CdCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CdDescription)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cashflowparam>(entity =>
            {
                entity.HasKey(e => e.CfgFileId)
                    .HasName("cfgByPos");

                entity.Property(e => e.CfgFileId).ValueGeneratedNever();

                entity.Property(e => e.CfgAct1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgAct7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode23)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode24)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode25)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode26)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgCode27)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CfgComm7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cashregmyf>(entity =>
            {
                entity.HasKey(e => e.CrFileId)
                    .HasName("CashRegByPos");

                entity.Property(e => e.CrFileId).ValueGeneratedNever();

                entity.Property(e => e.CrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CrTaxCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cashtrn>(entity =>
            {
                entity.HasKey(e => e.CashTrnFileId)
                    .HasName("CashTrnByPosition");

                entity.Property(e => e.CashTrnValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Cashtrnparam>(entity =>
            {
                entity.HasKey(e => e.CtpFileId)
                    .HasName("ctpByPos");

                entity.Property(e => e.CtpFileId).ValueGeneratedNever();

                entity.Property(e => e.CtpData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Causetable>(entity =>
            {
                entity.HasKey(e => e.CauFileId)
                    .HasName("cauByPos");

                entity.Property(e => e.CauFileId).ValueGeneratedNever();

                entity.Property(e => e.CauName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ccomment>(entity =>
            {
                entity.HasKey(e => e.CcmFileId)
                    .HasName("ccmByPos");

                entity.Property(e => e.CcmFileId).ValueGeneratedNever();

                entity.Property(e => e.CcmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cextrafield>(entity =>
            {
                entity.HasKey(e => e.CxfFileId)
                    .HasName("cxfByPos");

                entity.Property(e => e.CxfFileId).ValueGeneratedNever();

                entity.Property(e => e.CxfName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cgraph>(entity =>
            {
                entity.HasKey(e => e.CgrFileId)
                    .HasName("cgrByPos");

                entity.Property(e => e.CgrFileId).ValueGeneratedNever();

                entity.Property(e => e.CgrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cjrnl>(entity =>
            {
                entity.HasKey(e => e.CjrFileId)
                    .HasName("cjrByPos");

                entity.Property(e => e.CjrFileId).ValueGeneratedNever();

                entity.Property(e => e.CjrDesc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CjrTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Clabel>(entity =>
            {
                entity.HasKey(e => e.ClblFileId)
                    .HasName("clblByPos");

                entity.Property(e => e.ClblFileId).ValueGeneratedNever();

                entity.Property(e => e.ClblData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cledger>(entity =>
            {
                entity.HasKey(e => e.ClgFileId)
                    .HasName("clgByPos");

                entity.Property(e => e.ClgFileId).ValueGeneratedNever();

                entity.Property(e => e.ClgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cmast>(entity =>
            {
                entity.HasKey(e => e.CFileId)
                    .HasName("cByPos");

                entity.Property(e => e.C2Code)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CAddress11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CAddress12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CAddress21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CAddress22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CArea1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CArea2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CBank1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CBank2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CCredLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CDelivMan)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CDimos)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CDiscPcnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CDoy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CDoycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEdiCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEdiPcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEinvEmail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEinvEncKey)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEmail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CEuro).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFcopenCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFcopenDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFcyearCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFcyearDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFeatCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CFeatCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CForCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CForSales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CFrgnCurr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CHouseCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CInvVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CInvVal0).HasDefaultValueSql("((0))");

                entity.Property(e => e.CInvVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CManager)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CMobile)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CNonPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.COpenCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPayables).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPerifereia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CPersales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPersales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPhone1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CPhone2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CPointsFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPointsUsedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPrevYearCr).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPrevYearDb).HasDefaultValueSql("((0))");

                entity.Property(e => e.CProfession)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CProfits).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CPysales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CRelCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CRepCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CTelex)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CWebsite)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CZipCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CZipCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CmonthCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.CmonthDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.CopenDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.CyearCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.CyearDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.DelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Colorsset>(entity =>
            {
                entity.HasKey(e => e.ClsetFileId)
                    .HasName("clSetBypos");

                entity.Property(e => e.ClsetFileId).ValueGeneratedNever();

                entity.Property(e => e.ClSetColorCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode23)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode24)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetColorCode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ClSetDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Companyinfo>(entity =>
            {
                entity.HasKey(e => e.CmiFileId)
                    .HasName("cmiByPos");

                entity.Property(e => e.CmiFileId).ValueGeneratedNever();

                entity.Property(e => e.Aat)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Addr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Addr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Addr3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Afm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Arec)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ccafm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ccountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.City)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CodeDoy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CodePart)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Country)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Customs)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Doy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Gemhnumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Gemhnumber50)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Hfefolder)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Job)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Maenumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Maenumber25)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Name1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Name2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Name3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Part)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RdIdNumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RpDoy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RpDoycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RpFatherName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RpName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Telef)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Theme)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Tname)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrAddr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrAfm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrCity)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrFax)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrTelef)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrTk)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Trname)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Trsyn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.WallPaper)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Companyparam>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("cmppByPos");

                entity.Property(e => e.FileId).ValueGeneratedNever();

                entity.Property(e => e.B1default)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.B2default)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.BInvoicesLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.BInvoicesLimitSet).UseCollation("Greek_BIN");

                entity.Property(e => e.CmCopyToOtherComps).UseCollation("Greek_BIN");

                entity.Property(e => e.EanBcprefix)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GVataccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlPagExportPath)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GsisAfmservPassword)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GsisAfmservUserName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MinagricVinvSet).UseCollation("Greek_BIN");

                entity.Property(e => e.PmCopyToOtherComps).UseCollation("Greek_BIN");

                entity.Property(e => e.SAutoQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmCopyToOtherComps).UseCollation("Greek_BIN");

                entity.Property(e => e.VEinvExclude).UseCollation("Greek_BIN");

                entity.Property(e => e.VInvoicesLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.VInvoicesLimitSet).UseCollation("Greek_BIN");

                entity.Property(e => e.VRtlValidInvoicesSet).UseCollation("Greek_BIN");

                entity.Property(e => e.VZeroPriceInvoices).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.CnFileId)
                    .HasName("cnByPos");

                entity.Property(e => e.CnComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CnEmail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CnName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CnNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CnPhone1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CnPhone2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.CncFile)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CncFileId)
                    .HasConstraintName("cnToCm");

                entity.HasOne(d => d.CnmFile)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CnmFileId)
                    .HasConstraintName("cnToMM");

                entity.HasOne(d => d.CnpFile)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CnpFileId)
                    .HasConstraintName("cnToPm");
            });

            modelBuilder.Entity<Costostable>(entity =>
            {
                entity.HasKey(e => e.CtcCostId)
                    .HasName("ctcByPos");

                entity.Property(e => e.CtcCostId).ValueGeneratedNever();

                entity.Property(e => e.CtcDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcFlagsNew)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcLogGt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcVat)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcVatGt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.CountEok)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CountName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CountryCo)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cpopen>(entity =>
            {
                entity.HasKey(e => e.CpoFileId)
                    .HasName("cpoByPos");

                entity.Property(e => e.CpoCoverage).HasDefaultValueSql("((0))");

                entity.Property(e => e.CpoDrCover).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ctrcashcode>(entity =>
            {
                entity.HasKey(e => e.CtcFileId)
                    .HasName("ctcdByPos");

                entity.Property(e => e.CtcFileId).ValueGeneratedNever();

                entity.Property(e => e.CtcTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ctrcashcodesex>(entity =>
            {
                entity.HasKey(e => e.CtcExFileId)
                    .HasName("ctcExdByPos");

                entity.Property(e => e.CtcExFileId).ValueGeneratedNever();

                entity.Property(e => e.CtcExDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcExTrns1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcExTrns2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcExTrns3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcExTrns4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ctrcustcode>(entity =>
            {
                entity.HasKey(e => e.CtcFileId)
                    .HasName("ctccByPos");

                entity.Property(e => e.CtcFileId).ValueGeneratedNever();

                entity.Property(e => e.CtcData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ctrn>(entity =>
            {
                entity.HasKey(e => e.CtFileId)
                    .HasName("ctByPosition");

                entity.Property(e => e.CtComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtExpValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtFccovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtFcexpVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtFcfpaval).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtFcnetVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtForCncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtKepyoValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtKepyoVat).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtPointsUsedValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtPrevUseValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtSubsCoder)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtVatvalue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.CFile)
                    .WithMany(p => p.Ctrns)
                    .HasForeignKey(d => d.CFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctToCm");

                entity.HasOne(d => d.CtNemOriginNavigation)
                    .WithMany(p => p.Ctrns)
                    .HasForeignKey(d => d.CtNemOrigin)
                    .HasConstraintName("ctToNemast");

                entity.HasOne(d => d.CtTransKindNavigation)
                    .WithMany(p => p.Ctrns)
                    .HasForeignKey(d => d.CtTransKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctToCustTrnDesc");

                entity.HasOne(d => d.CtVm1originNavigation)
                    .WithMany(p => p.Ctrns)
                    .HasForeignKey(d => d.CtVm1origin)
                    .HasConstraintName("ctToVMaster1");

                entity.HasOne(d => d.CtVm2originNavigation)
                    .WithMany(p => p.Ctrns)
                    .HasForeignKey(d => d.CtVm2origin)
                    .HasConstraintName("ctToVMaster2");
            });

            modelBuilder.Entity<Currentable>(entity =>
            {
                entity.HasKey(e => e.XnCurrenId)
                    .HasName("xnByPos");

                entity.Property(e => e.XnCurrenId).ValueGeneratedNever();

                entity.Property(e => e.XnCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.XnDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.XnIsocode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.XnLname)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.XnLrate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Custfeat1>(entity =>
            {
                entity.HasKey(e => e.CFeatureId)
                    .HasName("ct1ByPos");

                entity.Property(e => e.CFeatureId).ValueGeneratedNever();

                entity.Property(e => e.CFeature1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CTdescr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Custfeat2>(entity =>
            {
                entity.HasKey(e => e.CFeatureId)
                    .HasName("ct2ByPos");

                entity.Property(e => e.CFeatureId).ValueGeneratedNever();

                entity.Property(e => e.CFeature2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CTdescr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Custtable1>(entity =>
            {
                entity.HasKey(e => e.CuFileIdNo1)
                    .HasName("Cu1ByPos");

                entity.Property(e => e.CuFileIdNo1).ValueGeneratedNever();

                entity.Property(e => e.CustDesc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Custtable2>(entity =>
            {
                entity.HasKey(e => e.CuFileIdNo2)
                    .HasName("Cu2ByPos");

                entity.Property(e => e.CuFileIdNo2).ValueGeneratedNever();

                entity.Property(e => e.CustDesc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Custtable3>(entity =>
            {
                entity.HasKey(e => e.CuFileIdNo3)
                    .HasName("Cu3ByPos");

                entity.Property(e => e.CuFileIdNo3).ValueGeneratedNever();

                entity.Property(e => e.CustDesc3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Custtaxkind>(entity =>
            {
                entity.HasKey(e => e.CTaxId)
                    .HasName("cTaxByPos");

                entity.Property(e => e.CTaxId).ValueGeneratedNever();

                entity.Property(e => e.CTaxLimitVal).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Custtrndesc>(entity =>
            {
                entity.HasKey(e => e.CtTransKind)
                    .HasName("custTrnByPos");

                entity.Property(e => e.CtTransKind).ValueGeneratedNever();

                entity.Property(e => e.CtDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtcGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Cwinlabel>(entity =>
            {
                entity.HasKey(e => e.CwlFileId)
                    .HasName("cwlByPos");

                entity.Property(e => e.CwlFileId).ValueGeneratedNever();

                entity.Property(e => e.CwlData).UseCollation("Greek_BIN");

                entity.Property(e => e.CwlDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Defaultvaluesfield>(entity =>
            {
                entity.HasKey(e => e.DfvFileId)
                    .HasName("DfvByPos");

                entity.Property(e => e.DfvFileId).ValueGeneratedNever();

                entity.Property(e => e.DfvData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Eokmast>(entity =>
            {
                entity.HasKey(e => e.EokFileId)
                    .HasName("eokByPos");

                entity.Property(e => e.EokFileId).ValueGeneratedNever();

                entity.Property(e => e.EokCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.EokMm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.EokName1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.EokName2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.EokName3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.EokName4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Extext>(entity =>
            {
                entity.HasKey(e => e.EtxFileId)
                    .HasName("etxByPos");

                entity.Property(e => e.EtxData).UseCollation("Greek_BIN");

                entity.HasOne(d => d.CFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.CFileId)
                    .HasConstraintName("etxTocm");

                entity.HasOne(d => d.CtFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.CtFileId)
                    .HasConstraintName("etxToct");

                entity.HasOne(d => d.GFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.GFileId)
                    .HasConstraintName("etxTogm");

                entity.HasOne(d => d.GFileIdOldNavigation)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.GFileIdOld)
                    .HasConstraintName("etxTogmo");

                entity.HasOne(d => d.GtFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.GtFileId)
                    .HasConstraintName("etxTogt");

                entity.HasOne(d => d.GtFileIdOldNavigation)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.GtFileIdOld)
                    .HasConstraintName("etxTogto");

                entity.HasOne(d => d.LFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.LFileId)
                    .HasConstraintName("etxTolm");

                entity.HasOne(d => d.LFileIdOldNavigation)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.LFileIdOld)
                    .HasConstraintName("etxTolmo");

                entity.HasOne(d => d.LoFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.LoFileId)
                    .HasConstraintName("etxTolo");

                entity.HasOne(d => d.LtFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.LtFileId)
                    .HasConstraintName("etxTolt");

                entity.HasOne(d => d.LtFileIdOldNavigation)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.LtFileIdOld)
                    .HasConstraintName("etxTolto");

                entity.HasOne(d => d.MFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.MFileId)
                    .HasConstraintName("etxTomm");

                entity.HasOne(d => d.PFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.PFileId)
                    .HasConstraintName("etxTopm");

                entity.HasOne(d => d.PdFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.PdFileId)
                    .HasConstraintName("etxTopd");

                entity.HasOne(d => d.PloFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.PloFileId)
                    .HasConstraintName("etxToplo");

                entity.HasOne(d => d.PoFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.PoFileId)
                    .HasConstraintName("etxTopo");

                entity.HasOne(d => d.PtFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.PtFileId)
                    .HasConstraintName("etxTopt");

                entity.HasOne(d => d.SFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.SFileId)
                    .HasConstraintName("etxTosfx");

                entity.HasOne(d => d.SdFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.SdFileId)
                    .HasConstraintName("etxTosd");

                entity.HasOne(d => d.SloFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.SloFileId)
                    .HasConstraintName("etxToslo");

                entity.HasOne(d => d.SnFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.SnFileId)
                    .HasConstraintName("etxTosn");

                entity.HasOne(d => d.SoFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.SoFileId)
                    .HasConstraintName("etxToso");

                entity.HasOne(d => d.StFile)
                    .WithMany(p => p.Extexts)
                    .HasForeignKey(d => d.StFileId)
                    .HasConstraintName("etxTost");
            });

            modelBuilder.Entity<Featname>(entity =>
            {
                entity.HasKey(e => e.FtnFileId)
                    .HasName("ftnByPos");

                entity.Property(e => e.FtnFileId).ValueGeneratedNever();

                entity.Property(e => e.FtnDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.HasKey(e => e.FltFileId)
                    .HasName("fltByPos");

                entity.Property(e => e.FltCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FltData).UseCollation("Greek_BIN");

                entity.Property(e => e.FltDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fiscalprt>(entity =>
            {
                entity.HasKey(e => e.FprFileId)
                    .HasName("fprByPos");

                entity.Property(e => e.FprFileId).ValueGeneratedNever();

                entity.Property(e => e.FprComments1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprComments2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprComments3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprComments4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprComments5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprDescription)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprDriver)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprFootLines1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprFootLines2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprFootLines3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprFootLines4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprFootLines5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprHeadLines8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprMonitorData).UseCollation("Greek_BIN");

                entity.Property(e => e.FprMovePayWays1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprMovePayWays2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprMovePayWays3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprMovePayWays4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprPayWays1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprPayWays2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprPayWays3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprPayWays4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprSaveReceiptPro)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprScrollingMessage1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprScrollingMessage2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes100)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes23)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes24)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes25)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes26)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes27)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes28)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes29)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes30)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes31)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes32)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes33)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes34)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes35)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes36)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes37)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes38)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes39)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes40)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes41)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes42)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes43)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes44)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes45)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes46)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes47)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes48)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes49)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes50)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes51)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes52)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes53)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes54)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes55)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes56)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes57)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes58)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes59)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes60)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes61)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes62)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes63)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes64)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes65)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes66)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes67)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes68)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes69)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes70)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes71)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes72)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes73)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes74)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes75)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes76)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes77)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes78)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes79)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes80)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes81)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes82)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes83)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes84)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes85)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes86)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes87)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes88)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes89)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes90)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes91)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes92)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes93)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes94)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes95)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes96)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes97)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes98)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FprVatRatesCodes99)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Forecast>(entity =>
            {
                entity.HasKey(e => e.FrcFileId)
                    .HasName("frcByPos");

                entity.Property(e => e.FrcFileId).ValueGeneratedNever();

                entity.Property(e => e.FrcName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FrcValue1).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue10).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue11).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue12).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue2).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue3).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue4).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue5).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue6).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue7).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue8).HasDefaultValueSql("((0))");

                entity.Property(e => e.FrcValue9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Fytaaity>(entity =>
            {
                entity.HasKey(e => e.AitFileId)
                    .HasName("aitByPos");

                entity.Property(e => e.AitFileId).ValueGeneratedNever();

                entity.Property(e => e.AitCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.AitDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fytadimoi>(entity =>
            {
                entity.HasKey(e => e.DimFileId)
                    .HasName("dimByPos");

                entity.Property(e => e.DimFileId).ValueGeneratedNever();

                entity.Property(e => e.DimCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DimDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DimPerifCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fytakalliergeie>(entity =>
            {
                entity.HasKey(e => e.KalFileId)
                    .HasName("kalByPos");

                entity.Property(e => e.KalFileId).ValueGeneratedNever();

                entity.Property(e => e.KalCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.KalDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fytamonade>(entity =>
            {
                entity.HasKey(e => e.MonFileId)
                    .HasName("monByPos");

                entity.Property(e => e.MonFileId).ValueGeneratedNever();

                entity.Property(e => e.MonCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MonDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fytaperifereium>(entity =>
            {
                entity.HasKey(e => e.PerifFileId)
                    .HasName("perifByPos");

                entity.Property(e => e.PerifFileId).ValueGeneratedNever();

                entity.Property(e => e.PerifCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PerifDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Fytaprescriber>(entity =>
            {
                entity.HasKey(e => e.PreFileId)
                    .HasName("preByPos");

                entity.Property(e => e.PreFileId).ValueGeneratedNever();

                entity.Property(e => e.PreAm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PreCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PreDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PreUsername)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PreVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gantijrnl>(entity =>
            {
                entity.HasKey(e => e.GajFileId)
                    .HasName("gajByPos");

                entity.Property(e => e.GajFileId).ValueGeneratedNever();

                entity.Property(e => e.GajCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajCode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajDescr9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GajSign9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gcomment>(entity =>
            {
                entity.HasKey(e => e.GcmFileId)
                    .HasName("gcmByPos");

                entity.Property(e => e.GcmFileId).ValueGeneratedNever();

                entity.Property(e => e.GcmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gdprlog>(entity =>
            {
                entity.HasKey(e => e.GdlFileId)
                    .HasName("gdlByPos");

                entity.Property(e => e.GdlData).UseCollation("Greek_BIN");

                entity.Property(e => e.GdlName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GdlNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gdprprm>(entity =>
            {
                entity.HasKey(e => e.GdpFileId)
                    .HasName("GdpByPos");

                entity.Property(e => e.GdpFileId).ValueGeneratedNever();

                entity.Property(e => e.GdpFields).UseCollation("Greek_BIN");

                entity.Property(e => e.GdpJobs).UseCollation("Greek_BIN");

                entity.Property(e => e.GdpUsers).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gextrafield>(entity =>
            {
                entity.HasKey(e => e.GxfFileId)
                    .HasName("gxfByPos");

                entity.Property(e => e.GxfFileId).ValueGeneratedNever();

                entity.Property(e => e.GxfName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ggraph>(entity =>
            {
                entity.HasKey(e => e.GgrFileId)
                    .HasName("ggrByPos");

                entity.Property(e => e.GgrFileId).ValueGeneratedNever();

                entity.Property(e => e.GgrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gjrnl>(entity =>
            {
                entity.HasKey(e => e.GjrFileId)
                    .HasName("gjrByPos");

                entity.Property(e => e.GjrFileId).ValueGeneratedNever();

                entity.Property(e => e.GjrName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glatable1>(entity =>
            {
                entity.HasKey(e => e.GlfileIdNo1)
                    .HasName("GL1ByPos");

                entity.Property(e => e.GlfileIdNo1).ValueGeneratedNever();

                entity.Property(e => e.Gladesc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glatable2>(entity =>
            {
                entity.HasKey(e => e.GlfileIdNo2)
                    .HasName("GL2ByPos");

                entity.Property(e => e.GlfileIdNo2).ValueGeneratedNever();

                entity.Property(e => e.Gladesc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glatable3>(entity =>
            {
                entity.HasKey(e => e.GlfileIdNo3)
                    .HasName("GL3ByPos");

                entity.Property(e => e.GlfileIdNo3).ValueGeneratedNever();

                entity.Property(e => e.Gladesc3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gledger>(entity =>
            {
                entity.HasKey(e => e.GlgFileId)
                    .HasName("glgByPos");

                entity.Property(e => e.GlgFileId).ValueGeneratedNever();

                entity.Property(e => e.GlgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glkform>(entity =>
            {
                entity.HasKey(e => e.GlfId)
                    .HasName("glfByID");

                entity.Property(e => e.GlfFieldDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlfFieldValue)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlfFormName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glreformcateg>(entity =>
            {
                entity.HasKey(e => e.RfId)
                    .HasName("rfByPos");

                entity.Property(e => e.RfId).ValueGeneratedNever();

                entity.Property(e => e.RfCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RfCredGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RfDebGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RfDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RfFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.RfTaxDiffGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gltrndesc>(entity =>
            {
                entity.HasKey(e => e.GtTransKind)
                    .HasName("GltdByPos");

                entity.Property(e => e.GtTransKind).ValueGeneratedNever();

                entity.Property(e => e.GtFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtblAnti)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtblData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glvat>(entity =>
            {
                entity.HasKey(e => e.GlvFileId)
                    .HasName("glvByPos");

                entity.Property(e => e.GlvFileId).ValueGeneratedNever();

                entity.Property(e => e.GlvBsellCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvBspsellCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvEokAlc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvEokAlc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvEokc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvFcc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvFcc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvSpcode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvSpcode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat23)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat31)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat32)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVat33)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVsellCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GlvVspsellCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GvlEokc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Glvatrecordsparam>(entity =>
            {
                entity.HasKey(e => e.RFileId)
                    .HasName("rByPos");

                entity.Property(e => e.RFileId).ValueGeneratedNever();

                entity.Property(e => e.CustCollTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.CustInvTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.SuplInvTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.SuplPayTransSet).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gmastb>(entity =>
            {
                entity.HasKey(e => e.GFileId)
                    .HasName("gByPos");

                entity.Property(e => e.CBankAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DetailFile).UseCollation("Greek_BIN");

                entity.Property(e => e.GAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GArea)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GBalTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalanceCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalanceDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBank)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCompName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GDoycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GExcludeIsolCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeIsolDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopenCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopenDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyearCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyearDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyrTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyrTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GForeCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GInvNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.GInvValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.GManager)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GOpenAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GOpenCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenInvNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenInvVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenTmpdeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsCrd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsCrd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GReformCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTaxOffice)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTelex)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GYearCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GYearDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GZipCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GcpMobile)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Gcpemail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GmEuro).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Gmastum>(entity =>
            {
                entity.HasKey(e => e.GFileId)
                    .HasName("goByPos");

                entity.Property(e => e.CBankAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DetailFile).UseCollation("Greek_BIN");

                entity.Property(e => e.GAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GArea)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GBalTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalanceCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBalanceDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GBank)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCompName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GDoyCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GExcludeIsolCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeIsolDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatCredit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GExcludeVatDebit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopenCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcopenDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyearCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyearDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyrTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GFcyrTmpDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GForeCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GForeDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GInvNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.GInvValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.GManager)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GOpenAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GOpenCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenInvNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenInvVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenTmpCrd).HasDefaultValueSql("((0))");

                entity.Property(e => e.GOpenTmpdeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerDebit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpCr9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPerTmpDb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrCrd9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsCrd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsCrd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GPrYrsDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GReformCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTaxOffice)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GTelex)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.GUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GYearCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GYearDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GZipCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GcpMobile)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Gcpemail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GmEuro).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Gtrna>(entity =>
            {
                entity.HasKey(e => e.GtFileId)
                    .HasName("gtoByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtCurrency).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtDocNum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtFcDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtFccredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtMyfval).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtReformCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtReformValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtrMyfVatVal).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.GmFile)
                    .WithMany(p => p.Gtrnas)
                    .HasForeignKey(d => d.GmFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gtoToGm");

                entity.HasOne(d => d.GtTransKindNavigation)
                    .WithMany(p => p.Gtrnas)
                    .HasForeignKey(d => d.GtTransKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gtoToGtbl");
            });

            modelBuilder.Entity<Gtrnb>(entity =>
            {
                entity.HasKey(e => e.GtFileId)
                    .HasName("gtByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtCurrency).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtDocNum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtFcDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtFccredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtMyfval).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtReformCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GtReformValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.GtrMyfVatVal).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.GmFile)
                    .WithMany(p => p.Gtrnbs)
                    .HasForeignKey(d => d.GmFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gtTogm");

                entity.HasOne(d => d.GtTransKindNavigation)
                    .WithMany(p => p.Gtrnbs)
                    .HasForeignKey(d => d.GtTransKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gtToGtbl");
            });

            modelBuilder.Entity<Gtskel>(entity =>
            {
                entity.HasKey(e => e.GsFileId)
                    .HasName("gtsByPos");

                entity.Property(e => e.GsFileId).ValueGeneratedNever();

                entity.Property(e => e.GsComm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GsComm2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GsTitle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Gtskelln>(entity =>
            {
                entity.HasKey(e => e.GslFileId)
                    .HasName("gslByPos");

                entity.Property(e => e.GslCalc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.GslgCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.GsSkelPosNavigation)
                    .WithMany(p => p.Gtskellns)
                    .HasForeignKey(d => d.GsSkelPos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gslTogtSkel");
            });

            modelBuilder.Entity<Holyday>(entity =>
            {
                entity.HasKey(e => e.HdaFileId)
                    .HasName("hdaByPos");

                entity.Property(e => e.HdaFileId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Idophone>(entity =>
            {
                entity.HasKey(e => e.IphnFileId)
                    .HasName("iphnByID");

                entity.Property(e => e.IphnPhone)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Iphnsubsid)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Indexingfield>(entity =>
            {
                entity.HasKey(e => e.IndexingIdNo)
                    .HasName("indfldbypos");

                entity.Property(e => e.IndexingIdNo).ValueGeneratedNever();

                entity.Property(e => e.IndexingColData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Inttranscategory>(entity =>
            {
                entity.HasKey(e => e.IntTrnFileId)
                    .HasName("intTrnCatBypos");

                entity.Property(e => e.IntTrnFileId).ValueGeneratedNever();

                entity.Property(e => e.IntTrnCatDescription)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.IntTrnCatId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.IntTrncatImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Intvrtl>(entity =>
            {
                entity.HasKey(e => e.IrFileId)
                    .HasName("irByPos");

                entity.Property(e => e.IrCatId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.IrImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.IrQuant).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Irparameter>(entity =>
            {
                entity.HasKey(e => e.IrparamsFileId)
                    .HasName("irParamsByPos");

                entity.Property(e => e.IrparamsFileId).ValueGeneratedNever();

                entity.Property(e => e.IrparamsData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Itf14qty>(entity =>
            {
                entity.HasKey(e => e.I14FileId)
                    .HasName("i14ByPos");

                entity.Property(e => e.I14FileId).ValueGeneratedNever();

                entity.Property(e => e.I14Qty1).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty10).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty11).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty12).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty13).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty14).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty15).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty16).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty17).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty18).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty19).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty2).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty20).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty21).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty22).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty23).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty24).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty25).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty26).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty27).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty28).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty29).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty3).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty30).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty31).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty32).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty33).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty34).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty35).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty36).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty37).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty38).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty39).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty4).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty40).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty41).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty42).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty43).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty44).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty45).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty46).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty47).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty48).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty49).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty5).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty50).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty6).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty7).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty8).HasDefaultValueSql("((0))");

                entity.Property(e => e.I14Qty9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Itvrtlcategory>(entity =>
            {
                entity.HasKey(e => e.SrtlFileId)
                    .HasName("itvrByPos");

                entity.Property(e => e.SrtlFileId).ValueGeneratedNever();

                entity.Property(e => e.SrtlcatDescription)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SrtlcatId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SrtlcatImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Kfsledger>(entity =>
            {
                entity.HasKey(e => e.KflFileId)
                    .HasName("kflByPos");

                entity.Property(e => e.KflFileId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lcategtable>(entity =>
            {
                entity.HasKey(e => e.LcFileId)
                    .HasName("lcByPos");

                entity.Property(e => e.LcFileId).ValueGeneratedNever();

                entity.Property(e => e.LcCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LcF1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LcF2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LcMfact).HasDefaultValueSql("((0))");

                entity.Property(e => e.LcName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ledgerinfo>(entity =>
            {
                entity.HasKey(e => e.LgiFileId)
                    .HasName("lgiByPos");

                entity.Property(e => e.LgiFileId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lextrafield>(entity =>
            {
                entity.HasKey(e => e.LxfFileId)
                    .HasName("lxfByPos");

                entity.Property(e => e.LxfFileId).ValueGeneratedNever();

                entity.Property(e => e.LxfName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Linkdatum>(entity =>
            {
                entity.HasKey(e => e.LndFileId)
                    .HasName("lndByPos");

                entity.Property(e => e.LndFileId).ValueGeneratedNever();

                entity.Property(e => e.LndData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Linkdoc>(entity =>
            {
                entity.HasKey(e => e.LdcFileId)
                    .HasName("ldcByPos");

                entity.Property(e => e.LdcCaption)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LdcFileName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LdcPath)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Llabel>(entity =>
            {
                entity.HasKey(e => e.LlblFileId)
                    .HasName("llblByPos");

                entity.Property(e => e.LlblFileId).ValueGeneratedNever();

                entity.Property(e => e.LlblData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Lnledger>(entity =>
            {
                entity.HasKey(e => e.LglFileId)
                    .HasName("lglByPos");

                entity.Property(e => e.LglFileId).ValueGeneratedNever();

                entity.Property(e => e.LglName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LglTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Lnmast>(entity =>
            {
                entity.HasKey(e => e.LFileId)
                    .HasName("LnBylFileId");

                entity.Property(e => e.LAnalCode0)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCalced1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced10).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced13).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced14).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced15).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced16).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced17).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced18).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced19).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced20).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced22).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced23).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced24).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced25).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced26).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced27).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced28).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced29).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced30).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced31).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced32).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced33).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced34).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced35).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced36).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced37).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced38).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced39).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced40).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced41).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced42).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced43).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced44).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced45).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced46).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced47).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced48).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced9).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCommitVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.LConnect)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LDepart)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LDeprinfo11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo110).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo111).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo112).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo113).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo114).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo115).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo13).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo14).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo15).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo16).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo17).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo18).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo19).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo210).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo211).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo212).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo213).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo214).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo215).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo22).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo23).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo24).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo25).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo26).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo27).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo28).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo29).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEpixor).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEuroDepr).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEuroValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LGcodes1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LInCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.LInstCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LInstVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.LName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LNumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LPerCent0).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent10).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent9).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPosit)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.LQuant1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LRepair).HasDefaultValueSql("((0))");

                entity.Property(e => e.LSerial)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LService).HasDefaultValueSql("((0))");

                entity.Property(e => e.LTaxValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUtlAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LYpolimat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linscomp1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsvalue1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue4).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Lnmastum>(entity =>
            {
                entity.HasKey(e => e.LFileId)
                    .HasName("LnoBylFileId");

                entity.Property(e => e.LAnalCode0)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LAnalCode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCalced1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced10).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced13).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced14).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced15).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced16).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced17).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced18).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced19).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced20).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced22).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced23).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced24).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced25).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced26).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced27).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced28).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced29).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced30).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced31).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced32).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced33).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced34).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced35).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced36).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced37).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced38).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced39).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced40).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced41).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced42).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced43).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced44).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced45).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced46).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced47).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced48).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCalced9).HasDefaultValueSql("((0))");

                entity.Property(e => e.LCateg)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LCommitVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.LConnect)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LDepart)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LDeprinfo11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo110).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo111).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo112).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo113).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo114).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo115).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo13).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo14).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo15).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo16).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo17).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo18).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo19).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo210).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo211).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo212).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo213).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo214).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo215).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo22).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo23).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo24).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo25).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo26).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo27).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo28).HasDefaultValueSql("((0))");

                entity.Property(e => e.LDeprinfo29).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEpixor).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEuroDepr).HasDefaultValueSql("((0))");

                entity.Property(e => e.LEuroValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LFacts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LGcodes1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LGcodes9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LInCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.LInstCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LInstVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.LName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LNumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LPerCent0).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent10).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPerCent9).HasDefaultValueSql("((0))");

                entity.Property(e => e.LPosit)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.LQuant1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LRepair).HasDefaultValueSql("((0))");

                entity.Property(e => e.LSerial)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LService).HasDefaultValueSql("((0))");

                entity.Property(e => e.LTaxValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LUtlAccount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LYpolimat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linscomp1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linscomp4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linskind4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsno4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Linsvalue1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Linsvalue4).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Lntrn>(entity =>
            {
                entity.HasKey(e => e.LtFileId)
                    .HasName("LtByltFileId");

                entity.Property(e => e.LtEuroDepr).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtEuroValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaAposV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaAposV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaKthsV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaKthsV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyval1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyval2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced110).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced111).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced112).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced210).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced211).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced212).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced25).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced26).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced27).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced28).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced29).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcause)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltcomm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LtdeprVa1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtdeprVa2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltdoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltfact).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltfpa)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltprevv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtstartV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtstartV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltstartqu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltsupcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltsuppl)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Lttaxval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lttaxxnv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lttollval).HasDefaultValueSql("((0))");

                entity.Property(e => e.LttollxnV).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltvalue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltxn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltxnprice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltxnvalu).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LtkindNavigation)
                    .WithMany(p => p.Lntrns)
                    .HasForeignKey(d => d.Ltkind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ltToAtd");

                entity.HasOne(d => d.LtmposNavigation)
                    .WithMany(p => p.Lntrns)
                    .HasForeignKey(d => d.Ltmpos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ltToLm");
            });

            modelBuilder.Entity<Lntrna>(entity =>
            {
                entity.HasKey(e => e.LtFileId)
                    .HasName("LtoByltFileId");

                entity.Property(e => e.LtEuroDepr).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtEuroValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaAposV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaAposV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaKthsV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaKthsV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV21).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtMaposV22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyval1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltbuyval2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced110).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced111).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced112).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced210).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced211).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced212).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced25).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced26).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced27).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced28).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcalced29).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltcause)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltcomm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.LtdeprVa1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtdeprVa2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltdoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltfact).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltfpa)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltgcodes3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltprevv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprevv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltprice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtstartV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LtstartV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltstartqu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltsupcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltsuppl)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Lttaxval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lttaxxnv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdd1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdd2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltthirdv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lttollval).HasDefaultValueSql("((0))");

                entity.Property(e => e.LttollxnV).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltvalue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltxn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Ltxnprice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ltxnvalu).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LtkindNavigation)
                    .WithMany(p => p.Lntrnas)
                    .HasForeignKey(d => d.Ltkind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ltoToAtd");

                entity.HasOne(d => d.LtmposNavigation)
                    .WithMany(p => p.Lntrnas)
                    .HasForeignKey(d => d.Ltmpos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ltoToLmo");
            });

            modelBuilder.Entity<Lotmast>(entity =>
            {
                entity.HasKey(e => e.LoFileId)
                    .HasName("loByPos");

                entity.Property(e => e.SLotComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SLotorder).HasDefaultValueSql("((0))");

                entity.Property(e => e.SLotwait).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlApogr1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlApogr2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlInvoice)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlOrigin)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlOtherInfo)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlPin).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlPlace)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlQ1in).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlQ1out).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlQ2in).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlQ2out).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlQualityClass)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlRemain1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlRemain2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlValApog).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlVariety)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlVin).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlVout).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Lwinlabel>(entity =>
            {
                entity.HasKey(e => e.LwlFileId)
                    .HasName("lwlByPos");

                entity.Property(e => e.LwlFileId).ValueGeneratedNever();

                entity.Property(e => e.LwlData).UseCollation("Greek_BIN");

                entity.Property(e => e.LwlDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasKey(e => e.MedFileId)
                    .HasName("medByPos");

                entity.Property(e => e.MedCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MedFullName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MedName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MedNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Medicmb>(entity =>
            {
                entity.HasKey(e => e.CmbFileId)
                    .HasName("cmbByPos");

                entity.Property(e => e.CmbDrastCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CmbKalCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CmbMedCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Medicrop>(entity =>
            {
                entity.HasKey(e => e.MdcFileId)
                    .HasName("mdcByPos");

                entity.Property(e => e.MdcCrop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Medidra>(entity =>
            {
                entity.HasKey(e => e.MddFileId)
                    .HasName("mddByPos");

                entity.Property(e => e.MddCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MddDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Medikal>(entity =>
            {
                entity.HasKey(e => e.MdkFileId)
                    .HasName("mdkByPos");

                entity.Property(e => e.MdkCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MdkDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Mmast>(entity =>
            {
                entity.HasKey(e => e.MFileId)
                    .HasName("mmByPosition");

                entity.Property(e => e.MAddress1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MAddress2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MArea)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MCodeBranch)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MCourier)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MDeiCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.MDoy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MDoycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MEdiCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MManager)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MMobile)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MTelef1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MTelex)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MZip)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.McpPayWay)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.McpSendWay)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MeMail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Mtelef2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.CFile)
                    .WithMany(p => p.Mmasts)
                    .HasForeignKey(d => d.CFileId)
                    .HasConstraintName("mmToCm");

                entity.HasOne(d => d.PFile)
                    .WithMany(p => p.Mmasts)
                    .HasForeignKey(d => d.PFileId)
                    .HasConstraintName("mmToPm");
            });

            modelBuilder.Entity<Modem>(entity =>
            {
                entity.HasKey(e => e.MdmFileId)
                    .HasName("mdmByPos");

                entity.Property(e => e.MdmFileId).ValueGeneratedNever();

                entity.Property(e => e.MdmDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MdmFileDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MdmPhone1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MdmPhone2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MdmPhone3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Monthkepyoparam>(entity =>
            {
                entity.HasKey(e => e.MKfileId)
                    .HasName("mKByPos");

                entity.Property(e => e.MKfileId).ValueGeneratedNever();

                entity.Property(e => e.MKfolder)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MKsiteUser)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MKwsuser)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MkBranch)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MkSitePass)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.MkWspass)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Myfmonth>(entity =>
            {
                entity.HasKey(e => e.MyfFileId)
                    .HasName("myfByPos");
            });

            modelBuilder.Entity<Neledger>(entity =>
            {
                entity.HasKey(e => e.ElgFileId)
                    .HasName("elgByPos");

                entity.Property(e => e.ElgFileId).ValueGeneratedNever();

                entity.Property(e => e.ElgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ElgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nelmast>(entity =>
            {
                entity.HasKey(e => e.NlmFileId)
                    .HasName("nlmByPos");

                entity.Property(e => e.NlmDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NlmShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.NlmTrNums)
                    .WithMany(p => p.Nelmasts)
                    .HasForeignKey(d => d.NlmTrNumsId)
                    .HasConstraintName("nlmToNums");
            });

            modelBuilder.Entity<Neltrn>(entity =>
            {
                entity.HasKey(e => e.NltFileId)
                    .HasName("nltByPos");
            });

            modelBuilder.Entity<Nemast>(entity =>
            {
                entity.HasKey(e => e.NemFileId)
                    .HasName("nemByPos");

                entity.Property(e => e.NemAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.NemCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemComment1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemEuro).HasDefaultValueSql("((0))");

                entity.Property(e => e.NemExn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemExnAmoun).HasDefaultValueSql("((0))");

                entity.Property(e => e.NemNumber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemPayamt).HasDefaultValueSql("((0))");

                entity.Property(e => e.NemShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemacCount)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NembCity)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NembCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NembcityDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemeAmount1).HasDefaultValueSql("((0))");

                entity.Property(e => e.NemgetDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemowAddr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemowName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemowTel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NemowVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NempbAddr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NempbName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NempbTel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NempbVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nemcomment>(entity =>
            {
                entity.HasKey(e => e.NmcmFileId)
                    .HasName("nmcmByPos");

                entity.Property(e => e.NmcmFileId).ValueGeneratedNever();

                entity.Property(e => e.NmcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nemkind>(entity =>
            {
                entity.HasKey(e => e.NemKindsId)
                    .HasName("NemKindsByPos");

                entity.Property(e => e.NemKindsId).ValueGeneratedNever();

                entity.Property(e => e.CredCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Data)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DebCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.IntRate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nemschedsetting>(entity =>
            {
                entity.HasKey(e => e.NschId)
                    .HasName("nschByPos");

                entity.Property(e => e.NschId).ValueGeneratedNever();

                entity.Property(e => e.NschKindSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NschReminderStateSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NschStateSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NschTitleSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nepartpay>(entity =>
            {
                entity.HasKey(e => e.NepFileId)
                    .HasName("neppByPos");

                entity.Property(e => e.NepFileId).ValueGeneratedNever();

                entity.Property(e => e.NepDset)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NepMinPart).HasDefaultValueSql("((0))");

                entity.Property(e => e.NepRndPart).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Neportfolio>(entity =>
            {
                entity.HasKey(e => e.NepFileId)
                    .HasName("nepByPos");

                entity.Property(e => e.NepFileId).ValueGeneratedNever();

                entity.Property(e => e.NepName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Neprt>(entity =>
            {
                entity.HasKey(e => e.NelgFileId)
                    .HasName("nelgByPos");

                entity.Property(e => e.NelgFileId).ValueGeneratedNever();

                entity.Property(e => e.NelgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NelgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Netbkind>(entity =>
            {
                entity.HasKey(e => e.NetbPos)
                    .HasName("netbByPos");

                entity.Property(e => e.NetbPos).ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrKinds)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Netrkind>(entity =>
            {
                entity.HasKey(e => e.NeTrKindsId)
                    .HasName("netrnKindsByPos");

                entity.Property(e => e.NeTrKindsId).ValueGeneratedNever();

                entity.Property(e => e.CredCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Data)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DebCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Netrn>(entity =>
            {
                entity.HasKey(e => e.NetFileId)
                    .HasName("netrnByPos");

                entity.Property(e => e.NetrnAmoun1).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetrnAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetrnComme)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnComme1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnGetDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnGlCred)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnGlDeb)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnThrdAddr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnThrdName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnThrdTel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnThrdVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Netrnexn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NetrnexnAma).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nlcost>(entity =>
            {
                entity.HasKey(e => e.ClFileId)
                    .HasName("nlcByPosition");
            });

            modelBuilder.Entity<Nmcost>(entity =>
            {
                entity.HasKey(e => e.CmFileId)
                    .HasName("mcByFileId");

                entity.Property(e => e.CmDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CmDocument)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CmGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nmspec>(entity =>
            {
                entity.HasKey(e => e.NspecFileId)
                    .HasName("nsmByFileId");

                entity.Property(e => e.NspecCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NspecComm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NspecFyra).HasDefaultValueSql("((0))");

                entity.Property(e => e.NspecHcost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NspecName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NspecNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NspecQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.NspecSpend).HasDefaultValueSql("((0))");

                entity.Property(e => e.NspecWhours).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nofpalaw>(entity =>
            {
                entity.HasKey(e => e.NflFileId)
                    .HasName("nflByPos");

                entity.Property(e => e.NflFileId).ValueGeneratedNever();

                entity.Property(e => e.NflCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.NflDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nsalgroup>(entity =>
            {
                entity.HasKey(e => e.SgpFileId)
                    .HasName("sgpByPos");

                entity.Property(e => e.SgpFileId).ValueGeneratedNever();

                entity.Property(e => e.SgpDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SgpPerc0).HasDefaultValueSql("((0))");

                entity.Property(e => e.SgpPerc1).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nsallevel>(entity =>
            {
                entity.HasKey(e => e.SlvFileId)
                    .HasName("slvByPos");

                entity.Property(e => e.SlvFileId).ValueGeneratedNever();

                entity.Property(e => e.SlvDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nsalscale>(entity =>
            {
                entity.HasKey(e => e.SscFileId)
                    .HasName("sscByPos");

                entity.Property(e => e.SscFileId).ValueGeneratedNever();

                entity.Property(e => e.SscLimit0).HasDefaultValueSql("((0))");

                entity.Property(e => e.SscLimit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SscPerc0).HasDefaultValueSql("((0))");

                entity.Property(e => e.SscPerc1).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nspalcode>(entity =>
            {
                entity.HasKey(e => e.SacFileId)
                    .HasName("sacByPos");

                entity.Property(e => e.SacFileId).ValueGeneratedNever();

                entity.Property(e => e.SacLaborAcc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SacMaterAcc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SacOtherAcc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nspbook>(entity =>
            {
                entity.HasKey(e => e.SboFileId)
                    .HasName("sboByPos");

                entity.Property(e => e.SboFileId).ValueGeneratedNever();

                entity.Property(e => e.SboData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nspcost>(entity =>
            {
                entity.HasKey(e => e.ScoFileId)
                    .HasName("scoByPos");

                entity.Property(e => e.ScoFileId).ValueGeneratedNever();

                entity.Property(e => e.ScoCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ScoDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nspinvtype>(entity =>
            {
                entity.HasKey(e => e.SitFileId)
                    .HasName("sitByPos");

                entity.Property(e => e.SitFileId).ValueGeneratedNever();

                entity.Property(e => e.SitDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SitValidTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nspmcst>(entity =>
            {
                entity.HasKey(e => e.PrcFileId)
                    .HasName("prcByPos");

                entity.Property(e => e.PrcScFactor1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor100).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor13).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor14).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor15).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor16).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor17).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor18).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor19).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor20).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor21).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor22).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor23).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor24).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor25).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor26).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor27).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor28).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor29).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor30).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor31).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor32).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor33).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor34).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor35).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor36).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor37).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor38).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor39).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor40).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor41).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor42).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor43).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor44).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor45).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor46).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor47).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor48).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor49).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor50).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor51).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor52).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor53).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor54).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor55).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor56).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor57).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor58).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor59).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor60).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor61).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor62).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor63).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor64).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor65).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor66).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor67).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor68).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor69).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor70).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor71).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor72).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor73).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor74).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor75).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor76).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor77).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor78).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor79).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor80).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor81).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor82).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor83).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor84).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor85).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor86).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor87).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor88).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor89).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor90).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor91).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor92).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor93).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor94).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor95).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor96).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor97).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor98).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrcScFactor99).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Nspminv>(entity =>
            {
                entity.HasKey(e => e.PrmFileId)
                    .HasName("prmByPos");

                entity.Property(e => e.PrmAprLabCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmAprOthCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrmComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrmDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrmFyra).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmLotCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrmQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmUpdLabCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmUpdOthCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrmWeight).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PrmTrNums)
                    .WithMany(p => p.Nspminvs)
                    .HasForeignKey(d => d.PrmTrNumsId)
                    .HasConstraintName("prmToNums");
            });

            modelBuilder.Entity<Nspphase>(entity =>
            {
                entity.HasKey(e => e.SphFileId)
                    .HasName("sphByPos");

                entity.Property(e => e.SphFileId).ValueGeneratedNever();

                entity.Property(e => e.SphDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Nsptinv>(entity =>
            {
                entity.HasKey(e => e.PrtFileId)
                    .HasName("prtByPos");

                entity.Property(e => e.PrtComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrtComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrtCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtDiffCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtFyra).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtLotcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PrtPhInvPerc).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtPrDiffCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrtWeigth).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ntcost>(entity =>
            {
                entity.HasKey(e => e.CtFileId)
                    .HasName("ntcByPosition");

                entity.Property(e => e.CtCglCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtCurr).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtDocument)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtFpaval).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtGlFpa)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtXnCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CtXnFpaval).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtXnValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ntspec>(entity =>
            {
                entity.HasKey(e => e.NstFileId)
                    .HasName("nstByPos");

                entity.Property(e => e.NstFyra).HasDefaultValueSql("((0))");

                entity.Property(e => e.NstQuant).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Paymode>(entity =>
            {
                entity.Property(e => e.PayModeId).ValueGeneratedNever();

                entity.Property(e => e.CpmAdvance).HasDefaultValueSql("((0))");

                entity.Property(e => e.CpmDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CpmEdiName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CpmGcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CpmPsDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayMode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pcomment>(entity =>
            {
                entity.HasKey(e => e.PcmFileId)
                    .HasName("pcmByPos");

                entity.Property(e => e.PcmFileId).ValueGeneratedNever();

                entity.Property(e => e.PcmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pdfparam>(entity =>
            {
                entity.HasKey(e => e.PdfFileId)
                    .HasName("pdfpByPos");

                entity.Property(e => e.PdfFileId).ValueGeneratedNever();

                entity.Property(e => e.PdfData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Perinf>(entity =>
            {
                entity.HasKey(e => e.PiFileId)
                    .HasName("pinfByPos");

                entity.Property(e => e.PiFileId).ValueGeneratedNever();

                entity.Property(e => e.PiVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PiVal9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.HasKey(e => e.PerFileIdNo)
                    .HasName("PeriodByPos");

                entity.Property(e => e.PerFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.DescPeriod)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pextrafield>(entity =>
            {
                entity.HasKey(e => e.PxfFileId)
                    .HasName("pxfByPos");

                entity.Property(e => e.PxfFileId).ValueGeneratedNever();

                entity.Property(e => e.PxfName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pgraph>(entity =>
            {
                entity.HasKey(e => e.PgrFileId)
                    .HasName("pgrByPos");

                entity.Property(e => e.PgrFileId).ValueGeneratedNever();

                entity.Property(e => e.PgrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pjrnl>(entity =>
            {
                entity.HasKey(e => e.PjrFileId)
                    .HasName("pjrByPos");

                entity.Property(e => e.PjrFileId).ValueGeneratedNever();

                entity.Property(e => e.PjrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PjrTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Plabel>(entity =>
            {
                entity.HasKey(e => e.PlblFileId)
                    .HasName("plblByPos");

                entity.Property(e => e.PlblFileId).ValueGeneratedNever();

                entity.Property(e => e.PlblData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pledger>(entity =>
            {
                entity.HasKey(e => e.PlgFileId)
                    .HasName("plgByPos");

                entity.Property(e => e.PlgFileId).ValueGeneratedNever();

                entity.Property(e => e.PlgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PlgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pmast>(entity =>
            {
                entity.HasKey(e => e.PFileId)
                    .HasName("pByPos");

                entity.Property(e => e.DelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.P2Code)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PAddres11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PAddres12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PArea1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PArea2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PBank1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PBank2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PCarrier)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PCredLim).HasDefaultValueSql("((0))");

                entity.Property(e => e.PDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PDoy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PDoycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PEdiccode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PEdicode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PEmail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PEuro).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFcncycode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PFcopenDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFcopnCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFcyearDeb).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFcyrCred).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFeatCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PFeatCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PForCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PForSales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PFpaCommision)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PInvVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PInvVal0).HasDefaultValueSql("((0))");

                entity.Property(e => e.PInvVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PManager)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PMnthCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PMobile)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PMonthDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PNonPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.POpenCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.POpenDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPayables).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerCred9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPerDeb9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPersales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPrevYearCr).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPrevYearDb).HasDefaultValueSql("((0))");

                entity.Property(e => e.PProfession)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PPysales1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales10).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales11).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales12).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PPysales9).HasDefaultValueSql("((0))");

                entity.Property(e => e.PRelCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PRepCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PSalesman)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTel1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTel2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTelex)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTrustPercentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.PUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PVatno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PWebsite)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PYearCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PYearDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.PZipCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PZipCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Paddres21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Paddres22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pointsinvvalue>(entity =>
            {
                entity.HasKey(e => e.PivFileId)
                    .HasName("pivPointByPos");

                entity.Property(e => e.PivFileId).ValueGeneratedNever();

                entity.Property(e => e.PivInvoiceValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Pointsitemuse>(entity =>
            {
                entity.HasKey(e => e.PiuFileId)
                    .HasName("piuPointsByPos");

                entity.Property(e => e.PiuFileId).ValueGeneratedNever();

                entity.Property(e => e.PiuQuantity).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Pointsparameter>(entity =>
            {
                entity.HasKey(e => e.PpFileId)
                    .HasName("ppPointsByPos");

                entity.Property(e => e.PpFileId).ValueGeneratedNever();

                entity.Property(e => e.PpPayWay)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PpPointsCalcFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.PpUseCalcFactor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Pointsuselevel>(entity =>
            {
                entity.HasKey(e => e.PulFileId)
                    .HasName("pulPointsByPos");

                entity.Property(e => e.PulFileId).ValueGeneratedNever();

                entity.Property(e => e.PulValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Pol1214param>(entity =>
            {
                entity.HasKey(e => e.PolFileId)
                    .HasName("polByPos");

                entity.Property(e => e.PolFileId).ValueGeneratedNever();

                entity.Property(e => e.PolCustCollTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.PolCustInvTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.PolSuplInvTransSet).UseCollation("Greek_BIN");

                entity.Property(e => e.PolSuplPayTransSet).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Prchordmi>(entity =>
            {
                entity.HasKey(e => e.PomFileId)
                    .HasName("pomByPos");

                entity.Property(e => e.PomFileId).ValueGeneratedNever();

                entity.Property(e => e.PomDet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PomName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PomSum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PomTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Prgmask>(entity =>
            {
                entity.HasKey(e => e.PgmFileId)
                    .HasName("pgmByPos");

                entity.Property(e => e.PgmFileId).ValueGeneratedNever();

                entity.Property(e => e.PgmCodeMask)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pricecheckertbl>(entity =>
            {
                entity.HasKey(e => e.PckFileId)
                    .HasName("pckByPos");

                entity.Property(e => e.PckFileId).ValueGeneratedNever();

                entity.Property(e => e.PckDescription)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckDriver)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckLines1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckLines2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckLines3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckLines4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PckLines5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pricelistsarea>(entity =>
            {
                entity.HasKey(e => e.PlaFileId)
                    .HasName("plaPriceListAreaByPos");

                entity.Property(e => e.PlaFileId).ValueGeneratedNever();

                entity.Property(e => e.PlaAreaDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Printrep>(entity =>
            {
                entity.HasKey(e => e.PrFileId)
                    .HasName("PrPrintByPos");

                entity.Property(e => e.PrDesignData).UseCollation("Greek_BIN");

                entity.Property(e => e.PrPrintName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Prlst>(entity =>
            {
                entity.HasKey(e => e.PlsFileId)
                    .HasName("plsByPos");

                entity.Property(e => e.PlsFileId).ValueGeneratedNever();

                entity.Property(e => e.PlsBrPoint1).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsBrPoint2).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsBrPoint3).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsBrPoint4).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsBrPoint5).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PlsDisc0101).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0102).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0103).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0104).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0105).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0106).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc011).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0111).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0112).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0113).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0114).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0115).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0116).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc012).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0121).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0122).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0123).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0124).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0125).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0126).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc013).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0131).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0132).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0133).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0134).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0135).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0136).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc014).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0141).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0142).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0143).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0144).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0145).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0146).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc015).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0151).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0152).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0153).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0154).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0155).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0156).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc016).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0161).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0162).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0163).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0164).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0165).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0166).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0171).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0172).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0173).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0174).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0175).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0176).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0181).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0182).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0183).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0184).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0185).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0186).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0191).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0192).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0193).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0194).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0195).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0196).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0201).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0202).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0203).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0204).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0205).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc0206).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc021).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc022).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc023).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc024).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc025).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc026).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc031).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc032).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc033).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc034).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc035).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc036).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc041).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc042).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc043).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc044).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc045).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc046).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc051).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc052).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc053).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc054).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc055).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc056).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc061).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc062).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc063).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc064).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc065).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc066).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc071).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc072).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc073).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc074).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc075).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc076).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc081).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc082).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc083).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc084).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc085).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc086).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc091).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc092).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc093).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc094).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc095).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc096).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc111).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc112).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc113).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc114).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc115).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc116).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1201).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1202).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1203).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1204).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1205).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1206).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc121).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1211).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1212).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1213).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1214).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1215).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1216).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc122).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1221).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1222).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1223).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1224).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1225).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1226).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc123).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1231).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1232).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1233).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1234).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1235).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1236).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc124).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1241).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1242).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1243).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1244).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1245).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1246).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc125).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1251).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1252).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1253).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1254).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1255).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1256).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc126).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1261).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1262).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1263).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1264).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1265).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1266).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1271).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1272).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1273).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1274).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1275).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1276).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1281).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1282).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1283).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1284).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1285).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1286).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1291).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1292).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1293).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1294).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1295).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1296).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1301).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1302).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1303).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1304).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1305).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc1306).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc131).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc132).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc133).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc134).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc135).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc136).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc141).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc142).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc143).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc144).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc145).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc146).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc151).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc152).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc153).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc154).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc155).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc156).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc161).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc162).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc163).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc164).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc165).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc166).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc171).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc172).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc173).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc174).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc175).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc176).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc181).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc182).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc183).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc184).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc185).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc186).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc191).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc192).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc193).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc194).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc195).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlsDisc196).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Productionstate>(entity =>
            {
                entity.HasKey(e => e.PrstFileId)
                    .HasName("prstByPos");

                entity.Property(e => e.PrstFileId).ValueGeneratedNever();

                entity.Property(e => e.PrstName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Prtinfo>(entity =>
            {
                entity.HasKey(e => e.PrtFileId)
                    .HasName("prtiByPos");

                entity.Property(e => e.PrtFileId).ValueGeneratedNever();

                entity.Property(e => e.PrtDriver)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Prtc).UseCollation("Greek_BIN");

                entity.Property(e => e.Prtn)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Prtt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Prtpreconf>(entity =>
            {
                entity.HasKey(e => e.PrcFileId)
                    .HasName("prtcByPos");

                entity.Property(e => e.PrcFileId).ValueGeneratedNever();

                entity.Property(e => e.Descr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ptrn>(entity =>
            {
                entity.HasKey(e => e.PtFileId)
                    .HasName("ptByPosition");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtExpValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtFccovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtFcexpVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtFcfpaval).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtFcnetVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtForCncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtKepyoValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtKepyoVat).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtPrevUseValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.PtSubsCoder)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtVatvalue).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PFile)
                    .WithMany(p => p.Ptrns)
                    .HasForeignKey(d => d.PFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ptToPm");

                entity.HasOne(d => d.PtBm1originNavigation)
                    .WithMany(p => p.Ptrns)
                    .HasForeignKey(d => d.PtBm1origin)
                    .HasConstraintName("ptToBMaster1");

                entity.HasOne(d => d.PtBm2originNavigation)
                    .WithMany(p => p.Ptrns)
                    .HasForeignKey(d => d.PtBm2origin)
                    .HasConstraintName("ptToBMaster2");

                entity.HasOne(d => d.PtNemOriginNavigation)
                    .WithMany(p => p.Ptrns)
                    .HasForeignKey(d => d.PtNemOrigin)
                    .HasConstraintName("ptToNemast");

                entity.HasOne(d => d.PtTransKindNavigation)
                    .WithMany(p => p.Ptrns)
                    .HasForeignKey(d => d.PtTransKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ptToSuplTrnDescr");
            });

            modelBuilder.Entity<Purchdesc>(entity =>
            {
                entity.HasKey(e => e.PurFileId)
                    .HasName("purByPos");

                entity.Property(e => e.PurFileId).ValueGeneratedNever();

                entity.Property(e => e.PurDesc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PurDintr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Purchexpen>(entity =>
            {
                entity.HasKey(e => e.PaFileIdNo)
                    .HasName("paByPos");

                entity.Property(e => e.PaFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.PaConstVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaExpense).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaSpGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaSpVatGlco)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaVatGlco)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PaVatType)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Purchmi>(entity =>
            {
                entity.HasKey(e => e.PdmFileId)
                    .HasName("pdmByPos");

                entity.Property(e => e.PdmFileId).ValueGeneratedNever();

                entity.Property(e => e.PdmDet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdmName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdmSum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PdmTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Pwinlabel>(entity =>
            {
                entity.HasKey(e => e.PwlFileId)
                    .HasName("pwlByPos");

                entity.Property(e => e.PwlFileId).ValueGeneratedNever();

                entity.Property(e => e.PwlData).UseCollation("Greek_BIN");

                entity.Property(e => e.PwlDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Report1>(entity =>
            {
                entity.HasKey(e => e.RepFileId)
                    .HasName("repByPos");

                entity.Property(e => e.RepCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RepData).UseCollation("Greek_BIN");

                entity.Property(e => e.RepModify)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RepRun)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RepTitle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Report3>(entity =>
            {
                entity.HasKey(e => e.Rep3Id)
                    .HasName("Rep3ByPos");

                entity.Property(e => e.Rep3Data).UseCollation("Greek_BIN");

                entity.Property(e => e.Rep3Filters).UseCollation("Greek_BIN");

                entity.Property(e => e.Rep3Links).UseCollation("Greek_BIN");

                entity.Property(e => e.Rep3Rights).UseCollation("Greek_BIN");

                entity.Property(e => e.Rep3Title)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Requiredfield>(entity =>
            {
                entity.HasKey(e => e.RqdFileId)
                    .HasName("RqdByPos");

                entity.Property(e => e.RqdFileId).ValueGeneratedNever();

                entity.Property(e => e.RqdData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Roundinfo>(entity =>
            {
                entity.HasKey(e => e.RniFileId)
                    .HasName("rniByPos");

                entity.Property(e => e.RniFileId).ValueGeneratedNever();

                entity.Property(e => e.RniFrom).HasDefaultValueSql("((0))");

                entity.Property(e => e.RniRound).HasDefaultValueSql("((0))");

                entity.Property(e => e.RniUpto).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sacttrn>(entity =>
            {
                entity.HasKey(e => e.SatFileId)
                    .HasName("satByPos");
            });

            modelBuilder.Entity<Salesdesc>(entity =>
            {
                entity.HasKey(e => e.SalDfileId)
                    .HasName("SalDByPos");

                entity.Property(e => e.SalDfileId).ValueGeneratedNever();

                entity.Property(e => e.SalDesc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SalDintr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Salesexpen>(entity =>
            {
                entity.HasKey(e => e.SeFileIdNo)
                    .HasName("seByPos");

                entity.Property(e => e.SeFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.SeConstVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeExpense).HasDefaultValueSql("((0))");

                entity.Property(e => e.SeFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeSpGlcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeSpVatGlco)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeVatGlco)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SeVatType)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.HasKey(e => e.SellFileId)
                    .HasName("selByPosition");

                entity.Property(e => e.Selarea)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Selfutinv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutinv9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutrec9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selfutsal9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selglcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Selladdr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellarea)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellcity)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellcomm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellemail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellfax)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellinv1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellinv9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellname)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SellnameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellperc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SellpercSales).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellprom9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellrecei9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales001).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0010).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0011).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0012).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales002).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales003).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales004).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales005).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales006).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales007).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales008).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales009).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales011).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0110).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0111).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0112).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales012).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales013).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales014).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales015).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales016).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales017).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales018).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales019).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales021).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0210).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0211).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0212).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales022).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales023).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales024).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales025).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales026).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales027).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales028).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales029).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales031).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0310).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0311).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0312).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales032).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales033).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales034).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales035).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales036).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales037).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales038).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales039).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales041).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0410).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0411).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0412).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales042).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales043).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales044).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales045).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales046).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales047).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales048).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales049).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales051).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0510).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0511).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0512).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales052).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales053).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales054).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales055).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales056).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales057).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales058).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales059).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales061).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0610).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0611).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0612).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales062).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales063).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales064).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales065).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales066).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales067).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales068).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales069).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales071).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0710).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0711).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0712).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales072).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales073).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales074).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales075).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales076).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales077).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales078).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales079).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales081).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0810).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0811).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0812).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales082).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales083).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales084).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales085).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales086).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales087).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales088).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales089).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales091).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0910).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0911).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales0912).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales092).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales093).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales094).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales095).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales096).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales097).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales098).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales099).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales101).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1010).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1011).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1012).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales102).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales103).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales104).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales105).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales106).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales107).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales108).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales109).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales111).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1110).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1111).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1112).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales112).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales113).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales114).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales115).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales116).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales117).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales118).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales119).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales121).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1210).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1211).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1212).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales122).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales123).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales124).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales125).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales126).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales127).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales128).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales129).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales131).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1310).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1311).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1312).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales132).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales133).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales134).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales135).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales136).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales137).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales138).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales139).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales141).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1410).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1411).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1412).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales142).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales143).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales144).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales145).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales146).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales147).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales148).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales149).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales151).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1510).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1511).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1512).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales152).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales153).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales154).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales155).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales156).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales157).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales158).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales159).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales161).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1610).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1611).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1612).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales162).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales163).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales164).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales165).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales166).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales167).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales168).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales169).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales171).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1710).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1711).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1712).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales172).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales173).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales174).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales175).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales176).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales177).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales178).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales179).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales181).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1810).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1811).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1812).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales182).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales183).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales184).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales185).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales186).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales187).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales188).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales189).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales191).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1910).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1911).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales1912).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales192).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales193).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales194).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales195).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales196).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales197).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales198).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales199).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales201).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales2010).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales2011).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales2012).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales202).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales203).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales204).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales205).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales206).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales207).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales208).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellsales209).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selltel)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Sellzip)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Selprevsa1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Selprevsa9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Salesmi>(entity =>
            {
                entity.HasKey(e => e.SdmFileId)
                    .HasName("sdmByPos");

                entity.Property(e => e.SdmFileId).ValueGeneratedNever();

                entity.Property(e => e.SdmDet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdmName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdmSum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdmTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Scolor>(entity =>
            {
                entity.HasKey(e => e.SclFileId)
                    .HasName("sclByPos");

                entity.Property(e => e.SclFileId).ValueGeneratedNever();

                entity.Property(e => e.SclCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SclDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Scomment>(entity =>
            {
                entity.HasKey(e => e.ScmFileId)
                    .HasName("scmByPos");

                entity.Property(e => e.ScmFileId).ValueGeneratedNever();

                entity.Property(e => e.ScmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ScmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Scppric>(entity =>
            {
                entity.HasKey(e => e.ScpFileId)
                    .HasName("scpByPos");

                entity.Property(e => e.ScpComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ScpDiscVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScpDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScpDiscount2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScpFc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ScpItemCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ScpMinQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScpPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScpRtlPrice).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sdepartment>(entity =>
            {
                entity.HasKey(e => e.SdptFileId)
                    .HasName("sDeptByPos");

                entity.Property(e => e.SdptFileId).ValueGeneratedNever();

                entity.Property(e => e.SdptData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Selectorfield>(entity =>
            {
                entity.HasKey(e => e.SelectorIdNo)
                    .HasName("selfldbypos");

                entity.Property(e => e.SelectorIdNo).ValueGeneratedNever();

                entity.Property(e => e.SelectorColData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sellact>(entity =>
            {
                entity.HasKey(e => e.ActFileId)
                    .HasName("actByPos");

                entity.Property(e => e.ActComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActCustContactStr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActEntryId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActGmailLink)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActLocationStr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActRelativeCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ActTitle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sellactivity>(entity =>
            {
                entity.HasKey(e => e.SellActId)
                    .HasName("sellactByPos");

                entity.Property(e => e.SellActId).ValueGeneratedNever();

                entity.Property(e => e.SellActDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sellactparam>(entity =>
            {
                entity.HasKey(e => e.SellPrmId)
                    .HasName("SellPrmByPos");

                entity.Property(e => e.SellPrmId).ValueGeneratedNever();

                entity.Property(e => e.SellActHistoryCols)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SellPrmActPrintCols)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SellPrmCaptionCols).UseCollation("Greek_BIN");

                entity.Property(e => e.SyncEmail)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SyncEmailPassw)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sellactrelative>(entity =>
            {
                entity.HasKey(e => e.RelatId)
                    .HasName("relatByPos");

                entity.Property(e => e.RelatId).ValueGeneratedNever();

                entity.Property(e => e.RelatCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.RelatDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sellstatus>(entity =>
            {
                entity.HasKey(e => e.SellStatId)
                    .HasName("sellstatByPos");

                entity.Property(e => e.SellStatId).ValueGeneratedNever();

                entity.Property(e => e.SellStatDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sendmode>(entity =>
            {
                entity.HasKey(e => e.DelivModeId)
                    .HasName("csmByPos");

                entity.Property(e => e.DelivModeId).ValueGeneratedNever();

                entity.Property(e => e.CsmDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CsmDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.CsmEdi)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CsmGcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.CsmSendIntr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Serial>(entity =>
            {
                entity.HasKey(e => e.SnFileId)
                    .HasName("snByPos");

                entity.Property(e => e.SnComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnInvoice1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnInvoice2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnInvoice3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersName1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersName2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnPersName3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SnSerialC)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sextrafield>(entity =>
            {
                entity.HasKey(e => e.SxfFileId)
                    .HasName("sxfByPos");

                entity.Property(e => e.SxfFileId).ValueGeneratedNever();

                entity.Property(e => e.SxfName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sglbridge>(entity =>
            {
                entity.HasKey(e => e.SgbFileId)
                    .HasName("sgbByPos");

                entity.Property(e => e.SgbFileId).ValueGeneratedNever();

                entity.Property(e => e.SgbLogc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SgbLogd)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sglcost>(entity =>
            {
                entity.HasKey(e => e.SgcFileId)
                    .HasName("sgcByPos");

                entity.Property(e => e.SgcFileId).ValueGeneratedNever();

                entity.Property(e => e.SgcLogC)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SgcLogD)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sglgroup>(entity =>
            {
                entity.HasKey(e => e.SGlPos)
                    .HasName("sGlByPos");

                entity.Property(e => e.SGlPos).ValueGeneratedNever();

                entity.Property(e => e.SGlCrCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SGlDbCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SGlExCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SGlGrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SGlImCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sglproinfo>(entity =>
            {
                entity.HasKey(e => e.SgiFileId)
                    .HasName("sgiByPos");

                entity.Property(e => e.SgiFileId).ValueGeneratedNever();

                entity.Property(e => e.SgiLogc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SgiLogd)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sgraph>(entity =>
            {
                entity.HasKey(e => e.SgrFileId)
                    .HasName("sgrByPos");

                entity.Property(e => e.SgrFileId).ValueGeneratedNever();

                entity.Property(e => e.SgrDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Shortcut>(entity =>
            {
                entity.HasKey(e => e.DscFileId)
                    .HasName("dscByPos");

                entity.Property(e => e.DscCaption)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DscData).UseCollation("Greek_BIN");

                entity.Property(e => e.DscIncoPath)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Slabel>(entity =>
            {
                entity.HasKey(e => e.SlblFileId)
                    .HasName("slblByPos");

                entity.Property(e => e.SlblFileId).ValueGeneratedNever();

                entity.Property(e => e.SlblData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sledger>(entity =>
            {
                entity.HasKey(e => e.SlgFileId)
                    .HasName("slgByPos");

                entity.Property(e => e.SlgFileId).ValueGeneratedNever();

                entity.Property(e => e.SlgName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SlgTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Slordmi>(entity =>
            {
                entity.HasKey(e => e.SomFileId)
                    .HasName("slomByPos");

                entity.Property(e => e.SomFileId).ValueGeneratedNever();

                entity.Property(e => e.SomDet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SomName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SomSum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SomTrns)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Smast>(entity =>
            {
                entity.HasKey(e => e.SFileId)
                    .HasName("sfxByPos");

                entity.Property(e => e.SAlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SAllocQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SAverCstPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SAverSlPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SAvgItemAge).HasDefaultValueSql("((0))");

                entity.Property(e => e.SAvgStoreDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.SCccode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SCccode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.SCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr21)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr22)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr23)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr24)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SColorDscr9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SComments)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SDefDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SDefSalesQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.SDrastiki)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SEfktax).HasDefaultValueSql("((0))");

                entity.Property(e => e.SEta).HasDefaultValueSql("((0))");

                entity.Property(e => e.SEuro).HasDefaultValueSql("((0))");

                entity.Property(e => e.SFactCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SFarmako)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SFcpurchPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SFcsalePr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SFeature1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SFeature2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SFifoCstPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SFiller)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SForCncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SForeInQ1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInQ9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeInV9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutQ9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SForeOutV9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SGlcode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SGlcode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SImage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SInNinvQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInOpenQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInOpenVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInYearQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInYearVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SInc6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SIncRtl).HasDefaultValueSql("((0))");

                entity.Property(e => e.SIncWhs).HasDefaultValueSql("((0))");

                entity.Property(e => e.SLastPrcPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SLastSlPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SLifoCstPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SMavCostPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SMaxdisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SMonThpr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SMonada)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SNameSrt)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SOpenAvgItemAge).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOrderQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOrigin)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SOutNinvQ).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOutYrQnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SOutYrVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInQ9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerInV9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutQ9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPerOutV9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPlace)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SPointsFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinQs9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYinVs9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutQs9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYoutVs9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYrOtQn).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrYrOtVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrvYinVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SPrvYrInQn).HasDefaultValueSql("((0))");

                entity.Property(e => e.SRelCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SReorder).HasDefaultValueSql("((0))");

                entity.Property(e => e.SRetMarkup).HasDefaultValueSql("((0))");

                entity.Property(e => e.SRetailPr).HasDefaultValueSql("((0))");

                entity.Property(e => e.SSafety).HasDefaultValueSql("((0))");

                entity.Property(e => e.SStandcost).HasDefaultValueSql("((0))");

                entity.Property(e => e.SStd96)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SSuplCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SSupplier)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUnitOm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUnitOm2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUnitsRel).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrCnts8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrNums6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SUsrStrs1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUsrStrs2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUsrStrs3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SUsrStrs4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SVatcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SVolFact).HasDefaultValueSql("((0))");

                entity.Property(e => e.SWghtFact).HasDefaultValueSql("((0))");

                entity.Property(e => e.SWhsMarkup).HasDefaultValueSql("((0))");

                entity.Property(e => e.SWhsalePr).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Smc>(entity =>
            {
                entity.HasKey(e => e.SmcsFileId)
                    .HasName("smcsByFileId");

                entity.Property(e => e.SmcsSize10Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize10Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize11Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize12Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize13Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize14Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize15Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize16Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize17Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize18Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize19Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize1Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize20Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize2Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize3Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize4Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize5Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize6Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize7Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize8Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmcsSize9Colour9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Smcode>(entity =>
            {
                entity.HasKey(e => e.SmcPos)
                    .HasName("smcByPos");

                entity.Property(e => e.SmcCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmcComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.HasOne(d => d.SmcpFile)
                    .WithMany(p => p.Smcodes)
                    .HasForeignKey(d => d.SmcpFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("smcToPm");

                entity.HasOne(d => d.SmcsFile)
                    .WithMany(p => p.Smcodes)
                    .HasForeignKey(d => d.SmcsFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("smcToSm");
            });

            modelBuilder.Entity<Smrel>(entity =>
            {
                entity.HasKey(e => e.SmrFileId)
                    .HasName("smrByPos");

                entity.Property(e => e.SmrCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmrCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmrQuant).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Smset>(entity =>
            {
                entity.HasKey(e => e.SmsFileId)
                    .HasName("smsByPos");

                entity.Property(e => e.SmsCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmsCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmsFquant).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmsQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmsQuant2).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Smweb>(entity =>
            {
                entity.HasKey(e => e.SmwbFileId)
                    .HasName("smwbByPos");

                entity.Property(e => e.SmwbCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbDiscPrc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmwbEnDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbEnName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbMarkUp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmwbName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbPicture)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SmwbPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.SmwbWeigth).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Snomast>(entity =>
            {
                entity.HasKey(e => e.SomFileId)
                    .HasName("somByPos");

                entity.Property(e => e.SomCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SomDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Snotrn>(entity =>
            {
                entity.HasKey(e => e.SotFileId)
                    .HasName("sotByPos");
            });

            modelBuilder.Entity<Sseazon>(entity =>
            {
                entity.HasKey(e => e.SseFileId)
                    .HasName("sseByPos");

                entity.Property(e => e.SseFileId).ValueGeneratedNever();

                entity.Property(e => e.SseDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Ssize>(entity =>
            {
                entity.HasKey(e => e.SszFileId)
                    .HasName("sszByPos");

                entity.Property(e => e.SszFileId).ValueGeneratedNever();

                entity.Property(e => e.SszCode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode10)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode11)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode12)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode13)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode14)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode15)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode16)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode17)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode18)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode19)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode20)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode5)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode6)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode7)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode8)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszCode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SszDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sstore>(entity =>
            {
                entity.HasKey(e => e.SstFileId)
                    .HasName("sstByPos");

                entity.Property(e => e.SstApogr1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstApogr2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstOrdered1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstOrdered2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstRemain1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstRemain2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstWaiting1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SstWaiting2).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Stc>(entity =>
            {
                entity.HasKey(e => e.StcsFileId)
                    .HasName("stcsByFileId");

                entity.Property(e => e.StcsSize10Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize10Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize11Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize12Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize13Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize14Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize15Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize16Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize17Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize18Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize19Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize1Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize20Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize2Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize3Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize4Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize5Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize6Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize7Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize8Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.StcsSize9Colour9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Stockspace>(entity =>
            {
                entity.HasKey(e => e.SpaFileIdNo)
                    .HasName("SpaByPos");

                entity.Property(e => e.SpaFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.SpaceEdiCd)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SpaceGlacc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SpaceInfo)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SpaceName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Stocktable1>(entity =>
            {
                entity.HasKey(e => e.StFileIdNo1)
                    .HasName("St1ByPos");

                entity.Property(e => e.StFileIdNo1).ValueGeneratedNever();

                entity.Property(e => e.StockTde1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Stocktable2>(entity =>
            {
                entity.HasKey(e => e.StFileIdNo2)
                    .HasName("St2ByPos");

                entity.Property(e => e.StFileIdNo2).ValueGeneratedNever();

                entity.Property(e => e.StockTde2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Stocktable3>(entity =>
            {
                entity.HasKey(e => e.StFileIdNo3)
                    .HasName("St3ByPos");

                entity.Property(e => e.StFileIdNo3).ValueGeneratedNever();

                entity.Property(e => e.StockTde3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Stocktax>(entity =>
            {
                entity.HasKey(e => e.DasFileIdNo)
                    .HasName("DasmByPos");

                entity.Property(e => e.DasFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.DasmDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.DasmNep).HasDefaultValueSql("((0))");

                entity.Property(e => e.DasmPerc).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Stockunit>(entity =>
            {
                entity.HasKey(e => e.SunFileId)
                    .HasName("sunByPos");

                entity.Property(e => e.SunFileId).ValueGeneratedNever();

                entity.Property(e => e.SuEdiName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SunCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SunDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Storfeat1>(entity =>
            {
                entity.HasKey(e => e.SFeatureId)
                    .HasName("ts1ByPos");

                entity.Property(e => e.SFeatureId).ValueGeneratedNever();

                entity.Property(e => e.SFeature1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TsDescr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Storfeat2>(entity =>
            {
                entity.HasKey(e => e.SFeatureId)
                    .HasName("ts2ByPos");

                entity.Property(e => e.SFeatureId).ValueGeneratedNever();

                entity.Property(e => e.SFeature2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TsDescr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Stortrndesc>(entity =>
            {
                entity.HasKey(e => e.STrNo)
                    .HasName("StorByPos");

                entity.Property(e => e.STrNo).ValueGeneratedNever();

                entity.Property(e => e.StDesc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Strn>(entity =>
            {
                entity.HasKey(e => e.StFileId)
                    .HasName("stByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StAitia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StAnamoni)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCertOper)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCombined)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StComment2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StCustSuppl)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDimos)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDocOthEx).HasDefaultValueSql("((0))");

                entity.Property(e => e.StDosage)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StDrastiki)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StEfk).HasDefaultValueSql("((0))");

                entity.Property(e => e.StFcdocOex).HasDefaultValueSql("((0))");

                entity.Property(e => e.StFcprice).HasDefaultValueSql("((0))");

                entity.Property(e => e.StFcvalue).HasDefaultValueSql("((0))");

                entity.Property(e => e.StForCncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StFpaVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.StFreeText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StInSpray)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StKalliergeia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StLotCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StMarkupg).HasDefaultValueSql("((0))");

                entity.Property(e => e.StMarkupr).HasDefaultValueSql("((0))");

                entity.Property(e => e.StOtherExp).HasDefaultValueSql("((0))");

                entity.Property(e => e.StPckg).HasDefaultValueSql("((0))");

                entity.Property(e => e.StPckg2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StPckgWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.StPckgWeight2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StPerifereia)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescLineId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrescriber)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPressureApplied)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.StQuanPsekDial)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.StQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.StStadio)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.StValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.StVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.StWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.StXycoeff).HasDefaultValueSql("((0))");

                entity.Property(e => e.StYgrCoeff).HasDefaultValueSql("((0))");

                entity.Property(e => e.StrSearchCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Strcost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SFile)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.SFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stToSm");

                entity.HasOne(d => d.StBm1originNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StBm1origin)
                    .HasConstraintName("stToBMaster1");

                entity.HasOne(d => d.StLocationNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stToSpa");

                entity.HasOne(d => d.StNmCostOriginNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StNmCostOrigin)
                    .HasConstraintName("stToNmCost");

                entity.HasOne(d => d.StNmSpInvOriginNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StNmSpInvOrigin)
                    .HasConstraintName("stToNmSpInv");

                entity.HasOne(d => d.StTransKindNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StTransKind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stToStrDesc");

                entity.HasOne(d => d.StVat)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StVatid)
                    .HasConstraintName("stToVAT");

                entity.HasOne(d => d.StVm1originNavigation)
                    .WithMany(p => p.Strns)
                    .HasForeignKey(d => d.StVm1origin)
                    .HasConstraintName("stToVMaster1");
            });

            modelBuilder.Entity<Strninv>(entity =>
            {
                entity.HasKey(e => e.SivFileId)
                    .HasName("sivByPos");

                entity.Property(e => e.SivQuant1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SivQuant2).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SFile)
                    .WithMany(p => p.Strninvs)
                    .HasForeignKey(d => d.SFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sivToSmfx");

                entity.HasOne(d => d.SivSpace)
                    .WithMany(p => p.Strninvs)
                    .HasForeignKey(d => d.SivSpaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sivToSpa");
            });

            modelBuilder.Entity<Subsid>(entity =>
            {
                entity.HasKey(e => e.SubFileIdNo)
                    .HasName("SubIndex");

                entity.Property(e => e.SubFileIdNo).ValueGeneratedNever();

                entity.Property(e => e.SubName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubRtlCustCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubsMinagricShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubsMinagricUser)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubsRdef)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubsVdef1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SubsVdef2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suplfeat1>(entity =>
            {
                entity.HasKey(e => e.PFeatureId)
                    .HasName("pt1ByPos");

                entity.Property(e => e.PFeatureId).ValueGeneratedNever();

                entity.Property(e => e.PFeature1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTdescr1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suplfeat2>(entity =>
            {
                entity.HasKey(e => e.PFeatureId)
                    .HasName("pt2ByPos");

                entity.Property(e => e.PFeatureId).ValueGeneratedNever();

                entity.Property(e => e.PFeature2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PTdescr2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Supltrndescr>(entity =>
            {
                entity.HasKey(e => e.PtTransKind)
                    .HasName("SuplTrnByPos");

                entity.Property(e => e.PtTransKind).ValueGeneratedNever();

                entity.Property(e => e.PtDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtTrFlags)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.PtpGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suppltable1>(entity =>
            {
                entity.HasKey(e => e.SuFileIdNo1)
                    .HasName("Su1ByPos");

                entity.Property(e => e.SuFileIdNo1).ValueGeneratedNever();

                entity.Property(e => e.SuppllDesc1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suppltable2>(entity =>
            {
                entity.HasKey(e => e.SuFileIdNo2)
                    .HasName("Su2ByPos");

                entity.Property(e => e.SuFileIdNo2).ValueGeneratedNever();

                entity.Property(e => e.SuppllDesc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suppltable3>(entity =>
            {
                entity.HasKey(e => e.SuFileIdNo3)
                    .HasName("Su3ByPos");

                entity.Property(e => e.SuFileIdNo3).ValueGeneratedNever();

                entity.Property(e => e.SuppllDesc3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Suppltaxkind>(entity =>
            {
                entity.HasKey(e => e.PTaxId)
                    .HasName("pTaxByPos");

                entity.Property(e => e.PTaxId).ValueGeneratedNever();

                entity.Property(e => e.PTaxLimitVal).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Swinlabel>(entity =>
            {
                entity.HasKey(e => e.SwlFileId)
                    .HasName("swlByPos");

                entity.Property(e => e.SwlFileId).ValueGeneratedNever();

                entity.Property(e => e.SwlData).UseCollation("Greek_BIN");

                entity.Property(e => e.SwlDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Sysrsrvjob>(entity =>
            {
                entity.HasKey(e => e.SrjFileid)
                    .HasName("srjByPos");

                entity.Property(e => e.SrjFileid).ValueGeneratedNever();

                entity.Property(e => e.SrjData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Tpetrelaioparam>(entity =>
            {
                entity.HasKey(e => e.TpetrFileId)
                    .HasName("TPertByPos");

                entity.Property(e => e.TpetrFileId).ValueGeneratedNever();

                entity.Property(e => e.Dptno)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Factor1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Factor2).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.ItemCodeKin)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SendMode1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SendMode2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SendMode3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SendMode9)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TradeMu2set).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Tracejob>(entity =>
            {
                entity.HasKey(e => e.TrjFileId)
                    .HasName("trjByPos");

                entity.Property(e => e.TrjFileId).ValueGeneratedNever();

                entity.Property(e => e.TrjData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("trdByPos");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Recstatusdescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdCpVal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdCpVal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdCpVal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdCpVal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdCurrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdDeadWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdDelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdDocum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdExpenses1).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdExpenses2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdGrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdIntrastatVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdPerDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdRelDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdSalesmanCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdSendToCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdSubsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdText1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdText2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdText3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdText4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdVdiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdcCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Tradeline>(entity =>
            {
                entity.HasKey(e => new { e.RecMaster, e.RecNo })
                    .HasName("trdlByPos");

                entity.Property(e => e.TrdColorCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdItemAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdItemComm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdItemDisc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemDisc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemFpaCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdItemLot)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrdItemPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItemWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdItempDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrdSizeCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Tradingcause>(entity =>
            {
                entity.HasKey(e => e.TrcId)
                    .HasName("trcByPos");

                entity.Property(e => e.TrcId).ValueGeneratedNever();

                entity.Property(e => e.TrcDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Transfor>(entity =>
            {
                entity.HasKey(e => e.TrfFileId)
                    .HasName("TrfByPos");

                entity.Property(e => e.TrfDestCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrfSourceCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Travelinfo>(entity =>
            {
                entity.HasKey(e => e.TifFileId)
                    .HasName("tifByPos");

                entity.Property(e => e.TifFileId).ValueGeneratedNever();

                entity.Property(e => e.TifKeyId)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TifName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Trnum>(entity =>
            {
                entity.HasKey(e => e.TrnFileId)
                    .HasName("TrnumByPos");

                entity.Property(e => e.TnCancelCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TnDesc2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrnCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrnDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.TrnGlCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Txtlabel>(entity =>
            {
                entity.HasKey(e => e.TxlFileId)
                    .HasName("txlByPos");

                entity.Property(e => e.TxlFileId).ValueGeneratedNever();

                entity.Property(e => e.TxlData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsgFileId)
                    .HasName("usgByPos");

                entity.Property(e => e.UsgFileId).ValueGeneratedNever();

                entity.Property(e => e.UsgData).UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Usermsg>(entity =>
            {
                entity.HasKey(e => e.UmsFileId)
                    .HasName("umsByPos");

                entity.Property(e => e.UmsFileId).ValueGeneratedNever();

                entity.Property(e => e.UmsData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.HasKey(e => e.FpaId)
                    .HasName("VATByPos");

                entity.Property(e => e.FpaId).ValueGeneratedNever();

                entity.Property(e => e.FpaCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.FpaData).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vcomment>(entity =>
            {
                entity.HasKey(e => e.VcmFileId)
                    .HasName("vcmByPos");

                entity.Property(e => e.VcmFileId).ValueGeneratedNever();

                entity.Property(e => e.VcmCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.VcmData)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.HasKey(e => e.AtableName)
                    .HasName("VersionInfoPK");

                entity.Property(e => e.AtableName)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Aversion)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Vglbridge>(entity =>
            {
                entity.HasKey(e => e.VgbFileId)
                    .HasName("vgbByPos");

                entity.Property(e => e.VgbFileId).ValueGeneratedNever();

                entity.Property(e => e.VgbCpCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.VgbGcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Vglinfo>(entity =>
            {
                entity.HasKey(e => e.VgliFileId)
                    .HasName("vgliByPos");

                entity.Property(e => e.VgliFileId).ValueGeneratedNever();

                entity.Property(e => e.VgliEfkcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.VgliNoVatcode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Vline2>(entity =>
            {
                entity.HasKey(e => e.SloFileId)
                    .HasName("sloByPos");

                entity.Property(e => e.SloComm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SloDisc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloDisc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloDisc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloLot)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SloPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloQuant2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloSearchCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SloTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloVolume).HasDefaultValueSql("((0))");

                entity.Property(e => e.SloWeight).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vm2c>(entity =>
            {
                entity.HasKey(e => e.Vm2csFileId)
                    .HasName("vm2csByFileId");

                entity.Property(e => e.Vm2csSize10Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize10Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize11Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize12Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize13Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize14Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize15Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize16Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize17Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize18Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize19Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize1Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize20Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize2Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize3Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize4Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize5Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize6Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize7Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize8Colour9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour13).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour14).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour15).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour16).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour17).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour18).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour19).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour20).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour21).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour22).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour23).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour24).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vm2csSize9Colour9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vmast1>(entity =>
            {
                entity.HasKey(e => e.SdFileId)
                    .HasName("sdByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdAfm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdCommision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdCostVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdCurrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdDeadWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdDelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdDocum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdEdicode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdEeccrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdEecdeliv)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdEecexp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdEeckind)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdExpenses1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdExpenses2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdGrossVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdGrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdLinesPos).UseCollation("Greek_BIN");

                entity.Property(e => e.SdNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdPerDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdReceivable).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdRelDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdSentToShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdSubsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxAgentCopiesSign1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxAgentCopiesSign2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxAgentCopiesSign3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxAgentCopiesSign4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxAgentSign)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTaxCard)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdTotEta).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdTotVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatval).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl25).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl26).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl27).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl28).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl29).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl30).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl31).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl32).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl33).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl34).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl35).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl36).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl37).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl38).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl39).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl40).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVatvl9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SdVlPrVat1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat25).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat26).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat27).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat28).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat29).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat30).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat31).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat32).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat33).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat34).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat35).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat36).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat37).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat38).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat39).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat40).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SdVlPrVat9).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SdTrNums)
                    .WithMany(p => p.Vmast1s)
                    .HasForeignKey(d => d.SdTrNumsId)
                    .HasConstraintName("sdToNums");
            });

            modelBuilder.Entity<Vmast2>(entity =>
            {
                entity.HasKey(e => e.SoFileId)
                    .HasName("sofxByPos");

                entity.Property(e => e.FlagsSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoAddress)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoAfm)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoComment)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoCommision).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoCostVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoCountry)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoCovered).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoCurrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoDeadWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoDelivMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoDocum)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoEdicode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoEeccrncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoEecdeliv)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoEecexp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoEeckind)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoExpenses1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoExpenses2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoForCrncy)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoGrossVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoGrossWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoNetValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoPayMode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoPerDiscnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoReceivable).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoRelDoc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoSentToShop)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoStatus)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoSubsCode)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxAgentCopiesSign1)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxAgentCopiesSign2)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxAgentCopiesSign3)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxAgentCopiesSign4)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxAgentSign)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTaxCard)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoText)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoTotEta).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTotVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatval).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals25).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals26).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals27).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals28).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals29).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals30).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals31).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals32).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals33).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals34).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals35).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals36).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals37).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals38).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals39).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals40).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVatvals9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVehicle)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.SoVlPrVat1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat10).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat11).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat12).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat13).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat14).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat15).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat16).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat17).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat18).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat19).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat2).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat20).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat21).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat22).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat23).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat24).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat25).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat26).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat27).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat28).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat29).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat3).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat30).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat31).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat32).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat33).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat34).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat35).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat36).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat37).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat38).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat39).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat4).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat40).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat5).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat6).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat7).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat8).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoVlPrVat9).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SoTrNums)
                    .WithMany(p => p.Vmast2s)
                    .HasForeignKey(d => d.SoTrNumsId)
                    .HasConstraintName("sofxToNums");
            });

            modelBuilder.Entity<Vtodiscscenario>(entity =>
            {
                entity.HasKey(e => e.VdsFileId)
                    .HasName("vdsByPos");

                entity.Property(e => e.VdsFileId).ValueGeneratedNever();

                entity.Property(e => e.VdsDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.VdsLimit1).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit10).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit3).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit4).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit5).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit6).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit7).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit8).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsLimit9).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc1).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc10).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc2).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc3).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc4).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc5).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc6).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc7).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc8).HasDefaultValueSql("((0))");

                entity.Property(e => e.VdsPrc9).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vxgl>(entity =>
            {
                entity.HasKey(e => e.VglFileId)
                    .HasName("vglByPos");

                entity.Property(e => e.VglFileId).ValueGeneratedNever();

                entity.Property(e => e.InvSet)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Xglc)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.Xgld)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Webitemcategory>(entity =>
            {
                entity.HasKey(e => e.WbIcFileId)
                    .HasName("WbIcByPos");

                entity.Property(e => e.WbIcFileId).ValueGeneratedNever();

                entity.Property(e => e.WbIcDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.WbIcEnDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.WbIcLogo)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Webmanufacturer>(entity =>
            {
                entity.HasKey(e => e.WbMfFileId)
                    .HasName("WbMfByPos");

                entity.Property(e => e.WbMfFileId).ValueGeneratedNever();

                entity.Property(e => e.WbMfDescr)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");

                entity.Property(e => e.WbMfLogo)
                    .IsUnicode(false)
                    .UseCollation("Greek_BIN");
            });

            modelBuilder.Entity<Xncurr>(entity =>
            {
                entity.HasKey(e => e.CrFileId)
                    .HasName("crByPos");

                entity.Property(e => e.CrCurr1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr13).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr14).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr15).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr16).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr17).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr18).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr19).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr20).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr21).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr22).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr23).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr24).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr25).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr26).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr27).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr28).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr29).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr30).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr31).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr32).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr33).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr34).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr35).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr36).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr37).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr38).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr39).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr40).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr41).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr42).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr43).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr44).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr45).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr46).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr47).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr48).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr49).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr50).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr51).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr52).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr53).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr54).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr55).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr56).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr57).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr58).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr59).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr60).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr61).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr62).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr63).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr64).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr65).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr66).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr67).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr68).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr69).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr70).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr71).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr72).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr73).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr74).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr75).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr76).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr77).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr78).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr79).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr80).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr81).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr82).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr83).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr84).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr85).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr86).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr87).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr88).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr89).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrCurr90).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat10).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat11).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat12).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat13).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat14).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat15).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat16).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat17).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat18).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat19).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat2).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat20).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat21).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat22).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat23).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat24).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat25).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat26).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat27).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat28).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat29).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat3).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat30).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat31).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat32).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat33).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat34).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat35).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat36).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat37).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat38).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat39).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat4).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat40).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat41).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat42).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat43).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat44).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat45).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat46).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat47).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat48).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat49).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat5).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat50).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat51).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat52).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat53).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat54).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat55).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat56).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat57).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat58).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat59).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat6).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat60).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat61).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat62).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat63).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat64).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat65).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat66).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat67).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat68).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat69).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat7).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat70).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat71).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat72).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat73).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat74).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat75).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat76).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat77).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat78).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat79).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat8).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat80).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat81).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat82).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat83).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat84).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat85).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat86).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat87).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat88).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat89).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat9).HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat90).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
