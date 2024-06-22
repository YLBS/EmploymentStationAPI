using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.GoodBoss
{
    public partial class GoodBossContext : DbContext
    {
        public GoodBossContext()
        {
        }

        public GoodBossContext(DbContextOptions<GoodBossContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AiDialingRecord> AiDialingRecords { get; set; } = null!;
        public virtual DbSet<AnalyseHolidayDatum> AnalyseHolidayData { get; set; } = null!;
        public virtual DbSet<ApEplId> ApEplIds { get; set; } = null!;
        public virtual DbSet<AppSecurity> AppSecurities { get; set; } = null!;
        public virtual DbSet<Article> Articles { get; set; } = null!;
        public virtual DbSet<CeshiMemId> CeshiMemIds { get; set; } = null!;
        public virtual DbSet<Ceshicomid> Ceshicomids { get; set; } = null!;
        public virtual DbSet<ClerkGoup> ClerkGoups { get; set; } = null!;
        public virtual DbSet<ClerkGoupInfo> ClerkGoupInfos { get; set; } = null!;
        public virtual DbSet<ClientCollaborative> ClientCollaboratives { get; set; } = null!;
        public virtual DbSet<ClientCollaborativeBack> ClientCollaborativeBacks { get; set; } = null!;
        public virtual DbSet<ClientCurveDetail> ClientCurveDetails { get; set; } = null!;
        public virtual DbSet<ClientRecommend> ClientRecommends { get; set; } = null!;
        public virtual DbSet<ClientRepeat> ClientRepeats { get; set; } = null!;
        public virtual DbSet<ClientTrackingCurve> ClientTrackingCurves { get; set; } = null!;
        public virtual DbSet<CmbCatchtype> CmbCatchtypes { get; set; } = null!;
        public virtual DbSet<CmbIncometype> CmbIncometypes { get; set; } = null!;
        public virtual DbSet<CmbManage> CmbManages { get; set; } = null!;
        public virtual DbSet<ComIdbyLink> ComIdbyLinks { get; set; } = null!;
        public virtual DbSet<CostDetail> CostDetails { get; set; } = null!;
        public virtual DbSet<CostType> CostTypes { get; set; } = null!;
        public virtual DbSet<CrmAbnegateGiveUp> CrmAbnegateGiveUps { get; set; } = null!;
        public virtual DbSet<CrmAbnegateLog> CrmAbnegateLogs { get; set; } = null!;
        public virtual DbSet<CrmAbnegateRecord> CrmAbnegateRecords { get; set; } = null!;
        public virtual DbSet<CrmAbnegateTemporary> CrmAbnegateTemporaries { get; set; } = null!;
        public virtual DbSet<CrmAbnegateTemporaryBack> CrmAbnegateTemporaryBacks { get; set; } = null!;
        public virtual DbSet<CrmAd> CrmAds { get; set; } = null!;
        public virtual DbSet<CrmAdCount> CrmAdCounts { get; set; } = null!;
        public virtual DbSet<CrmAdNew> CrmAdNews { get; set; } = null!;
        public virtual DbSet<CrmAdPlace> CrmAdPlaces { get; set; } = null!;
        public virtual DbSet<CrmAdPlaceBack> CrmAdPlaceBacks { get; set; } = null!;
        public virtual DbSet<CrmAdPlaceNew> CrmAdPlaceNews { get; set; } = null!;
        public virtual DbSet<CrmAdStandType> CrmAdStandTypes { get; set; } = null!;
        public virtual DbSet<CrmAddLog> CrmAddLogs { get; set; } = null!;
        public virtual DbSet<CrmAdplaceBak> CrmAdplaceBaks { get; set; } = null!;
        public virtual DbSet<CrmAicallRecord> CrmAicallRecords { get; set; } = null!;
        public virtual DbSet<CrmAicallRecordForUh> CrmAicallRecordForUhs { get; set; } = null!;
        public virtual DbSet<CrmBlockCom> CrmBlockComs { get; set; } = null!;
        public virtual DbSet<CrmBondManager> CrmBondManagers { get; set; } = null!;
        public virtual DbSet<CrmCallAwoke> CrmCallAwokes { get; set; } = null!;
        public virtual DbSet<CrmCessionLog> CrmCessionLogs { get; set; } = null!;
        public virtual DbSet<CrmCessionLogBack> CrmCessionLogBacks { get; set; } = null!;
        public virtual DbSet<CrmClientType> CrmClientTypes { get; set; } = null!;
        public virtual DbSet<CrmClientsTrade> CrmClientsTrades { get; set; } = null!;
        public virtual DbSet<CrmComCount> CrmComCounts { get; set; } = null!;
        public virtual DbSet<CrmComOpen> CrmComOpens { get; set; } = null!;
        public virtual DbSet<CrmComSnsOpen> CrmComSnsOpens { get; set; } = null!;
        public virtual DbSet<CrmCompany> CrmCompanies { get; set; } = null!;
        public virtual DbSet<CrmCompanyArchive> CrmCompanyArchives { get; set; } = null!;
        public virtual DbSet<CrmCompanyArchivesSort> CrmCompanyArchivesSorts { get; set; } = null!;
        public virtual DbSet<CrmCompanyBak> CrmCompanyBaks { get; set; } = null!;
        public virtual DbSet<CrmCompanyNew> CrmCompanyNews { get; set; } = null!;
        public virtual DbSet<CrmCompanyOld> CrmCompanyOlds { get; set; } = null!;
        public virtual DbSet<CrmCompanySource> CrmCompanySources { get; set; } = null!;
        public virtual DbSet<CrmContactApply> CrmContactApplies { get; set; } = null!;
        public virtual DbSet<CrmCsLog> CrmCsLogs { get; set; } = null!;
        public virtual DbSet<CrmDeleteLog> CrmDeleteLogs { get; set; } = null!;
        public virtual DbSet<CrmDepartTask> CrmDepartTasks { get; set; } = null!;
        public virtual DbSet<CrmDevelopStatus> CrmDevelopStatuses { get; set; } = null!;
        public virtual DbSet<CrmDredgeCompany> CrmDredgeCompanies { get; set; } = null!;
        public virtual DbSet<CrmElectronProgram> CrmElectronPrograms { get; set; } = null!;
        public virtual DbSet<CrmElectronTemplate> CrmElectronTemplates { get; set; } = null!;
        public virtual DbSet<CrmEplTask> CrmEplTasks { get; set; } = null!;
        public virtual DbSet<CrmExpirationDisplay> CrmExpirationDisplays { get; set; } = null!;
        public virtual DbSet<CrmFoshanRecord> CrmFoshanRecords { get; set; } = null!;
        public virtual DbSet<CrmFreeOpen> CrmFreeOpens { get; set; } = null!;
        public virtual DbSet<CrmFromWebAddLog> CrmFromWebAddLogs { get; set; } = null!;
        public virtual DbSet<CrmGetLog> CrmGetLogs { get; set; } = null!;
        public virtual DbSet<CrmHomePage> CrmHomePages { get; set; } = null!;
        public virtual DbSet<CrmLinkman> CrmLinkmen { get; set; } = null!;
        public virtual DbSet<CrmLinkmanBack> CrmLinkmanBacks { get; set; } = null!;
        public virtual DbSet<CrmLinkmanOld> CrmLinkmanOlds { get; set; } = null!;
        public virtual DbSet<CrmLinkmanPo> CrmLinkmanPos { get; set; } = null!;
        public virtual DbSet<CrmLinkmanSen> CrmLinkmanSens { get; set; } = null!;
        public virtual DbSet<CrmMandatory> CrmMandatories { get; set; } = null!;
        public virtual DbSet<CrmMemselfhelp> CrmMemselfhelps { get; set; } = null!;
        public virtual DbSet<CrmModifyNameApply> CrmModifyNameApplies { get; set; } = null!;
        public virtual DbSet<CrmNewsAd> CrmNewsAds { get; set; } = null!;
        public virtual DbSet<CrmOnduty> CrmOnduties { get; set; } = null!;
        public virtual DbSet<CrmOuterTemporary> CrmOuterTemporaries { get; set; } = null!;
        public virtual DbSet<CrmProcessClient> CrmProcessClients { get; set; } = null!;
        public virtual DbSet<CrmProductBond> CrmProductBonds { get; set; } = null!;
        public virtual DbSet<CrmRecord> CrmRecords { get; set; } = null!;
        public virtual DbSet<CrmRecordsType> CrmRecordsTypes { get; set; } = null!;
        public virtual DbSet<CrmRemind> CrmReminds { get; set; } = null!;
        public virtual DbSet<CrmStand> CrmStands { get; set; } = null!;
        public virtual DbSet<CrmTempClient> CrmTempClients { get; set; } = null!;
        public virtual DbSet<DataDptMoney> DataDptMoneys { get; set; } = null!;
        public virtual DbSet<DataEplMoney> DataEplMoneys { get; set; } = null!;
        public virtual DbSet<DataFinComCount> DataFinComCounts { get; set; } = null!;
        public virtual DbSet<DayInfo> DayInfos { get; set; } = null!;
        public virtual DbSet<DayPhone> DayPhones { get; set; } = null!;
        public virtual DbSet<DaySign> DaySigns { get; set; } = null!;
        public virtual DbSet<DayUserCost> DayUserCosts { get; set; } = null!;
        public virtual DbSet<DeCrmLinkmanaLog> DeCrmLinkmanaLogs { get; set; } = null!;
        public virtual DbSet<DevBak> DevBaks { get; set; } = null!;
        public virtual DbSet<DevClient> DevClients { get; set; } = null!;
        public virtual DbSet<DevClientType> DevClientTypes { get; set; } = null!;
        public virtual DbSet<DevTrackRecord> DevTrackRecords { get; set; } = null!;
        public virtual DbSet<DevTrackType> DevTrackTypes { get; set; } = null!;
        public virtual DbSet<DevTransferLog> DevTransferLogs { get; set; } = null!;
        public virtual DbSet<DicCs80State> DicCs80States { get; set; } = null!;
        public virtual DbSet<ErmAdminBranch> ErmAdminBranches { get; set; } = null!;
        public virtual DbSet<ErmEmployee> ErmEmployees { get; set; } = null!;
        public virtual DbSet<ErmEmployeePosition> ErmEmployeePositions { get; set; } = null!;
        public virtual DbSet<ErmEsLog> ErmEsLogs { get; set; } = null!;
        public virtual DbSet<ErmEvection> ErmEvections { get; set; } = null!;
        public virtual DbSet<ErmOnDuty> ErmOnDuties { get; set; } = null!;
        public virtual DbSet<ErmOvertime> ErmOvertimes { get; set; } = null!;
        public virtual DbSet<EvaluateCategory> EvaluateCategories { get; set; } = null!;
        public virtual DbSet<EvaluateItem> EvaluateItems { get; set; } = null!;
        public virtual DbSet<EvaluateRecord> EvaluateRecords { get; set; } = null!;
        public virtual DbSet<EvaluateScore> EvaluateScores { get; set; } = null!;
        public virtual DbSet<FinAchievementPk> FinAchievementPks { get; set; } = null!;
        public virtual DbSet<FinAdAmount> FinAdAmounts { get; set; } = null!;
        public virtual DbSet<FinAdType> FinAdTypes { get; set; } = null!;
        public virtual DbSet<FinInvoice> FinInvoices { get; set; } = null!;
        public virtual DbSet<FinSalary> FinSalaries { get; set; } = null!;
        public virtual DbSet<FinTradeList> FinTradeLists { get; set; } = null!;
        public virtual DbSet<FinWebSite> FinWebSites { get; set; } = null!;
        public virtual DbSet<ForumAskReply> ForumAskReplies { get; set; } = null!;
        public virtual DbSet<ForumAskType> ForumAskTypes { get; set; } = null!;
        public virtual DbSet<ForumAsking> ForumAskings { get; set; } = null!;
        public virtual DbSet<ForumComment> ForumComments { get; set; } = null!;
        public virtual DbSet<ForumCommentBak> ForumCommentBaks { get; set; } = null!;
        public virtual DbSet<ForumMessage> ForumMessages { get; set; } = null!;
        public virtual DbSet<ForumMessageBak> ForumMessageBaks { get; set; } = null!;
        public virtual DbSet<ForumOnline> ForumOnlines { get; set; } = null!;
        public virtual DbSet<ForumPlate> ForumPlates { get; set; } = null!;
        public virtual DbSet<GoodjobRecommend> GoodjobRecommends { get; set; } = null!;
        public virtual DbSet<GoodjobRecommendBack> GoodjobRecommendBacks { get; set; } = null!;
        public virtual DbSet<HrAttend> HrAttends { get; set; } = null!;
        public virtual DbSet<HrHoliday> HrHolidays { get; set; } = null!;
        public virtual DbSet<HrHolidayType> HrHolidayTypes { get; set; } = null!;
        public virtual DbSet<HrSignin> HrSignins { get; set; } = null!;
        public virtual DbSet<HrSigninLog> HrSigninLogs { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<LinShiMobile> LinShiMobiles { get; set; } = null!;
        public virtual DbSet<LinshiBackMobile> LinshiBackMobiles { get; set; } = null!;
        public virtual DbSet<MngAdclass> MngAdclasses { get; set; } = null!;
        public virtual DbSet<MngPopsite> MngPopsites { get; set; } = null!;
        public virtual DbSet<MyCrmAdPlace> MyCrmAdPlaces { get; set; } = null!;
        public virtual DbSet<Noname1> Noname1s { get; set; } = null!;
        public virtual DbSet<OnDudy2008> OnDudy2008s { get; set; } = null!;
        public virtual DbSet<PackArticle> PackArticles { get; set; } = null!;
        public virtual DbSet<PackDeposiDetail> PackDeposiDetails { get; set; } = null!;
        public virtual DbSet<PackDeposit> PackDeposits { get; set; } = null!;
        public virtual DbSet<PackFurnish> PackFurnishes { get; set; } = null!;
        public virtual DbSet<PackLog> PackLogs { get; set; } = null!;
        public virtual DbSet<PackScrap> PackScraps { get; set; } = null!;
        public virtual DbSet<PackScrapDetail> PackScrapDetails { get; set; } = null!;
        public virtual DbSet<PackType> PackTypes { get; set; } = null!;
        public virtual DbSet<PackUse> PackUses { get; set; } = null!;
        public virtual DbSet<PackUseDetail> PackUseDetails { get; set; } = null!;
        public virtual DbSet<PeiComment> PeiComments { get; set; } = null!;
        public virtual DbSet<PeiFileList> PeiFileLists { get; set; } = null!;
        public virtual DbSet<PeiFileType> PeiFileTypes { get; set; } = null!;
        public virtual DbSet<PhoneCallAccept> PhoneCallAccepts { get; set; } = null!;
        public virtual DbSet<PhoneCallHistory> PhoneCallHistories { get; set; } = null!;
        public virtual DbSet<PhoneGroup> PhoneGroups { get; set; } = null!;
        public virtual DbSet<PhoneRecord> PhoneRecords { get; set; } = null!;
        public virtual DbSet<PhoneRecordsBak> PhoneRecordsBaks { get; set; } = null!;
        public virtual DbSet<PhoneTempCompany> PhoneTempCompanies { get; set; } = null!;
        public virtual DbSet<PhoneUser> PhoneUsers { get; set; } = null!;
        public virtual DbSet<PhoneVoiceRecord> PhoneVoiceRecords { get; set; } = null!;
        public virtual DbSet<PubInfoSecurity> PubInfoSecurities { get; set; } = null!;
        public virtual DbSet<PubInfoType> PubInfoTypes { get; set; } = null!;
        public virtual DbSet<PubInformation> PubInformations { get; set; } = null!;
        public virtual DbSet<PubJobMemo> PubJobMemos { get; set; } = null!;
        public virtual DbSet<PubJobMemoType> PubJobMemoTypes { get; set; } = null!;
        public virtual DbSet<PubMind> PubMinds { get; set; } = null!;
        public virtual DbSet<ReportsCompanyHistoryRank> ReportsCompanyHistoryRanks { get; set; } = null!;
        public virtual DbSet<Signin> Signins { get; set; } = null!;
        public virtual DbSet<SysAbnegate> SysAbnegates { get; set; } = null!;
        public virtual DbSet<SysAnnualbonu> SysAnnualbonus { get; set; } = null!;
        public virtual DbSet<SysCity> SysCities { get; set; } = null!;
        public virtual DbSet<SysCompanyState> SysCompanyStates { get; set; } = null!;
        public virtual DbSet<SysCompanyState1> SysCompanyState1s { get; set; } = null!;
        public virtual DbSet<SysDay> SysDays { get; set; } = null!;
        public virtual DbSet<SysDegree> SysDegrees { get; set; } = null!;
        public virtual DbSet<SysDepartment> SysDepartments { get; set; } = null!;
        public virtual DbSet<SysDuty> SysDuties { get; set; } = null!;
        public virtual DbSet<SysEducation> SysEducations { get; set; } = null!;
        public virtual DbSet<SysEmpRight> SysEmpRights { get; set; } = null!;
        public virtual DbSet<SysEmpState> SysEmpStates { get; set; } = null!;
        public virtual DbSet<SysEmpTeamRight> SysEmpTeamRights { get; set; } = null!;
        public virtual DbSet<SysGoodjobLoginLog> SysGoodjobLoginLogs { get; set; } = null!;
        public virtual DbSet<SysGotoworktime> SysGotoworktimes { get; set; } = null!;
        public virtual DbSet<SysIdCenter> SysIdCenters { get; set; } = null!;
        public virtual DbSet<SysKfTj> SysKfTjs { get; set; } = null!;
        public virtual DbSet<SysKfTjf> SysKfTjfs { get; set; } = null!;
        public virtual DbSet<SysMarry> SysMarries { get; set; } = null!;
        public virtual DbSet<SysMenu> SysMenus { get; set; } = null!;
        public virtual DbSet<SysMenuInRole> SysMenuInRoles { get; set; } = null!;
        public virtual DbSet<SysMenuInRoleOuterResume> SysMenuInRoleOuterResumes { get; set; } = null!;
        public virtual DbSet<SysMonth> SysMonths { get; set; } = null!;
        public virtual DbSet<SysNation> SysNations { get; set; } = null!;
        public virtual DbSet<SysNotice> SysNotices { get; set; } = null!;
        public virtual DbSet<SysOuterResumeLoginLog> SysOuterResumeLoginLogs { get; set; } = null!;
        public virtual DbSet<SysPageTemplate> SysPageTemplates { get; set; } = null!;
        public virtual DbSet<SysPageTemplateItem> SysPageTemplateItems { get; set; } = null!;
        public virtual DbSet<SysPersonArea> SysPersonAreas { get; set; } = null!;
        public virtual DbSet<SysPlanTime> SysPlanTimes { get; set; } = null!;
        public virtual DbSet<SysPosition> SysPositions { get; set; } = null!;
        public virtual DbSet<SysProvince> SysProvinces { get; set; } = null!;
        public virtual DbSet<SysRemind> SysReminds { get; set; } = null!;
        public virtual DbSet<SysRole> SysRoles { get; set; } = null!;
        public virtual DbSet<SysRoleOuterResume> SysRoleOuterResumes { get; set; } = null!;
        public virtual DbSet<SysSection> SysSections { get; set; } = null!;
        public virtual DbSet<SysSectionInRole> SysSectionInRoles { get; set; } = null!;
        public virtual DbSet<SysServiceOnduty> SysServiceOnduties { get; set; } = null!;
        public virtual DbSet<SysSex> SysSexes { get; set; } = null!;
        public virtual DbSet<SysTeam> SysTeams { get; set; } = null!;
        public virtual DbSet<SysTeamRight> SysTeamRights { get; set; } = null!;
        public virtual DbSet<SysTemplateItem> SysTemplateItems { get; set; } = null!;
        public virtual DbSet<SysTown> SysTowns { get; set; } = null!;
        public virtual DbSet<SysType> SysTypes { get; set; } = null!;
        public virtual DbSet<SysUserInRole> SysUserInRoles { get; set; } = null!;
        public virtual DbSet<SysUserInRoleOuterResume> SysUserInRoleOuterResumes { get; set; } = null!;
        public virtual DbSet<SysWebsiteFinProperty> SysWebsiteFinProperties { get; set; } = null!;
        public virtual DbSet<TaskGroup> TaskGroups { get; set; } = null!;
        public virtual DbSet<TaskList> TaskLists { get; set; } = null!;
        public virtual DbSet<TaskMember> TaskMembers { get; set; } = null!;
        public virtual DbSet<TaskProcess> TaskProcesses { get; set; } = null!;
        public virtual DbSet<TemCompany> TemCompanies { get; set; } = null!;
        public virtual DbSet<TempGotowork> TempGotoworks { get; set; } = null!;
        public virtual DbSet<TouchMenu> TouchMenus { get; set; } = null!;
        public virtual DbSet<TraRequirement> TraRequirements { get; set; } = null!;
        public virtual DbSet<Userbak> Userbaks { get; set; } = null!;
        public virtual DbSet<ViewAbnegateTemporarySummary> ViewAbnegateTemporarySummaries { get; set; } = null!;
        public virtual DbSet<ViewAd> ViewAds { get; set; } = null!;
        public virtual DbSet<ViewAdNew> ViewAdNews { get; set; } = null!;
        public virtual DbSet<ViewAddLog> ViewAddLogs { get; set; } = null!;
        public virtual DbSet<ViewAllCrmAbnegateTemporarySummary> ViewAllCrmAbnegateTemporarySummaries { get; set; } = null!;
        public virtual DbSet<ViewApplPpoint> ViewApplPpoints { get; set; } = null!;
        public virtual DbSet<ViewClientCollaborative> ViewClientCollaboratives { get; set; } = null!;
        public virtual DbSet<ViewClientRecommend> ViewClientRecommends { get; set; } = null!;
        public virtual DbSet<ViewClientRepeat> ViewClientRepeats { get; set; } = null!;
        public virtual DbSet<ViewClientTrackingCurve> ViewClientTrackingCurves { get; set; } = null!;
        public virtual DbSet<ViewCrmAbnegateLog> ViewCrmAbnegateLogs { get; set; } = null!;
        public virtual DbSet<ViewCrmAbnegateTemporary> ViewCrmAbnegateTemporaries { get; set; } = null!;
        public virtual DbSet<ViewCrmAbnegateTemporarySummary> ViewCrmAbnegateTemporarySummaries { get; set; } = null!;
        public virtual DbSet<ViewCrmAd> ViewCrmAds { get; set; } = null!;
        public virtual DbSet<ViewCrmAicallRecordForUh> ViewCrmAicallRecordForUhs { get; set; } = null!;
        public virtual DbSet<ViewCrmBondManager> ViewCrmBondManagers { get; set; } = null!;
        public virtual DbSet<ViewCrmCallAwoke> ViewCrmCallAwokes { get; set; } = null!;
        public virtual DbSet<ViewCrmCessionLog> ViewCrmCessionLogs { get; set; } = null!;
        public virtual DbSet<ViewCrmClient> ViewCrmClients { get; set; } = null!;
        public virtual DbSet<ViewCrmClientsBack> ViewCrmClientsBacks { get; set; } = null!;
        public virtual DbSet<ViewCrmComOpen> ViewCrmComOpens { get; set; } = null!;
        public virtual DbSet<ViewCrmComSelf> ViewCrmComSelves { get; set; } = null!;
        public virtual DbSet<ViewCrmComSn> ViewCrmComSns { get; set; } = null!;
        public virtual DbSet<ViewCrmCompany> ViewCrmCompanies { get; set; } = null!;
        public virtual DbSet<ViewCrmContactApply> ViewCrmContactApplies { get; set; } = null!;
        public virtual DbSet<ViewCrmExpirationDisplay> ViewCrmExpirationDisplays { get; set; } = null!;
        public virtual DbSet<ViewCrmFreeOpen> ViewCrmFreeOpens { get; set; } = null!;
        public virtual DbSet<ViewCrmHomePage> ViewCrmHomePages { get; set; } = null!;
        public virtual DbSet<ViewCrmJobMemo> ViewCrmJobMemos { get; set; } = null!;
        public virtual DbSet<ViewCrmKhzk> ViewCrmKhzks { get; set; } = null!;
        public virtual DbSet<ViewCrmKhzklist> ViewCrmKhzklists { get; set; } = null!;
        public virtual DbSet<ViewCrmLinkman> ViewCrmLinkmen { get; set; } = null!;
        public virtual DbSet<ViewCrmModifyNameApply> ViewCrmModifyNameApplies { get; set; } = null!;
        public virtual DbSet<ViewCrmNewsAd> ViewCrmNewsAds { get; set; } = null!;
        public virtual DbSet<ViewCrmOuter> ViewCrmOuters { get; set; } = null!;
        public virtual DbSet<ViewCrmOuterTemporary> ViewCrmOuterTemporaries { get; set; } = null!;
        public virtual DbSet<ViewCrmRecord> ViewCrmRecords { get; set; } = null!;
        public virtual DbSet<ViewCrmRemind> ViewCrmReminds { get; set; } = null!;
        public virtual DbSet<ViewCrmStand> ViewCrmStands { get; set; } = null!;
        public virtual DbSet<ViewCrmTransaction> ViewCrmTransactions { get; set; } = null!;
        public virtual DbSet<ViewDataDptMoney> ViewDataDptMoneys { get; set; } = null!;
        public virtual DbSet<ViewDataEplMoney> ViewDataEplMoneys { get; set; } = null!;
        public virtual DbSet<ViewDayinfo> ViewDayinfos { get; set; } = null!;
        public virtual DbSet<ViewDevClient> ViewDevClients { get; set; } = null!;
        public virtual DbSet<ViewDevFirstClient> ViewDevFirstClients { get; set; } = null!;
        public virtual DbSet<ViewDevTrackRecord> ViewDevTrackRecords { get; set; } = null!;
        public virtual DbSet<ViewDevTransfer> ViewDevTransfers { get; set; } = null!;
        public virtual DbSet<ViewErmAdminBranchList> ViewErmAdminBranchLists { get; set; } = null!;
        public virtual DbSet<ViewErmAttend> ViewErmAttends { get; set; } = null!;
        public virtual DbSet<ViewErmEmployee> ViewErmEmployees { get; set; } = null!;
        public virtual DbSet<ViewErmHoliday> ViewErmHolidays { get; set; } = null!;
        public virtual DbSet<ViewErmSignin> ViewErmSignins { get; set; } = null!;
        public virtual DbSet<ViewEvection> ViewEvections { get; set; } = null!;
        public virtual DbSet<ViewFinInvoice> ViewFinInvoices { get; set; } = null!;
        public virtual DbSet<ViewFinSalary> ViewFinSalaries { get; set; } = null!;
        public virtual DbSet<ViewFinTradeList> ViewFinTradeLists { get; set; } = null!;
        public virtual DbSet<ViewFinWebSite> ViewFinWebSites { get; set; } = null!;
        public virtual DbSet<ViewForumAskReply> ViewForumAskReplies { get; set; } = null!;
        public virtual DbSet<ViewForumAsking> ViewForumAskings { get; set; } = null!;
        public virtual DbSet<ViewForumComment> ViewForumComments { get; set; } = null!;
        public virtual DbSet<ViewForumMessage> ViewForumMessages { get; set; } = null!;
        public virtual DbSet<ViewForumPlate> ViewForumPlates { get; set; } = null!;
        public virtual DbSet<ViewFromWebAddLog> ViewFromWebAddLogs { get; set; } = null!;
        public virtual DbSet<ViewGetLog> ViewGetLogs { get; set; } = null!;
        public virtual DbSet<ViewGoodjobRecommend> ViewGoodjobRecommends { get; set; } = null!;
        public virtual DbSet<ViewGoodjobRecommendtj> ViewGoodjobRecommendtjs { get; set; } = null!;
        public virtual DbSet<ViewInformation> ViewInformations { get; set; } = null!;
        public virtual DbSet<ViewInvoice> ViewInvoices { get; set; } = null!;
        public virtual DbSet<ViewMenu> ViewMenus { get; set; } = null!;
        public virtual DbSet<ViewMenuInRole> ViewMenuInRoles { get; set; } = null!;
        public virtual DbSet<ViewPeiComment> ViewPeiComments { get; set; } = null!;
        public virtual DbSet<ViewPeiFileList> ViewPeiFileLists { get; set; } = null!;
        public virtual DbSet<ViewPhoneCallhistory> ViewPhoneCallhistories { get; set; } = null!;
        public virtual DbSet<ViewPhoneList> ViewPhoneLists { get; set; } = null!;
        public virtual DbSet<ViewPhoneRank> ViewPhoneRanks { get; set; } = null!;
        public virtual DbSet<ViewPubMind> ViewPubMinds { get; set; } = null!;
        public virtual DbSet<ViewRemind> ViewReminds { get; set; } = null!;
        public virtual DbSet<ViewRole> ViewRoles { get; set; } = null!;
        public virtual DbSet<ViewSection> ViewSections { get; set; } = null!;
        public virtual DbSet<ViewSectionInRole> ViewSectionInRoles { get; set; } = null!;
        public virtual DbSet<ViewTeam> ViewTeams { get; set; } = null!;
        public virtual DbSet<ViewTeamRight> ViewTeamRights { get; set; } = null!;
        public virtual DbSet<ViewUserInRole> ViewUserInRoles { get; set; } = null!;
        public virtual DbSet<ViewWebSiteBondManager> ViewWebSiteBondManagers { get; set; } = null!;
        public virtual DbSet<ViewWebSiteCession> ViewWebSiteCessions { get; set; } = null!;
        public virtual DbSet<ViewWebSiteClient> ViewWebSiteClients { get; set; } = null!;
        public virtual DbSet<ViewWebSiteLinkMan> ViewWebSiteLinkMen { get; set; } = null!;
        public virtual DbSet<ViewWebSiteVisit> ViewWebSiteVisits { get; set; } = null!;
        public virtual DbSet<ViewZphModify> ViewZphModifies { get; set; } = null!;
        public virtual DbSet<ViewZphPoint> ViewZphPoints { get; set; } = null!;
        public virtual DbSet<ViewZphSign> ViewZphSigns { get; set; } = null!;
        public virtual DbSet<ViewZphTheme> ViewZphThemes { get; set; } = null!;
        public virtual DbSet<WebConfig> WebConfigs { get; set; } = null!;
        public virtual DbSet<WebSeting> WebSetings { get; set; } = null!;
        public virtual DbSet<WebSiteBondManager> WebSiteBondManagers { get; set; } = null!;
        public virtual DbSet<WebSiteCessionRecord> WebSiteCessionRecords { get; set; } = null!;
        public virtual DbSet<WebSiteClient> WebSiteClients { get; set; } = null!;
        public virtual DbSet<WebSiteLinkMan> WebSiteLinkMen { get; set; } = null!;
        public virtual DbSet<WebSiteType> WebSiteTypes { get; set; } = null!;
        public virtual DbSet<WebSiteVisit> WebSiteVisits { get; set; } = null!;
        public virtual DbSet<WebSiteVisitType> WebSiteVisitTypes { get; set; } = null!;
        public virtual DbSet<ZphCance> ZphCances { get; set; } = null!;
        public virtual DbSet<ZphModify> ZphModifies { get; set; } = null!;
        public virtual DbSet<ZphPoint> ZphPoints { get; set; } = null!;
        public virtual DbSet<ZphReserve> ZphReserves { get; set; } = null!;
        public virtual DbSet<ZphSign> ZphSigns { get; set; } = null!;
        public virtual DbSet<ZphTheme> ZphThemes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.2.2;Initial Catalog=GoodBoss;User ID=jcwgoodjobboss;Password=jcwgoodjobcn2011/*--*/;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AiDialingRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AI_Dialing_Record");

                entity.Property(e => e.AicreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AICreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AnalyseHolidayDatum>(entity =>
            {
                entity.ToTable("analyse_holiday_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackSTw).HasColumnName("BackS_Tw");

                entity.Property(e => e.BackTS).HasColumnName("BackT_S");

                entity.Property(e => e.BackTT).HasColumnName("BackT_T");

                entity.Property(e => e.Bdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Holidday).HasColumnName("holidday");

                entity.Property(e => e.LateSTw).HasColumnName("LateS_Tw");

                entity.Property(e => e.LateTS).HasColumnName("LateT_S");

                entity.Property(e => e.LateTT).HasColumnName("LateT_T");

                entity.Property(e => e.Ugroup).HasColumnName("ugroup");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<ApEplId>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("AP_EplID");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("EplID");

                entity.Property(e => e.EedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AppSecurity>(entity =>
            {
                entity.ToTable("App_Security");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Randomchar)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.ArtId);

                entity.ToTable("article");

                entity.Property(e => e.ArtId)
                    .ValueGeneratedNever()
                    .HasColumnName("artID");

                entity.Property(e => e.Author)
                    .HasMaxLength(10)
                    .HasColumnName("author");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.From)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("from");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Tags)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("tags");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CeshiMemId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ceshiMemID");

                entity.Property(e => e.A)
                    .HasColumnName("a")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComId).HasColumnName("ComID");
            });

            modelBuilder.Entity<Ceshicomid>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("ceshicomid");

                entity.Property(e => e.ComId)
                    .ValueGeneratedNever()
                    .HasColumnName("ComID");
            });

            modelBuilder.Entity<ClerkGoup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClerkGoup");

                entity.Property(e => e.Advancedclerk)
                    .HasColumnType("money")
                    .HasColumnName("advancedclerk");

                entity.Property(e => e.Commonclerk)
                    .HasColumnType("money")
                    .HasColumnName("commonclerk");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Jinyingclerk)
                    .HasColumnType("money")
                    .HasColumnName("jinyingclerk");

                entity.Property(e => e.Manager)
                    .HasColumnType("money")
                    .HasColumnName("manager");

                entity.Property(e => e.Starclerk)
                    .HasColumnType("money")
                    .HasColumnName("starclerk");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("starttime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ClerkGoupInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClerkGoupInfo");

                entity.Property(e => e.AllSum).HasColumnName("allSum");

                entity.Property(e => e.AllSumInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("allSumInfo");

                entity.Property(e => e.ClerkInfo)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("clerkInfo");

                entity.Property(e => e.ClerkName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clerkName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Positime).HasColumnName("positime");

                entity.Property(e => e.PositimeInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("positimeInfo");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<ClientCollaborative>(entity =>
            {
                entity.HasKey(e => e.CollId);

                entity.ToTable("client_collaborative");

                entity.Property(e => e.CollId)
                    .ValueGeneratedNever()
                    .HasColumnName("collID");

                entity.Property(e => e.CollEplid).HasColumnName("collEplid");

                entity.Property(e => e.CollEplname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("collEplname");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Importance).HasColumnName("importance");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasComment("3 停止合作 2 合作完成 1合作中");
            });

            modelBuilder.Entity<ClientCollaborativeBack>(entity =>
            {
                entity.HasKey(e => e.CollId)
                    .HasName("PK_client_collaborative1");

                entity.ToTable("client_collaborative_back");

                entity.Property(e => e.CollId)
                    .ValueGeneratedNever()
                    .HasColumnName("collID");

                entity.Property(e => e.CollEplid).HasColumnName("collEplid");

                entity.Property(e => e.CollEplname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("collEplname");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Importance).HasColumnName("importance");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ClientCurveDetail>(entity =>
            {
                entity.HasKey(e => e.CdId);

                entity.ToTable("client_curveDetail");

                entity.Property(e => e.CdId).HasColumnName("cdID");

                entity.Property(e => e.CurrSum).HasColumnName("currSum");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.IsLast).HasColumnName("isLast");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<ClientRecommend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("client_recommend");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checkTime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EntTime)
                    .HasColumnType("datetime")
                    .HasColumnName("entTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.RecId).HasColumnName("recID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ClientRepeat>(entity =>
            {
                entity.HasKey(e => e.RepeatId);

                entity.ToTable("client_repeat");

                entity.Property(e => e.RepeatId)
                    .ValueGeneratedNever()
                    .HasColumnName("repeatID");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ClientTrackingCurve>(entity =>
            {
                entity.HasKey(e => e.CurId);

                entity.ToTable("client_trackingCurve");

                entity.Property(e => e.CurId)
                    .ValueGeneratedNever()
                    .HasColumnName("curID");

                entity.Property(e => e.CurveName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curveName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Layer).HasColumnName("layer");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<CmbCatchtype>(entity =>
            {
                entity.ToTable("cmb_catchtype");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CmbIncometype>(entity =>
            {
                entity.ToTable("cmb_incometype");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CmbManage>(entity =>
            {
                entity.ToTable("cmb_manage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("money")
                    .HasColumnName("cost");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.InType).HasColumnName("inType");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ComIdbyLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComIDByLink");

                entity.Property(e => e.ComId).HasColumnName("ComID");
            });

            modelBuilder.Entity<CostDetail>(entity =>
            {
                entity.ToTable("cost_Detail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("adminName");

                entity.Property(e => e.CostTypeId).HasColumnName("costTypeID");

                entity.Property(e => e.CostTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("costTypeName");

                entity.Property(e => e.CostValue)
                    .HasColumnType("money")
                    .HasColumnName("costValue");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.HappenTime)
                    .HasColumnType("datetime")
                    .HasColumnName("happenTime");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<CostType>(entity =>
            {
                entity.ToTable("cost_Type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CrmAbnegateGiveUp>(entity =>
            {
                entity.ToTable("CRM_Abnegate_GiveUp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AngTypeCsId).HasColumnName("AngTypeCsID");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.GiveUpDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmAbnegateLog>(entity =>
            {
                entity.ToTable("CRM_Abnegate_log");

                entity.HasIndex(e => e.ComId, "CrM_Abnegate_log_Comid");

                entity.HasIndex(e => e.AngDate, "CrM_Abnegate_log_ang_date");

                entity.HasIndex(e => e.AngId, "CrM_Abnegate_log_ang_id");

                entity.HasIndex(e => e.EplId, "CrM_Abnegate_log_epl_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AngDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Ang_Date");

                entity.Property(e => e.AngId).HasColumnName("Ang_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.CsId)
                    .HasColumnName("CS_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPL_IP");

                entity.Property(e => e.Reason).HasColumnType("text");
            });

            modelBuilder.Entity<CrmAbnegateRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_AbnegateRecords");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmAbnegateTemporary>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("CRM_Abnegate_Temporary");

                entity.Property(e => e.ComId)
                    .ValueGeneratedNever()
                    .HasColumnName("COM_ID");

                entity.Property(e => e.AngDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ang_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AngTypeCsId).HasColumnName("AngTypeCsID");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");
            });

            modelBuilder.Entity<CrmAbnegateTemporaryBack>(entity =>
            {
                entity.ToTable("CRM_Abnegate_Temporary_back");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AngDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ang_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AngTypeCsId).HasColumnName("AngTypeCsID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");
            });

            modelBuilder.Entity<CrmAd>(entity =>
            {
                entity.HasKey(e => e.AdId);

                entity.ToTable("CRM_Ad");

                entity.HasIndex(e => e.ApplyDate, "IX_ApplyDate");

                entity.HasIndex(e => e.CheckMark, "IX_CheckMark");

                entity.HasIndex(e => e.StartDate, "IX_StartDate");

                entity.Property(e => e.AdId).HasColumnName("Ad_ID");

                entity.Property(e => e.AlterDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApplyWhy).HasMaxLength(1000);

                entity.Property(e => e.Bondno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("合同编号");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescribe).HasMaxLength(2000);

                entity.Property(e => e.DownLineDate).HasColumnType("datetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.OnlineDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UnPassWhy).HasMaxLength(1000);

                entity.Property(e => e.UpLineDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmAdCount>(entity =>
            {
                entity.HasKey(e => e.CountId);

                entity.ToTable("CRM_AdCount");

                entity.Property(e => e.CountId)
                    .ValueGeneratedNever()
                    .HasColumnName("Count_ID");

                entity.Property(e => e.HaveSpaceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OnlineEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");
            });

            modelBuilder.Entity<CrmAdNew>(entity =>
            {
                entity.HasKey(e => e.AdId);

                entity.ToTable("CRM_Ad_New");

                entity.Property(e => e.AdId).HasColumnName("Ad_ID");

                entity.Property(e => e.AlterDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApplyType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApplyWhy).HasMaxLength(1000);

                entity.Property(e => e.Bondno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("合同编号");

                entity.Property(e => e.CaLnkUrl)
                    .HasMaxLength(100)
                    .HasColumnName("CA_LnkURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescribe).HasMaxLength(2000);

                entity.Property(e => e.DownLineDate).HasColumnType("datetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.OnlineDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UnPassWhy).HasMaxLength(1000);

                entity.Property(e => e.UpLineDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrmAdPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_AdPlace");

                entity.Property(e => e.AdSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<CrmAdPlaceBack>(entity =>
            {
                entity.HasKey(e => e.PlaceId)
                    .HasName("PK_CRM_AdPlace");

                entity.ToTable("CRM_AdPlace_back");

                entity.HasIndex(e => e.PlaceName, "IX_PlaceName");

                entity.Property(e => e.PlaceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Place_ID");

                entity.Property(e => e.AdSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<CrmAdPlaceNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_AdPlace_New");

                entity.Property(e => e.AdSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cover)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 电脑网页端 1手机端 2微信推广");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<CrmAdStandType>(entity =>
            {
                entity.HasKey(e => e.StandType);

                entity.ToTable("CRM_AdStandType");

                entity.Property(e => e.StandType).ValueGeneratedNever();

                entity.Property(e => e.StandTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CrmAddLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_Add_log");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmAdplaceBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("crm_adplace_bak");

                entity.Property(e => e.AdSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<CrmAicallRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_AICallRecord");

                entity.Property(e => e.CallBackDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CallRecord)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RecordUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("录音地址");

                entity.Property(e => e.RequestDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RequestPhone)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmAicallRecordForUh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_AICallRecordForUH");

                entity.HasComment("优呼AI通话回调记录");

                entity.Property(e => e.CallBackDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LocaId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LocaID")
                    .HasComment("回调标识");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TalkText).HasColumnType("ntext");

                entity.Property(e => e.TouchPhoneId).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CrmBlockCom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_BlockComs");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmBondManager>(entity =>
            {
                entity.HasKey(e => e.Bondno)
                    .HasName("PK_Crm_BondManager");

                entity.ToTable("CRM_BondManager");

                entity.HasIndex(e => e.InputEplId, "PK_CRM_BondManager_EplID");

                entity.Property(e => e.Bondno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bondno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdBegin).HasColumnType("smalldatetime");

                entity.Property(e => e.AdEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.AdInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("adInfo");

                entity.Property(e => e.AdRecordId).HasColumnName("AdRecordID");

                entity.Property(e => e.Bdmoney)
                    .HasColumnType("money")
                    .HasColumnName("BDMoney");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HiresCount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InputDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderStatus).HasComment("0 未生成 1已完成 2已生成");

                entity.Property(e => e.SmsAmount).HasColumnType("money");

                entity.Property(e => e.WordFile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CrmCallAwoke>(entity =>
            {
                entity.ToTable("CRM_CallAwoke");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AwokeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.FinishFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmCessionLog>(entity =>
            {
                entity.ToTable("CRM_Cession_log");

                entity.HasIndex(e => e.ComId, "CRM_Cession_log_Com_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminIP");

                entity.Property(e => e.AdminUid).HasColumnName("adminUid");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CessionReason).HasColumnType("text");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FCsId).HasColumnName("F_CS_ID");

                entity.Property(e => e.FEplId).HasColumnName("F_EPL_ID");

                entity.Property(e => e.InceptDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inceptDate");

                entity.Property(e => e.InceptReason)
                    .HasColumnType("text")
                    .HasColumnName("inceptReason")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TCsId).HasColumnName("T_CS_ID");

                entity.Property(e => e.TEplId).HasColumnName("T_EPL_ID");
            });

            modelBuilder.Entity<CrmCessionLogBack>(entity =>
            {
                entity.ToTable("CRM_Cession_log_back");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminIP");

                entity.Property(e => e.AdminUid).HasColumnName("adminUid");

                entity.Property(e => e.CessionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CessionReason).HasColumnType("text");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FCsId).HasColumnName("F_CS_ID");

                entity.Property(e => e.FEplId).HasColumnName("F_EPL_ID");

                entity.Property(e => e.InceptDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inceptDate");

                entity.Property(e => e.InceptReason)
                    .HasColumnType("text")
                    .HasColumnName("inceptReason")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TCsId).HasColumnName("T_CS_ID");

                entity.Property(e => e.TEplId).HasColumnName("T_EPL_ID");
            });

            modelBuilder.Entity<CrmClientType>(entity =>
            {
                entity.ToTable("CRM_ClientType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Channelid).HasColumnName("channelid");

                entity.Property(e => e.Mcount).HasColumnName("mcount");

                entity.Property(e => e.Monday)
                    .HasColumnName("monday")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(16)
                    .HasColumnName("name");

                entity.Property(e => e.Orderid).HasColumnName("orderid");
            });

            modelBuilder.Entity<CrmClientsTrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_ClientsTrade");

                entity.Property(e => e.ClientsTrade)
                    .HasMaxLength(50)
                    .HasColumnName("clientsTrade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NewId).HasColumnName("newID");
            });

            modelBuilder.Entity<CrmComCount>(entity =>
            {
                entity.ToTable("CRM_ComCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Csid)
                    .HasColumnName("CSID")
                    .HasComment("1 未成交  2过期库");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");
            });

            modelBuilder.Entity<CrmComOpen>(entity =>
            {
                entity.ToTable("CRM_ComOpen");

                entity.HasIndex(e => e.ComId, "IX_CRM_ComOpen_ComID");

                entity.HasIndex(e => e.CheckState, "ix_CRM_Records_CheckState");

                entity.HasIndex(e => e.OpenState, "ix_CRM_Records_Openstate");

                entity.HasIndex(e => e.OpenType, "ix_CRM_Records_Opentype");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Bondid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.MemId).HasColumnName("Mem_ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenEplId)
                    .HasColumnName("OpenEpl_ID")
                    .HasComment("0");
            });

            modelBuilder.Entity<CrmComSnsOpen>(entity =>
            {
                entity.ToTable("CRM_ComSnsOpen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplyTypeId).HasColumnName("ApplyTypeID");

                entity.Property(e => e.Bondno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEplID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEplID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenEplId).HasColumnName("OpenEplID");

                entity.Property(e => e.TradeMoney).HasColumnType("money");
            });

            modelBuilder.Entity<CrmCompany>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("CRM_Company");

                entity.HasComment("");

                entity.HasIndex(e => new { e.PhoneZ, e.PhoneN, e.PhoneE }, "CRM_Company_Phone");

                entity.HasIndex(e => e.EplId, "IX_CRM_Company_EPL_ID");

                entity.HasIndex(e => new { e.ProvId, e.CityId }, "IX_CRM_Company_ProvCite");

                entity.HasIndex(e => e.ComName, "PK_CRM_ComPany_String");

                entity.HasIndex(e => e.CsId, "PK_Company_Cs_ID");

                entity.HasIndex(e => new { e.LastLinkDate, e.Cgetdate, e.Cetime, e.Cstime }, "PK_Company_Date");

                entity.Property(e => e.ComId)
                    .ValueGeneratedNever()
                    .HasColumnName("COM_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JiufuMemId).HasColumnName("jiufuMemID");

                entity.Property(e => e.Jobs)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.ZphPoints).HasColumnName("zphPoints");
            });

            modelBuilder.Entity<CrmCompanyArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_CompanyArchives");

                entity.Property(e => e.CaId).HasColumnName("CA_ID");

                entity.Property(e => e.CaLnkUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CA_LnkURL");

                entity.Property(e => e.CaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CA_Name");

                entity.Property(e => e.CaSize).HasColumnName("CA_Size");

                entity.Property(e => e.CaType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CA_Type");

                entity.Property(e => e.Caflag)
                    .HasColumnName("CAFlag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CasId).HasColumnName("CAS_ID");

                entity.Property(e => e.CasParentId).HasColumnName("CAS_ParentID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Epl_IP");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Epl_Name");

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmCompanyArchivesSort>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_CompanyArchivesSort");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmCompanyBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_Company_bak");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence)
                    .HasColumnName("CLicence")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId)
                    .HasColumnName("CS_ID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId)
                    .HasColumnName("DepartID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JiufuMemId).HasColumnName("jiufuMemID");

                entity.Property(e => e.Jobs)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.ZphPoints).HasColumnName("zphPoints");
            });

            modelBuilder.Entity<CrmCompanyNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_Company_New");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JiufuMemId).HasColumnName("jiufuMemID");

                entity.Property(e => e.Jobs)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.ZphPoints).HasColumnName("zphPoints");
            });

            modelBuilder.Entity<CrmCompanyOld>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.ToTable("CRM_Company_Old");

                entity.Property(e => e.ComId)
                    .ValueGeneratedNever()
                    .HasColumnName("COM_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JiufuMemId).HasColumnName("jiufuMemID");

                entity.Property(e => e.Jobs)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.ZphPoints).HasColumnName("zphPoints");
            });

            modelBuilder.Entity<CrmCompanySource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_CompanySource");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmContactApply>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_ContactApply");

                entity.Property(e => e.ApplicantDptId)
                    .HasColumnName("ApplicantDptID")
                    .HasComment("申请人所在部门");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ApplicantName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApplyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComplatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HasContact).HasComment("0 无联系方式 ；1 已找到 ；2 无法找到联系方式 ； 3 无效 ；4 拒绝；");

                entity.Property(e => e.HasDistributed).HasComment("是否分配");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .HasColumnName("Phone_N")
                    .IsFixedLength();

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Position)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaskRecipient).HasComment("任务接收人");

                entity.Property(e => e.WxId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WxID");
            });

            modelBuilder.Entity<CrmCsLog>(entity =>
            {
                entity.ToTable("CRM_CS_log");

                entity.HasIndex(e => e.ComId, "IX_CRM_CS_Log_ComID");

                entity.HasIndex(e => e.EplId, "IX_CRM_CS_Log_EplID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cgetdate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Epl_Name");

                entity.Property(e => e.FCsId).HasColumnName("F_CS_ID");

                entity.Property(e => e.OEplId).HasColumnName("oEpl_ID");

                entity.Property(e => e.OEplIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("oEpl_IP");

                entity.Property(e => e.OEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("oEpl_Name");

                entity.Property(e => e.OperId).HasColumnName("operID");

                entity.Property(e => e.OperMode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("operMode");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TCsId).HasColumnName("T_CS_ID");
            });

            modelBuilder.Entity<CrmDeleteLog>(entity =>
            {
                entity.ToTable("CRM_Delete_Log");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("com_id");

                entity.Property(e => e.EplId).HasColumnName("epl_id");

                entity.Property(e => e.InDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmDepartTask>(entity =>
            {
                entity.ToTable("CRM_DepartTask");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smonth).HasColumnName("SMonth");

                entity.Property(e => e.Syear).HasColumnName("SYear");

                entity.Property(e => e.TaskValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmDevelopStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_DevelopStatus");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmDredgeCompany>(entity =>
            {
                entity.ToTable("CRM_DredgeCompany");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApplyEplId).HasColumnName("ApplyEpl_ID");

                entity.Property(e => e.ApplyEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ApplyEpl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApplyInfo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("beginDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CheckEpl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckInfo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DredgeComType).HasColumnName("dredgeComType");

                entity.Property(e => e.DredgeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DredgeDays).HasColumnName("dredgeDays");

                entity.Property(e => e.DredgeEplId).HasColumnName("DredgeEpl_ID");

                entity.Property(e => e.DredgeEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DredgeEpl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DredgeInfo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DredgeStatus).HasComment("开通状态 0未开通，1开通了");

                entity.Property(e => e.DredgeType).HasColumnName("dredgeType");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExamDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExamEplId).HasColumnName("ExamEpl_ID");

                entity.Property(e => e.ExamEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExamEpl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamInfo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasComment("单状态 0 刚填写 1 审核不通过 2 审核通过 3 复核不通 4 复核通过");
            });

            modelBuilder.Entity<CrmElectronProgram>(entity =>
            {
                entity.HasKey(e => e.EleId);

                entity.ToTable("crm_electronProgram");

                entity.Property(e => e.EleId)
                    .ValueGeneratedNever()
                    .HasColumnName("eleID")
                    .HasComment("编号");

                entity.Property(e => e.ApplyTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("applyTime")
                    .HasComment("申请日期");

                entity.Property(e => e.ComId)
                    .HasColumnName("comID")
                    .HasComment("客户编号\r\n");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comName")
                    .HasComment("客户名称");

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasColumnName("content")
                    .HasComment("正文");

                entity.Property(e => e.DptId)
                    .HasColumnName("dptID")
                    .HasComment("部门编号");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName")
                    .HasComment("部门名称");

                entity.Property(e => e.EplId)
                    .HasColumnName("eplID")
                    .HasComment("申请人编号");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName")
                    .HasComment("申请人姓名");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime")
                    .HasComment("录入日期");

                entity.Property(e => e.Int1)
                    .HasColumnName("int1")
                    .HasComment("备1");

                entity.Property(e => e.IsReceive)
                    .HasColumnName("isReceive")
                    .HasComment("是否接收");

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("isSuccess")
                    .HasComment("是否成功");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .HasComment("接收人电话");

                entity.Property(e => e.ReceiveEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("receiveEmail")
                    .HasComment("接收人邮箱");

                entity.Property(e => e.SendName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sendName");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.Str1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("str1")
                    .HasComment("备2");
            });

            modelBuilder.Entity<CrmElectronTemplate>(entity =>
            {
                entity.HasKey(e => e.EtId)
                    .HasName("PK_crm_electronTemplate_1");

                entity.ToTable("crm_electronTemplate");

                entity.Property(e => e.EtId)
                    .ValueGeneratedNever()
                    .HasColumnName("etID")
                    .HasComment("编号");

                entity.Property(e => e.Body)
                    .HasColumnType("ntext")
                    .HasColumnName("body")
                    .HasComment("正文");

                entity.Property(e => e.EplId)
                    .HasColumnName("eplID")
                    .HasComment("所属人");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName")
                    .HasComment("所属姓名");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime")
                    .HasComment("录入时间");

                entity.Property(e => e.Int1)
                    .HasColumnName("int1")
                    .HasComment("备1");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("模板名");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.Str1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("str1")
                    .HasComment("备2");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasComment("类型");
            });

            modelBuilder.Entity<CrmEplTask>(entity =>
            {
                entity.ToTable("CRM_EplTask");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depid).HasColumnName("depid");

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.Smonth).HasColumnName("SMonth");

                entity.Property(e => e.Syear).HasColumnName("SYear");

                entity.Property(e => e.TaskValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmExpirationDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_ExpirationDisplay");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplId)
                    .HasColumnName("EPL_ID")
                    .HasComment("所属人");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GetDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.GetEplId).HasColumnName("GetEplID");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastTradeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmFoshanRecord>(entity =>
            {
                entity.ToTable("CRM_FoshanRecord");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.EplId).HasColumnName("epl_id");

                entity.Property(e => e.SetDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmFreeOpen>(entity =>
            {
                entity.ToTable("Crm_FreeOpen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.InputDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");
            });

            modelBuilder.Entity<CrmFromWebAddLog>(entity =>
            {
                entity.ToTable("CRM_FromWebAdd_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("Com_id");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.MemId).HasColumnName("Mem_id");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("registerDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmGetLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_Get_log");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FEplId).HasColumnName("F_EPL_ID");

                entity.Property(e => e.GetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Get_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TEplId).HasColumnName("T_EPL_ID");
            });

            modelBuilder.Entity<CrmHomePage>(entity =>
            {
                entity.ToTable("CRM_HomePage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdTypeId).HasColumnName("AdTypeID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DemoText)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OnlineDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CrmLinkman>(entity =>
            {
                entity.HasKey(e => e.LnkId);

                entity.ToTable("CRM_Linkman");

                entity.HasIndex(e => e.ComId, "CRM_Linkman_ComID");

                entity.HasIndex(e => e.LnkName, "CRM_Linkman_Lnk_Name");

                entity.HasIndex(e => e.Mobile, "PK_CRM_Linkman_Mobile");

                entity.HasIndex(e => new { e.PhoneN, e.PhoneZ, e.PhoneE }, "PK_Crm_Linkman_Phone");

                entity.Property(e => e.LnkId)
                    .ValueGeneratedNever()
                    .HasColumnName("Lnk_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comname)
                    .HasMaxLength(200)
                    .HasColumnName("comname");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.Eplname)
                    .HasMaxLength(50)
                    .HasColumnName("eplname");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ");

                entity.Property(e => e.LnkName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Lnk_Name");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmLinkmanBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_Linkman_back");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comname)
                    .HasMaxLength(200)
                    .HasColumnName("comname");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.Eplname)
                    .HasMaxLength(50)
                    .HasColumnName("eplname");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ");

                entity.Property(e => e.LnkId).HasColumnName("Lnk_ID");

                entity.Property(e => e.LnkName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Lnk_Name");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmLinkmanOld>(entity =>
            {
                entity.HasKey(e => e.LnkId);

                entity.ToTable("CRM_Linkman_Old");

                entity.Property(e => e.LnkId)
                    .ValueGeneratedNever()
                    .HasColumnName("Lnk_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Comname)
                    .HasMaxLength(200)
                    .HasColumnName("comname");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.Eplname)
                    .HasMaxLength(50)
                    .HasColumnName("eplname");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ");

                entity.Property(e => e.LnkName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Lnk_Name");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmLinkmanPo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_LinkmanPos");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmLinkmanSen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_LinkmanSens");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CrmMandatory>(entity =>
            {
                entity.ToTable("CRM_Mandatory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.LiyouText)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShenheDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CrmMemselfhelp>(entity =>
            {
                entity.ToTable("CRM_Memselfhelp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comid).HasColumnName("COMID");

                entity.Property(e => e.DemoText)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");
            });

            modelBuilder.Entity<CrmModifyNameApply>(entity =>
            {
                entity.ToTable("CRM_ModifyNameApply");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AEplId).HasColumnName("A_Epl_ID");

                entity.Property(e => e.AEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Epl_Name");

                entity.Property(e => e.ApplyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.CrmModify).HasDefaultValueSql("(1)");

                entity.Property(e => e.EEplId).HasColumnName("E_Epl_ID");

                entity.Property(e => e.EEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Epl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("F_COM_Name");

                entity.Property(e => e.FFax)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("F_Fax");

                entity.Property(e => e.FPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("F_Phone");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.MEplId).HasColumnName("M_Epl_ID");

                entity.Property(e => e.MEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_Epl_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("registerDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("T_COM_Name");

                entity.Property(e => e.WebModify).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CrmNewsAd>(entity =>
            {
                entity.HasKey(e => e.NewsAdId);

                entity.ToTable("CRM_NewsAd");

                entity.Property(e => e.NewsAdId).HasColumnName("NewsAdID");

                entity.Property(e => e.ApplyTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContentText)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.OrderById).HasColumnName("OrderByID");

                entity.Property(e => e.PositionText)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StandId).HasColumnName("StandID");
            });

            modelBuilder.Entity<CrmOnduty>(entity =>
            {
                entity.HasKey(e => e.OnId);

                entity.ToTable("CRM_Onduty");

                entity.Property(e => e.OnId)
                    .ValueGeneratedNever()
                    .HasColumnName("onID");

                entity.Property(e => e.DptId).HasColumnName("dpt_ID");

                entity.Property(e => e.Modtype)
                    .HasColumnName("modtype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OndutyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ondutyDate");
            });

            modelBuilder.Entity<CrmOuterTemporary>(entity =>
            {
                entity.ToTable("CRM_Outer_Temporary");

                entity.HasComment("外网企业更新公库");

                entity.HasIndex(e => e.ComId, "IX_CRM_Outer_Temporary_COM_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLinkEplId)
                    .HasColumnName("LastLinkEplID")
                    .HasComment("最后拜访人");

                entity.Property(e => e.NewestPosName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewestReflashDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmProcessClient>(entity =>
            {
                entity.ToTable("crm_processClients");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Retainday).HasColumnName("retainday");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CrmProductBond>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("crm_productBond");

                entity.Property(e => e.ProId)
                    .ValueGeneratedNever()
                    .HasColumnName("proID");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.DptId).HasColumnName("dptId");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Int1).HasColumnName("int1");

                entity.Property(e => e.IntTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("intTime");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Str1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("str1");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CrmRecord>(entity =>
            {
                entity.HasKey(e => e.RId);

                entity.ToTable("CRM_Records");

                entity.HasIndex(e => e.RDate, "Crm_Records_rDate");

                entity.HasIndex(e => e.RType, "ix_CRM_Records_Rtype");

                entity.HasIndex(e => e.Author, "ix_CRM_Records_author");

                entity.HasIndex(e => e.CId, "ix_CRM_Records_cid");

                entity.Property(e => e.RId).HasColumnName("rId");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Bgcolor)
                    .HasMaxLength(50)
                    .HasColumnName("bgcolor")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CId).HasColumnName("cId");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.DptId)
                    .HasColumnName("dptID")
                    .HasComment("0");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Len)
                    .HasColumnName("len")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RContent)
                    .HasColumnType("ntext")
                    .HasColumnName("rContent");

                entity.Property(e => e.RDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rDate");

                entity.Property(e => e.RType).HasColumnName("rType");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeName");

                entity.Property(e => e.Wavname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("wavname")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CrmRecordsType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRM_RecordsType");

                entity.Property(e => e.RecordsType).HasMaxLength(16);
            });

            modelBuilder.Entity<CrmRemind>(entity =>
            {
                entity.ToTable("CRM_Remind");

                entity.HasIndex(e => e.ComId, "PK_CRM_Remind_ComID");

                entity.HasIndex(e => e.EplId, "PK_CRM_Remind_EplID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.Sday).HasColumnName("SDay");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.Vdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDate");
            });

            modelBuilder.Entity<CrmStand>(entity =>
            {
                entity.HasKey(e => e.StandId);

                entity.ToTable("CRM_Stand");

                entity.Property(e => e.StandId).HasColumnName("StandID");

                entity.Property(e => e.AtTheTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dptid).HasColumnName("DPTID");

                entity.Property(e => e.Dptid2)
                    .HasColumnName("DPTID2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EplIds)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InputEplId).HasColumnName("InputEplID");

                entity.Property(e => e.Matters)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumberCount)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CrmTempClient>(entity =>
            {
                entity.ToTable("crm_tempClients");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveTime)
                    .HasColumnType("datetime")
                    .HasColumnName("activeTime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.KeepDay).HasColumnName("keepDay");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<DataDptMoney>(entity =>
            {
                entity.ToTable("Data_DptMoney");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DptId).HasColumnName("Dpt_id");

                entity.Property(e => e.Syear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataEplMoney>(entity =>
            {
                entity.ToTable("Data_EplMoney");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DptId).HasColumnName("dpt_id");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.Money1).HasColumnName("money1");

                entity.Property(e => e.Money10).HasColumnName("money10");

                entity.Property(e => e.Money11).HasColumnName("money11");

                entity.Property(e => e.Money12).HasColumnName("money12");

                entity.Property(e => e.Money2).HasColumnName("money2");

                entity.Property(e => e.Money3).HasColumnName("money3");

                entity.Property(e => e.Money4).HasColumnName("money4");

                entity.Property(e => e.Money5).HasColumnName("money5");

                entity.Property(e => e.Money6).HasColumnName("money6");

                entity.Property(e => e.Money7).HasColumnName("money7");

                entity.Property(e => e.Money8).HasColumnName("money8");

                entity.Property(e => e.Money9).HasColumnName("money9");

                entity.Property(e => e.Moneycount).HasColumnName("moneycount");

                entity.Property(e => e.Syear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataFinComCount>(entity =>
            {
                entity.ToTable("Data_Fin_ComCount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Smonth).HasColumnName("smonth");

                entity.Property(e => e.Sname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sname");

                entity.Property(e => e.Svalue).HasColumnName("svalue");

                entity.Property(e => e.Syear).HasColumnName("syear");
            });

            modelBuilder.Entity<DayInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dayInfo");

                entity.Property(e => e.Allsum).HasColumnName("allsum");

                entity.Property(e => e.Cmonth).HasColumnName("cmonth");

                entity.Property(e => e.Cyear).HasColumnName("cyear");

                entity.Property(e => e.Day1).HasColumnName("day1");

                entity.Property(e => e.Day10).HasColumnName("day10");

                entity.Property(e => e.Day11).HasColumnName("day11");

                entity.Property(e => e.Day12).HasColumnName("day12");

                entity.Property(e => e.Day13).HasColumnName("day13");

                entity.Property(e => e.Day14).HasColumnName("day14");

                entity.Property(e => e.Day15).HasColumnName("day15");

                entity.Property(e => e.Day16).HasColumnName("day16");

                entity.Property(e => e.Day17).HasColumnName("day17");

                entity.Property(e => e.Day18).HasColumnName("day18");

                entity.Property(e => e.Day19).HasColumnName("day19");

                entity.Property(e => e.Day2).HasColumnName("day2");

                entity.Property(e => e.Day20).HasColumnName("day20");

                entity.Property(e => e.Day21).HasColumnName("day21");

                entity.Property(e => e.Day22).HasColumnName("day22");

                entity.Property(e => e.Day23).HasColumnName("day23");

                entity.Property(e => e.Day24).HasColumnName("day24");

                entity.Property(e => e.Day25).HasColumnName("day25");

                entity.Property(e => e.Day26).HasColumnName("day26");

                entity.Property(e => e.Day27).HasColumnName("day27");

                entity.Property(e => e.Day28).HasColumnName("day28");

                entity.Property(e => e.Day29).HasColumnName("day29");

                entity.Property(e => e.Day3).HasColumnName("day3");

                entity.Property(e => e.Day30).HasColumnName("day30");

                entity.Property(e => e.Day31).HasColumnName("day31");

                entity.Property(e => e.Day4).HasColumnName("day4");

                entity.Property(e => e.Day5).HasColumnName("day5");

                entity.Property(e => e.Day6).HasColumnName("day6");

                entity.Property(e => e.Day7).HasColumnName("day7");

                entity.Property(e => e.Day8).HasColumnName("day8");

                entity.Property(e => e.Day9).HasColumnName("day9");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.EsId).HasColumnName("esID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Picture)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<DayPhone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dayPhone");

                entity.Property(e => e.Allsum).HasColumnName("allsum");

                entity.Property(e => e.CMonth).HasColumnName("cMonth");

                entity.Property(e => e.CYear).HasColumnName("cYear");

                entity.Property(e => e.Day1).HasColumnName("day1");

                entity.Property(e => e.Day10).HasColumnName("day10");

                entity.Property(e => e.Day11).HasColumnName("day11");

                entity.Property(e => e.Day12).HasColumnName("day12");

                entity.Property(e => e.Day13).HasColumnName("day13");

                entity.Property(e => e.Day14).HasColumnName("day14");

                entity.Property(e => e.Day15).HasColumnName("day15");

                entity.Property(e => e.Day16).HasColumnName("day16");

                entity.Property(e => e.Day17).HasColumnName("day17");

                entity.Property(e => e.Day18).HasColumnName("day18");

                entity.Property(e => e.Day19).HasColumnName("day19");

                entity.Property(e => e.Day2).HasColumnName("day2");

                entity.Property(e => e.Day20).HasColumnName("day20");

                entity.Property(e => e.Day21).HasColumnName("day21");

                entity.Property(e => e.Day22).HasColumnName("day22");

                entity.Property(e => e.Day23).HasColumnName("day23");

                entity.Property(e => e.Day24).HasColumnName("day24");

                entity.Property(e => e.Day25).HasColumnName("day25");

                entity.Property(e => e.Day26).HasColumnName("day26");

                entity.Property(e => e.Day27).HasColumnName("day27");

                entity.Property(e => e.Day28).HasColumnName("day28");

                entity.Property(e => e.Day29).HasColumnName("day29");

                entity.Property(e => e.Day3).HasColumnName("day3");

                entity.Property(e => e.Day30).HasColumnName("day30");

                entity.Property(e => e.Day31).HasColumnName("day31");

                entity.Property(e => e.Day4).HasColumnName("day4");

                entity.Property(e => e.Day5).HasColumnName("day5");

                entity.Property(e => e.Day6).HasColumnName("day6");

                entity.Property(e => e.Day7).HasColumnName("day7");

                entity.Property(e => e.Day8).HasColumnName("day8");

                entity.Property(e => e.Day9).HasColumnName("day9");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("picture");
            });

            modelBuilder.Entity<DaySign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daySign");

                entity.Property(e => e.A1).HasColumnName("a1");

                entity.Property(e => e.A10).HasColumnName("a10");

                entity.Property(e => e.A2).HasColumnName("a2");

                entity.Property(e => e.A3).HasColumnName("a3");

                entity.Property(e => e.A4).HasColumnName("a4");

                entity.Property(e => e.A5).HasColumnName("a5");

                entity.Property(e => e.A6).HasColumnName("a6");

                entity.Property(e => e.A7).HasColumnName("a7");

                entity.Property(e => e.A8).HasColumnName("a8");

                entity.Property(e => e.A9).HasColumnName("a9");

                entity.Property(e => e.AaCount).HasColumnName("aaCount");

                entity.Property(e => e.Back10).HasColumnName("back10");

                entity.Property(e => e.Back1030).HasColumnName("back10_30");

                entity.Property(e => e.Back120).HasColumnName("back120");

                entity.Property(e => e.Back3060).HasColumnName("back30_60");

                entity.Property(e => e.Back60120).HasColumnName("back60_120");

                entity.Property(e => e.DayMonth).HasColumnName("dayMonth");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Hmonth).HasColumnName("hmonth");

                entity.Property(e => e.Hyear).HasColumnName("hyear");

                entity.Property(e => e.Late10).HasColumnName("late10");

                entity.Property(e => e.Late1030).HasColumnName("late10_30");

                entity.Property(e => e.Late120).HasColumnName("late120");

                entity.Property(e => e.Late3060).HasColumnName("late30_60");

                entity.Property(e => e.Late60120).HasColumnName("late60_120");

                entity.Property(e => e.LateMor).HasColumnName("lateMor");

                entity.Property(e => e.Lateaft).HasColumnName("lateaft");

                entity.Property(e => e.MmCount).HasColumnName("mmCount");
            });

            modelBuilder.Entity<DayUserCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dayUserCost");

                entity.Property(e => e.Allsum).HasColumnName("allsum");

                entity.Property(e => e.CMonth).HasColumnName("cMonth");

                entity.Property(e => e.CYear).HasColumnName("cYear");

                entity.Property(e => e.Day1).HasColumnName("day1");

                entity.Property(e => e.Day10).HasColumnName("day10");

                entity.Property(e => e.Day11).HasColumnName("day11");

                entity.Property(e => e.Day12).HasColumnName("day12");

                entity.Property(e => e.Day13).HasColumnName("day13");

                entity.Property(e => e.Day14).HasColumnName("day14");

                entity.Property(e => e.Day15).HasColumnName("day15");

                entity.Property(e => e.Day16).HasColumnName("day16");

                entity.Property(e => e.Day17).HasColumnName("day17");

                entity.Property(e => e.Day18).HasColumnName("day18");

                entity.Property(e => e.Day19).HasColumnName("day19");

                entity.Property(e => e.Day2).HasColumnName("day2");

                entity.Property(e => e.Day20).HasColumnName("day20");

                entity.Property(e => e.Day21).HasColumnName("day21");

                entity.Property(e => e.Day22).HasColumnName("day22");

                entity.Property(e => e.Day23).HasColumnName("day23");

                entity.Property(e => e.Day24).HasColumnName("day24");

                entity.Property(e => e.Day25).HasColumnName("day25");

                entity.Property(e => e.Day26).HasColumnName("day26");

                entity.Property(e => e.Day27).HasColumnName("day27");

                entity.Property(e => e.Day28).HasColumnName("day28");

                entity.Property(e => e.Day29).HasColumnName("day29");

                entity.Property(e => e.Day3).HasColumnName("day3");

                entity.Property(e => e.Day30).HasColumnName("day30");

                entity.Property(e => e.Day31).HasColumnName("day31");

                entity.Property(e => e.Day4).HasColumnName("day4");

                entity.Property(e => e.Day5).HasColumnName("day5");

                entity.Property(e => e.Day6).HasColumnName("day6");

                entity.Property(e => e.Day7).HasColumnName("day7");

                entity.Property(e => e.Day8).HasColumnName("day8");

                entity.Property(e => e.Day9).HasColumnName("day9");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.EsId).HasColumnName("esID");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasColumnName("memo");

                entity.Property(e => e.Picture)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Posimonth).HasColumnName("posimonth");
            });

            modelBuilder.Entity<DeCrmLinkmanaLog>(entity =>
            {
                entity.ToTable("De_Crm_Linkmana_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.LnkId).HasColumnName("Lnk_ID");
            });

            modelBuilder.Entity<DevBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dev_bak");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<DevClient>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("DEV_Client");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.ClientInfo).HasColumnType("ntext");

                entity.Property(e => e.ClientName).HasMaxLength(50);

                entity.Property(e => e.ClientTypeId).HasColumnName("ClientTypeID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.GetDate).HasColumnType("datetime");

                entity.Property(e => e.GiveupDate).HasColumnType("datetime");

                entity.Property(e => e.HaveOwner)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.LastTrackDate).HasColumnType("datetime");

                entity.Property(e => e.LastTrackId).HasColumnName("LastTrackID");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Msn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MSN");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneArea).HasMaxLength(50);

                entity.Property(e => e.PhoneExt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneUser).HasMaxLength(50);

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Qq)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("QQ");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransferLog)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.WebDomain).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<DevClientType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("DEV_ClientType");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DevTrackRecord>(entity =>
            {
                entity.HasKey(e => e.TrackId);

                entity.ToTable("DEV_TrackRecord");

                entity.Property(e => e.TrackId)
                    .ValueGeneratedNever()
                    .HasColumnName("TrackID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.TrackDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrackTypeId).HasColumnName("TrackTypeID");
            });

            modelBuilder.Entity<DevTrackType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("DEV_TrackType");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DevTransferLog>(entity =>
            {
                entity.ToTable("DEV_TransferLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.SendDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SendWhy)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicCs80State>(entity =>
            {
                entity.ToTable("Dic_Cs80_State");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_name");
            });

            modelBuilder.Entity<ErmAdminBranch>(entity =>
            {
                entity.ToTable("ERM_AdminBranch");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ManaBranch)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("manaBranch");

                entity.Property(e => e.RegTime)
                    .HasColumnType("datetime")
                    .HasColumnName("regTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ErmEmployee>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("ERM_Employee");

                entity.HasIndex(e => e.CityId, "ix_ERM_Employee.City_ID");

                entity.HasIndex(e => e.DgrId, "ix_ERM_Employee.DGR_ID");

                entity.HasIndex(e => e.DptId, "ix_ERM_Employee.Dpt_ID");

                entity.HasIndex(e => e.EsId, "ix_ERM_Employee.ES_ID");

                entity.HasIndex(e => e.ProvId, "ix_ERM_Employee.PROV_ID");

                entity.HasIndex(e => e.PosId, "ix_ERM_Employee.Pos_ID");

                entity.HasIndex(e => e.RegisterDate, "ix_ERM_Employee.RegisterDate");

                entity.HasIndex(e => e.UserName, "ix_ERM_Employee.UserName");

                entity.HasIndex(e => e.UserPwd, "ix_ERM_PassWord");

                entity.HasIndex(e => e.RegisterDate, "ix_Erm_Employee_RegisterDate");

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

            modelBuilder.Entity<ErmEmployeePosition>(entity =>
            {
                entity.ToTable("ERM_EmployeePosition");

                entity.HasIndex(e => e.DptId, "ix_ERM_EmployeePosition.Dpt_ID");

                entity.HasIndex(e => e.EplId, "ix_ERM_EmployeePosition.Epl_ID");

                entity.HasIndex(e => e.PosId, "ix_ERM_EmployeePosition.Pos_ID");

                entity.HasIndex(e => e.RegisterDate, "ix_ERM_EmployeePosition.RegisterDate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.PosId).HasColumnName("Pos_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ErmEsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERM_ES_log");

                entity.Property(e => e.Cause).HasColumnType("text");

                entity.Property(e => e.EplId)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Epl_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OEplId).HasColumnName("oEpl_ID");

                entity.Property(e => e.Oip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OIP");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ErmEvection>(entity =>
            {
                entity.ToTable("ERM_Evection");

                entity.HasIndex(e => e.DptId, "ix_ERM_Evection.Dpt_ID");

                entity.HasIndex(e => e.EplId, "ix_ERM_Evection.Epl_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("beginDate");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("checkDate");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEpl_ID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CompanyForecast)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companyForecast")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanySize)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companySize")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EvectionType).HasColumnName("evectionType");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("linkMan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LinkTel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("linkTel")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MakeProtocol)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("makeProtocol")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.Reason)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalDay).HasColumnName("totalDay");

                entity.Property(e => e.TotalHour).HasColumnName("totalHour");

                entity.Property(e => e.TotalMinute).HasColumnName("totalMinute");

                entity.Property(e => e.TrafficDay).HasColumnName("trafficDay");

                entity.Property(e => e.TrafficHour).HasColumnName("trafficHour");

                entity.Property(e => e.TrafficMinute).HasColumnName("trafficMinute");

                entity.Property(e => e.TrialDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("trialDate");

                entity.Property(e => e.TrialEplId).HasColumnName("trialEpl_ID");

                entity.Property(e => e.WorkDay).HasColumnName("workDay");

                entity.Property(e => e.WorkHour).HasColumnName("workHour");

                entity.Property(e => e.WorkMinute).HasColumnName("workMinute");
            });

            modelBuilder.Entity<ErmOnDuty>(entity =>
            {
                entity.ToTable("ERM_OnDuty");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dpt_Name");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.InputTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("插入时间");

                entity.Property(e => e.OnDutyDay)
                    .HasColumnType("smalldatetime")
                    .HasComment("值班日期");

                entity.Property(e => e.OnDutyTime).HasComment("值班类型，1 全天；2  上午；3  下午 ");
            });

            modelBuilder.Entity<ErmOvertime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ERM_Overtime");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyDepart)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyPerNameId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeginTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OvertimeDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassPerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.TtlTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Why)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EvaluateCategory>(entity =>
            {
                entity.ToTable("evaluate_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.CateName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cateName");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<EvaluateItem>(entity =>
            {
                entity.ToTable("evaluate_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Fraction).HasColumnName("fraction");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(20)
                    .HasColumnName("itemName");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<EvaluateRecord>(entity =>
            {
                entity.ToTable("evaluate_records");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdminEplId).HasColumnName("adminEplID");

                entity.Property(e => e.AdminEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("adminEplName");

                entity.Property(e => e.CallLen)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("callLen");

                entity.Property(e => e.CallTime)
                    .HasColumnType("datetime")
                    .HasColumnName("callTime");

                entity.Property(e => e.CallType).HasColumnName("callType");

                entity.Property(e => e.Callphone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("callphone");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.CateName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cateName");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checkTime");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("content");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplId");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.FraRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("fraRemark");

                entity.Property(e => e.Fraction)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fraction");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.PhoneId).HasColumnName("phoneID");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Tags)
                    .HasMaxLength(500)
                    .HasColumnName("tags");

                entity.Property(e => e.VoiceFile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("voiceFile");
            });

            modelBuilder.Entity<EvaluateScore>(entity =>
            {
                entity.ToTable("evaluate_score");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CallTime)
                    .HasColumnType("datetime")
                    .HasColumnName("callTime");

                entity.Property(e => e.CateId).HasColumnName("cateID");

                entity.Property(e => e.DptId).HasColumnName("dptId");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Fraction)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fraction");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.MarkEplId).HasColumnName("markEplID");

                entity.Property(e => e.MarkEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("markEplName");

                entity.Property(e => e.RecordId).HasColumnName("recordID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<FinAchievementPk>(entity =>
            {
                entity.HasKey(e => e.Pkid);

                entity.ToTable("Fin_AchievementPK");

                entity.Property(e => e.Pkid).HasColumnName("PKID");

                entity.Property(e => e.EplIdone).HasColumnName("EplIDOne");

                entity.Property(e => e.EplIdtwo).HasColumnName("EplIDTwo");
            });

            modelBuilder.Entity<FinAdAmount>(entity =>
            {
                entity.HasKey(e => e.FadId);

                entity.ToTable("Fin_AdAmount");

                entity.Property(e => e.FadId)
                    .ValueGeneratedNever()
                    .HasColumnName("fadID");

                entity.Property(e => e.AdName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("adName");

                entity.Property(e => e.AdType).HasColumnName("adType");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.Delflag).HasColumnName("delflag");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.InputEplId).HasColumnName("inputEplID");

                entity.Property(e => e.InputEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("inputEplName");

                entity.Property(e => e.ReTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Revenue)
                    .HasColumnType("money")
                    .HasColumnName("revenue");

                entity.Property(e => e.RevenueType).HasColumnName("revenueType");
            });

            modelBuilder.Entity<FinAdType>(entity =>
            {
                entity.HasKey(e => e.AId);

                entity.ToTable("fin_adType");

                entity.Property(e => e.AId)
                    .ValueGeneratedNever()
                    .HasColumnName("aID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FinInvoice>(entity =>
            {
                entity.HasKey(e => e.InId);

                entity.ToTable("fin_invoice");

                entity.Property(e => e.InId).HasColumnName("InID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("申请时间");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("公司地址");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("开票金额");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("审核时间");

                entity.Property(e => e.BroughtAccount)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasComment("对公账号");

                entity.Property(e => e.ComId)
                    .HasColumnName("COM_ID")
                    .HasComment("企业编号");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("公司名称");

                entity.Property(e => e.ComType).HasComment("公司类别（番禺或南沙）");

                entity.Property(e => e.EplId)
                    .HasColumnName("EplID")
                    .HasComment("申请人编号");

                entity.Property(e => e.InModify).HasComment("申请修改（通过状态下  1 为申请修改  2 为同意修改 3为领取）");

                entity.Property(e => e.InNum)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("开具发票（开具后输入发票号码）");

                entity.Property(e => e.InState).HasComment("申请状态（0 未审核 -1 审核不通过 1申请通过 ）");

                entity.Property(e => e.InType).HasComment("发票类型");

                entity.Property(e => e.NumTime).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("开户行");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("电话");

                entity.Property(e => e.ReceiveTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("数量（填写招聘会场次或会员时间）");

                entity.Property(e => e.StateContext)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')")
                    .HasComment("不通过原因");

                entity.Property(e => e.Taxpayers)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('‘’')")
                    .HasComment("纳税人识别号");

                entity.Property(e => e.UseType).HasComment("类型（填写招聘会或网络会员）");
            });

            modelBuilder.Entity<FinSalary>(entity =>
            {
                entity.ToTable("Fin_salary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Afternoon)
                    .HasColumnName("afternoon")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Amerce)
                    .HasColumnName("amerce")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Bonus)
                    .HasColumnName("bonus")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DayCount)
                    .HasColumnName("dayCount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DptId)
                    .HasColumnName("dptID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplId)
                    .HasColumnName("eplID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormalAfternoon)
                    .HasColumnName("formalAfternoon")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormalSalary)
                    .HasColumnName("formalSalary")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.House)
                    .HasColumnName("house")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Insurance)
                    .HasColumnName("insurance")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ipmac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPMac")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LiveCost)
                    .HasColumnName("liveCost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Overtime)
                    .HasColumnName("overtime")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Revenue)
                    .HasColumnName("revenue")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<FinTradeList>(entity =>
            {
                entity.ToTable("FIN_TradeList");

                entity.HasIndex(e => e.ComId, "PK_FIN_TradeList_ComID");

                entity.HasIndex(e => e.EplId, "PK_FIN_TradeList_EplID");

                entity.HasIndex(e => e.DptId, "PK_Fin_TradeList_DPT_ID");

                entity.HasIndex(e => new { e.TradeDate, e.ReceiveDate, e.InputDate }, "PK_TradeList_Date");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("cityID");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.DelFlag).HasColumnName("delFlag");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.Info)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtherFinId).HasColumnName("otherFinID");

                entity.Property(e => e.ProvId).HasColumnName("provID");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceiveEplId).HasColumnName("ReceiveEpl_id");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.TradeDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TradeEplId).HasColumnName("TradeEpl_id");

                entity.Property(e => e.TradeListType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1招聘；2软件；3猎才(前端)；4猎才(后端)");

                entity.Property(e => e.TradeMoney).HasColumnType("money");
            });

            modelBuilder.Entity<FinWebSite>(entity =>
            {
                entity.ToTable("Fin_WebSite");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdminIP")
                    .HasComment("管理人IP");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("管理人姓名");

                entity.Property(e => e.AdminUser).HasComment("管理人ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasComment("公司ID");

                entity.Property(e => e.DptId)
                    .HasColumnName("Dpt_ID")
                    .HasComment("收费人所在部门");

                entity.Property(e => e.EplId)
                    .HasColumnName("Epl_ID")
                    .HasComment("收费人ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Epl_Name")
                    .HasComment("收费人姓名");

                entity.Property(e => e.FinProperty).HasComment("收费性质");

                entity.Property(e => e.HowCost)
                    .HasColumnType("money")
                    .HasComment("费用");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("录入时间");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasComment("备注");
            });

            modelBuilder.Entity<ForumAskReply>(entity =>
            {
                entity.ToTable("Forum_AskReply");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AskId).HasColumnName("AskID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("ReplyID")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ForumAskType>(entity =>
            {
                entity.ToTable("Forum_AskType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumAsking>(entity =>
            {
                entity.ToTable("Forum_Asking");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipmac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPMac");
            });

            modelBuilder.Entity<ForumComment>(entity =>
            {
                entity.ToTable("Forum_Comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CommentCount)
                    .HasColumnName("commentCount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CommentId)
                    .HasColumnName("CommentID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.MsgId).HasColumnName("MsgID");

                entity.Property(e => e.ReferMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyMessage).HasColumnType("text");
            });

            modelBuilder.Entity<ForumCommentBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Forum_Comment_bak");

                entity.Property(e => e.CommentCount).HasColumnName("commentCount");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.MsgId).HasColumnName("MsgID");

                entity.Property(e => e.ReferMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyMessage).HasColumnType("text");
            });

            modelBuilder.Entity<ForumMessage>(entity =>
            {
                entity.HasKey(e => e.MsgId);

                entity.ToTable("Forum_message");

                entity.Property(e => e.MsgId)
                    .ValueGeneratedNever()
                    .HasColumnName("msgID");

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessType).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsgContent)
                    .HasColumnType("text")
                    .HasColumnName("Msg_Content");

                entity.Property(e => e.MsgHit).HasColumnName("Msg_hit");

                entity.Property(e => e.MsgTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Title");

                entity.Property(e => e.PlateId).HasColumnName("PlateID");

                entity.Property(e => e.ReplyHit)
                    .HasColumnName("Reply_Hit")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ReplyLastTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Reply_LastTime");

                entity.Property(e => e.ReplyMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reply_man")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ThisMark).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumMessageBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Forum_message_bak");

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.MsgContent)
                    .HasColumnType("text")
                    .HasColumnName("Msg_Content");

                entity.Property(e => e.MsgHit).HasColumnName("Msg_hit");

                entity.Property(e => e.MsgId).HasColumnName("msgID");

                entity.Property(e => e.MsgTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Title");

                entity.Property(e => e.PlateId).HasColumnName("PlateID");

                entity.Property(e => e.ReplyHit).HasColumnName("Reply_Hit");

                entity.Property(e => e.ReplyLastTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Reply_LastTime");

                entity.Property(e => e.ReplyMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reply_man");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ForumOnline>(entity =>
            {
                entity.ToTable("Forum_online");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Epl_name");

                entity.Property(e => e.InIp)
                    .HasMaxLength(10)
                    .HasColumnName("InIP")
                    .IsFixedLength();

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ForumPlate>(entity =>
            {
                entity.HasKey(e => e.PlateId);

                entity.ToTable("Forum_Plate");

                entity.Property(e => e.PlateId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlateID");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlateStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GoodjobRecommend>(entity =>
            {
                entity.ToTable("Goodjob_Recommend");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DateId).HasColumnName("DateID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ProcessingDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceMyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceMyUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpEplId).HasColumnName("UpEplID");
            });

            modelBuilder.Entity<GoodjobRecommendBack>(entity =>
            {
                entity.ToTable("Goodjob_Recommend_back");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DateId).HasColumnName("DateID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ProcessingDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceMyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceMyUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpEplId).HasColumnName("UpEplID");
            });

            modelBuilder.Entity<HrAttend>(entity =>
            {
                entity.ToTable("Hr_Attend");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Afternoonbz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("afternoonbz");

                entity.Property(e => e.Afternooncount).HasColumnName("afternooncount");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime");

                entity.Property(e => e.Attenddate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("attenddate");

                entity.Property(e => e.Morningbz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("morningbz")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Morningcount).HasColumnName("morningcount");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("morningtime");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<HrHoliday>(entity =>
            {
                entity.ToTable("Hr_holiday");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckManUid).HasDefaultValueSql("('')");

                entity.Property(e => e.Checkmemo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Intime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("intime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<HrHolidayType>(entity =>
            {
                entity.HasKey(e => e.Hid);

                entity.ToTable("Hr_Holiday_Type");

                entity.Property(e => e.Hid).ValueGeneratedNever();

                entity.Property(e => e.Hname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrSignin>(entity =>
            {
                entity.ToTable("Hr_signin");

                entity.HasIndex(e => e.UId, "Hr_signin_Uid");

                entity.HasIndex(e => e.Insertdate, "Hr_signin_insertdate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Afternoonbz).HasColumnName("afternoonbz");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FromIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromIpLast)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FromIP_last")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Insertdate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Morningbz).HasColumnName("morningbz");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("morningtime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UId).HasColumnName("uID");
            });

            modelBuilder.Entity<HrSigninLog>(entity =>
            {
                entity.ToTable("Hr_signin_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fromip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fromip");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InId);

                entity.Property(e => e.InId)
                    .ValueGeneratedNever()
                    .HasColumnName("InID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CheckDptId).HasColumnName("checkDptID");

                entity.Property(e => e.CheckDptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkDptName");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("checkTime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.InType).HasColumnName("inType");

                entity.Property(e => e.RegTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("regTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<LinShiMobile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LinShi_Mobile");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LinshiBackMobile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Linshi_backMobile");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngAdclass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_ADClass");

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.ClassInfo).HasMaxLength(200);

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<MngPopsite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_Popsite");

                entity.Property(e => e.Domain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyCrmAdPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("my_CRM_AdPlace");

                entity.Property(e => e.AdSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceId).HasColumnName("Place_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Noname1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Noname1");

                entity.Property(e => e.Col001)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<OnDudy2008>(entity =>
            {
                entity.ToTable("OnDudy2008");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DutyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PackArticle>(entity =>
            {
                entity.HasKey(e => e.ArtId);

                entity.ToTable("Pack_article");

                entity.Property(e => e.ArtId)
                    .ValueGeneratedNever()
                    .HasColumnName("artID");

                entity.Property(e => e.Allsum)
                    .HasColumnName("allsum")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ArtName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("artName");

                entity.Property(e => e.BigType).HasColumnName("bigType");

                entity.Property(e => e.Depiction)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("depiction");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Origin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("origin");

                entity.Property(e => e.PackType).HasColumnName("packType");

                entity.Property(e => e.PackTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("packTypeName");

                entity.Property(e => e.Picture)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.Scrap).HasColumnName("scrap");

                entity.Property(e => e.Specification)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("specification");

                entity.Property(e => e.Userof).HasColumnName("userof");
            });

            modelBuilder.Entity<PackDeposiDetail>(entity =>
            {
                entity.HasKey(e => e.DdId);

                entity.ToTable("Pack_DeposiDetail");

                entity.Property(e => e.DdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ddID");

                entity.Property(e => e.ArtId).HasColumnName("artID");

                entity.Property(e => e.ArtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("artName");

                entity.Property(e => e.DepId).HasColumnName("depID");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Pricing).HasColumnType("money");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Specification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("specification");

                entity.Property(e => e.Units)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackDeposit>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.ToTable("Pack_Deposit");

                entity.Property(e => e.DepId)
                    .ValueGeneratedNever()
                    .HasColumnName("depID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Supplier).HasColumnName("supplier");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("supplierName");

                entity.Property(e => e.Vouchers)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vouchers");
            });

            modelBuilder.Entity<PackFurnish>(entity =>
            {
                entity.HasKey(e => e.FurId);

                entity.ToTable("Pack_furnish");

                entity.Property(e => e.FurId)
                    .ValueGeneratedNever()
                    .HasColumnName("furID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BankAccounts)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bankAccounts");

                entity.Property(e => e.BankName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.CityId).HasColumnName("cityID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("clientName");

                entity.Property(e => e.CorpBehalf)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("corpBehalf");

                entity.Property(e => e.Craft).HasColumnName("craft");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Homepage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("homepage");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.MailProduct)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mailProduct");

                entity.Property(e => e.MainLinkMan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mainLinkMan");

                entity.Property(e => e.MainUser)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mainUser");

                entity.Property(e => e.NearTime)
                    .HasColumnType("datetime")
                    .HasColumnName("nearTime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.President)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("president");

                entity.Property(e => e.ProvinceId).HasColumnName("provinceID");

                entity.Property(e => e.RegTime)
                    .HasColumnType("datetime")
                    .HasColumnName("regTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SaleScope)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("saleScope");

                entity.Property(e => e.Staffnumber).HasColumnName("staffnumber");

                entity.Property(e => e.Superior)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("superior");

                entity.Property(e => e.TalkTime)
                    .HasColumnType("datetime")
                    .HasColumnName("talkTime");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taxNumber");

                entity.Property(e => e.Turnover)
                    .HasColumnType("money")
                    .HasColumnName("turnover");
            });

            modelBuilder.Entity<PackLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("Pack_log");

                entity.Property(e => e.LogId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logID");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ipAddress");

                entity.Property(e => e.LogType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("logType");

                entity.Property(e => e.Number)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<PackScrap>(entity =>
            {
                entity.HasKey(e => e.ScrId);

                entity.ToTable("Pack_Scrap");

                entity.Property(e => e.ScrId)
                    .ValueGeneratedNever()
                    .HasColumnName("scrID");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checkTime");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTIme");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.ScrapTime)
                    .HasColumnType("datetime")
                    .HasColumnName("scrapTime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<PackScrapDetail>(entity =>
            {
                entity.HasKey(e => e.UdId);

                entity.ToTable("Pack_ScrapDetail");

                entity.Property(e => e.UdId)
                    .ValueGeneratedNever()
                    .HasColumnName("udID");

                entity.Property(e => e.ArtId).HasColumnName("artID");

                entity.Property(e => e.ArtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("artName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Pricing).HasColumnType("money");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.ScrId).HasColumnName("scrID");

                entity.Property(e => e.Specification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("specification");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Units)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackType>(entity =>
            {
                entity.HasKey(e => e.PtId);

                entity.ToTable("Pack_Type");

                entity.Property(e => e.PtId)
                    .ValueGeneratedNever()
                    .HasColumnName("ptID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.ParentId).HasColumnName("parentID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackUse>(entity =>
            {
                entity.HasKey(e => e.UseId);

                entity.ToTable("Pack_use");

                entity.Property(e => e.UseId)
                    .ValueGeneratedNever()
                    .HasColumnName("useID");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("checkTime");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.OperEplId).HasColumnName("OperEplID");

                entity.Property(e => e.OperEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("operEplName");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UseTime)
                    .HasColumnType("datetime")
                    .HasColumnName("useTime");
            });

            modelBuilder.Entity<PackUseDetail>(entity =>
            {
                entity.HasKey(e => e.UdId);

                entity.ToTable("Pack_useDetail");

                entity.Property(e => e.UdId)
                    .ValueGeneratedNever()
                    .HasColumnName("udID");

                entity.Property(e => e.AlterEplId)
                    .HasColumnName("alterEplID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AlterEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("alterEplName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AlterTime)
                    .HasColumnType("datetime")
                    .HasColumnName("alterTime");

                entity.Property(e => e.ArtId).HasColumnName("artID");

                entity.Property(e => e.ArtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("artName");

                entity.Property(e => e.DepId).HasColumnName("depID");

                entity.Property(e => e.DeposeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("deposeTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.OldUdId)
                    .HasColumnName("oldUdID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Pricing).HasColumnType("money");

                entity.Property(e => e.RecoverTime)
                    .HasColumnType("datetime")
                    .HasColumnName("recoverTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Specification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("specification");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Units)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeiComment>(entity =>
            {
                entity.ToTable("Pei_Comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EplIP");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Regtime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PeiFileList>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_Tra_FileList");

                entity.ToTable("Pei_FileList");

                entity.Property(e => e.FileId)
                    .ValueGeneratedNever()
                    .HasColumnName("FileID")
                    .HasComment("//自动编号");

                entity.Property(e => e.DelFlag).HasComment("是否被删除");

                entity.Property(e => e.EplId)
                    .HasColumnName("Epl_id")
                    .HasComment("是谁发布的内容");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpandType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("文件标题");

                entity.Property(e => e.FileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("//文件编号");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("文件路径");

                entity.Property(e => e.FileType)
                    .HasDefaultValueSql("(1)")
                    .HasComment("文件类型");

                entity.Property(e => e.InNumber).HasComment("点击次数");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("录入时间");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortMemo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("备注");
            });

            modelBuilder.Entity<PeiFileType>(entity =>
            {
                entity.ToTable("Pei_FileType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID")
                    .HasComment("//菜单编号");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("录入时间");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ParentID")
                    .IsFixedLength()
                    .HasComment("父ID,无父ID用0表示");

                entity.Property(e => e.PtypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTypeName")
                    .HasComment("名称");
            });

            modelBuilder.Entity<PhoneCallAccept>(entity =>
            {
                entity.HasKey(e => e.PhoneId);

                entity.ToTable("Phone_Call_accept");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.CallAccept)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("call_accept")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Callnum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("callnum")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phonenum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phonenum")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PhoneCallHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Phone_CallHistory");

                entity.HasIndex(e => e.CallBeginTime, "callbegintime")
                    .IsClustered();

                entity.HasIndex(e => e.CallerNumber, "callnumber");

                entity.Property(e => e.CallBeginTime).HasColumnType("datetime");

                entity.Property(e => e.CallId)
                    .HasMaxLength(50)
                    .HasColumnName("CallID");

                entity.Property(e => e.CallerName).HasMaxLength(50);

                entity.Property(e => e.CallerNumber).HasMaxLength(32);

                entity.Property(e => e.DialKey).HasMaxLength(50);

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.EndTime).HasMaxLength(32);

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.Idvalue).HasColumnName("IDValue");

                entity.Property(e => e.Keyword).HasMaxLength(100);

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.PhoneToName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rid");

                entity.Property(e => e.TalkBeginTime).HasMaxLength(32);

                entity.Property(e => e.TransFrom).HasMaxLength(32);

                entity.Property(e => e.TransTo).HasMaxLength(32);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.VoiceFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhoneGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Phone_Groups");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("rid");
            });

            modelBuilder.Entity<PhoneRecord>(entity =>
            {
                entity.ToTable("Phone_Records");

                entity.HasIndex(e => e.DialKey, "Phone_DialKey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallResult).HasColumnName("callResult");

                entity.Property(e => e.CallType).HasColumnName("callType");

                entity.Property(e => e.CallerNumber)
                    .HasMaxLength(32)
                    .HasColumnName("callerNumber");

                entity.Property(e => e.Callid)
                    .HasMaxLength(50)
                    .HasColumnName("callid");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DialKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dialKey");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .HasColumnName("eplName");

                entity.Property(e => e.IsCommend).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsEval)
                    .HasColumnName("isEval")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.TalkLength).HasColumnName("talkLength");

                entity.Property(e => e.Voicefile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("voicefile");
            });

            modelBuilder.Entity<PhoneRecordsBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("phone_records_bak");

                entity.Property(e => e.CallResult).HasColumnName("callResult");

                entity.Property(e => e.CallType).HasColumnName("callType");

                entity.Property(e => e.CallerNumber)
                    .HasMaxLength(32)
                    .HasColumnName("callerNumber");

                entity.Property(e => e.Callid)
                    .HasMaxLength(50)
                    .HasColumnName("callid");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DialKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dialKey");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .HasColumnName("eplName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEval).HasColumnName("isEval");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.TalkLength).HasColumnName("talkLength");

                entity.Property(e => e.Voicefile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("voicefile");
            });

            modelBuilder.Entity<PhoneTempCompany>(entity =>
            {
                entity.ToTable("Phone_TempCompany");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.IsEdit).HasColumnName("isEdit");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("rInfo");
            });

            modelBuilder.Entity<PhoneUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Phone_Users");

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.UserGroup).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(16)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<PhoneVoiceRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Phone_VoiceRecord");

                entity.Property(e => e.BackupLabel).HasMaxLength(32);

                entity.Property(e => e.BackupTime).HasMaxLength(50);

                entity.Property(e => e.BeginTime).HasMaxLength(32);

                entity.Property(e => e.CallId)
                    .HasMaxLength(32)
                    .HasColumnName("CallID");

                entity.Property(e => e.EndTime).HasMaxLength(32);

                entity.Property(e => e.Filename).HasMaxLength(64);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.StorePath).HasMaxLength(64);

                entity.Property(e => e.VocId)
                    .HasMaxLength(32)
                    .HasColumnName("VocID");
            });

            modelBuilder.Entity<PubInfoSecurity>(entity =>
            {
                entity.ToTable("PUB_InfoSecurity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");
            });

            modelBuilder.Entity<PubInfoType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("PUB_InfoType");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Type_ID");

                entity.Property(e => e.AreaRemark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubInformation>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.ToTable("PUB_Information");

                entity.HasIndex(e => e.TypeId, "IX_InfoType");

                entity.HasIndex(e => e.PublishDate, "IX_PublishDate");

                entity.Property(e => e.InfoId)
                    .ValueGeneratedNever()
                    .HasColumnName("Info_ID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Heading).HasMaxLength(100);

                entity.Property(e => e.IssuedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PubInformations)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PUB_Information_PUB_InfoType");
            });

            modelBuilder.Entity<PubJobMemo>(entity =>
            {
                entity.ToTable("Pub_JobMemo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeginTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('09:00')");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('18:00')");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemoDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubJobMemoType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_JobMemoType");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PubMind>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_mind");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RepeatContent).HasColumnType("text");

                entity.Property(e => e.RepeatEplId).HasColumnName("RepeatEplID");

                entity.Property(e => e.RepeatEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ReportsCompanyHistoryRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reports_CompanyHistoryRank");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpt_name");

                entity.Property(e => e.EplId).HasColumnName("epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Receivemoney).HasColumnName("receivemoney");
            });

            modelBuilder.Entity<Signin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("signin");

                entity.Property(e => e.Aa).HasColumnName("aa");

                entity.Property(e => e.AfInt).HasColumnName("afInt");

                entity.Property(e => e.Afternoonbz).HasColumnName("afternoonbz");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime");

                entity.Property(e => e.Av).HasColumnName("av");

                entity.Property(e => e.FromIp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FromIP");

                entity.Property(e => e.FromIpLast)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FromIP_last");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mm).HasColumnName("mm");

                entity.Property(e => e.MoInt).HasColumnName("moInt");

                entity.Property(e => e.Morningbz).HasColumnName("morningbz");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("morningtime");

                entity.Property(e => e.Mv).HasColumnName("mv");

                entity.Property(e => e.UId).HasColumnName("uID");
            });

            modelBuilder.Entity<SysAbnegate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Abnegate");

                entity.Property(e => e.Alias)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AngId).HasColumnName("Ang_ID");

                entity.Property(e => e.AngName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Ang_Name");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysAnnualbonu>(entity =>
            {
                entity.HasKey(e => e.AnnualId);

                entity.ToTable("Sys_Annualbonus");

                entity.Property(e => e.AnnualId).HasColumnName("AnnualID");

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.EplId).HasColumnName("EplID");
            });

            modelBuilder.Entity<SysCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_City");

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<SysCompanyState>(entity =>
            {
                entity.HasKey(e => e.CsId);

                entity.ToTable("SYS_CompanyState");

                entity.Property(e => e.CsId)
                    .ValueGeneratedNever()
                    .HasColumnName("CS_ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysCompanyState1>(entity =>
            {
                entity.ToTable("SYS_CompanyState1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CsId).HasColumnName("CS_id");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Registerdate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysDay>(entity =>
            {
                entity.HasKey(e => e.DValue);

                entity.ToTable("SYS_Day");

                entity.Property(e => e.DValue)
                    .ValueGeneratedNever()
                    .HasColumnName("dValue");
            });

            modelBuilder.Entity<SysDegree>(entity =>
            {
                entity.ToTable("SYS_Degree");

                entity.HasIndex(e => e.DgrId, "ix_SYS_Degree.Dgr_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DgrId).HasColumnName("Dgr_ID");

                entity.Property(e => e.DgrName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dgr_Name");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysDepartment>(entity =>
            {
                entity.HasKey(e => e.DptId);

                entity.ToTable("SYS_Department");

                entity.HasIndex(e => e.TypeId, "ix_SYS_Department.Type_ID");

                entity.Property(e => e.DptId)
                    .ValueGeneratedNever()
                    .HasColumnName("DPT_ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.GiveupId)
                    .HasColumnName("giveupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");
            });

            modelBuilder.Entity<SysDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Duty");

                entity.Property(e => e.Alias)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DyId).HasColumnName("DY_ID");

                entity.Property(e => e.DyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DY_Name");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysEducation>(entity =>
            {
                entity.HasKey(e => e.EduId);

                entity.ToTable("SYS_Education");

                entity.Property(e => e.EduId)
                    .ValueGeneratedNever()
                    .HasColumnName("Edu_ID");

                entity.Property(e => e.Education)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysEmpRight>(entity =>
            {
                entity.ToTable("SYS_EmpRights");

                entity.HasIndex(e => e.EplId, "IX_SYS_EmpRights_Eplid");

                entity.HasIndex(e => e.MnuId, "IX_SYS_EmpRights_MunID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.MnuId).HasColumnName("Mnu_ID");
            });

            modelBuilder.Entity<SysEmpState>(entity =>
            {
                entity.ToTable("SYS_EmpState");

                entity.HasIndex(e => e.EsId, "IX_SYS_EmpState_ESID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.EsName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ES_Name");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysEmpTeamRight>(entity =>
            {
                entity.ToTable("SYS_EmpTeamRights");

                entity.HasIndex(e => e.EplId, "IX_SYS_EmpTeamRights_Eplid");

                entity.HasIndex(e => e.TeamId, "IX_SYS_EmpTeamRights_teamid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.TeamId).HasColumnName("Team_ID");
            });

            modelBuilder.Entity<SysGoodjobLoginLog>(entity =>
            {
                entity.HasKey(e => e.GllId);

                entity.ToTable("sys_goodjobLoginLogs");

                entity.Property(e => e.GllId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gllID");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.IntTime)
                    .HasColumnType("datetime")
                    .HasColumnName("intTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoginEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginEplName");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginIP");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loginTime");

                entity.Property(e => e.Randomchar)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("randomchar");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<SysGotoworktime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_gotoworktime");

                entity.Property(e => e.AfterRecess).HasColumnName("afterRecess");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime");

                entity.Property(e => e.MorningRecess).HasColumnName("morningRecess");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("morningtime");

                entity.Property(e => e.Worktime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("worktime");
            });

            modelBuilder.Entity<SysIdCenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_IdCenter");

                entity.Property(e => e.IdValue).HasColumnName("idValue");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysKfTj>(entity =>
            {
                entity.ToTable("Sys_KfTj");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.EplId).HasColumnName("eplID");
            });

            modelBuilder.Entity<SysKfTjf>(entity =>
            {
                entity.ToTable("Sys_KfTjfs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.EplId).HasColumnName("eplID");
            });

            modelBuilder.Entity<SysMarry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Marry");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.MarryName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Marry_Name")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.HasKey(e => e.MnuId);

                entity.ToTable("SYS_Menu");

                entity.HasIndex(e => e.MnuType, "ix_SYS_Menu.Mnu_Type");

                entity.HasIndex(e => e.RegisterDate, "ix_SYS_Menu.RegisterDate");

                entity.HasIndex(e => e.Sequence, "ix_SYS_Menu.Sequence");

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

                entity.Property(e => e.MnuType)
                    .HasColumnName("Mnu_Type")
                    .HasComment("外网简历管理：1表示页面，2表示按钮");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TouchImagePath)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TouchWebPath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SysMenuInRole>(entity =>
            {
                entity.ToTable("SYS_MenuInRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SysMenuInRoleOuterResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_MenuInRole_OuterResume");

                entity.HasComment("外网简历管理角色权限表");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<SysMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_Month");

                entity.Property(e => e.Mvalue).HasColumnName("MValue");
            });

            modelBuilder.Entity<SysNation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Nation");

                entity.Property(e => e.民族名称).HasMaxLength(10);
            });

            modelBuilder.Entity<SysNotice>(entity =>
            {
                entity.HasKey(e => e.NotId);

                entity.ToTable("Sys_Notice");

                entity.Property(e => e.NotId)
                    .ValueGeneratedNever()
                    .HasColumnName("NotID");

                entity.Property(e => e.NoticeName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysOuterResumeLoginLog>(entity =>
            {
                entity.HasKey(e => e.GllId)
                    .HasName("PK_sys_OuterResumeLogs");

                entity.ToTable("sys_OuterResumeLoginLogs");

                entity.Property(e => e.GllId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gllID");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.IntTime)
                    .HasColumnType("datetime")
                    .HasColumnName("intTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoginEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginEplName");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginIP");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loginTime");

                entity.Property(e => e.Randomchar)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("randomchar");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<SysPageTemplate>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("sys_pageTemplate");

                entity.Property(e => e.PageId)
                    .ValueGeneratedNever()
                    .HasColumnName("pageID");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.LeftInfo)
                    .HasColumnType("ntext")
                    .HasColumnName("leftInfo");

                entity.Property(e => e.MenuId).HasColumnName("menuID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("modelName");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RightInfo)
                    .HasColumnType("ntext")
                    .HasColumnName("rightInfo");

                entity.Property(e => e.TemplateInfo)
                    .HasColumnType("ntext")
                    .HasColumnName("templateInfo");
            });

            modelBuilder.Entity<SysPageTemplateItem>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("sys_pageTemplateItem");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Checked).HasColumnName("checked");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.MenuId).HasColumnName("menuID");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<SysPersonArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_personArea");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.ParentId).HasColumnName("parentID");

                entity.Property(e => e.SubId).HasColumnName("subID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<SysPlanTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_PlanTime");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SysPosition>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK_SYS_Position_1");

                entity.ToTable("SYS_Position");

                entity.Property(e => e.PosId)
                    .ValueGeneratedNever()
                    .HasColumnName("POS_ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DutyName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dutyName");

                entity.Property(e => e.DyId).HasColumnName("DY_ID");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_Name");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");
            });

            modelBuilder.Entity<SysProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Province");

                entity.Property(e => e.Pname).HasMaxLength(10);
            });

            modelBuilder.Entity<SysRemind>(entity =>
            {
                entity.ToTable("Sys_Remind");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDValue");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.WakeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("SYS_Role");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysRoleOuterResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Role_OuterResume");

                entity.HasComment("外网简历管理系统角色表");

                entity.Property(e => e.RoleId).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleMemo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysSection>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("SYS_Section");

                entity.Property(e => e.SectionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SectionID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<SysSectionInRole>(entity =>
            {
                entity.ToTable("SYS_SectionInRole");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<SysServiceOnduty>(entity =>
            {
                entity.HasKey(e => e.SoId);

                entity.ToTable("sys_serviceOnduty");

                entity.Property(e => e.SoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soID");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.DutyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dutyDate");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<SysSex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_Sex");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.SexName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Sex_Name")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysTeam>(entity =>
            {
                entity.ToTable("SYS_Team");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TeamMemo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysTeamRight>(entity =>
            {
                entity.ToTable("SYS_TeamRights");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MnuId).HasColumnName("Mnu_ID");

                entity.Property(e => e.TeamId).HasColumnName("Team_ID");
            });

            modelBuilder.Entity<SysTemplateItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_templateItem");

                entity.Property(e => e.ControlUrl)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("controlUrl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Label)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("label");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SysTown>(entity =>
            {
                entity.ToTable("SYS_Town");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.IsShow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");
            });

            modelBuilder.Entity<SysType>(entity =>
            {
                entity.ToTable("SYS_Type");

                entity.HasIndex(e => e.TypeId, "ix_SYS_Type.Type_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Type_Name");
            });

            modelBuilder.Entity<SysUserInRole>(entity =>
            {
                entity.ToTable("SYS_UserInRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SysUserInRoleOuterResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_UserInRole_OuterResume");

                entity.HasComment("外网简历管理系统角色赋权表");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SysWebsiteFinProperty>(entity =>
            {
                entity.ToTable("Sys_WebsiteFinProperty");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskGroup>(entity =>
            {
                entity.ToTable("task_groups");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BuildTime)
                    .HasColumnType("datetime")
                    .HasColumnName("buildTime");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<TaskList>(entity =>
            {
                entity.ToTable("task_lists");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("content");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplIname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplIName");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("groupName");

                entity.Property(e => e.Import).HasColumnName("import");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.InputType).HasColumnName("inputType");

                entity.Property(e => e.Jobs)
                    .HasColumnType("ntext")
                    .HasColumnName("jobs");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TaskMember>(entity =>
            {
                entity.ToTable("task_member");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<TaskProcess>(entity =>
            {
                entity.ToTable("task_process");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.FollowTime)
                    .HasColumnType("datetime")
                    .HasColumnName("followTime");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("groupName");

                entity.Property(e => e.Remark)
                    .HasColumnType("ntext")
                    .HasColumnName("remark");

                entity.Property(e => e.TaskId).HasColumnName("taskID");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TemCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temCompany");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<TempGotowork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_gotowork");

                entity.Property(e => e.B1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("b1");

                entity.Property(e => e.B2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("b2");

                entity.Property(e => e.C1).HasColumnName("c1");

                entity.Property(e => e.C2).HasColumnName("c2");

                entity.Property(e => e.Cday).HasColumnName("cday");

                entity.Property(e => e.Ch1).HasColumnName("ch1");

                entity.Property(e => e.Ch2).HasColumnName("ch2");

                entity.Property(e => e.Cmonth).HasColumnName("cmonth");

                entity.Property(e => e.Cyear).HasColumnName("cyear");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .HasColumnName("eplName");

                entity.Property(e => e.Eplid).HasColumnName("eplid");

                entity.Property(e => e.EsId).HasColumnName("esID");

                entity.Property(e => e.H1).HasColumnName("h1");

                entity.Property(e => e.J1).HasColumnName("j1");

                entity.Property(e => e.J2).HasColumnName("j2");

                entity.Property(e => e.J3).HasColumnName("j3");

                entity.Property(e => e.J4).HasColumnName("j4");

                entity.Property(e => e.Jc).HasColumnName("jc");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.Mj1).HasColumnName("mj1");

                entity.Property(e => e.Mj2).HasColumnName("mj2");

                entity.Property(e => e.R1).HasColumnName("r1");

                entity.Property(e => e.R2).HasColumnName("r2");

                entity.Property(e => e.T1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t1");

                entity.Property(e => e.T2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t2");

                entity.Property(e => e.Work1).HasColumnName("work1");

                entity.Property(e => e.Work2).HasColumnName("work2");

                entity.Property(e => e.Workc).HasColumnName("workc");
            });

            modelBuilder.Entity<TouchMenu>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("Touch_Menu");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("EPL_ID");

                entity.Property(e => e.ChooseMenu)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TraRequirement>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("Tra_Requirement");

                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("courseId")
                    .HasComment("编号");

                entity.Property(e => e.ArrangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("arrangeTime")
                    .HasComment("录入时间");

                entity.Property(e => e.Calltime)
                    .HasColumnType("datetime")
                    .HasColumnName("calltime")
                    .HasComment("需培训时间");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(50)
                    .HasColumnName("checkEplName")
                    .HasComment("审核人姓名");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark")
                    .HasComment("审核备注");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checkTime")
                    .HasComment("审核时间");

                entity.Property(e => e.CheckeplId)
                    .HasColumnName("checkeplID")
                    .HasComment("审核人");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("courseName")
                    .HasComment("需求课程名称");

                entity.Property(e => e.CourseNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("courseNumber")
                    .HasComment("需求编号");

                entity.Property(e => e.DptId)
                    .HasColumnName("dptId")
                    .HasComment("所在部门");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .HasColumnName("dptName")
                    .HasComment("部门名称");

                entity.Property(e => e.EplId)
                    .HasColumnName("eplID")
                    .HasComment("所属人");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName")
                    .HasComment("所属姓名");

                entity.Property(e => e.FundingRequirement)
                    .HasColumnType("money")
                    .HasColumnName("fundingRequirement")
                    .HasComment("师资要求");

                entity.Property(e => e.RecommendAgency)
                    .HasMaxLength(520)
                    .IsUnicode(false)
                    .HasColumnName("recommendAgency")
                    .HasComment("培训机构推荐");

                entity.Property(e => e.ResultText)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("resultText")
                    .HasComment("效果考核");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.TrainBudget)
                    .HasColumnType("money")
                    .HasColumnName("trainBudget")
                    .HasComment("培训预算");

                entity.Property(e => e.TrainObjective)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("trainObjective")
                    .HasComment("培训目的");

                entity.Property(e => e.TraineText)
                    .HasMaxLength(2000)
                    .HasColumnName("traineText")
                    .HasComment("培训内容");

                entity.Property(e => e.TrainedForm)
                    .HasMaxLength(520)
                    .IsUnicode(false)
                    .HasColumnName("trainedForm")
                    .HasComment("培训形式");

                entity.Property(e => e.TrainedObject)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("trainedObject")
                    .HasComment("培训对象");
            });

            modelBuilder.Entity<Userbak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userbak");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bqq)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.DgrId).HasColumnName("DGR_ID");

                entity.Property(e => e.Diploma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.Headship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ID_Card");

                entity.Property(e => e.Interest).HasColumnType("text");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveDate).HasColumnType("datetime");

                entity.Property(e => e.LimitIp).HasColumnName("LimitIP");

                entity.Property(e => e.LnkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LnkTel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

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
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosiDate).HasColumnType("datetime");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tongue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewAbnegateTemporarySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Abnegate_TemporarySummary");

                entity.Property(e => e.Cmonth).HasColumnName("cmonth");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.Cyear).HasColumnName("cyear");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewAd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_AD");

                entity.Property(e => e.AdId).HasColumnName("Ad_ID");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.Bondno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.DeleteMemo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EndlineDate).HasColumnType("datetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.OnlineDate).HasColumnType("datetime");

                entity.Property(e => e.OnlineMemo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewAdNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_AD_New");

                entity.Property(e => e.AdId).HasColumnName("Ad_ID");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.Bondno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.DeleteMemo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EndlineDate).HasColumnType("datetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.OnlineDate).HasColumnType("datetime");

                entity.Property(e => e.OnlineMemo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewAddLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Add_log");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewAllCrmAbnegateTemporarySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AllCRM_Abnegate_TemporarySummary");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewApplPpoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ApplPpoints");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.ZphPoints).HasColumnName("zphPoints");
            });

            modelBuilder.Entity<ViewClientCollaborative>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_client_collaborative");

                entity.Property(e => e.CollEplid).HasColumnName("collEplid");

                entity.Property(e => e.CollEplname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("collEplname");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Importance).HasColumnName("importance");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ViewClientRecommend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_client_recommend");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EntTime)
                    .HasColumnType("datetime")
                    .HasColumnName("entTime");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.RecId).HasColumnName("recID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ViewClientRepeat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_client_repeat");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Intime)
                    .HasColumnType("datetime")
                    .HasColumnName("intime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.RepeatId).HasColumnName("repeatID");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ViewClientTrackingCurve>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_client_trackingCurve");

                entity.Property(e => e.CurId).HasColumnName("curID");

                entity.Property(e => e.CurveInfo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("curveInfo");

                entity.Property(e => e.CurveName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("curveName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Layer).HasColumnName("layer");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<ViewCrmAbnegateLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Abnegate_Log");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AngDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Ang_Date");

                entity.Property(e => e.AngId).HasColumnName("Ang_ID");

                entity.Property(e => e.AngName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Ang_Name");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");
            });

            modelBuilder.Entity<ViewCrmAbnegateTemporary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_Abnegate_Temporary");

                entity.Property(e => e.AngDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ang_Date");

                entity.Property(e => e.AngTypeCsId).HasColumnName("AngTypeCsID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");
            });

            modelBuilder.Entity<ViewCrmAbnegateTemporarySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_Abnegate_TemporarySummary");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmAd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_AD");

                entity.Property(e => e.AdId).HasColumnName("Ad_ID");

                entity.Property(e => e.AlterDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyWhy).HasMaxLength(1000);

                entity.Property(e => e.Bondno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescribe).HasMaxLength(2000);

                entity.Property(e => e.DownLineDate).HasColumnType("datetime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.OnlineDate).HasColumnType("datetime");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UnPassWhy).HasMaxLength(1000);

                entity.Property(e => e.UpLineDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewCrmAicallRecordForUh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_AICallRecordForUH");

                entity.Property(e => e.CallBackDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocaId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LocaID");

                entity.Property(e => e.RequestDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RequestPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TalkText).HasColumnType("ntext");
            });

            modelBuilder.Entity<ViewCrmBondManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_BondManager");

                entity.Property(e => e.AdBegin).HasColumnType("smalldatetime");

                entity.Property(e => e.AdEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.AdInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("adInfo");

                entity.Property(e => e.AdRecordId).HasColumnName("AdRecordID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bdmoney)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("BDMoney");

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bondno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bondno");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CStime");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.IsAdValue)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("isAdValue");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SmsAmount).HasColumnType("money");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WordFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmCallAwoke>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_CallAwoke");

                entity.Property(e => e.Awokedate)
                    .HasColumnType("datetime")
                    .HasColumnName("awokedate");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplId1).HasColumnName("epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Finishflag).HasColumnName("finishflag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDValue");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.WakeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewCrmCessionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Cession_log");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdminEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("admin_eplName");

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminIP");

                entity.Property(e => e.AdminUid).HasColumnName("adminUid");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CessionReason).HasColumnType("text");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Expr1).HasColumnType("datetime");

                entity.Property(e => e.FCsId).HasColumnName("F_CS_ID");

                entity.Property(e => e.FCsName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("F_CsName");

                entity.Property(e => e.FEplId).HasColumnName("F_EPL_ID");

                entity.Property(e => e.FEplname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("F_Eplname");

                entity.Property(e => e.FUserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("F_userName");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InceptDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inceptDate");

                entity.Property(e => e.InceptReason)
                    .HasColumnType("text")
                    .HasColumnName("inceptReason");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.StatusValue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("statusValue");

                entity.Property(e => e.TCsId).HasColumnName("T_CS_ID");

                entity.Property(e => e.TEplId).HasColumnName("T_EPL_ID");

                entity.Property(e => e.TEplname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("T_Eplname");
            });

            modelBuilder.Entity<ViewCrmClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Clients");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Cityname)
                    .HasMaxLength(10)
                    .HasColumnName("cityname");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRegtime");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Cstime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CStime");

                entity.Property(e => e.Ctel)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("ctel");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.Expr2).HasColumnType("datetime");

                entity.Property(e => e.Expr3).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr4).HasColumnType("datetime");

                entity.Property(e => e.Expr5).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr6).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr7).HasColumnType("datetime");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.NewsCsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NewsCS_Name");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Pname)
                    .HasMaxLength(10)
                    .HasColumnName("pname");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.TraInfo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Tra_Info");

                entity.Property(e => e.TraInputDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_InputDate");

                entity.Property(e => e.TraReceiveDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_ReceiveDate");

                entity.Property(e => e.TraReceiveEplId).HasColumnName("Tra_ReceiveEpl_id");

                entity.Property(e => e.TraReceiveFlag).HasColumnName("Tra_ReceiveFlag");

                entity.Property(e => e.TraReceiveMoney)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Tra_ReceiveMoney");

                entity.Property(e => e.TraTradeDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_TradeDate");

                entity.Property(e => e.TraTradeEplId).HasColumnName("Tra_TradeEpl_id");

                entity.Property(e => e.TraTradeMoney)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Tra_TradeMoney");
            });

            modelBuilder.Entity<ViewCrmClientsBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Clients_back");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Cityname)
                    .HasMaxLength(10)
                    .HasColumnName("cityname");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRegtime");

                entity.Property(e => e.Cs80State).HasColumnName("cs80_state");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Cstime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CStime");

                entity.Property(e => e.Ctel)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("ctel");

                entity.Property(e => e.DepartmentTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("departmentTime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.Expr2).HasColumnType("datetime");

                entity.Property(e => e.Expr3).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr4).HasColumnType("datetime");

                entity.Property(e => e.Expr5).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr6).HasColumnType("smalldatetime");

                entity.Property(e => e.Expr7).HasColumnType("datetime");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Pname)
                    .HasMaxLength(10)
                    .HasColumnName("pname");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.TraInfo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Tra_Info");

                entity.Property(e => e.TraInputDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_InputDate");

                entity.Property(e => e.TraReceiveDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_ReceiveDate");

                entity.Property(e => e.TraReceiveEplId).HasColumnName("Tra_ReceiveEpl_id");

                entity.Property(e => e.TraReceiveFlag).HasColumnName("Tra_ReceiveFlag");

                entity.Property(e => e.TraReceiveMoney)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Tra_ReceiveMoney");

                entity.Property(e => e.TraTradeDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Tra_TradeDate");

                entity.Property(e => e.TraTradeEplId).HasColumnName("Tra_TradeEpl_id");

                entity.Property(e => e.TraTradeMoney)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Tra_TradeMoney");
            });

            modelBuilder.Entity<ViewCrmComOpen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_ComOpen");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bondid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("Mem_ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenEplId).HasColumnName("OpenEpl_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.ReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TypeName).HasMaxLength(16);
            });

            modelBuilder.Entity<ViewCrmComSelf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_ComSelf");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Comid1).HasColumnName("COMID");

                entity.Property(e => e.DemoText).HasColumnType("ntext");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemId1).HasColumnName("MEM_ID");

                entity.Property(e => e.Memid).HasColumnName("MEMID");

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");
            });

            modelBuilder.Entity<ViewCrmComSn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_ComSns");

                entity.Property(e => e.ApplyTypeId).HasColumnName("ApplyTypeID");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEplID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComId1).HasColumnName("ComID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEplID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenEplId).HasColumnName("OpenEplID");

                entity.Property(e => e.TradeMoney).HasColumnType("money");
            });

            modelBuilder.Entity<ViewCrmCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_Company");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.CessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cessionDate");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.CollId).HasColumnName("collID");

                entity.Property(e => e.CollState).HasColumnName("collState");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.CurrentValue).HasColumnName("currentValue");

                entity.Property(e => e.CurveId).HasColumnName("curveID");

                entity.Property(e => e.CurveSequence).HasColumnName("curveSequence");

                entity.Property(e => e.CurveStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("curveStartTime");

                entity.Property(e => e.CurveValue).HasColumnName("curveValue");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IsLastCurve).HasColumnName("isLastCurve");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Pname).HasMaxLength(10);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.WakeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("wakeTime");
            });

            modelBuilder.Entity<ViewCrmContactApply>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_ContactApply");

                entity.Property(e => e.ApplicantDptId).HasColumnName("ApplicantDptID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ApplicantName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.ComplatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WxId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("WxID");
            });

            modelBuilder.Entity<ViewCrmExpirationDisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_ExpirationDisplay");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GetEplId).HasColumnName("GetEplID");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastTradeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmFreeOpen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Crm_FreeOpen");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");
            });

            modelBuilder.Entity<ViewCrmHomePage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_HomePage");

                entity.Property(e => e.AdTypeId).HasColumnName("AdTypeID");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.DemoText).HasColumnType("ntext");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OnlineDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewCrmJobMemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_JobMemo");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.BeginTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FinishText)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("finishText");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.MemoDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pname).HasMaxLength(10);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmKhzk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_khzk");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CrmCompanyEplId).HasColumnName("CRM_Company_EplID");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.EndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Khzeplname)
                    .HasMaxLength(50)
                    .HasColumnName("khzeplname");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.LiyouText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.ShenheDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Yyhzreplname)
                    .HasMaxLength(50)
                    .HasColumnName("yyhzreplname");
            });

            modelBuilder.Entity<ViewCrmKhzklist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_khzklist");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CollEplId).HasColumnName("collEplID");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Khzeplname)
                    .HasMaxLength(50)
                    .HasColumnName("khzeplname");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");
            });

            modelBuilder.Entity<ViewCrmLinkman>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Linkman");

                entity.Property(e => e.Cfax)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("cfax");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Ctel)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("ctel");

                entity.Property(e => e.DeleteInfo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.HrQq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HrQQ");

                entity.Property(e => e.LnkId).HasColumnName("Lnk_ID");

                entity.Property(e => e.LnkName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Lnk_Name");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SexText)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sexText");
            });

            modelBuilder.Entity<ViewCrmModifyNameApply>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_ModifyNameApply");

                entity.Property(e => e.AEplId).HasColumnName("A_Epl_ID");

                entity.Property(e => e.AEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Epl_Name");

                entity.Property(e => e.ApplyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.Crmmodify).HasColumnName("crmmodify");

                entity.Property(e => e.EEplId).HasColumnName("E_Epl_ID");

                entity.Property(e => e.EEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Epl_Name");

                entity.Property(e => e.ExamDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExamStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("examStatus");

                entity.Property(e => e.FComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("F_COM_Name");

                entity.Property(e => e.FFax)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("F_Fax");

                entity.Property(e => e.FPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("F_Phone");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_Z");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MEplId).HasColumnName("M_Epl_ID");

                entity.Property(e => e.MEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_Epl_Name");

                entity.Property(e => e.ModdifyStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("moddifyStatus");

                entity.Property(e => e.ModifyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("registerDate");

                entity.Property(e => e.TComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("T_COM_Name");

                entity.Property(e => e.Webmodify).HasColumnName("webmodify");
            });

            modelBuilder.Entity<ViewCrmNewsAd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_NewsAd");

                entity.Property(e => e.ApplyTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.NewsAdId).HasColumnName("NewsAdID");

                entity.Property(e => e.OrderById).HasColumnName("OrderByID");

                entity.Property(e => e.StandId).HasColumnName("StandID");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmOuter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Outer");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.LastLinkEplId).HasColumnName("LastLinkEplID");

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmOuterTemporary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_Outer_Temporary");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FromSite)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLinkEplId).HasColumnName("LastLinkEplID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.NewestPosName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OuterRefleshDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OuterSiteUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pname).HasMaxLength(10);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.TownId).HasColumnName("Town_ID");

                entity.Property(e => e.TownName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Records");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Bgcolor)
                    .HasMaxLength(50)
                    .HasColumnName("bgcolor");

                entity.Property(e => e.CId).HasColumnName("cId");

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RContent)
                    .HasColumnType("ntext")
                    .HasColumnName("rContent");

                entity.Property(e => e.RDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rDate");

                entity.Property(e => e.RId).HasColumnName("rId");

                entity.Property(e => e.RType).HasColumnName("rType");

                entity.Property(e => e.RecordsType).HasMaxLength(16);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmRemind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Remind");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.CollEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("collEplName");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.ComId1).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Sday).HasColumnName("SDay");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Vdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VDate");
            });

            modelBuilder.Entity<ViewCrmStand>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CRM_Stand");

                entity.Property(e => e.AtTheTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEplID");

                entity.Property(e => e.Matters)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NumberCount)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.One).HasColumnName("one");

                entity.Property(e => e.StandId).HasColumnName("StandID");

                entity.Property(e => e.StandTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCrmTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_CRM_Transactions");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bondid)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CEtime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEpl_ID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CStime");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Info)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InputEplId).HasColumnName("InputEpl_ID");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("Mem_ID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenEplId).HasColumnName("OpenEpl_ID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.ReceiveMoney).HasColumnType("money");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TradeMoney).HasColumnType("money");
            });

            modelBuilder.Entity<ViewDataDptMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Data_DptMoney");

                entity.Property(e => e.DptId).HasColumnName("Dpt_id");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Syear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDataEplMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Data_EplMoney");

                entity.Property(e => e.DptId).HasColumnName("Dpt_id");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Money1).HasColumnName("money1");

                entity.Property(e => e.Money10).HasColumnName("money10");

                entity.Property(e => e.Money11).HasColumnName("money11");

                entity.Property(e => e.Money12).HasColumnName("money12");

                entity.Property(e => e.Money2).HasColumnName("money2");

                entity.Property(e => e.Money3).HasColumnName("money3");

                entity.Property(e => e.Money4).HasColumnName("money4");

                entity.Property(e => e.Money5).HasColumnName("money5");

                entity.Property(e => e.Money6).HasColumnName("money6");

                entity.Property(e => e.Money7).HasColumnName("money7");

                entity.Property(e => e.Money8).HasColumnName("money8");

                entity.Property(e => e.Money9).HasColumnName("money9");

                entity.Property(e => e.Moneycount).HasColumnName("moneycount");

                entity.Property(e => e.Posidate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("posidate");

                entity.Property(e => e.Syear)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDayinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_dayinfo");

                entity.Property(e => e.Allsum).HasColumnName("allsum");

                entity.Property(e => e.Cmonth).HasColumnName("cmonth");

                entity.Property(e => e.Cyear).HasColumnName("cyear");

                entity.Property(e => e.Day1).HasColumnName("day1");

                entity.Property(e => e.Day10).HasColumnName("day10");

                entity.Property(e => e.Day11).HasColumnName("day11");

                entity.Property(e => e.Day12).HasColumnName("day12");

                entity.Property(e => e.Day13).HasColumnName("day13");

                entity.Property(e => e.Day14).HasColumnName("day14");

                entity.Property(e => e.Day15).HasColumnName("day15");

                entity.Property(e => e.Day16).HasColumnName("day16");

                entity.Property(e => e.Day17).HasColumnName("day17");

                entity.Property(e => e.Day18).HasColumnName("day18");

                entity.Property(e => e.Day19).HasColumnName("day19");

                entity.Property(e => e.Day2).HasColumnName("day2");

                entity.Property(e => e.Day20).HasColumnName("day20");

                entity.Property(e => e.Day21).HasColumnName("day21");

                entity.Property(e => e.Day22).HasColumnName("day22");

                entity.Property(e => e.Day23).HasColumnName("day23");

                entity.Property(e => e.Day24).HasColumnName("day24");

                entity.Property(e => e.Day25).HasColumnName("day25");

                entity.Property(e => e.Day26).HasColumnName("day26");

                entity.Property(e => e.Day27).HasColumnName("day27");

                entity.Property(e => e.Day28).HasColumnName("day28");

                entity.Property(e => e.Day29).HasColumnName("day29");

                entity.Property(e => e.Day3).HasColumnName("day3");

                entity.Property(e => e.Day30).HasColumnName("day30");

                entity.Property(e => e.Day31).HasColumnName("day31");

                entity.Property(e => e.Day4).HasColumnName("day4");

                entity.Property(e => e.Day5).HasColumnName("day5");

                entity.Property(e => e.Day6).HasColumnName("day6");

                entity.Property(e => e.Day7).HasColumnName("day7");

                entity.Property(e => e.Day8).HasColumnName("day8");

                entity.Property(e => e.Day9).HasColumnName("day9");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Picture)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ViewDevClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_DEV_Client");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientInfo).HasColumnType("ntext");

                entity.Property(e => e.ClientName).HasMaxLength(50);

                entity.Property(e => e.ClientTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.GiveupDate).HasColumnType("datetime");

                entity.Property(e => e.LastTrackDate).HasColumnType("datetime");

                entity.Property(e => e.LastTrackId).HasColumnName("LastTrackID");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Msn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MSN");

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceName).HasMaxLength(10);

                entity.Property(e => e.Qq)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("QQ");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransferLog)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.WebDomain).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewDevFirstClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_DEV_FirstClient");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientInfo).HasColumnType("ntext");

                entity.Property(e => e.ClientName).HasMaxLength(50);

                entity.Property(e => e.ClientTypeId).HasColumnName("ClientTypeID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.GiveupDate).HasColumnType("datetime");

                entity.Property(e => e.LastTrackDate).HasColumnType("datetime");

                entity.Property(e => e.LastTrackId).HasColumnName("LastTrackID");

                entity.Property(e => e.Linkman).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Msn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MSN");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneArea).HasMaxLength(50);

                entity.Property(e => e.PhoneExt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneUser).HasMaxLength(50);

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Qq)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("QQ");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransferLog)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.WebDomain).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewDevTrackRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_DEV_TrackRecord");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.TrackDate).HasColumnType("datetime");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.Property(e => e.TrackTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrackerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDevTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_DEV_Transfer");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendWhy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewErmAdminBranchList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERM_AdminBranchList");

                entity.Property(e => e.DptId).HasColumnName("dpt_id");

                entity.Property(e => e.DptView)
                    .HasMaxLength(74)
                    .IsUnicode(false)
                    .HasColumnName("dptView");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ManaBranch)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("manaBranch");

                entity.Property(e => e.Regtime)
                    .HasColumnType("datetime")
                    .HasColumnName("regtime");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ViewErmAttend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERM_attend");

                entity.Property(e => e.Afternoonbz)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("afternoonbz");

                entity.Property(e => e.Afternooncount).HasColumnName("afternooncount");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime");

                entity.Property(e => e.Attenddate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("attenddate");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Morningbz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("morningbz");

                entity.Property(e => e.Morningcount).HasColumnName("morningcount");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("morningtime");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<ViewErmEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERM_Employee");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bqq)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.DgrId).HasColumnName("DGR_ID");

                entity.Property(e => e.Diploma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.Education)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("education");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.EsName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ES_Name");

                entity.Property(e => e.Headship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ID_Card");

                entity.Property(e => e.Interest).HasColumnType("text");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LimitIp).HasColumnName("LimitIP");

                entity.Property(e => e.LnkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LnkTel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marry)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

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
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosiDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId)
                    .HasMaxLength(10)
                    .HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tongue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewErmHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERM_holiday");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Checkmemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Checksate).HasColumnName("checksate");

                entity.Property(e => e.DptId).HasColumnName("dpt_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FromTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Hname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsPass)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Myname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("myname");

                entity.Property(e => e.PassMan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PosiName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("posiName");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<ViewErmSignin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ERM_signin");

                entity.Property(e => e.Afternoon).HasColumnName("afternoon");

                entity.Property(e => e.Afternoonbz).HasColumnName("afternoonbz");

                entity.Property(e => e.AfternoonbzFlag)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("afternoonbzFlag");

                entity.Property(e => e.Afternoontime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("afternoontime");

                entity.Property(e => e.DptId).HasColumnName("dpt_id");

                entity.Property(e => e.EplId).HasColumnName("epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("epl_name");

                entity.Property(e => e.Fromip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("fromip");

                entity.Property(e => e.FromipLast)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("fromip_last");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("insertdate");

                entity.Property(e => e.Moring).HasColumnName("moring");

                entity.Property(e => e.Morningbz).HasColumnName("morningbz");

                entity.Property(e => e.MorningbzFlag)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("morningbzFlag");

                entity.Property(e => e.Morningtime)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("morningtime");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<ViewEvection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Evection");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("beginDate");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("checkDate");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEpl_ID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(10)
                    .HasColumnName("City_Name");

                entity.Property(e => e.CompanyForecast)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companyForecast");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyName");

                entity.Property(e => e.CompanySize)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("companySize");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpt_name");

                entity.Property(e => e.EndDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Epl_Name");

                entity.Property(e => e.EvectionFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EvectionType).HasColumnName("evectionType");

                entity.Property(e => e.FinishFlag)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LinkMan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("linkMan");

                entity.Property(e => e.LinkTel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("linkTel");

                entity.Property(e => e.MakeProtocol)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("makeProtocol");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.ProvName)
                    .HasMaxLength(10)
                    .HasColumnName("Prov_Name");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TotalDay).HasColumnName("totalDay");

                entity.Property(e => e.TotalHour).HasColumnName("totalHour");

                entity.Property(e => e.TotalMinute).HasColumnName("totalMinute");

                entity.Property(e => e.TrafficDay).HasColumnName("trafficDay");

                entity.Property(e => e.TrafficHour).HasColumnName("trafficHour");

                entity.Property(e => e.TrafficMinute).HasColumnName("trafficMinute");

                entity.Property(e => e.TrialDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("trialDate");

                entity.Property(e => e.TrialEplId).HasColumnName("trialEpl_ID");

                entity.Property(e => e.WorkDay).HasColumnName("workDay");

                entity.Property(e => e.WorkHour).HasColumnName("workHour");

                entity.Property(e => e.WorkMinute).HasColumnName("workMinute");
            });

            modelBuilder.Entity<ViewFinInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_fin_invoice");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AuditTime).HasColumnType("smalldatetime");

                entity.Property(e => e.BroughtAccount)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.InId).HasColumnName("InID");

                entity.Property(e => e.InNum)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumTime).HasColumnType("smalldatetime");

                entity.Property(e => e.OpenAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StateContext).HasColumnType("ntext");

                entity.Property(e => e.Taxpayers)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewFinSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Fin_salary");

                entity.Property(e => e.Addtime).HasColumnType("datetime");

                entity.Property(e => e.Afternoon).HasColumnName("afternoon");

                entity.Property(e => e.Amerce).HasColumnName("amerce");

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.DayCount).HasColumnName("dayCount");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.FormalAfternoon).HasColumnName("formalAfternoon");

                entity.Property(e => e.FormalSalary).HasColumnName("formalSalary");

                entity.Property(e => e.House).HasColumnName("house");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insurance).HasColumnName("insurance");

                entity.Property(e => e.Ipmac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPMac");

                entity.Property(e => e.Kcount).HasColumnName("kcount");

                entity.Property(e => e.LiveCost).HasColumnName("liveCost");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Overtime).HasColumnName("overtime");

                entity.Property(e => e.PersonSalary).HasColumnName("personSalary");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Ycount).HasColumnName("ycount");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewFinTradeList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_FIN_TradeList");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CabandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CAbandonTime");

                entity.Property(e => e.Cbankroll)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CBankroll");

                entity.Property(e => e.Cemail)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CEmail");

                entity.Property(e => e.Cetime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cetime");

                entity.Property(e => e.Cgetdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CGetdate");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Clicence).HasColumnName("CLicence");

                entity.Property(e => e.ComId).HasColumnName("Com_ID");

                entity.Property(e => e.ComInfo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Cposition)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("CPosition");

                entity.Property(e => e.Cregtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRegtime");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Cstime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cstime");

                entity.Property(e => e.DelFlag).HasColumnName("delFlag");

                entity.Property(e => e.DevelopStatus).HasColumnName("developStatus");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FAX_E");

                entity.Property(e => e.FaxN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("FAX_N");

                entity.Property(e => e.FaxZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FAX_Z");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.HomePage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Info)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.JcwRegTime).HasColumnType("datetime");

                entity.Property(e => e.Jobs).HasColumnType("text");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLinkDate");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.OCsId).HasColumnName("o_CS_ID");

                entity.Property(e => e.OtherFinId).HasColumnName("otherFinID");

                entity.Property(e => e.Percount).HasColumnName("percount");

                entity.Property(e => e.Persum).HasColumnName("persum");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

                entity.Property(e => e.PhoneN)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_N");

                entity.Property(e => e.PhoneZ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Z");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.ReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReceiveEplId).HasColumnName("ReceiveEpl_id");

                entity.Property(e => e.ReceiveMoney).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.TradeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TradeEplId).HasColumnName("TradeEpl_id");

                entity.Property(e => e.TradeMoney).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ViewFinWebSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Fin_WebSite");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdminIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdminIP");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientEplId).HasColumnName("ClientEplID");

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.DptId).HasColumnName("Dpt_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Epl_Name");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.FinPropertyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HowCost).HasColumnType("money");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewForumAskReply>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Forum_AskReply");

                entity.Property(e => e.AskId).HasColumnName("AskID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.ReplyId).HasColumnName("ReplyID");
            });

            modelBuilder.Entity<ViewForumAsking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Forum_Asking");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Ipmac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPMac");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewForumComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Forum_Comment");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.MsgContent)
                    .HasColumnType("text")
                    .HasColumnName("Msg_Content");

                entity.Property(e => e.MsgHit).HasColumnName("Msg_hit");

                entity.Property(e => e.MsgId).HasColumnName("MsgID");

                entity.Property(e => e.MsgTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Title");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlateId).HasColumnName("PlateID");

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_Name");

                entity.Property(e => e.ReferMessage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyHit).HasColumnName("Reply_Hit");

                entity.Property(e => e.ReplyMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reply_man");

                entity.Property(e => e.ReplyMessage).HasColumnType("text");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewForumMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Forum_message");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Bqq)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.Dayvalue).HasColumnName("dayvalue");

                entity.Property(e => e.DgrId).HasColumnName("DGR_ID");

                entity.Property(e => e.Diploma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("ES_ID");

                entity.Property(e => e.Headship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("ID_Card");

                entity.Property(e => e.InIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InIP");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Interest).HasColumnType("text");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LimitIp).HasColumnName("LimitIP");

                entity.Property(e => e.LnkMan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LnkTel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgContent)
                    .HasColumnType("text")
                    .HasColumnName("Msg_Content");

                entity.Property(e => e.MsgHit).HasColumnName("Msg_hit");

                entity.Property(e => e.MsgId).HasColumnName("msgID");

                entity.Property(e => e.MsgTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Msg_Title");

                entity.Property(e => e.Nation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PhoneE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_E");

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
                    .IsUnicode(false);

                entity.Property(e => e.PlateId).HasColumnName("PlateID");

                entity.Property(e => e.PlateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlateStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_Name");

                entity.Property(e => e.PosiDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("Prov_ID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReplyHit).HasColumnName("Reply_Hit");

                entity.Property(e => e.ReplyLastTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Reply_LastTime");

                entity.Property(e => e.ReplyMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Reply_man");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tongue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewForumPlate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Forum_Plate");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlateId).HasColumnName("PlateID");

                entity.Property(e => e.PlateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlateStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewFromWebAddLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_FromWebAdd_Log");

                entity.Property(e => e.ComId).HasColumnName("Com_id");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("Mem_id");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("registerDate");
            });

            modelBuilder.Entity<ViewGetLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Get_log");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.GetDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Get_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TEplId).HasColumnName("T_EPL_ID");
            });

            modelBuilder.Entity<ViewGoodjobRecommend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Goodjob_Recommend");

                entity.Property(e => e.ApplicationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.DateId).HasColumnName("DateID");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ProcessingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceMyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceMyUserID");
            });

            modelBuilder.Entity<ViewGoodjobRecommendtj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Goodjob_Recommendtj");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ProcessingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceMyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceMyUserID");

                entity.Property(e => e.UpEplId).HasColumnName("UpEplID");
            });

            modelBuilder.Entity<ViewInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Information");

                entity.Property(e => e.AreaRemark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayValue).HasColumnName("dayValue");

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Heading).HasMaxLength(100);

                entity.Property(e => e.Important)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.InfoContent).HasColumnType("ntext");

                entity.Property(e => e.InfoId).HasColumnName("Info_ID");

                entity.Property(e => e.IssuedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.New)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_invoices");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CheckDptId).HasColumnName("checkDptID");

                entity.Property(e => e.CheckDptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkDptName");

                entity.Property(e => e.CheckEplId).HasColumnName("checkEplID");

                entity.Property(e => e.CheckEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checkEplName");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("checkRemark");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("checkTime");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comName");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.InId).HasColumnName("InID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.InType).HasColumnName("inType");

                entity.Property(e => e.RegTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("regTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<ViewMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Menu");

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

                entity.Property(e => e.MnuId).HasColumnName("Mnu_ID");

                entity.Property(e => e.MnuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mnu_Name");

                entity.Property(e => e.MnuType).HasColumnName("Mnu_Type");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewMenuInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_MenuInRole");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MnuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mnu_Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ViewPeiComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Pei_Comment");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplId1).HasColumnName("Epl_id");

                entity.Property(e => e.EplIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EplIP");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EplName1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.ExpandType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expr1).HasColumnType("smalldatetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POS_Name");

                entity.Property(e => e.Regtime).HasColumnType("smalldatetime");

                entity.Property(e => e.ShortMemo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPeiFileList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Pei_FileList");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.ExpandType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ParentID")
                    .IsFixedLength();

                entity.Property(e => e.PtypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTypeName");

                entity.Property(e => e.ShortMemo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPhoneCallhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_phone_callhistory");

                entity.Property(e => e.CallBeginTime).HasMaxLength(32);

                entity.Property(e => e.CallId)
                    .HasMaxLength(50)
                    .HasColumnName("CallID");

                entity.Property(e => e.CallerName).HasMaxLength(50);

                entity.Property(e => e.CallerNumber).HasMaxLength(32);

                entity.Property(e => e.DialKey).HasMaxLength(50);

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.EndTime).HasMaxLength(32);

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.Keyword).HasMaxLength(100);

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.PhoneToName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.TalkBeginTime).HasMaxLength(32);

                entity.Property(e => e.TransFrom).HasMaxLength(32);

                entity.Property(e => e.TransTo).HasMaxLength(32);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.VoiceFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPhoneList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Phone_Lists");

                entity.Property(e => e.CallBeginTime).HasMaxLength(32);

                entity.Property(e => e.CallerNumber).HasMaxLength(32);

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.EndTime).HasMaxLength(32);

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.PhoneToName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("rInfo");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewPhoneRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Phone_Rank");

                entity.Property(e => e.CurrentDayCount).HasColumnName("currentDayCount");

                entity.Property(e => e.CurrentDaySum).HasColumnName("currentDaySum");

                entity.Property(e => e.CurrentMonthCount).HasColumnName("currentMonthCount");

                entity.Property(e => e.CurrentMonthSum).HasColumnName("currentMonthSum");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPT_Name");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.EsId).HasColumnName("es_id");

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YesterdayDaySum).HasColumnName("yesterdayDaySum");
            });

            modelBuilder.Entity<ViewPubMind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Pub_mind");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.DptId).HasColumnName("dptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptName");

                entity.Property(e => e.EplId).HasColumnName("eplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eplName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.RepeatContent).HasColumnType("text");

                entity.Property(e => e.RepeatEplId).HasColumnName("RepeatEplID");

                entity.Property(e => e.RepeatEplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ViewRemind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Remind");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDValue");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.WakeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Role");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ViewSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_section");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<ViewSectionInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_SectionInRole");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<ViewTeam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_Team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TeamMemo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewTeamRight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_TeamRights");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LnkUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("lnkURL");

                entity.Property(e => e.MnuId).HasColumnName("Mnu_ID");

                entity.Property(e => e.MnuName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mnu_Name");

                entity.Property(e => e.TeamId).HasColumnName("Team_ID");

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewUserInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_userInRole");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewWebSiteBondManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebSite_BondManager");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BondMoney).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BondNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEplID");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CheckName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.Dns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNS");

                entity.Property(e => e.DnsBeginTime).HasColumnType("datetime");

                entity.Property(e => e.DnsEndTime).HasColumnType("datetime");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InEplId).HasColumnName("InEplID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceBeginTime).HasColumnType("datetime");

                entity.Property(e => e.SpaceEndTime).HasColumnType("datetime");

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");

                entity.Property(e => e.WebSpace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewWebSiteCession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebSite_Cession");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("epl_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.OldEplId).HasColumnName("Old_eplID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.ReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");

                entity.Property(e => e.ToDptId).HasColumnName("ToDpt_ID");

                entity.Property(e => e.ToEplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ToEpl_name");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewWebSiteClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebSite_Client");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CityName).HasMaxLength(10);

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CraftName).HasMaxLength(16);

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.Pname).HasMaxLength(10);

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewWebSiteLinkMan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebSite_LinkMan");

                entity.Property(e => e.BraName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QQ");

                entity.Property(e => e.Sex)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewWebSiteVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebSite_Visit");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.DptId).HasColumnName("DPT_ID");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisitInfo).HasColumnType("text");
            });

            modelBuilder.Entity<ViewZphModify>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_zph_Modify");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComName1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyComName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyId).HasColumnName("ModifyID");

                entity.Property(e => e.ModifyMobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewZphPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_zph_Points");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.ComzphPoints).HasColumnName("comzphPoints");

                entity.Property(e => e.EditDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EPL_Name");

                entity.Property(e => e.Instructions)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PointsId).HasColumnName("PointsID");
            });

            modelBuilder.Entity<ViewZphSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_zph_Sign");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComName1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COM_Name");

                entity.Property(e => e.Contact)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyText).IsUnicode(false);

                entity.Property(e => e.ProEplId).HasColumnName("ProEplID");

                entity.Property(e => e.ProName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZhaoPinHuiId).HasColumnName("ZhaoPinHuiID");
            });

            modelBuilder.Entity<ViewZphTheme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_zph_theme");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AtTheTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ByTheTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EditDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Matters)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ZhaoPinHuiId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ZhaoPinHuiID");
            });

            modelBuilder.Entity<WebConfig>(entity =>
            {
                entity.ToTable("web_config");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID")
                    .HasComment("编号");

                entity.Property(e => e.BusinessDepart)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("业务部门[控制350家等等]");

                entity.Property(e => e.CompanyCount).HasComment("业务员的企业数目,配合前部门来使用");

                entity.Property(e => e.EffectDepart)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("业绩部门显示");

                entity.Property(e => e.FsEffectDepart)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("fsEffectDepart");

                entity.Property(e => e.HowTimeGet).HasComment("陈列期，放弃后多少个小时不能获取");

                entity.Property(e => e.MyCustomersType)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("未收费类型");

                entity.Property(e => e.PhoneMaxFileTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneMaxTime).HasColumnType("datetime");

                entity.Property(e => e.PyEffectDepart)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("pyEffectDepart");

                entity.Property(e => e.SpecialStaff)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("特列排名显示人员");

                entity.Property(e => e.WebCompanyNumber).HasColumnName("Web_companyNumber");

                entity.Property(e => e.WebName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("网站名称");
            });

            modelBuilder.Entity<WebSeting>(entity =>
            {
                entity.ToTable("Web_Seting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dptid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPTID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<WebSiteBondManager>(entity =>
            {
                entity.HasKey(e => e.BondNo);

                entity.ToTable("WebSite_BondManager");

                entity.Property(e => e.BondNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BondMoney).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CheckEplId).HasColumnName("CheckEplID");

                entity.Property(e => e.CheckMemo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CheckName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Dns)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DNS");

                entity.Property(e => e.DnsBeginTime).HasColumnType("datetime");

                entity.Property(e => e.DnsEndTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InEplId).HasColumnName("InEplID");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceBeginTime).HasColumnType("datetime");

                entity.Property(e => e.SpaceEndTime).HasColumnType("datetime");

                entity.Property(e => e.WebSpace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSiteCessionRecord>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("WebSite_Cession_Records");

                entity.Property(e => e.Tid).ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EplId).HasColumnName("epl_ID");

                entity.Property(e => e.InTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSiteClient>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK_Website_clients");

                entity.ToTable("WebSite_Clients");

                entity.Property(e => e.ClientId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClientID");

                entity.Property(e => e.AbandonTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cinfo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHompage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clog)
                    .HasColumnType("text")
                    .HasColumnName("CLog");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.DnsEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.DnsStime).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.FaxA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.FinId).HasColumnName("Fin_id");

                entity.Property(e => e.InCity).HasDefaultValueSql("(0)");

                entity.Property(e => e.InProvince).HasDefaultValueSql("(0)");

                entity.Property(e => e.Indate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INDate");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLinkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.RegMoney)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceEtime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpaceStime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<WebSiteLinkMan>(entity =>
            {
                entity.ToTable("WebSite_LinkMan");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BraName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_a");

                entity.Property(e => e.FaxB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fax_b");

                entity.Property(e => e.FaxC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Fax_c");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneA)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_a");

                entity.Property(e => e.PhoneB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_b");

                entity.Property(e => e.PhoneC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Phone_c");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QQ");

                entity.Property(e => e.Sex)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<WebSiteType>(entity =>
            {
                entity.ToTable("WebSite_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CsId).HasColumnName("CS_ID");

                entity.Property(e => e.CsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CS_Name");

                entity.Property(e => e.Intime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("INTime");
            });

            modelBuilder.Entity<WebSiteVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebSite_Visit");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.VisitInfo).HasColumnType("text");
            });

            modelBuilder.Entity<WebSiteVisitType>(entity =>
            {
                entity.ToTable("WebSite_VisitType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZphCance>(entity =>
            {
                entity.HasKey(e => e.CancelId);

                entity.ToTable("zph_Cance");
            });

            modelBuilder.Entity<ZphModify>(entity =>
            {
                entity.HasKey(e => e.ModifyId);

                entity.ToTable("zph_Modify");

                entity.Property(e => e.ModifyId).HasColumnName("ModifyID");

                entity.Property(e => e.Audit).HasComment("审核状态 0为尚未审核  1为通过 2为尚未通过 ");

                entity.Property(e => e.AuditEplId)
                    .HasColumnName("AuditEplID")
                    .HasComment("审核人编号");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("审核时间");

                entity.Property(e => e.ComId).HasColumnName("COM_ID");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("编辑时间");

                entity.Property(e => e.ModifyComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("企业名称");

                entity.Property(e => e.ModifyContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("联系人");

                entity.Property(e => e.ModifyEplid).HasColumnName("ModifyEPLID");

                entity.Property(e => e.ModifyMobile)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("电话");

                entity.Property(e => e.ModifyText).IsUnicode(false);

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");

                entity.Property(e => e.ZhaoPinHuiId).HasColumnName("ZhaoPinHuiID");
            });

            modelBuilder.Entity<ZphPoint>(entity =>
            {
                entity.HasKey(e => e.PointsId);

                entity.ToTable("zph_Points");

                entity.Property(e => e.PointsId).HasColumnName("PointsID");

                entity.Property(e => e.Audit).HasComment("审核状态 0为尚未审核  1为通过 2为尚未通过 ");

                entity.Property(e => e.AuditEplId)
                    .HasColumnName("AuditEplID")
                    .HasComment("审核人编号");

                entity.Property(e => e.AuditText)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("审核时间");

                entity.Property(e => e.ComId)
                    .HasColumnName("Com_ID")
                    .HasComment("企业ID");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("编辑时间");

                entity.Property(e => e.EplId).HasColumnName("EPL_ID");

                entity.Property(e => e.Instructions)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("说明");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");

                entity.Property(e => e.ZphPoints).HasComment("点数");
            });

            modelBuilder.Entity<ZphReserve>(entity =>
            {
                entity.ToTable("zph_Reserve");

                entity.Property(e => e.IsUse).HasComment("0 为 尚未使用");
            });

            modelBuilder.Entity<ZphSign>(entity =>
            {
                entity.HasKey(e => e.SignId);

                entity.ToTable("zph_Sign");

                entity.Property(e => e.SignId)
                    .HasColumnName("SignID")
                    .HasComment("申请编号");

                entity.Property(e => e.Audit).HasComment("审核状态 0为尚未审核  1为通过 2为尚未通过 ");

                entity.Property(e => e.AuditEplId)
                    .HasColumnName("AuditEplID")
                    .HasComment("审核人编号");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("审核时间");

                entity.Property(e => e.Cancel)
                    .IsUnicode(false)
                    .HasComment("取消报名理由");

                entity.Property(e => e.ComId)
                    .HasColumnName("COM_ID")
                    .HasComment("企业编号");

                entity.Property(e => e.ComName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("企业名称");

                entity.Property(e => e.Contact)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("联系人");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("编辑时间");

                entity.Property(e => e.EplId)
                    .HasColumnName("EPL_ID")
                    .HasComment("申请人编号");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("电话");

                entity.Property(e => e.Modify)
                    .HasDefaultValueSql("((0))")
                    .HasComment("海报状态");

                entity.Property(e => e.ModifyCount).HasComment("修改次数");

                entity.Property(e => e.ModifyText)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("海报资料");

                entity.Property(e => e.Number).HasComment("摊位号");

                entity.Property(e => e.Poster)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProEplId)
                    .HasColumnName("ProEplID")
                    .HasDefaultValueSql("((1490))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");

                entity.Property(e => e.ZhaoPinHuiId)
                    .HasColumnName("ZhaoPinHuiID")
                    .HasComment("招聘会编号");
            });

            modelBuilder.Entity<ZphTheme>(entity =>
            {
                entity.HasKey(e => e.ZhaoPinHuiId);

                entity.ToTable("zph_theme");

                entity.Property(e => e.ZhaoPinHuiId)
                    .HasColumnName("ZhaoPinHuiID")
                    .HasComment("招聘会编号");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("举办地址");

                entity.Property(e => e.AtTheTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("举报时间");

                entity.Property(e => e.AzpHid)
                    .HasColumnName("AZpHId")
                    .HasComment("关联校园招聘会ID");

                entity.Property(e => e.ByTheTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("结束时间");

                entity.Property(e => e.EditDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("编辑时间");

                entity.Property(e => e.EplId)
                    .HasColumnName("EPL_ID")
                    .HasComment("用户编号");

                entity.Property(e => e.JztheTime).HasColumnName("JZTheTime");

                entity.Property(e => e.Matters)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("注意事项");

                entity.Property(e => e.Number).HasComment("摊位数");

                entity.Property(e => e.NumberOk).HasComment("摊位号是否确认");

                entity.Property(e => e.State).HasComment("0 默认为开启 1 位暂停");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("招聘会名称");

                entity.Property(e => e.Type).HasComment("性质 0公益 1收益");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
