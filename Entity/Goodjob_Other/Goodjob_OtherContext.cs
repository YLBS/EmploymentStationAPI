using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Goodjob_Other
{
    public partial class Goodjob_OtherContext : DbContext
    {
        public Goodjob_OtherContext()
        {
        }

        public Goodjob_OtherContext(DbContextOptions<Goodjob_OtherContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AJobsmall> AJobsmalls { get; set; } = null!;
        public virtual DbSet<BackMemId> BackMemIds { get; set; } = null!;
        public virtual DbSet<BackMyuserId> BackMyuserIds { get; set; } = null!;
        public virtual DbSet<DaoMyUserId> DaoMyUserIds { get; set; } = null!;
        public virtual DbSet<DataAnalysePtposition> DataAnalysePtpositions { get; set; } = null!;
        public virtual DbSet<DataAnalyseWeb> DataAnalyseWebs { get; set; } = null!;
        public virtual DbSet<DataStatCompanyMember> DataStatCompanyMembers { get; set; } = null!;
        public virtual DbSet<DataStatDownload> DataStatDownloads { get; set; } = null!;
        public virtual DbSet<DataStatItem> DataStatItems { get; set; } = null!;
        public virtual DbSet<DataStatPosition> DataStatPositions { get; set; } = null!;
        public virtual DbSet<DataStatResume> DataStatResumes { get; set; } = null!;
        public virtual DbSet<DataStatWeb> DataStatWebs { get; set; } = null!;
        public virtual DbSet<DicCalling> DicCallings { get; set; } = null!;
        public virtual DbSet<DicCertificateType> DicCertificateTypes { get; set; } = null!;
        public virtual DbSet<DicCheckinDate> DicCheckinDates { get; set; } = null!;
        public virtual DbSet<DicCity> DicCities { get; set; } = null!;
        public virtual DbSet<DicCityDr> DicCityDrs { get; set; } = null!;
        public virtual DbSet<DicCompany> DicCompanies { get; set; } = null!;
        public virtual DbSet<DicComputerLevel> DicComputerLevels { get; set; } = null!;
        public virtual DbSet<DicDegree> DicDegrees { get; set; } = null!;
        public virtual DbSet<DicEmployeeSize> DicEmployeeSizes { get; set; } = null!;
        public virtual DbSet<DicJob> DicJobs { get; set; } = null!;
        public virtual DbSet<DicJobFunction> DicJobFunctions { get; set; } = null!;
        public virtual DbSet<DicJobFunction1> DicJobFunctions1 { get; set; } = null!;
        public virtual DbSet<DicJobFunctionBig> DicJobFunctionBigs { get; set; } = null!;
        public virtual DbSet<DicJobFunctionPart> DicJobFunctionParts { get; set; } = null!;
        public virtual DbSet<DicJobFunctionsBig> DicJobFunctionsBigs { get; set; } = null!;
        public virtual DbSet<DicJobFunctionsSmal> DicJobFunctionsSmals { get; set; } = null!;
        public virtual DbSet<DicKeyword> DicKeywords { get; set; } = null!;
        public virtual DbSet<DicKeywordDaily> DicKeywordDailies { get; set; } = null!;
        public virtual DbSet<DicLanguage> DicLanguages { get; set; } = null!;
        public virtual DbSet<DicMemAdvantage> DicMemAdvantages { get; set; } = null!;
        public virtual DbSet<DicMemProperty> DicMemProperties { get; set; } = null!;
        public virtual DbSet<DicNation> DicNations { get; set; } = null!;
        public virtual DbSet<DicOtherDic> DicOtherDics { get; set; } = null!;
        public virtual DbSet<DicOuterSite> DicOuterSites { get; set; } = null!;
        public virtual DbSet<DicProductType> DicProductTypes { get; set; } = null!;
        public virtual DbSet<DicProfessional> DicProfessionals { get; set; } = null!;
        public virtual DbSet<DicProvince> DicProvinces { get; set; } = null!;
        public virtual DbSet<DicProvinceDr> DicProvinceDrs { get; set; } = null!;
        public virtual DbSet<DicPtjobFunction> DicPtjobFunctions { get; set; } = null!;
        public virtual DbSet<DicPtjobFunctionBig> DicPtjobFunctionBigs { get; set; } = null!;
        public virtual DbSet<DicRegisterFund> DicRegisterFunds { get; set; } = null!;
        public virtual DbSet<DicSalary> DicSalaries { get; set; } = null!;
        public virtual DbSet<DicSalaryNew> DicSalaryNews { get; set; } = null!;
        public virtual DbSet<DicSchool> DicSchools { get; set; } = null!;
        public virtual DbSet<DicServiceItem> DicServiceItems { get; set; } = null!;
        public virtual DbSet<DicTown> DicTowns { get; set; } = null!;
        public virtual DbSet<DicWelfare> DicWelfares { get; set; } = null!;
        public virtual DbSet<EmailAdministrator> EmailAdministrators { get; set; } = null!;
        public virtual DbSet<EmailCheckFlag> EmailCheckFlags { get; set; } = null!;
        public virtual DbSet<EmailSendResumeNotUpdated> EmailSendResumeNotUpdateds { get; set; } = null!;
        public virtual DbSet<GoodBossMemId> GoodBossMemIds { get; set; } = null!;
        public virtual DbSet<Log114job> Log114jobs { get; set; } = null!;
        public virtual DbSet<LogCommendResume> LogCommendResumes { get; set; } = null!;
        public virtual DbSet<LogMyuserId> LogMyuserIds { get; set; } = null!;
        public virtual DbSet<LogRefuseApply> LogRefuseApplies { get; set; } = null!;
        public virtual DbSet<LogUpdateMemCalling> LogUpdateMemCallings { get; set; } = null!;
        public virtual DbSet<LogUpdateMemName> LogUpdateMemNames { get; set; } = null!;
        public virtual DbSet<MemLoginLog> MemLoginLogs { get; set; } = null!;
        public virtual DbSet<MmMemId> MmMemIds { get; set; } = null!;
        public virtual DbSet<MngMemLoginLog> MngMemLoginLogs { get; set; } = null!;
        public virtual DbSet<MyLoginLog> MyLoginLogs { get; set; } = null!;
        public virtual DbSet<ServiceNumber> ServiceNumbers { get; set; } = null!;
        public virtual DbSet<TaskQueue> TaskQueues { get; set; } = null!;
        public virtual DbSet<TempSalesname> TempSalesnames { get; set; } = null!;
        public virtual DbSet<TemporaryMemid> TemporaryMemids { get; set; } = null!;
        public virtual DbSet<TmpFangduoduo> TmpFangduoduos { get; set; } = null!;
        public virtual DbSet<TmpJiangweiqi> TmpJiangweiqis { get; set; } = null!;
        public virtual DbSet<TmpLiumeilan> TmpLiumeilans { get; set; } = null!;
        public virtual DbSet<TmpMngAd> TmpMngAds { get; set; } = null!;
        public virtual DbSet<TmpWjl> TmpWjls { get; set; } = null!;
        public virtual DbSet<TmpWuzhifen> TmpWuzhifens { get; set; } = null!;
        public virtual DbSet<TmpXiazhaoxium> TmpXiazhaoxia { get; set; } = null!;
        public virtual DbSet<TmpZhangjun> TmpZhangjuns { get; set; } = null!;
        public virtual DbSet<TmpZhanglikuan> TmpZhanglikuans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.3.2;Initial Catalog=Goodjob_Other;User ID=goodjobjishu;Password=juncaiwang/*-;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AJobsmall>(entity =>
            {
                entity.HasKey(e => e.JobSmall);

                entity.ToTable("a_jobsmall");

                entity.Property(e => e.JobSmall)
                    .ValueGeneratedNever()
                    .HasColumnName("jobSmall");
            });

            modelBuilder.Entity<BackMemId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Back_memID");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<BackMyuserId>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("Back_MyuserID");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");
            });

            modelBuilder.Entity<DaoMyUserId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dao_MyUserID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<DataAnalysePtposition>(entity =>
            {
                entity.ToTable("Data_Analyse_PTPosition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnalyseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsertDateTime).HasColumnType("datetime");

                entity.Property(e => e.Item)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

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

            modelBuilder.Entity<DataStatCompanyMember>(entity =>
            {
                entity.ToTable("Data_StatCompanyMember");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<DataStatDownload>(entity =>
            {
                entity.ToTable("Data_StatDownload");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<DataStatItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Data_StatItem");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataStatPosition>(entity =>
            {
                entity.ToTable("Data_StatPosition");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<DataStatResume>(entity =>
            {
                entity.ToTable("Data_StatResume");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<DataStatWeb>(entity =>
            {
                entity.ToTable("Data_StatWeb");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<DicCalling>(entity =>
            {
                entity.ToTable("Dic_Calling");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicCertificateType>(entity =>
            {
                entity.ToTable("Dic_CertificateType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicCheckinDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_CheckinDate");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicCity>(entity =>
            {
                entity.ToTable("Dic_City");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<DicCityDr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_City_dr");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<DicCompany>(entity =>
            {
                entity.ToTable("Dic_Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicComputerLevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_ComputerLevel");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicDegree>(entity =>
            {
                entity.ToTable("Dic_Degree");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicEmployeeSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_EmployeeSize");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicJob>(entity =>
            {
                entity.ToTable("Dic_Job");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobRequirements)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobResponsibilities)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicJobFunction>(entity =>
            {
                entity.ToTable("Dic_JobFunction");

                entity.HasIndex(e => e.BigId, "IX_Dic_JobFunction_bigid");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BigId).HasColumnName("BigID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicJobFunction1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_JobFunctions");

                entity.Property(e => e.BigId).HasColumnName("BigID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PinYinName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmalId).HasColumnName("SmalID");
            });

            modelBuilder.Entity<DicJobFunctionBig>(entity =>
            {
                entity.ToTable("Dic_JobFunction_Big");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicJobFunctionPart>(entity =>
            {
                entity.HasKey(e => e.Kid);

                entity.ToTable("Dic_JobFunction_Part");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Posname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicJobFunctionsBig>(entity =>
            {
                entity.ToTable("Dic_JobFunctions_Big");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicJobFunctionsSmal>(entity =>
            {
                entity.ToTable("Dic_JobFunctions_Smal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BigId).HasColumnName("BigID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicKeyword>(entity =>
            {
                entity.ToTable("Dic_Keyword");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Channel)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Position)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchedCount).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DicKeywordDaily>(entity =>
            {
                entity.ToTable("Dic_Keyword_Daily");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicLanguage>(entity =>
            {
                entity.ToTable("Dic_Language");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicMemAdvantage>(entity =>
            {
                entity.ToTable("Dic_MemAdvantage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdvantageType).HasComment("企业优势关键词类别：1 融资情况；2 公司亮点；3 公司实力");

                entity.Property(e => e.AdvantageWord)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("对应关键词");
            });

            modelBuilder.Entity<DicMemProperty>(entity =>
            {
                entity.ToTable("Dic_MemProperty");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicNation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_Nation");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicOtherDic>(entity =>
            {
                entity.ToTable("Dic_OtherDic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DicId).HasColumnName("DicID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.TypeMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicOuterSite>(entity =>
            {
                entity.ToTable("Dic_OuterSite");

                entity.HasComment("外网网站字典");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicProductType>(entity =>
            {
                entity.ToTable("Dic_ProductType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicProfessional>(entity =>
            {
                entity.ToTable("Dic_Professional");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfessionalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_Province");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicProvinceDr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_Province_dr");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicPtjobFunction>(entity =>
            {
                entity.ToTable("Dic_PTJobFunction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BigId).HasColumnName("BigID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicPtjobFunctionBig>(entity =>
            {
                entity.ToTable("Dic_PTJobFunction_Big");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicRegisterFund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_RegisterFund");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_Salary");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicSalaryNew>(entity =>
            {
                entity.ToTable("Dic_Salary_New");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<DicSchool>(entity =>
            {
                entity.ToTable("Dic_School");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DicServiceItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_ServiceItem");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicTown>(entity =>
            {
                entity.ToTable("Dic_Town");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<DicWelfare>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dic_Welfare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAdministrator>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Email_Administrator");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailCheckFlag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Email_CheckFlag");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmailSendResumeNotUpdated>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Email_SendResumeNotUpdated");

                entity.Property(e => e.EncryptionStr)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LockDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SendDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GoodBossMemId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GoodBoss_Mem_ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<Log114job>(entity =>
            {
                entity.ToTable("Log_114Job");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExportDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExportTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogCommendResume>(entity =>
            {
                entity.ToTable("Log_CommendResume");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommendDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CommendType).HasDefaultValueSql("((1))");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MyUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OnceCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogMyuserId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log_MyuserID");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");
            });

            modelBuilder.Entity<LogRefuseApply>(entity =>
            {
                entity.ToTable("Log_RefuseApply");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.RefuseDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefuseMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LogUpdateMemCalling>(entity =>
            {
                entity.ToTable("Log_UpdateMemCalling");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogUpdateMemName>(entity =>
            {
                entity.ToTable("Log_UpdateMemName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MemLoginLog>(entity =>
            {
                entity.ToTable("Mem_LoginLog");

                entity.HasIndex(e => e.MemId, "IX_Mem_LoginLog_MemID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LoginType).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MmMemId>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("mm_MemID");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");
            });

            modelBuilder.Entity<MngMemLoginLog>(entity =>
            {
                entity.ToTable("Mng_MemLoginLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MyLoginLog>(entity =>
            {
                entity.ToTable("My_LoginLog");

                entity.HasIndex(e => e.MyUserId, "IX_My_LoginLog_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<ServiceNumber>(entity =>
            {
                entity.ToTable("Service_Number");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.SalerId).HasColumnName("SalerID");
            });

            modelBuilder.Entity<TaskQueue>(entity =>
            {
                entity.ToTable("task_queue");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.TaskContent)
                    .HasMaxLength(100)
                    .HasColumnName("task_content")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(20)
                    .HasColumnName("task_name");

                entity.Property(e => e.TaskResult)
                    .HasMaxLength(200)
                    .HasColumnName("task_result")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaskState)
                    .HasColumnName("task_state")
                    .HasComment("0 待执行 1执行中 2执行完成 3执行失败 ");

                entity.Property(e => e.TaskType)
                    .HasColumnName("task_type")
                    .HasComment("0增1删2改3查4请求");

                entity.Property(e => e.TaskUrl)
                    .HasMaxLength(300)
                    .HasColumnName("task_url")
                    .HasDefaultValueSql("('')")
                    .HasComment("请求地址");

                entity.Property(e => e.TaskUrlData)
                    .HasMaxLength(1000)
                    .HasColumnName("task_url_data")
                    .HasDefaultValueSql("('')")
                    .HasComment("请求数据包");
            });

            modelBuilder.Entity<TempSalesname>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_salesname");

                entity.Property(e => e.EplId).HasColumnName("epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.MemId).HasColumnName("mem_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<TemporaryMemid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TemporaryMemid");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<TmpFangduoduo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_fangduoduo");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpJiangweiqi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_jiangweiqi");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpLiumeilan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_liumeilan");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpMngAd>(entity =>
            {
                entity.ToTable("Tmp_Mng_ad");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AreaSite)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Logo).HasMaxLength(200);

                entity.Property(e => e.MemId)
                    .HasMaxLength(50)
                    .HasColumnName("MemID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PartnerSite)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PopSite)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<TmpWjl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_wjl");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpWuzhifen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_wuzhifen");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");
            });

            modelBuilder.Entity<TmpXiazhaoxium>(entity =>
            {
                entity.HasKey(e => e.Myuserid);

                entity.ToTable("tmp_xiazhaoxia");

                entity.Property(e => e.Myuserid)
                    .ValueGeneratedNever()
                    .HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpZhangjun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_zhangjun");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            modelBuilder.Entity<TmpZhanglikuan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_zhanglikuan");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
