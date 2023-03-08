using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirstSampleApp.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgentFailAbsent> AgentFailAbsents { get; set; } = null!;
        public virtual DbSet<ArsAudit> ArsAudits { get; set; } = null!;
        public virtual DbSet<ArsSetting> ArsSettings { get; set; } = null!;
        public virtual DbSet<ArsUggroup> ArsUggroups { get; set; } = null!;
        public virtual DbSet<ArsUgmember> ArsUgmembers { get; set; } = null!;
        public virtual DbSet<ArsUgright> ArsUgrights { get; set; } = null!;
        public virtual DbSet<ArsUser> ArsUsers { get; set; } = null!;
        public virtual DbSet<BatchInv> BatchInvs { get; set; } = null!;
        public virtual DbSet<BatchPdc> BatchPdcs { get; set; } = null!;
        public virtual DbSet<DaftarTagihanCpd> DaftarTagihanCpds { get; set; } = null!;
        public virtual DbSet<DetailBatchInv> DetailBatchInvs { get; set; } = null!;
        public virtual DbSet<DetailBatchPdc> DetailBatchPdcs { get; set; } = null!;
        public virtual DbSet<DetailDaftarHadir> DetailDaftarHadirs { get; set; } = null!;
        public virtual DbSet<DetailTagihan> DetailTagihans { get; set; } = null!;
        public virtual DbSet<DetailTagihanCpd> DetailTagihanCpds { get; set; } = null!;
        public virtual DbSet<DetailUploadIrregular> DetailUploadIrregulars { get; set; } = null!;
        public virtual DbSet<DetailUploadIrregular1> DetailUploadIrregular1s { get; set; } = null!;
        public virtual DbSet<DetailUploadPerpindahan> DetailUploadPerpindahans { get; set; } = null!;
        public virtual DbSet<DetailUploadProse> DetailUploadProses { get; set; } = null!;
        public virtual DbSet<DetailUploadUnprose> DetailUploadUnproses { get; set; } = null!;
        public virtual DbSet<ExamDetail> ExamDetails { get; set; } = null!;
        public virtual DbSet<FilterIdMobi> FilterIdMobis { get; set; } = null!;
        public virtual DbSet<HeaderTagihan> HeaderTagihans { get; set; } = null!;
        public virtual DbSet<HistoryTglUjian> HistoryTglUjians { get; set; } = null!;
        public virtual DbSet<HistoryUjian> HistoryUjians { get; set; } = null!;
        public virtual DbSet<ListDaftarHadir> ListDaftarHadirs { get; set; } = null!;
        public virtual DbSet<ListUpload> ListUploads { get; set; } = null!;
        public virtual DbSet<ListUploadCpd> ListUploadCpds { get; set; } = null!;
        public virtual DbSet<ListUploadDataModulCore> ListUploadDataModulCores { get; set; } = null!;
        public virtual DbSet<ListUploadLisensi> ListUploadLisensis { get; set; } = null!;
        public virtual DbSet<ListUploadPerpindahan> ListUploadPerpindahans { get; set; } = null!;
        public virtual DbSet<ListUploadPesertaModulCore> ListUploadPesertaModulCores { get; set; } = null!;
        public virtual DbSet<ListUploadReactiveModulCore> ListUploadReactiveModulCores { get; set; } = null!;
        public virtual DbSet<ListUploadUserModulCore> ListUploadUserModulCores { get; set; } = null!;
        public virtual DbSet<ListUploadVaManual> ListUploadVaManuals { get; set; } = null!;
        public virtual DbSet<MTanggalUjian> MTanggalUjians { get; set; } = null!;
        public virtual DbSet<MappingGroupTypeChannel> MappingGroupTypeChannels { get; set; } = null!;
        public virtual DbSet<MasterMenu> MasterMenus { get; set; } = null!;
        public virtual DbSet<MstAksesTipeUser> MstAksesTipeUsers { get; set; } = null!;
        public virtual DbSet<MstBiaya> MstBiayas { get; set; } = null!;
        public virtual DbSet<MstBiayaUjianUlang> MstBiayaUjianUlangs { get; set; } = null!;
        public virtual DbSet<MstBiayaVaManual> MstBiayaVaManuals { get; set; } = null!;
        public virtual DbSet<MstCabang> MstCabangs { get; set; } = null!;
        public virtual DbSet<MstChannel> MstChannels { get; set; } = null!;
        public virtual DbSet<MstChannelCpd> MstChannelCpds { get; set; } = null!;
        public virtual DbSet<MstCoverBiaya> MstCoverBiayas { get; set; } = null!;
        public virtual DbSet<MstDigitalKey> MstDigitalKeys { get; set; } = null!;
        public virtual DbSet<MstHomeCity> MstHomeCities { get; set; } = null!;
        public virtual DbSet<MstJabatan> MstJabatans { get; set; } = null!;
        public virtual DbSet<MstJawaban> MstJawabans { get; set; } = null!;
        public virtual DbSet<MstJenisKelamin> MstJenisKelamins { get; set; } = null!;
        public virtual DbSet<MstJenisLaporan> MstJenisLaporans { get; set; } = null!;
        public virtual DbSet<MstJenisModul> MstJenisModuls { get; set; } = null!;
        public virtual DbSet<MstJenisTagihan> MstJenisTagihans { get; set; } = null!;
        public virtual DbSet<MstJenisTagihanArsLama> MstJenisTagihanArsLamas { get; set; } = null!;
        public virtual DbSet<MstJenisTransaksi> MstJenisTransaksis { get; set; } = null!;
        public virtual DbSet<MstKdAgen> MstKdAgens { get; set; } = null!;
        public virtual DbSet<MstMappingApproval> MstMappingApprovals { get; set; } = null!;
        public virtual DbSet<MstMappingUserCpd> MstMappingUserCpds { get; set; } = null!;
        public virtual DbSet<MstMateri> MstMateris { get; set; } = null!;
        public virtual DbSet<MstMenu> MstMenus { get; set; } = null!;
        public virtual DbSet<MstModul> MstModuls { get; set; } = null!;
        public virtual DbSet<MstModulCore> MstModulCores { get; set; } = null!;
        public virtual DbSet<MstModulLog> MstModulLogs { get; set; } = null!;
        public virtual DbSet<MstOfficeCity> MstOfficeCities { get; set; } = null!;
        public virtual DbSet<MstPesertaCpd> MstPesertaCpds { get; set; } = null!;
        public virtual DbSet<MstPesertaModulCore> MstPesertaModulCores { get; set; } = null!;
        public virtual DbSet<MstPesertum> MstPeserta { get; set; } = null!;
        public virtual DbSet<MstProdtype> MstProdtypes { get; set; } = null!;
        public virtual DbSet<MstSoal> MstSoals { get; set; } = null!;
        public virtual DbSet<MstSoalLog> MstSoalLogs { get; set; } = null!;
        public virtual DbSet<MstStatus> MstStatuses { get; set; } = null!;
        public virtual DbSet<MstStatusCpd> MstStatusCpds { get; set; } = null!;
        public virtual DbSet<MstStatusPerkawinan> MstStatusPerkawinans { get; set; } = null!;
        public virtual DbSet<MstTanggal> MstTanggals { get; set; } = null!;
        public virtual DbSet<MstTanggalNonAktif> MstTanggalNonAktifs { get; set; } = null!;
        public virtual DbSet<MstTanggalOk> MstTanggalOks { get; set; } = null!;
        public virtual DbSet<MstTarifujian> MstTarifujians { get; set; } = null!;
        public virtual DbSet<MstTglUjianIrreguler> MstTglUjianIrregulers { get; set; } = null!;
        public virtual DbSet<MstTipeBisni> MstTipeBisnis { get; set; } = null!;
        public virtual DbSet<MstTipeUser> MstTipeUsers { get; set; } = null!;
        public virtual DbSet<MstUploadIrregular> MstUploadIrregulars { get; set; } = null!;
        public virtual DbSet<MstUploadProse> MstUploadProses { get; set; } = null!;
        public virtual DbSet<MstUploadUnprose> MstUploadUnproses { get; set; } = null!;
        public virtual DbSet<MstUser> MstUsers { get; set; } = null!;
        public virtual DbSet<MstUserCpd> MstUserCpds { get; set; } = null!;
        public virtual DbSet<MstVa> MstVas { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Query> Queries { get; set; } = null!;
        public virtual DbSet<SetujuSpk> SetujuSpks { get; set; } = null!;
        public virtual DbSet<TblBantuan> TblBantuans { get; set; } = null!;
        public virtual DbSet<TblDatum> TblData { get; set; } = null!;
        public virtual DbSet<TblExam> TblExams { get; set; } = null!;
        public virtual DbSet<TblHasilUjian> TblHasilUjians { get; set; } = null!;
        public virtual DbSet<TblKonfUjian> TblKonfUjians { get; set; } = null!;
        public virtual DbSet<TblMobi> TblMobis { get; set; } = null!;
        public virtual DbSet<TblMobis1> TblMobis1s { get; set; } = null!;
        public virtual DbSet<TblMutasiFm> TblMutasiFms { get; set; } = null!;
        public virtual DbSet<TblRejectMobi> TblRejectMobis { get; set; } = null!;
        public virtual DbSet<TblUjianUlang> TblUjianUlangs { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Test1> Test1s { get; set; } = null!;
        public virtual DbSet<TglAgent> TglAgents { get; set; } = null!;
        public virtual DbSet<TglAgentBackup> TglAgentBackups { get; set; } = null!;
        public virtual DbSet<TglAgentHist> TglAgentHists { get; set; } = null!;
        public virtual DbSet<TglAgentLog> TglAgentLogs { get; set; } = null!;
        public virtual DbSet<TglAgentLog1> TglAgentLog1s { get; set; } = null!;
        public virtual DbSet<TrLogProsesBatch> TrLogProsesBatches { get; set; } = null!;
        public virtual DbSet<TransMateri> TransMateris { get; set; } = null!;
        public virtual DbSet<TransModul> TransModuls { get; set; } = null!;
        public virtual DbSet<TransModulBackUp> TransModulBackUps { get; set; } = null!;
        public virtual DbSet<TransPendCar> TransPendCars { get; set; } = null!;
        public virtual DbSet<TransRekon> TransRekons { get; set; } = null!;
        public virtual DbSet<TransSoal> TransSoals { get; set; } = null!;
        public virtual DbSet<TransUjianUlang> TransUjianUlangs { get; set; } = null!;
        public virtual DbSet<TransUploadCpd> TransUploadCpds { get; set; } = null!;
        public virtual DbSet<TransUploadDataModulCore> TransUploadDataModulCores { get; set; } = null!;
        public virtual DbSet<TransUploadLisensi> TransUploadLisensis { get; set; } = null!;
        public virtual DbSet<TransUploadPesertaModulCore> TransUploadPesertaModulCores { get; set; } = null!;
        public virtual DbSet<TransUploadReactiveModulCore> TransUploadReactiveModulCores { get; set; } = null!;
        public virtual DbSet<TransUploadUserModulCore> TransUploadUserModulCores { get; set; } = null!;
        public virtual DbSet<TransUploadVaManual> TransUploadVaManuals { get; set; } = null!;
        public virtual DbSet<TransaksiEmail> TransaksiEmails { get; set; } = null!;
        public virtual DbSet<TrxPengkinianAgen> TrxPengkinianAgens { get; set; } = null!;
        public virtual DbSet<UploadStatusAaji19> UploadStatusAaji19s { get; set; } = null!;
        public virtual DbSet<VAgent> VAgents { get; set; } = null!;
        public virtual DbSet<VAgentTarifujian> VAgentTarifujians { get; set; } = null!;
        public virtual DbSet<VBatchFile> VBatchFiles { get; set; } = null!;
        public virtual DbSet<VBatchFileCabang> VBatchFileCabangs { get; set; } = null!;
        public virtual DbSet<VBatchInv> VBatchInvs { get; set; } = null!;
        public virtual DbSet<VBatchPdc> VBatchPdcs { get; set; } = null!;
        public virtual DbSet<VDaftarTagihanCpd> VDaftarTagihanCpds { get; set; } = null!;
        public virtual DbSet<VDaftarTagihanCpd1> VDaftarTagihanCpd1s { get; set; } = null!;
        public virtual DbSet<VDaftarTagihanCpdNew> VDaftarTagihanCpdNews { get; set; } = null!;
        public virtual DbSet<VDaftarTagihanCpdOld> VDaftarTagihanCpdOlds { get; set; } = null!;
        public virtual DbSet<VDetailBatchInv> VDetailBatchInvs { get; set; } = null!;
        public virtual DbSet<VDetailBatchPdc> VDetailBatchPdcs { get; set; } = null!;
        public virtual DbSet<VDetailDaftarHadir> VDetailDaftarHadirs { get; set; } = null!;
        public virtual DbSet<VDetailTagihanCpdInv> VDetailTagihanCpdInvs { get; set; } = null!;
        public virtual DbSet<VDetailTagihanCpdInvArsLama> VDetailTagihanCpdInvArsLamas { get; set; } = null!;
        public virtual DbSet<VDetailTagihanCpdInvVaManual> VDetailTagihanCpdInvVaManuals { get; set; } = null!;
        public virtual DbSet<VDigitalKey> VDigitalKeys { get; set; } = null!;
        public virtual DbSet<VDigitalKey1> VDigitalKey1s { get; set; } = null!;
        public virtual DbSet<VHeaderTagihan> VHeaderTagihans { get; set; } = null!;
        public virtual DbSet<VJawaban> VJawabans { get; set; } = null!;
        public virtual DbSet<VListUploadPindah> VListUploadPindahs { get; set; } = null!;
        public virtual DbSet<VMasterBiaya> VMasterBiayas { get; set; } = null!;
        public virtual DbSet<VMasterMateri> VMasterMateris { get; set; } = null!;
        public virtual DbSet<VMasterModul> VMasterModuls { get; set; } = null!;
        public virtual DbSet<VMasterSoal> VMasterSoals { get; set; } = null!;
        public virtual DbSet<VMenu> VMenus { get; set; } = null!;
        public virtual DbSet<VModul> VModuls { get; set; } = null!;
        public virtual DbSet<VMstBiayaVaManual> VMstBiayaVaManuals { get; set; } = null!;
        public virtual DbSet<VMstPesertaCpd> VMstPesertaCpds { get; set; } = null!;
        public virtual DbSet<VMstPesertaModulCore> VMstPesertaModulCores { get; set; } = null!;
        public virtual DbSet<VMstVa> VMstVas { get; set; } = null!;
        public virtual DbSet<VPesertum> VPeserta { get; set; } = null!;
        public virtual DbSet<VRekonTagihanCpd> VRekonTagihanCpds { get; set; } = null!;
        public virtual DbSet<VReportChannel> VReportChannels { get; set; } = null!;
        public virtual DbSet<VRfile> VRfiles { get; set; } = null!;
        public virtual DbSet<VRfileCabang> VRfileCabangs { get; set; } = null!;
        public virtual DbSet<VSummeryUjian> VSummeryUjians { get; set; } = null!;
        public virtual DbSet<VTagihan> VTagihans { get; set; } = null!;
        public virtual DbSet<VTagihanVa> VTagihanVas { get; set; } = null!;
        public virtual DbSet<VTglUjian> VTglUjians { get; set; } = null!;
        public virtual DbSet<VTglUjianAr> VTglUjianArs { get; set; } = null!;
        public virtual DbSet<VTglUjianArsLama> VTglUjianArsLamas { get; set; } = null!;
        public virtual DbSet<VTglUjianMobi> VTglUjianMobis { get; set; } = null!;
        public virtual DbSet<VTransMateri> VTransMateris { get; set; } = null!;
        public virtual DbSet<VTransModul> VTransModuls { get; set; } = null!;
        public virtual DbSet<VTransPendCar> VTransPendCars { get; set; } = null!;
        public virtual DbSet<VTransSoal> VTransSoals { get; set; } = null!;
        public virtual DbSet<VTransUploadVaManual> VTransUploadVaManuals { get; set; } = null!;
        public virtual DbSet<VUploadCpd> VUploadCpds { get; set; } = null!;
        public virtual DbSet<VUploadDataModulCore> VUploadDataModulCores { get; set; } = null!;
        public virtual DbSet<VUploadLisensi> VUploadLisensis { get; set; } = null!;
        public virtual DbSet<VUploadPesertaModulCore> VUploadPesertaModulCores { get; set; } = null!;
        public virtual DbSet<VUploadReactiveModulCore> VUploadReactiveModulCores { get; set; } = null!;
        public virtual DbSet<VUploadVaManual> VUploadVaManuals { get; set; } = null!;
        public virtual DbSet<VUserGroupTypeChannel> VUserGroupTypeChannels { get; set; } = null!;
        public virtual DbSet<VVaManualApproval> VVaManualApprovals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=JKV00DEV01.car.co.id;Database=ARSDB_NEW;User Id=admin;Password=car;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgentFailAbsent>(entity =>
            {
                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ArsSetting>(entity =>
            {
                entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ArsUggroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__ars_uggr__149AF30A48CFD27E");
            });

            modelBuilder.Entity<ArsUgmember>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.GroupId })
                    .HasName("PK__ars_ugme__78BB2B6744FF419A");
            });

            modelBuilder.Entity<ArsUgright>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.GroupId })
                    .HasName("PK__ars_ugri__C27FFDDF412EB0B6");
            });

            modelBuilder.Entity<ArsUser>(entity =>
            {
                entity.Property(e => e.GroupTypeData).IsFixedLength();
            });

            modelBuilder.Entity<BatchInv>(entity =>
            {
                entity.Property(e => e.IdBatchInv).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BatchPdc>(entity =>
            {
                entity.Property(e => e.IdBatchPdc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DaftarTagihanCpd>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusPaid).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DetailBatchInv>(entity =>
            {
                entity.Property(e => e.IdDetail).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DetailBatchPdc>(entity =>
            {
                entity.Property(e => e.IdDetailPdc).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DetailTagihan>(entity =>
            {
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DetailTagihanCpd>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HeaderTagihan>(entity =>
            {
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.StatusPaid)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<HistoryUjian>(entity =>
            {
                entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ListUpload>(entity =>
            {
                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MTanggalUjian>(entity =>
            {
                entity.Property(e => e.StatusAktif).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MappingGroupTypeChannel>(entity =>
            {
                entity.Property(e => e.NamaGroup).IsFixedLength();

                entity.Property(e => e.TypeData).IsFixedLength();
            });

            modelBuilder.Entity<MasterMenu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstAksesTipeUser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstBiayaUjianUlang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstBiayaVaManual>(entity =>
            {
                entity.HasKey(e => e.IdBiayaVaManual)
                    .HasName("PK__mst_biay__26835B12F75FB2BD");
            });

            modelBuilder.Entity<MstCabang>(entity =>
            {
                entity.Property(e => e.Idcbg).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstChannel>(entity =>
            {
                entity.Property(e => e.Channel).IsFixedLength();
            });

            modelBuilder.Entity<MstChannelCpd>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstDigitalKey>(entity =>
            {
                entity.Property(e => e.Request).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusExpired).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MstHomeCity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstJabatan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.KodeJabatan).IsFixedLength();

                entity.Property(e => e.NamaJabatan).IsFixedLength();
            });

            modelBuilder.Entity<MstJawaban>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstJenisKelamin>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.KodeJenisKelamin).IsFixedLength();

                entity.Property(e => e.NamaJenisKelamin).IsFixedLength();
            });

            modelBuilder.Entity<MstJenisModul>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstJenisTransaksi>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstKdAgen>(entity =>
            {
                entity.Property(e => e.KdAgen).IsFixedLength();
            });

            modelBuilder.Entity<MstMateri>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstMenu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstModul>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstModulCore>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstModulLog>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstOfficeCity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstSoal>(entity =>
            {
                entity.Property(e => e.StatusFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MstStatusPerkawinan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.KodeStatus).IsFixedLength();

                entity.Property(e => e.NamaStatus).IsFixedLength();
            });

            modelBuilder.Entity<MstTanggal>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__mst_tang__3214D5486B24EA82");

                entity.Property(e => e.No).ValueGeneratedNever();

                entity.Property(e => e.StatusAktif).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MstTanggalOk>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__mst_tang__3214D54866603565");

                entity.Property(e => e.No).ValueGeneratedNever();
            });

            modelBuilder.Entity<MstTglUjianIrreguler>(entity =>
            {
                entity.Property(e => e.Kuota).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MstTipeUser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MstUploadProse>(entity =>
            {
                entity.HasKey(e => e.IdProses)
                    .HasName("PK_mst_upload_proses2");
            });

            modelBuilder.Entity<MstVa>(entity =>
            {
                entity.Property(e => e.IdAgent).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Pid).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasDefaultValueSql("('None')");
            });

            modelBuilder.Entity<TblExam>(entity =>
            {
                entity.Property(e => e.ScheduleStatus).HasDefaultValueSql("('New')");
            });

            modelBuilder.Entity<TblMobi>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusBayar).IsFixedLength();
            });

            modelBuilder.Entity<TblMobis1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusBayar).IsFixedLength();
            });

            modelBuilder.Entity<TblMutasiFm>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblRejectMobi>(entity =>
            {
                entity.Property(e => e.CreateBy).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Aa).IsFixedLength();
            });

            modelBuilder.Entity<TglAgent>(entity =>
            {
                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();

                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<TglAgentBackup>(entity =>
            {
                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<TglAgentHist>(entity =>
            {
                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<TglAgentLog>(entity =>
            {
                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<TglAgentLog1>(entity =>
            {
                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<TrLogProsesBatch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransMateri>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TransModul>(entity =>
            {
                entity.Property(e => e.Score).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TransModulBackUp>(entity =>
            {
                entity.Property(e => e.Score).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TransPendCar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransRekon>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransSoal>(entity =>
            {
                entity.Property(e => e.StatusJawaban).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TransUjianUlang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TrxPengkinianAgen>(entity =>
            {
                entity.Property(e => e.JenisPengajuan).HasComment("1 = Pengkinian SPK\r\n0 = Pengkinian Data");
            });

            modelBuilder.Entity<VAgent>(entity =>
            {
                entity.ToView("v_agent");

                entity.Property(e => e.IdMobis).IsFixedLength();

                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VAgentTarifujian>(entity =>
            {
                entity.ToView("v_agent_tarifujian");

                entity.Property(e => e.IdMobis).IsFixedLength();
            });

            modelBuilder.Entity<VBatchFile>(entity =>
            {
                entity.ToView("v_batch_file");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VBatchFileCabang>(entity =>
            {
                entity.ToView("v_batch_file_cabang");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VBatchInv>(entity =>
            {
                entity.ToView("v_batch_inv");
            });

            modelBuilder.Entity<VBatchPdc>(entity =>
            {
                entity.ToView("v_batch_pdc");
            });

            modelBuilder.Entity<VDaftarTagihanCpd>(entity =>
            {
                entity.ToView("v_daftar_tagihan_cpd");
            });

            modelBuilder.Entity<VDaftarTagihanCpd1>(entity =>
            {
                entity.ToView("v_daftar_tagihan_cpd_1");
            });

            modelBuilder.Entity<VDaftarTagihanCpdNew>(entity =>
            {
                entity.ToView("v_daftar_tagihan_cpd_new");
            });

            modelBuilder.Entity<VDaftarTagihanCpdOld>(entity =>
            {
                entity.ToView("v_daftar_tagihan_cpd_old");
            });

            modelBuilder.Entity<VDetailBatchInv>(entity =>
            {
                entity.ToView("v_detail_batch_inv");
            });

            modelBuilder.Entity<VDetailBatchPdc>(entity =>
            {
                entity.ToView("v_detail_batch_pdc");
            });

            modelBuilder.Entity<VDetailDaftarHadir>(entity =>
            {
                entity.ToView("v_detail_daftar_hadir");
            });

            modelBuilder.Entity<VDetailTagihanCpdInv>(entity =>
            {
                entity.ToView("v_detail_tagihan_cpd_inv");
            });

            modelBuilder.Entity<VDetailTagihanCpdInvArsLama>(entity =>
            {
                entity.ToView("v_detail_tagihan_cpd_inv_ars_lama");
            });

            modelBuilder.Entity<VDetailTagihanCpdInvVaManual>(entity =>
            {
                entity.ToView("v_detail_tagihan_cpd_inv_va_manual");
            });

            modelBuilder.Entity<VDigitalKey>(entity =>
            {
                entity.ToView("v_digital_key");
            });

            modelBuilder.Entity<VDigitalKey1>(entity =>
            {
                entity.ToView("v_digital_key1");
            });

            modelBuilder.Entity<VHeaderTagihan>(entity =>
            {
                entity.ToView("v_header_tagihan");

                entity.Property(e => e.Status).IsFixedLength();

                entity.Property(e => e.StatusPaid).IsFixedLength();
            });

            modelBuilder.Entity<VJawaban>(entity =>
            {
                entity.ToView("v_jawaban");

                entity.Property(e => e.IdJawaban).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VListUploadPindah>(entity =>
            {
                entity.ToView("v_list_upload_pindah");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VMasterBiaya>(entity =>
            {
                entity.ToView("v_master_biaya");

                entity.Property(e => e.IdBiaya).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VMasterMateri>(entity =>
            {
                entity.ToView("v_master_materi");
            });

            modelBuilder.Entity<VMasterModul>(entity =>
            {
                entity.ToView("v_master_modul");
            });

            modelBuilder.Entity<VMasterSoal>(entity =>
            {
                entity.ToView("v_master_soal");
            });

            modelBuilder.Entity<VMenu>(entity =>
            {
                entity.ToView("v_menu");
            });

            modelBuilder.Entity<VModul>(entity =>
            {
                entity.ToView("v_modul");
            });

            modelBuilder.Entity<VMstBiayaVaManual>(entity =>
            {
                entity.ToView("v_mst_biaya_va_manual");
            });

            modelBuilder.Entity<VMstPesertaCpd>(entity =>
            {
                entity.ToView("v_mst_peserta_cpd");
            });

            modelBuilder.Entity<VMstPesertaModulCore>(entity =>
            {
                entity.ToView("v_mst_peserta_modul_core");
            });

            modelBuilder.Entity<VMstVa>(entity =>
            {
                entity.ToView("v_mst_va");
            });

            modelBuilder.Entity<VPesertum>(entity =>
            {
                entity.ToView("v_peserta");
            });

            modelBuilder.Entity<VRekonTagihanCpd>(entity =>
            {
                entity.ToView("v_rekon_tagihan_cpd");
            });

            modelBuilder.Entity<VReportChannel>(entity =>
            {
                entity.ToView("v_report_channel");

                entity.Property(e => e.IdMobis).IsFixedLength();

                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VRfile>(entity =>
            {
                entity.ToView("v_rfile");

                entity.Property(e => e.IdMobis).IsFixedLength();

                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VRfileCabang>(entity =>
            {
                entity.ToView("v_rfile_cabang");

                entity.Property(e => e.IdMobis).IsFixedLength();

                entity.Property(e => e.Idupd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VSummeryUjian>(entity =>
            {
                entity.ToView("v_summery_ujian");
            });

            modelBuilder.Entity<VTagihan>(entity =>
            {
                entity.ToView("v_tagihan");

                entity.Property(e => e.Status).IsFixedLength();

                entity.Property(e => e.StatusPaid).IsFixedLength();
            });

            modelBuilder.Entity<VTagihanVa>(entity =>
            {
                entity.ToView("v_tagihan_va");
            });

            modelBuilder.Entity<VTglUjian>(entity =>
            {
                entity.ToView("v_tgl_ujian");
            });

            modelBuilder.Entity<VTglUjianAr>(entity =>
            {
                entity.ToView("v_tgl_ujian_ars");
            });

            modelBuilder.Entity<VTglUjianArsLama>(entity =>
            {
                entity.ToView("v_tgl_ujian_ars_lama");
            });

            modelBuilder.Entity<VTglUjianMobi>(entity =>
            {
                entity.ToView("v_tgl_ujian_mobis");
            });

            modelBuilder.Entity<VTransMateri>(entity =>
            {
                entity.ToView("v_trans_materi");
            });

            modelBuilder.Entity<VTransModul>(entity =>
            {
                entity.ToView("v_trans_modul");
            });

            modelBuilder.Entity<VTransPendCar>(entity =>
            {
                entity.ToView("v_trans_pend_car");
            });

            modelBuilder.Entity<VTransSoal>(entity =>
            {
                entity.ToView("v_trans_soal");
            });

            modelBuilder.Entity<VTransUploadVaManual>(entity =>
            {
                entity.ToView("v_trans_upload_va_manual");
            });

            modelBuilder.Entity<VUploadCpd>(entity =>
            {
                entity.ToView("v_upload_cpd");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VUploadDataModulCore>(entity =>
            {
                entity.ToView("v_upload_data_modul_core");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VUploadLisensi>(entity =>
            {
                entity.ToView("v_upload_lisensi");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VUploadPesertaModulCore>(entity =>
            {
                entity.ToView("v_upload_peserta_modul_core");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VUploadReactiveModulCore>(entity =>
            {
                entity.ToView("v_upload_reactive_modul_core");

                entity.Property(e => e.UploadId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VUploadVaManual>(entity =>
            {
                entity.ToView("v_upload_va_manual");
            });

            modelBuilder.Entity<VUserGroupTypeChannel>(entity =>
            {
                entity.ToView("v_user_group_type_channel");

                entity.Property(e => e.IdMobis).IsFixedLength();

                entity.Property(e => e.NamaGroup).IsFixedLength();
            });

            modelBuilder.Entity<VVaManualApproval>(entity =>
            {
                entity.ToView("v_va_manual_approval");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
