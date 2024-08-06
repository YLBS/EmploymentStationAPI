using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Sitedata
{
    public partial class sitedataContext : DbContext
    {
        public sitedataContext()
        {
        }

        public sitedataContext(DbContextOptions<sitedataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AC> ACs { get; set; } = null!;
        public virtual DbSet<AMobileNumBack> AMobileNumBacks { get; set; } = null!;
        public virtual DbSet<APaichu> APaichus { get; set; } = null!;
        public virtual DbSet<APcmyuserid> APcmyuserids { get; set; } = null!;
        public virtual DbSet<AdminUser> AdminUsers { get; set; } = null!;
        public virtual DbSet<Article> Articles { get; set; } = null!;
        public virtual DbSet<ArticleClass> ArticleClasses { get; set; } = null!;
        public virtual DbSet<AutomationSigUpAudit> AutomationSigUpAudits { get; set; } = null!;
        public virtual DbSet<BbsSign> BbsSigns { get; set; } = null!;
        public virtual DbSet<BrandInfo> BrandInfos { get; set; } = null!;
        public virtual DbSet<CampusAcompany> CampusAcompanies { get; set; } = null!;
        public virtual DbSet<CampusAdmin> CampusAdmins { get; set; } = null!;
        public virtual DbSet<CampusApply> CampusApplies { get; set; } = null!;
        public virtual DbSet<CampusInvite> CampusInvites { get; set; } = null!;
        public virtual DbSet<CampusIsOk> CampusIsOks { get; set; } = null!;
        public virtual DbSet<CampusMackeRomvePo> CampusMackeRomvePos { get; set; } = null!;
        public virtual DbSet<CampusNmem> CampusNmems { get; set; } = null!;
        public virtual DbSet<CampusNpo> CampusNpos { get; set; } = null!;
        public virtual DbSet<CampusSharingRecord> CampusSharingRecords { get; set; } = null!;
        public virtual DbSet<CampusZpMem> CampusZpMems { get; set; } = null!;
        public virtual DbSet<CampusZpPo> CampusZpPos { get; set; } = null!;
        public virtual DbSet<CampusZpPosTemplate> CampusZpPosTemplates { get; set; } = null!;
        public virtual DbSet<CampusZpSigUp> CampusZpSigUps { get; set; } = null!;
        public virtual DbSet<CampusZpSinUpBack> CampusZpSinUpBacks { get; set; } = null!;
        public virtual DbSet<CampusZphMemContact> CampusZphMemContacts { get; set; } = null!;
        public virtual DbSet<CampusZphMemRelation> CampusZphMemRelations { get; set; } = null!;
        public virtual DbSet<CompanyBusiness> CompanyBusinesses { get; set; } = null!;
        public virtual DbSet<DedeAddonarticle> DedeAddonarticles { get; set; } = null!;
        public virtual DbSet<DedeArchive> DedeArchives { get; set; } = null!;
        public virtual DbSet<JiuYeStation> JiuYeStations { get; set; } = null!;
        public virtual DbSet<JiuYeStationImage> JiuYeStationImages { get; set; } = null!;
        public virtual DbSet<LiveConfereeMyResume> LiveConfereeMyResumes { get; set; } = null!;
        public virtual DbSet<MemParkMem> MemParkMems { get; set; } = null!;
        public virtual DbSet<ParkInfo> ParkInfos { get; set; } = null!;
        public virtual DbSet<ParkNews> ParkNews { get; set; } = null!;
        public virtual DbSet<SArticle> SArticles { get; set; } = null!;
        public virtual DbSet<SArticleClass> SArticleClasses { get; set; } = null!;
        public virtual DbSet<SParent> SParents { get; set; } = null!;
        public virtual DbSet<SkillGameMem> SkillGameMems { get; set; } = null!;
        public virtual DbSet<SkillGameMy> SkillGameMies { get; set; } = null!;
        public virtual DbSet<SysAdClass> SysAdClasses { get; set; } = null!;
        public virtual DbSet<SysAreaSite> SysAreaSites { get; set; } = null!;
        public virtual DbSet<SysCareerSite> SysCareerSites { get; set; } = null!;
        public virtual DbSet<SysHtmlLabel> SysHtmlLabels { get; set; } = null!;
        public virtual DbSet<SysHtmlTemplate> SysHtmlTemplates { get; set; } = null!;
        public virtual DbSet<SysKeyWord> SysKeyWords { get; set; } = null!;
        public virtual DbSet<SysLineAd> SysLineAds { get; set; } = null!;
        public virtual DbSet<SysLineAdRecord> SysLineAdRecords { get; set; } = null!;
        public virtual DbSet<SysSiteName> SysSiteNames { get; set; } = null!;
        public virtual DbSet<TopicInfo> TopicInfos { get; set; } = null!;
        public virtual DbSet<TopicMemInfo> TopicMemInfos { get; set; } = null!;
        public virtual DbSet<TopicNews> TopicNews { get; set; } = null!;
        public virtual DbSet<WapArticle> WapArticles { get; set; } = null!;
        public virtual DbSet<WapArticlesB> WapArticlesBs { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiEntity> ZhaoPinHuis { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiAdminManage> ZhaoPinHuiAdminManages { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiBack> ZhaoPinHuiBacks { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiBooth> ZhaoPinHuiBooths { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiCampus> ZhaoPinHuiCampuses { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiHotCount> ZhaoPinHuiHotCounts { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiImage> ZhaoPinHuiImages { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiK> ZhaoPinHuiKs { get; set; } = null!;
        public virtual DbSet<ZhaoPinHuiNews> ZhaoPinHuiNews { get; set; } = null!;
        public virtual DbSet<ZphAdminUser> ZphAdminUsers { get; set; } = null!;
        public virtual DbSet<ZphAppointmentTime> ZphAppointmentTimes { get; set; } = null!;
        public virtual DbSet<ZphBlack> ZphBlacks { get; set; } = null!;
        public virtual DbSet<ZphBoardDataList> ZphBoardDataLists { get; set; } = null!;
        public virtual DbSet<ZphBoardDataPara> ZphBoardDataParas { get; set; } = null!;
        public virtual DbSet<ZphCheckTemplate> ZphCheckTemplates { get; set; } = null!;
        public virtual DbSet<ZphClickPhoneRecord> ZphClickPhoneRecords { get; set; } = null!;
        public virtual DbSet<ZphConfereeMem> ZphConfereeMems { get; set; } = null!;
        public virtual DbSet<ZphConfereeMemPoster> ZphConfereeMemPosters { get; set; } = null!;
        public virtual DbSet<ZphConfereeMyResume> ZphConfereeMyResumes { get; set; } = null!;
        public virtual DbSet<ZphConfereePo> ZphConfereePos { get; set; } = null!;
        public virtual DbSet<ZphMemContactInfo> ZphMemContactInfos { get; set; } = null!;
        public virtual DbSet<ZphMemContactInfoPay> ZphMemContactInfoPays { get; set; } = null!;
        public virtual DbSet<ZphMemPromise> ZphMemPromises { get; set; } = null!;
        public virtual DbSet<ZphMyEntrance> ZphMyEntrances { get; set; } = null!;
        public virtual DbSet<ZphReg> ZphRegs { get; set; } = null!;
        public virtual DbSet<ZphSchoolSetUp> ZphSchoolSetUps { get; set; } = null!;
        public virtual DbSet<ZphSchoolSetUpContent> ZphSchoolSetUpContents { get; set; } = null!;
        public virtual DbSet<ZphSurvey> ZphSurveys { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.3.2;Initial Catalog=sitedata;User ID=goodjobjishu;Password=juncaiwang/*-;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AC>(entity =>
            {
                entity.HasKey(e => e.Chang);

                entity.ToTable("a_c");

                entity.Property(e => e.Chang)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chang");
            });

            modelBuilder.Entity<AMobileNumBack>(entity =>
            {
                entity.HasKey(e => e.MobileNum);

                entity.ToTable("A_MobileNum_Back");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TrueName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<APaichu>(entity =>
            {
                entity.HasKey(e => e.MemId)
                    .HasName("PK_ls_paichu");

                entity.ToTable("a_paichu");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");
            });

            modelBuilder.Entity<APcmyuserid>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("a_pcmyuserid");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.ToTable("AdminUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminClass)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.NewsId)
                    .HasName("PK_Article_back");

                entity.ToTable("Article");

                entity.HasIndex(e => e.IssueDate, "PK_Aritcle_ID");

                entity.HasIndex(e => e.HitCount, "PK_Article_Hit");

                entity.HasIndex(e => e.ClassId, "PK_News_ClassID");

                entity.HasIndex(e => e.HotFlag, "PK_News_Hot");

                entity.HasIndex(e => e.MemId, "PK_News_MemID");

                entity.HasIndex(e => e.NewsId, "PK_News_NewsID");

                entity.HasIndex(e => e.SiteId, "PK_News_SiteID");

                entity.HasIndex(e => e.Tags, "PK_News_Tag");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassParentId).HasColumnName("ClassParentID");

                entity.Property(e => e.Contents)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoreContent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId)
                    .HasColumnName("MemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RelateJobFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("关联小类职位ID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SmallImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tags)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownId)
                    .HasColumnName("TownID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ArticleClass>(entity =>
            {
                entity.ToTable("ArticleClass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsHide).HasComment("是否隐藏");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<AutomationSigUpAudit>(entity =>
            {
                entity.ToTable("Automation_SigUpAudit");

                entity.Property(e => e.Audit).HasComment("0尚未 1审核通过 2审核未通过");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.Datetime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BbsSign>(entity =>
            {
                entity.HasKey(e => e.SignId);

                entity.ToTable("BBS_Sign");

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Bbsid).HasColumnName("BBSID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.SignDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BrandInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Brand_Info");

                entity.Property(e => e.BrandId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BrandID");

                entity.Property(e => e.BrandIntroduction)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrandType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("9f 旧类别 未启用");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
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

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnBrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FoundDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Initial)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Legalperson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PinYin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CampusAcompany>(entity =>
            {
                entity.ToTable("Campus_ACompany");

                entity.Property(e => e.ComapnyDescribe)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Crmcid)
                    .HasColumnName("CRMCId")
                    .HasComment("后台ID");

                entity.Property(e => e.FixedPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsFull).HasComment("0为填写 1 为填写");

                entity.Property(e => e.MemId).HasComment("企业ID");

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.UpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CampusAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("Campus_Admin");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Time).HasComment("设定 处理限时");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CampusApply>(entity =>
            {
                entity.ToTable("Campus_Apply");

                entity.HasIndex(e => e.CampusId, "PK_Campus_Apply_CampusID");

                entity.HasIndex(e => e.ResumeId, "PK_Campus_Apply_ResumeID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsOk).HasComment("0未选 1可以 2不行 3需复试");
            });

            modelBuilder.Entity<CampusInvite>(entity =>
            {
                entity.ToTable("Campus_Invite");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("datetime")
                    .HasComment("getdate()");

                entity.Property(e => e.IsOk).HasComment("0未选 1可以 2不行 3需复试");

                entity.Property(e => e.ResponseId).HasComment("响应人");

                entity.Property(e => e.SponsorId).HasComment("发起人");
            });

            modelBuilder.Entity<CampusIsOk>(entity =>
            {
                entity.ToTable("Campus_IsOk");

                entity.HasIndex(e => new { e.Cid, e.PosId, e.MemId, e.IsOk, e.CampusId, e.Type }, "CamPus_IsOK_Int");

                entity.HasIndex(e => e.OpenId, "Campus_IsOk_String");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.IsOk).HasComment("0未选 1可以 2不行");

                entity.Property(e => e.OpenId).HasMaxLength(100);

                entity.Property(e => e.Type).HasComment("1是应聘 2是邀约");
            });

            modelBuilder.Entity<CampusMackeRomvePo>(entity =>
            {
                entity.ToTable("Campus_MackeRomvePos");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.PosName).HasMaxLength(50);

                entity.Property(e => e.UpTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CampusNmem>(entity =>
            {
                entity.ToTable("Campus_NMem");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OpenId).HasMaxLength(500);
            });

            modelBuilder.Entity<CampusNpo>(entity =>
            {
                entity.ToTable("Campus_NPos");

                entity.HasIndex(e => e.CampusId, "PK_CampusID");

                entity.HasIndex(e => e.PosId, "PK_PosID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OpenId).HasMaxLength(500);
            });

            modelBuilder.Entity<CampusSharingRecord>(entity =>
            {
                entity.ToTable("Campus_SharingRecords");

                entity.Property(e => e.EndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SartDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CampusZpMem>(entity =>
            {
                entity.ToTable("Campus_ZpMem");

                entity.HasIndex(e => e.AddDateTime, "PK_AddDateTime");

                entity.HasIndex(e => e.CampusZpId, "PK_Campus_ZpID");

                entity.HasIndex(e => e.MemId, "PK_MemID");

                entity.HasIndex(e => e.MemName, "PK_MemName");

                entity.HasIndex(e => e.OpenId, "PK_OpenID");

                entity.HasIndex(e => e.Sequence, "PK_Sequence");

                entity.HasIndex(e => e.ZphNumber, "PK_ZphNumber");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BrowseCount).HasColumnName("browseCount");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenId)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignState).HasComment("1报名  2入场");

                entity.Property(e => e.SignUpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ZphNumber)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CampusZpPo>(entity =>
            {
                entity.ToTable("Campus_ZpPos");

                entity.HasIndex(e => e.PosJobBigId, "PK_PosJobBigID");

                entity.HasIndex(e => e.PosJobId, "PK_PosJobID");

                entity.HasIndex(e => e.PosName, "PK_PosName");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.Pnumber).HasColumnName("PNumber");

                entity.Property(e => e.PosJobBigId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosJobId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosJobValue)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosSalaryRange)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CampusZpPosTemplate>(entity =>
            {
                entity.ToTable("Campus_ZpPosTemplate");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.Pnumber).HasColumnName("PNumber");

                entity.Property(e => e.PosJobBigId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosJobId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosJobValue)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosSalaryRange)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CampusZpSigUp>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("Campus_ZpSigUp");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CjobId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CJobId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CjobMaxId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CJobMaxId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CjobValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CJobValue")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPhone")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Csource)
                    .HasColumnName("CSource")
                    .HasComment("1俊才2招聘会");

                entity.Property(e => e.EntranceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Openid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResumePhotoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SignUpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.State).HasComment("1报名  2入场");
            });

            modelBuilder.Entity<CampusZpSinUpBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campus_ZpSinUp_back");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.CjobId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CJobId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CjobMaxId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CJobMaxId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CjobValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CJobValue")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPhone")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntranceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Openid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignUpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.State).HasComment("1报名  2入场");
            });

            modelBuilder.Entity<CampusZphMemContact>(entity =>
            {
                entity.ToTable("Campus_zphMemContact");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusZpId).HasColumnName("Campus_ZpId");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<CampusZphMemRelation>(entity =>
            {
                entity.ToTable("Campus_ZphMemRelation");

                entity.HasIndex(e => new { e.CampusId, e.MemId }, "PK_Campus_ZphMemRelation_Int");

                entity.HasIndex(e => e.OpenId, "PK_Campus_ZphMemRelation_String");

                entity.Property(e => e.AddDatetime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusId).HasColumnName("Campus_Id");

                entity.Property(e => e.OpenId).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CompanyBusiness>(entity =>
            {
                entity.ToTable("CompanyBusiness");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Business)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FaxNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Word)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DedeAddonarticle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dede_addonarticle");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Redirecturl)
                    .HasMaxLength(255)
                    .HasColumnName("redirecturl");

                entity.Property(e => e.Templet)
                    .HasMaxLength(90)
                    .HasColumnName("templet");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.Property(e => e.Userip)
                    .HasMaxLength(45)
                    .HasColumnName("userip");
            });

            modelBuilder.Entity<DedeArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dede_archives");

                entity.Property(e => e.Arcrank).HasColumnName("arcrank");

                entity.Property(e => e.Badpost).HasColumnName("badpost");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.Click).HasColumnName("click");

                entity.Property(e => e.Color)
                    .HasMaxLength(21)
                    .HasColumnName("color");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Dutyadmin).HasColumnName("dutyadmin");

                entity.Property(e => e.Filename)
                    .HasMaxLength(120)
                    .HasColumnName("filename");

                entity.Property(e => e.Flag)
                    .HasMaxLength(45)
                    .HasColumnName("flag");

                entity.Property(e => e.Goodpost).HasColumnName("goodpost");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ismake).HasColumnName("ismake");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(90)
                    .HasColumnName("keywords");

                entity.Property(e => e.Lastpost).HasColumnName("lastpost");

                entity.Property(e => e.Litpic)
                    .HasMaxLength(240)
                    .HasColumnName("litpic");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Mtype).HasColumnName("mtype");

                entity.Property(e => e.Notpost).HasColumnName("notpost");

                entity.Property(e => e.Pubdate).HasColumnName("pubdate");

                entity.Property(e => e.Scores).HasColumnName("scores");

                entity.Property(e => e.Senddate).HasColumnName("senddate");

                entity.Property(e => e.Shorttitle)
                    .HasMaxLength(108)
                    .HasColumnName("shorttitle");

                entity.Property(e => e.Sortrank).HasColumnName("sortrank");

                entity.Property(e => e.Source)
                    .HasMaxLength(90)
                    .HasColumnName("source");

                entity.Property(e => e.Tackid).HasColumnName("tackid");

                entity.Property(e => e.Title)
                    .HasMaxLength(180)
                    .HasColumnName("title");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.Property(e => e.Typeid2)
                    .HasMaxLength(255)
                    .HasColumnName("typeid2");

                entity.Property(e => e.Writer)
                    .HasMaxLength(60)
                    .HasColumnName("writer");
            });

            modelBuilder.Entity<JiuYeStation>(entity =>
            {
                entity.ToTable("JiuYeStation");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AffiliatedUnit).HasMaxLength(100);

                entity.Property(e => e.Eaddress)
                    .HasMaxLength(100)
                    .HasColumnName("EAddress");

                entity.Property(e => e.EaddressC).HasColumnName("EAddressC");

                entity.Property(e => e.EaddressD).HasColumnName("EAddressD");

                entity.Property(e => e.EaddressP).HasColumnName("EAddressP");

                entity.Property(e => e.EaddressT).HasColumnName("EAddressT");

                entity.Property(e => e.Introduce).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<JiuYeStationImage>(entity =>
            {
                entity.ToTable("JiuYeStation_Image");

                entity.Property(e => e.Esid)
                    .HasColumnName("ESId")
                    .HasComment("驿站ID");

                entity.Property(e => e.ImageType).HasComment("0 1顶部 2列表图片 3环境");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.UpImageDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LiveConfereeMyResume>(entity =>
            {
                entity.HasKey(e => e.SignId);

                entity.ToTable("Live_ConfereeMyResume");

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SignDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemParkMem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ParkMem");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.ParkId).HasColumnName("ParkID");
            });

            modelBuilder.Entity<ParkInfo>(entity =>
            {
                entity.HasKey(e => e.ParkId);

                entity.ToTable("Park_Info");

                entity.HasComment("珠宝园区信息");

                entity.Property(e => e.ParkId).HasColumnName("ParkID");

                entity.Property(e => e.BannerUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.LocationT).HasColumnName("Location_T");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkConfigurationinfo)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkContact)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkIntroduction)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkProjectbrief)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParkStyle)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ParkNews>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Park_News");

                entity.HasComment("珠宝园区资讯");

                entity.Property(e => e.ContentText)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewsID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SArticle>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("S_Article");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassParentId).HasColumnName("ClassParentID");

                entity.Property(e => e.Contents).IsUnicode(false);

                entity.Property(e => e.CoreContent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Tags)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SArticleClass>(entity =>
            {
                entity.ToTable("S_ArticleClass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<SParent>(entity =>
            {
                entity.ToTable("S_Parent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<SkillGameMem>(entity =>
            {
                entity.ToTable("Skill_GameMem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosSort).HasDefaultValueSql("((0))");

                entity.Property(e => e.SGId)
                    .HasColumnName("S_G_ID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SkillGameMy>(entity =>
            {
                entity.ToTable("Skill_GameMy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobFunction)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosIdString)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SGId)
                    .HasColumnName("S_G_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysAdClass>(entity =>
            {
                entity.ToTable("Sys_AdClass");

                entity.HasIndex(e => e.ClassName, "PK_AdClassClassName");

                entity.HasIndex(e => e.SiteId, "PK_AdClassSiteID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<SysAreaSite>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("Sys_AreaSite");

                entity.Property(e => e.SiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("SiteID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Domain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Together)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysCareerSite>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("Sys_CareerSite");

                entity.Property(e => e.SiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("SiteID");

                entity.Property(e => e.Domain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SitePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysHtmlLabel>(entity =>
            {
                entity.ToTable("Sys_HtmlLabel");

                entity.HasIndex(e => e.Disabled, "PK_HtmlLabelDisabled");

                entity.HasIndex(e => e.AutoRefresh, "PK_HtmlabelAutoRefresh");

                entity.HasIndex(e => e.TemplateId, "PK_SysHtmlLabelTemplateID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AreaSiteConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClassNameField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataCondition)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataOrder)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImageField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LabelName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TimeField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TitleField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UrlField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysHtmlTemplate>(entity =>
            {
                entity.ToTable("Sys_HtmlTemplate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MasterPagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaveEncoding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaveFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplatePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysKeyWord>(entity =>
            {
                entity.ToTable("Sys_KeyWord");

                entity.HasIndex(e => e.AddTime, "PK_KeyWordAddTime");

                entity.HasIndex(e => e.KeyWords, "PK_KeyWordKeyWords");

                entity.HasIndex(e => e.PosTypeId, "PK_KeyWordPosTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.KeyHome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PosTypeId).HasColumnName("PosTypeID");
            });

            modelBuilder.Entity<SysLineAd>(entity =>
            {
                entity.ToTable("Sys_LineAd");

                entity.HasIndex(e => e.ClassId, "PK_LineADClassID");

                entity.HasIndex(e => e.EndDate, "PK_LineADEnddate");

                entity.HasIndex(e => e.AddDate, "PK_LineADaddDate");

                entity.HasIndex(e => e.BeginDate, "PK_LineAdBeginDate");

                entity.HasIndex(e => e.MemId, "PK_LineAdMemID");

                entity.HasIndex(e => e.SiteId, "PK_LineAdSiteID");

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

            modelBuilder.Entity<SysLineAdRecord>(entity =>
            {
                entity.ToTable("Sys_LineAdRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TownId).HasColumnName("TownID");

                entity.Property(e => e.TxtRemark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("txtRemark");
            });

            modelBuilder.Entity<SysSiteName>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("Sys_SiteName");

                entity.Property(e => e.SiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TopicInfo>(entity =>
            {
                entity.HasKey(e => e.TopicId)
                    .HasName("PK_Topic_Info_1");

                entity.ToTable("Topic_Info");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TopicConfigurationinfo)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopicIntroduction)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopicName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopicProjectbrief)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopicStyle)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopickContact)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopickLawguide)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopickPreferential)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopickServices)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TopicMemInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Topic_MemInfo");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<TopicNews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("Topic_News");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.ContentText)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WapArticle>(entity =>
            {
                entity.HasKey(e => e.NewsId)
                    .HasName("PK_WapArticles_back");

                entity.HasIndex(e => e.ImagePath, "PK_WapArticles_");

                entity.HasIndex(e => e.IssueDate, "PK_WapArticles_ID");

                entity.HasIndex(e => e.IssueDate, "PK_WapArticles_IssueDate");

                entity.HasIndex(e => e.NewsId, "PK_WapArticles_NewsID");

                entity.HasIndex(e => e.Tags, "PK_WapArticles_Tag");

                entity.HasIndex(e => e.HotFlag, "PK_WapArticles_hotFag");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassParentId).HasColumnName("ClassParentID");

                entity.Property(e => e.Contents)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoreContent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewsFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RelateJobFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SmallImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tags)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownId).HasColumnName("TownID");
            });

            modelBuilder.Entity<WapArticlesB>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("WapArticles_b");

                entity.Property(e => e.NewsId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewsID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassParentId).HasColumnName("ClassParentID");

                entity.Property(e => e.Contents)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoreContent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewsFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SmallImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tags)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownId).HasColumnName("TownID");
            });

            modelBuilder.Entity<ZhaoPinHuiEntity>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_ZhaoPinHui_back");

                entity.ToTable("ZhaoPinHui");

                entity.HasIndex(e => new { e.BenigDate, e.EndDate, e.AddDate, e.UpdateDate, e.RegEndDate }, "PK_Date");

                entity.HasIndex(e => new { e.HotCount, e.ZphType, e.AdminId, e.VideoBeginDate, e.VideoEndDate, e.JobType, e.ZphAdminId }, "PK_Int");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AssistHostunit)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("协办方");

                entity.Property(e => e.BenigDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeUpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CrmzphId).HasColumnName("CRMzphId");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Details)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Display)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupCodePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hostunit)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HotCounts).HasComputedColumnSql("([dbo].[F_GetZphHotCount]([PID]))", false);

                entity.Property(e => e.HrLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrLogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsBlend).HasComment("是否混合模式 线上+线下");

                entity.Property(e => e.IsFree).HasComment("0 mian fei");

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsViedo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWebShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LiveUrl)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LiveUrl1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Location)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemInstructionsPath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("企业操作手册路径");

                entity.Property(e => e.RegEndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("备注 简介 说明");

                entity.Property(e => e.Scale)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignRemind)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpecificTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatType).HasDefaultValueSql("((1))");

                entity.Property(e => e.StudentInstructionsPath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("学生操作手册路径");

                entity.Property(e => e.Subscribe1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subscribe2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subscribe3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subscribe4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TeaserInTop).HasComment("搜索页顶部是否预告招聘会");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UndertakeHostunit)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("承办方");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");

                entity.Property(e => e.ZphGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("招聘会二维码群名");

                entity.Property(e => e.Esid)
                    .HasColumnName("ESId")
                    .HasComment("驿站ID");

                entity.Property(e => e.ZphType).HasComment("0为正常 1为校园");
            });

            modelBuilder.Entity<ZhaoPinHuiAdminManage>(entity =>
            {
                entity.ToTable("ZhaoPinHuiAdminManage");

                entity.Property(e => e.Createdate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SubZphAdminId).HasColumnName("SubZphAdminID");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");
            });

            modelBuilder.Entity<ZhaoPinHuiBack>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_ZhaoPinHui_back_1");

                entity.ToTable("ZhaoPinHui_back");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AssistHostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("协办方");

                entity.Property(e => e.BenigDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CrmzphId).HasColumnName("CRMzphId");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Details)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hostunit)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrLogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsBlend).HasComment("是否混合模式 线上+线下");

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsViedo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWebShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegEndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("备注 简介 说明");

                entity.Property(e => e.Scale)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignRemind)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpecificTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UndertakeHostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("承办方");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");

                entity.Property(e => e.ZphType).HasComment("0为正常 1为校园");
            });

            modelBuilder.Entity<ZhaoPinHuiBooth>(entity =>
            {
                entity.ToTable("ZhaoPinHui_Booth");

                entity.Property(e => e.Id).HasComment("0");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Region).HasMaxLength(20);
            });

            modelBuilder.Entity<ZhaoPinHuiCampus>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_ZhaoPinHuiCampus_1");

                entity.ToTable("ZhaoPinHuiCampus");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.AddDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BenigDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ClassType).HasComment("0 显示  删除");

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Hostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Scale)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ZhaoPinHuiHotCount>(entity =>
            {
                entity.ToTable("ZhaoPinHuiHotCount");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ZhaoPinHuiImage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("自增ID");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("上传时间");

                entity.Property(e => e.Originalpath)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .HasComment("原图地址");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasComment("文章ID");

                entity.Property(e => e.Thumbpath)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .HasComment("缩略图地址");
            });

            modelBuilder.Entity<ZhaoPinHuiK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZhaoPinHui_k");

                entity.HasIndex(e => new { e.BenigDate, e.EndDate, e.AddDate, e.UpdateDate, e.RegEndDate }, "SY_Date");

                entity.HasIndex(e => new { e.HotCount, e.ZphType, e.AdminId, e.CrmzphId, e.JobType, e.ZphAdminId }, "SY_Int");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AssistHostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("协办方");

                entity.Property(e => e.BenigDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CampusTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CrmzphId).HasColumnName("CRMzphId");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Details)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hostunit)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrLogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsViedo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWebShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogoPrimary)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.RegEndDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("备注 简介 说明");

                entity.Property(e => e.Scale)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignRemind)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpecificTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UndertakeHostunit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("承办方");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");

                entity.Property(e => e.ZphType).HasComment("0为正常 1为校园");
            });

            modelBuilder.Entity<ZhaoPinHuiNews>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.ContentText)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotCount).HasComputedColumnSql("([dbo].[F_GetZphHotCount]([PID]))", false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ZphAdminUser>(entity =>
            {
                entity.HasKey(e => e.ZphAdminId)
                    .HasName("PK_Zph_AdminUer");

                entity.ToTable("Zph_AdminUser");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AffiliatedUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ZphAppointmentTime>(entity =>
            {
                entity.ToTable("Zph_AppointmentTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InterviewTime).HasColumnType("smalldatetime");

                entity.Property(e => e.InterviewTimeType).HasMaxLength(50);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ZphBlack>(entity =>
            {
                entity.ToTable("Zph_Black");

                entity.Property(e => e.InDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReDateTme).HasColumnType("smalldatetime");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");
            });

            modelBuilder.Entity<ZphBoardDataList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zph_BoardDataList");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ListType)
                    .HasColumnName("listType")
                    .HasComment("0 :学生专业分布 1:岗位供需对比 2 :岗位薪资分布");

                entity.Property(e => e.MemCount).HasColumnName("memCount");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.StringName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stringName");

                entity.Property(e => e.Switch).HasColumnName("switch");
            });

            modelBuilder.Entity<ZphBoardDataPara>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zph_BoardDataPara");

                entity.Property(e => e.ApplyCount)
                    .HasColumnName("applyCount")
                    .HasComment("学生预约数");

                entity.Property(e => e.ApplyFlag).HasColumnName("applyFlag");

                entity.Property(e => e.ApplyIncrease).HasColumnName("applyIncrease");

                entity.Property(e => e.ApplyInterval).HasColumnName("applyInterval");

                entity.Property(e => e.ApplyMaxCount).HasColumnName("applyMaxCount");

                entity.Property(e => e.CompareFlag).HasColumnName("compareFlag");

                entity.Property(e => e.EntryMemCount)
                    .HasColumnName("entryMemCount")
                    .HasComment("入场企业数");

                entity.Property(e => e.EntryMemFlag).HasColumnName("entryMemFlag");

                entity.Property(e => e.EntryMemIncrease).HasColumnName("entryMemIncrease");

                entity.Property(e => e.EntryMemInterval).HasColumnName("entryMemInterval");

                entity.Property(e => e.EntryMemMaxCount).HasColumnName("entryMemMaxCount");

                entity.Property(e => e.EntryPerCount)
                    .HasColumnName("entryPerCount")
                    .HasComment("现场入场人数");

                entity.Property(e => e.EntryPerFlag).HasColumnName("entryPerFlag");

                entity.Property(e => e.EntryPerIncrease).HasColumnName("entryPerIncrease");

                entity.Property(e => e.EntryPerInterval).HasColumnName("entryPerInterval");

                entity.Property(e => e.EntryPerMaxCount).HasColumnName("entryPerMaxCount");

                entity.Property(e => e.EntryPerNameFlag).HasColumnName("entryPerNameFlag");

                entity.Property(e => e.EntryPerNameRadio).HasColumnName("entryPerNameRadio");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InterviewCount)
                    .HasColumnName("interviewCount")
                    .HasComment("实时面试数");

                entity.Property(e => e.InterviewFlag).HasColumnName("interviewFlag");

                entity.Property(e => e.InterviewIncrease).HasColumnName("interviewIncrease");

                entity.Property(e => e.InterviewInterval).HasColumnName("interviewInterval");

                entity.Property(e => e.InterviewMaxCount).HasColumnName("interviewMaxCount");

                entity.Property(e => e.InviteCount)
                    .HasColumnName("inviteCount")
                    .HasComment("企业邀请数");

                entity.Property(e => e.InviteFlag).HasColumnName("inviteFlag");

                entity.Property(e => e.InviteIncrease).HasColumnName("inviteIncrease");

                entity.Property(e => e.InviteInterval).HasColumnName("inviteInterval");

                entity.Property(e => e.InviteMaxCount).HasColumnName("inviteMaxCount");

                entity.Property(e => e.MajorFlag).HasColumnName("majorFlag");

                entity.Property(e => e.PId).HasColumnName("pId");

                entity.Property(e => e.RecruitPerCount)
                    .HasColumnName("recruitPerCount")
                    .HasComment("招聘人数");

                entity.Property(e => e.RecruitPerFlag).HasColumnName("recruitPerFlag");

                entity.Property(e => e.RecruitPosCount)
                    .HasColumnName("recruitPosCount")
                    .HasComment("招聘岗位数");

                entity.Property(e => e.RecruitPosFlag).HasColumnName("recruitPosFlag");

                entity.Property(e => e.RequirePosCount)
                    .HasColumnName("requirePosCount")
                    .HasComment("需求岗位数");

                entity.Property(e => e.RequirePosFlag).HasColumnName("requirePosFlag");

                entity.Property(e => e.SalaryFlag).HasColumnName("salaryFlag");

                entity.Property(e => e.SignUpMemCount)
                    .HasColumnName("signUpMemCount")
                    .HasComment("报名企业数");

                entity.Property(e => e.SignUpMemFlag).HasColumnName("signUpMemFlag");

                entity.Property(e => e.SignUpPerCount)
                    .HasColumnName("signUpPerCount")
                    .HasComment("报名学生数");

                entity.Property(e => e.SignUpPerFlag).HasColumnName("signUpPerFlag");

                entity.Property(e => e.Switch).HasColumnName("switch");
            });

            modelBuilder.Entity<ZphCheckTemplate>(entity =>
            {
                entity.ToTable("Zph_CheckTemplate");

                entity.Property(e => e.CreatDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DellDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");
            });

            modelBuilder.Entity<ZphClickPhoneRecord>(entity =>
            {
                entity.ToTable("Zph_ClickPhoneRecord");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ZphConfereeMem>(entity =>
            {
                entity.HasKey(e => e.ConfereeId);

                entity.ToTable("Zph_ConfereeMem");

                entity.HasIndex(e => e.IsOnline, "PK_IsOnline");

                entity.HasIndex(e => e.MemId, "PK_MemID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.HasIndex(e => e.SignDate, "PK_SignDate");

                entity.HasIndex(e => e.StallNum, "PK_StallNum");

                entity.Property(e => e.ConfereeId).HasColumnName("ConfereeID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSchool).HasComment("是否校企");

                entity.Property(e => e.IsZjopen).HasColumnName("IsZJOpen");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewCheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pconline).HasColumnName("PCOnline");

                entity.Property(e => e.PconlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PCOnlineDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.SignDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ssmsdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SSMSDate");
            });

            modelBuilder.Entity<ZphConfereeMemPoster>(entity =>
            {
                entity.ToTable("Zph_ConfereeMemPoster");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsOk).HasComment("是否可以 0 待定 1可以 2不行");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Poster)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosterUrl)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RdateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RDateTime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SendDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ZphConfereeMyResume>(entity =>
            {
                entity.HasKey(e => e.SignId);

                entity.ToTable("Zph_ConfereeMyResume");

                entity.HasIndex(e => e.MyUserId, "PK_MyUserID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.HasIndex(e => e.SignDateTime, "PK_SingnDateTime");

                entity.HasIndex(e => e.SignId, "PK_SingnID");

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SignDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ZphConfereePo>(entity =>
            {
                entity.HasKey(e => e.StatisticsId);

                entity.ToTable("Zph_ConfereePos");

                entity.HasIndex(e => e.IsDell, "PK_Dell");

                entity.HasIndex(e => e.MemId, "PK_MemID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.HasIndex(e => e.PosId, "PK_PosID");

                entity.HasIndex(e => e.AddDateTime, "PK_date");

                entity.Property(e => e.StatisticsId).HasColumnName("StatisticsID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckFlag).HasComment("1 新增待审核  2 审核 3位通过  4 修改待审核");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Region)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .HasComment("未通过 原因");
            });

            modelBuilder.Entity<ZphMemContactInfo>(entity =>
            {
                entity.ToTable("Zph_MemContactInfo");

                entity.HasIndex(e => new { e.CreateDate, e.UpDate }, "PK_Date");

                entity.HasIndex(e => e.MemId, "PK_MemID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HealthCode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .HasColumnName("IDCard")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Landline)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("座机号码 用-分割");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.PosterPrintFlag).HasComment("是否印刷到海报上 0 不显示 ； 1 用手机号 ； 2 用座机 ; 3 两个都加上去");

                entity.Property(e => e.TripCode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Up_date");
            });

            modelBuilder.Entity<ZphMemContactInfoPay>(entity =>
            {
                entity.ToTable("Zph_MemContactInfo_Pay");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HealthCode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idcard)
                    .HasMaxLength(50)
                    .HasColumnName("IDCard")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LandLine)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.OrderString)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.PosIds)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosterPrintFlag).HasComment("是否印刷到海报上 0 不显示 ； 1 用手机号 ； 2 用座机 ; 3 两个都加上去");

                entity.Property(e => e.TripCode)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Up_date");
            });

            modelBuilder.Entity<ZphMemPromise>(entity =>
            {
                entity.ToTable("Zph_MemPromise");

                entity.HasIndex(e => new { e.CreateDate, e.UpDate }, "PK_Date");

                entity.HasIndex(e => e.MemId, "PK_MemID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.UpDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Up_date");

                entity.Property(e => e.ViolationRemark)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ZphMyEntrance>(entity =>
            {
                entity.ToTable("Zph_MyEntrance");

                entity.HasIndex(e => e.EntranceDate, "PK_EntranceDate");

                entity.HasIndex(e => e.MyUserId, "PK_MyUserID");

                entity.HasIndex(e => e.Pid, "PK_PID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntranceDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ZphReg>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("Zph_Reg");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.College)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobString)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemString)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("OpenID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Professional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StudentID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TheClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TrueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ZphSchoolSetUp>(entity =>
            {
                entity.ToTable("Zph_School_SetUp");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Stype)
                    .HasColumnName("SType")
                    .HasComment("0 初始值 1年级  2院系 3专业 4班级");

                entity.Property(e => e.UpDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");
            });

            modelBuilder.Entity<ZphSchoolSetUpContent>(entity =>
            {
                entity.ToTable("Zph_School_SetUpContent");

                entity.Property(e => e.CreatDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SetUpContent)
                    .HasMaxLength(7000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ZphAdminId).HasColumnName("ZphAdminID");
            });

            modelBuilder.Entity<ZphSurvey>(entity =>
            {
                entity.ToTable("Zph_Survey");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Survey1).HasMaxLength(50);

                entity.Property(e => e.Survey2).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
