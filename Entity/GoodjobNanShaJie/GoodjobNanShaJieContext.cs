using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.GoodjobNanShaJie
{
    public partial class GoodjobNanShaJieContext : DbContext
    {
        public GoodjobNanShaJieContext()
        {
        }

        public GoodjobNanShaJieContext(DbContextOptions<GoodjobNanShaJieContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataAnalyseWeb> DataAnalyseWebs { get; set; } = null!;
        public virtual DbSet<ErmEmployee> ErmEmployees { get; set; } = null!;
        public virtual DbSet<MemAccount> MemAccounts { get; set; } = null!;
        public virtual DbSet<MemBackPassword> MemBackPasswords { get; set; } = null!;
        public virtual DbSet<MemCheckResumeContactRecord> MemCheckResumeContactRecords { get; set; } = null!;
        public virtual DbSet<MemCompanyInfo> MemCompanyInfos { get; set; } = null!;
        public virtual DbSet<MemDepartment> MemDepartments { get; set; } = null!;
        public virtual DbSet<MemHiresLog> MemHiresLogs { get; set; } = null!;
        public virtual DbSet<MemImage> MemImages { get; set; } = null!;
        public virtual DbSet<MemInfo> MemInfos { get; set; } = null!;
        public virtual DbSet<MemInterFace> MemInterFaces { get; set; } = null!;
        public virtual DbSet<MemLibCommend> MemLibCommends { get; set; } = null!;
        public virtual DbSet<MemLibDel> MemLibDels { get; set; } = null!;
        public virtual DbSet<MemLibDownload> MemLibDownloads { get; set; } = null!;
        public virtual DbSet<MemLibOwer> MemLibOwers { get; set; } = null!;
        public virtual DbSet<MemLibOwerSort> MemLibOwerSorts { get; set; } = null!;
        public virtual DbSet<MemLibTemp> MemLibTemps { get; set; } = null!;
        public virtual DbSet<MemMapCoordinate> MemMapCoordinates { get; set; } = null!;
        public virtual DbSet<MemOpenHistory> MemOpenHistories { get; set; } = null!;
        public virtual DbSet<MemPosDescriptionTemplate> MemPosDescriptionTemplates { get; set; } = null!;
        public virtual DbSet<MemPosInvitationsRecord> MemPosInvitationsRecords { get; set; } = null!;
        public virtual DbSet<MemPosJobFunction> MemPosJobFunctions { get; set; } = null!;
        public virtual DbSet<MemPosJobFunction1> MemPosJobFunctions1 { get; set; } = null!;
        public virtual DbSet<MemPosJobFunctionTime> MemPosJobFunctionTimes { get; set; } = null!;
        public virtual DbSet<MemPosJobLocation> MemPosJobLocations { get; set; } = null!;
        public virtual DbSet<MemPosJobLocation1> MemPosJobLocations1 { get; set; } = null!;
        public virtual DbSet<MemPosNoRefresh> MemPosNoRefreshes { get; set; } = null!;
        public virtual DbSet<MemPosQuery> MemPosQueries { get; set; } = null!;
        public virtual DbSet<MemPosSpotRecord> MemPosSpotRecords { get; set; } = null!;
        public virtual DbSet<MemPosition> MemPositions { get; set; } = null!;
        public virtual DbSet<MemRemarkList> MemRemarkLists { get; set; } = null!;
        public virtual DbSet<MemServiceNumber> MemServiceNumbers { get; set; } = null!;
        public virtual DbSet<MemSmsRecord> MemSmsRecords { get; set; } = null!;
        public virtual DbSet<MemSmsforResume> MemSmsforResumes { get; set; } = null!;
        public virtual DbSet<MemUser> MemUsers { get; set; } = null!;
        public virtual DbSet<MyAccount> MyAccounts { get; set; } = null!;
        public virtual DbSet<MyFavouriate> MyFavouriates { get; set; } = null!;
        public virtual DbSet<MyJobFunctionTime> MyJobFunctionTimes { get; set; } = null!;
        public virtual DbSet<MyPosCollectionRecord> MyPosCollectionRecords { get; set; } = null!;
        public virtual DbSet<MyResume> MyResumes { get; set; } = null!;
        public virtual DbSet<MySkill> MySkills { get; set; } = null!;
        public virtual DbSet<NewsInfo> NewsInfos { get; set; } = null!;
        public virtual DbSet<PubInterviewing> PubInterviewings { get; set; } = null!;
        public virtual DbSet<PubNoticeInfo> PubNoticeInfos { get; set; } = null!;
        public virtual DbSet<PubPerApplyPo> PubPerApplyPos { get; set; } = null!;
        public virtual DbSet<PubPosApplyRecord> PubPosApplyRecords { get; set; } = null!;
        public virtual DbSet<PubPosContractRecord> PubPosContractRecords { get; set; } = null!;
        public virtual DbSet<PubResumeBrowsedLog> PubResumeBrowsedLogs { get; set; } = null!;
        public virtual DbSet<PubResumeViewLog> PubResumeViewLogs { get; set; } = null!;
        public virtual DbSet<PubVisitPosRecord> PubVisitPosRecords { get; set; } = null!;
        public virtual DbSet<SysLineAd> SysLineAds { get; set; } = null!;
        public virtual DbSet<SysMenu> SysMenus { get; set; } = null!;
        public virtual DbSet<SysMessage> SysMessages { get; set; } = null!;
        public virtual DbSet<TJobFairAlbum> TJobFairAlbums { get; set; } = null!;
        public virtual DbSet<TJobFairInfo> TJobFairInfos { get; set; } = null!;
        public virtual DbSet<TableMaxId> TableMaxIds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.3.2;Initial Catalog=GoodjobNanShaJie;User ID=goodjobjishu;Password=juncaiwang/*-;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataAnalyseWeb>(entity =>
            {
                entity.ToTable("Data_Analyse_Web");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnalyseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AnalyseType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Item)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErmEmployee>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("ERM_Employee");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("EPL_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bqq)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.DgrId).HasColumnName("DGR_ID");

                entity.Property(e => e.Diploma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId)
                    .HasColumnName("ES_ID")
                    .HasDefaultValueSql("((1801))");

                entity.Property(e => e.Headship)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ID_Card")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interest)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LimitIp).HasColumnName("LimitIP");

                entity.Property(e => e.LnkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LnkTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneId)
                    .HasColumnName("PhoneID")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('\\images\\EmployeePhoto\\no_image.gif')");

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosiDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tongue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TraiBeginTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("traiBeginTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TraiEndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("traiEndTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemAccount>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Account");

                entity.Property(e => e.MemId).ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountPwd)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JcwmemId).HasColumnName("JCWMemId");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(50)
                    .HasColumnName("LastLoginIP");

                entity.Property(e => e.LastTime).HasColumnType("smalldatetime");

                entity.Property(e => e.RegisterTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegisterType).HasComment("0 为 网页 1为APP");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");

                entity.Property(e => e.WxOpenId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemBackPassword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_BackPassword");

                entity.Property(e => e.EncryptionStr)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.SendTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemCheckResumeContactRecord>(entity =>
            {
                entity.ToTable("Mem_CheckResumeContactRecord");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemCompanyInfo>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_CompanyInfo");

                entity.Property(e => e.MemId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AddressT).HasColumnName("Address_T");

                entity.Property(e => e.CompanyStats)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 默认状态 1 审核通过 2 尚未审核通过  3提交审核");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Introduce)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemDepartment>(entity =>
            {
                entity.ToTable("Mem_Department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemHiresLog>(entity =>
            {
                entity.ToTable("Mem_HiresLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndHiresDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HiresDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemImage>(entity =>
            {
                entity.ToTable("Mem_Image");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContentType).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type).HasComment("图片类型 0为logo 1为环境");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemInfo>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Info");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AddressT)
                    .HasColumnName("Address_T")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyIntroduction)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FoundDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenceNumber)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoUpdatedate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldContactTel)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qqflag).HasColumnName("QQFlag");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemInterFace>(entity =>
            {
                entity.HasKey(e => e.InviteId);

                entity.ToTable("Mem_InterFace");

                entity.Property(e => e.InviteId).HasColumnName("InviteID");

                entity.Property(e => e.InviteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InviteTite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.WxInterviewAdress)
                    .HasMaxLength(500)
                    .HasColumnName("wxInterviewAdress")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxInterviewCompany)
                    .HasMaxLength(200)
                    .HasColumnName("wxInterviewCompany")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxInterviewDate)
                    .HasMaxLength(200)
                    .HasColumnName("wxInterviewDate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxInterviewName)
                    .HasMaxLength(100)
                    .HasColumnName("wxInterviewName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxInterviewPhone)
                    .HasMaxLength(100)
                    .HasColumnName("wxInterviewPhone")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxIsActive).HasColumnName("wxIsActive");
            });

            modelBuilder.Entity<MemLibCommend>(entity =>
            {
                entity.ToTable("Mem_LibCommend");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.SalerId).HasColumnName("SalerID");
            });

            modelBuilder.Entity<MemLibDel>(entity =>
            {
                entity.ToTable("Mem_LibDel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DelFrom).HasDefaultValueSql("('')");

                entity.Property(e => e.DelTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OldRecordId).HasColumnName("OldRecordID");
            });

            modelBuilder.Entity<MemLibDownload>(entity =>
            {
                entity.ToTable("Mem_LibDownload");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DownDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MemLibOwer>(entity =>
            {
                entity.ToTable("Mem_LibOwer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemLibOwerSort>(entity =>
            {
                entity.ToTable("Mem_LibOwerSort");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.SortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemLibTemp>(entity =>
            {
                entity.ToTable("Mem_LibTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MemMapCoordinate>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_MapCoordinate");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lng");
            });

            modelBuilder.Entity<MemOpenHistory>(entity =>
            {
                entity.ToTable("Mem_OpenHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RegisterDAte")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalerUserId).HasColumnName("SalerUserID");

                entity.Property(e => e.Show)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SignDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserIP")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemPosDescriptionTemplate>(entity =>
            {
                entity.ToTable("Mem_PosDescriptionTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Posdescription).HasMaxLength(1800);

                entity.Property(e => e.Tite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemPosInvitationsRecord>(entity =>
            {
                entity.ToTable("Mem_PosInvitationsRecord");

                entity.Property(e => e.ContractTime).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvitationContent).HasMaxLength(500);

                entity.Property(e => e.InvitationsTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContract).HasComment("是否签约 0否 1 是");

                entity.Property(e => e.ReadTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemPosJobFunction>(entity =>
            {
                entity.ToTable("Mem_PosJobFunction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_small");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobFunction1>(entity =>
            {
                entity.ToTable("MemPos_JobFunction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobfunctionSmall).HasColumnName("Jobfunction_small");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobFunctionTime>(entity =>
            {
                entity.ToTable("Mem_PosJobFunctionTime");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobTime).HasMaxLength(50);

                entity.Property(e => e.TimeType)
                    .HasMaxLength(50)
                    .HasComment("时间类型：11上午12下午13晚上");

                entity.Property(e => e.WorkTime).HasMaxLength(50);
            });

            modelBuilder.Entity<MemPosJobLocation>(entity =>
            {
                entity.ToTable("Mem_PosJobLocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobLocationC).HasColumnName("JobLocation_C");

                entity.Property(e => e.JobLocationP).HasColumnName("JobLocation_P");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobLocation1>(entity =>
            {
                entity.ToTable("MemPos_JobLocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobLocationC).HasColumnName("JobLocation_C");

                entity.Property(e => e.JobLocationP).HasColumnName("JobLocation_P");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosNoRefresh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_PosNoRefresh");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosQuery>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("MemPos_Query");

                entity.Property(e => e.PosId)
                    .ValueGeneratedNever()
                    .HasColumnName("PosID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Geyn).HasColumnName("GEYN");

                entity.Property(e => e.HasPage).HasComment("是否有专页");

                entity.Property(e => e.Iscommend).HasComment("是否推荐企业");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemRegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PosDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryRange).HasMaxLength(150);

                entity.Property(e => e.SeoAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Welfa).HasMaxLength(150);
            });

            modelBuilder.Entity<MemPosSpotRecord>(entity =>
            {
                entity.ToTable("Mem_PosSpotRecord");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .HasComment("订单编号");

                entity.Property(e => e.Spot).HasComment("点数");

                entity.Property(e => e.SpotType).HasComment("点数类型 0为充值 1为消费");
            });

            modelBuilder.Entity<MemPosition>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("Mem_Position");

                entity.Property(e => e.PosId)
                    .ValueGeneratedNever()
                    .HasColumnName("PosID");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.BeginHiresDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Calling).HasComment("职位类型");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactFaxZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTelZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExamAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamNotice)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Geyn).HasColumnName("GEYN");

                entity.Property(e => e.HitCounter).HasComment("查看次数(登录后的查看方位有效)");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(1800)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("职位刷新时间(显示以该时间为准)");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TagLib)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Welfa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemRemarkList>(entity =>
            {
                entity.ToTable("Mem_Remark_List");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MarkMemo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarkTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarkUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('''')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MemServiceNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ServiceNumber");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PosNumber).HasComment("职位数量");

                entity.Property(e => e.ResumeNumber).HasComment("简历数量");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemSmsRecord>(entity =>
            {
                entity.ToTable("Mem_SmsRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SendContent).HasMaxLength(500);

                entity.Property(e => e.SendTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemSmsforResume>(entity =>
            {
                entity.ToTable("Mem_SMSForResume");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LatestSendTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SentCount).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MemUser>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Users");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.BeginValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckUserId).HasColumnName("CheckUserID");

                entity.Property(e => e.DateMaxViewNum).HasDefaultValueSql("((100))");

                entity.Property(e => e.EndValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LastLoginIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxPosNum).HasDefaultValueSql("((999))");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalerTel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalerUserId).HasColumnName("SalerUserID");

                entity.Property(e => e.SalerUserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyAccount>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Account");

                entity.Property(e => e.MyUserId).ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(20);

                entity.Property(e => e.AccountPwd).HasMaxLength(20);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JcwresumeId)
                    .HasColumnName("JCWResumeId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(20)
                    .HasColumnName("LastLoginIP");

                entity.Property(e => e.LastLongTime).HasColumnType("smalldatetime");

                entity.Property(e => e.RegisterTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");

                entity.Property(e => e.WxOpenId).HasMaxLength(50);
            });

            modelBuilder.Entity<MyFavouriate>(entity =>
            {
                entity.ToTable("My_Favouriate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MyJobFunctionTime>(entity =>
            {
                entity.ToTable("My_JobFunctionTime");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobTime).HasMaxLength(50);

                entity.Property(e => e.TimeType).HasMaxLength(50);

                entity.Property(e => e.WorkTime).HasMaxLength(50);
            });

            modelBuilder.Entity<MyPosCollectionRecord>(entity =>
            {
                entity.ToTable("My_PosCollectionRecord");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsCollection).HasComment("是否收藏(0 不收藏 1收藏 ) 默认值为0");
            });

            modelBuilder.Entity<MyResume>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Resume");

                entity.Property(e => e.MyUserId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("出生日期");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoordinateY).HasDefaultValueSql("((0))");

                entity.Property(e => e.CoordinateZ).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobAddress)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobAddressC).HasColumnName("JobAddress_C");

                entity.Property(e => e.JobAddressP).HasColumnName("JobAddress_P");

                entity.Property(e => e.PerName).HasMaxLength(50);

                entity.Property(e => e.PhotoDisplay).HasComment("0 初始值 1公开 2为不公开");

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("头像");

                entity.Property(e => e.PosCalling)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .HasComment("职位类型（13,11 ,号区分）");

                entity.Property(e => e.ResumeSate).HasComment("简历状态默认0(0正常 1符合 2不符合");

                entity.Property(e => e.ResumeTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UpTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MySkill>(entity =>
            {
                entity.ToTable("My_Skill");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SkillDescribe).HasMaxLength(200);

                entity.Property(e => e.SkillLevel).HasMaxLength(50);

                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            modelBuilder.Entity<NewsInfo>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("News_Info");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.ArticleType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContentText)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Introduction)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PubInterviewing>(entity =>
            {
                entity.ToTable("Pub_Interviewing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterviewTime).HasColumnType("smalldatetime");

                entity.Property(e => e.InterviewTimeType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InviteCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.InviteDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InviteMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PerTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<PubNoticeInfo>(entity =>
            {
                entity.ToTable("Pub_NoticeInfo");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsRead).HasComment("是否读取");

                entity.Property(e => e.Ncontent)
                    .HasMaxLength(200)
                    .HasColumnName("NContent");

                entity.Property(e => e.ReadTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Type).HasComment("通知类型 0位所有 1为企业 2为个人");
            });

            modelBuilder.Entity<PubPerApplyPo>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PerTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ReceiveCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PubPosApplyRecord>(entity =>
            {
                entity.ToTable("Pub_PosApplyRecord");

                entity.Property(e => e.ApplyState).HasComment("1为邀约 2为拒绝");

                entity.Property(e => e.ApplyTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContract).HasComment("是否签约 0否 1 是");

                entity.Property(e => e.ReadTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PubPosContractRecord>(entity =>
            {
                entity.ToTable("Pub_PosContractRecord");

                entity.Property(e => e.ContractTime).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContract).HasComment("是否签约 0否 1 是");
            });

            modelBuilder.Entity<PubResumeBrowsedLog>(entity =>
            {
                entity.ToTable("Pub_ResumeBrowsedLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LatestBrowsedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<PubResumeViewLog>(entity =>
            {
                entity.ToTable("pub_ResumeViewLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OperateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OperateIp)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubVisitPosRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_VisitPosRecord");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VisitCount).HasComment("查看次数(重复查看则累加该字段)");
            });

            modelBuilder.Entity<SysLineAd>(entity =>
            {
                entity.ToTable("Sys_LineAd");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SpaceCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.TopValue).HasDefaultValueSql("((100))");

                entity.Property(e => e.TownId)
                    .HasColumnName("TownID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TxtRemark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("txtRemark")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.HasKey(e => e.MnuId);

                entity.ToTable("SYS_Menu");

                entity.Property(e => e.MnuId)
                    .ValueGeneratedNever()
                    .HasColumnName("Mnu_ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LnkUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("lnkURL");

                entity.Property(e => e.Memo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MnuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mnu_Name");

                entity.Property(e => e.MnuType).HasColumnName("Mnu_Type");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Message");

                entity.Property(e => e.CreatDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Message).HasColumnType("text");
            });

            modelBuilder.Entity<TJobFairAlbum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_JobFairAlbum");

                entity.Property(e => e.Addtime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Originalpath)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TJobFairInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_JobFairInfo");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BenigDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.Property(e => e.Scale)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TableMaxId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableMaxID");

                entity.Property(e => e.MaxId)
                    .HasColumnName("MaxID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
