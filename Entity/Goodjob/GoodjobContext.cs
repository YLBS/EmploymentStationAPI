using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Goodjob
{
    public partial class GoodjobContext : DbContext
    {
        public GoodjobContext()
        {
        }

        public GoodjobContext(DbContextOptions<GoodjobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ALinshi> ALinshis { get; set; } = null!;
        public virtual DbSet<APaiChu> APaiChus { get; set; } = null!;
        public virtual DbSet<AbackMemId> AbackMemIds { get; set; } = null!;
        public virtual DbSet<ApplytRegisterForJob> ApplytRegisterForJobs { get; set; } = null!;
        public virtual DbSet<BaiDuResume> BaiDuResumes { get; set; } = null!;
        public virtual DbSet<CrmErmemployee> CrmErmemployees { get; set; } = null!;
        public virtual DbSet<EplCallRecord> EplCallRecords { get; set; } = null!;
        public virtual DbSet<EplMobile> EplMobiles { get; set; } = null!;
        public virtual DbSet<GeResume> GeResumes { get; set; } = null!;
        public virtual DbSet<HomeDeductPoint> HomeDeductPoints { get; set; } = null!;
        public virtual DbSet<HomeLoginLog> HomeLoginLogs { get; set; } = null!;
        public virtual DbSet<HtrApplyList> HtrApplyLists { get; set; } = null!;
        public virtual DbSet<HtrInfo> HtrInfos { get; set; } = null!;
        public virtual DbSet<HtrPosition> HtrPositions { get; set; } = null!;
        public virtual DbSet<HtrReward> HtrRewards { get; set; } = null!;
        public virtual DbSet<ImAutMassage> ImAutMassages { get; set; } = null!;
        public virtual DbSet<ImMyAutMassage> ImMyAutMassages { get; set; } = null!;
        public virtual DbSet<IpBlack> IpBlacks { get; set; } = null!;
        public virtual DbSet<IpBlackRecord> IpBlackRecords { get; set; } = null!;
        public virtual DbSet<IpLogInBlocked> IpLogInBlockeds { get; set; } = null!;
        public virtual DbSet<KeyWordSimilarity> KeyWordSimilarities { get; set; } = null!;
        public virtual DbSet<LevelDictionary> LevelDictionaries { get; set; } = null!;
        public virtual DbSet<MemAdvantage> MemAdvantages { get; set; } = null!;
        public virtual DbSet<MemBackPassword> MemBackPasswords { get; set; } = null!;
        public virtual DbSet<MemBdPhoneRecord> MemBdPhoneRecords { get; set; } = null!;
        public virtual DbSet<MemBlack> MemBlacks { get; set; } = null!;
        public virtual DbSet<MemBusStation> MemBusStations { get; set; } = null!;
        public virtual DbSet<MemBusiness> MemBusinesses { get; set; } = null!;
        public virtual DbSet<MemBuyResume> MemBuyResumes { get; set; } = null!;
        public virtual DbSet<MemCopyBlackList> MemCopyBlackLists { get; set; } = null!;
        public virtual DbSet<MemCurriculum> MemCurricula { get; set; } = null!;
        public virtual DbSet<MemCurriculumSignin> MemCurriculumSignins { get; set; } = null!;
        public virtual DbSet<MemDepartment> MemDepartments { get; set; } = null!;
        public virtual DbSet<MemEmaliFlag> MemEmaliFlags { get; set; } = null!;
        public virtual DbSet<MemExcludeMy> MemExcludeMies { get; set; } = null!;
        public virtual DbSet<MemExplosiveProductsResumeLog> MemExplosiveProductsResumeLogs { get; set; } = null!;
        public virtual DbSet<MemFirstLoginAd> MemFirstLoginAds { get; set; } = null!;
        public virtual DbSet<MemFirstLoginAdType> MemFirstLoginAdTypes { get; set; } = null!;
        public virtual DbSet<MemGood> MemGoods { get; set; } = null!;
        public virtual DbSet<MemGoodsRegion> MemGoodsRegions { get; set; } = null!;
        public virtual DbSet<MemGoodsType> MemGoodsTypes { get; set; } = null!;
        public virtual DbSet<MemHiresLog> MemHiresLogs { get; set; } = null!;
        public virtual DbSet<MemImBlack> MemImBlacks { get; set; } = null!;
        public virtual DbSet<MemImConsumption> MemImConsumptions { get; set; } = null!;
        public virtual DbSet<MemImage> MemImages { get; set; } = null!;
        public virtual DbSet<MemInfo> MemInfos { get; set; } = null!;
        public virtual DbSet<MemInfoJy> MemInfoJies { get; set; } = null!;
        public virtual DbSet<MemInterFace> MemInterFaces { get; set; } = null!;
        public virtual DbSet<MemInviteMsgTemplate> MemInviteMsgTemplates { get; set; } = null!;
        public virtual DbSet<MemInvoice> MemInvoices { get; set; } = null!;
        public virtual DbSet<MemJcb> MemJcbs { get; set; } = null!;
        public virtual DbSet<MemJzWxUser> MemJzWxUsers { get; set; } = null!;
        public virtual DbSet<MemLibCommend> MemLibCommends { get; set; } = null!;
        public virtual DbSet<MemLibCommendVice> MemLibCommendVices { get; set; } = null!;
        public virtual DbSet<MemLibDel> MemLibDels { get; set; } = null!;
        public virtual DbSet<MemLibDownload> MemLibDownloads { get; set; } = null!;
        public virtual DbSet<MemLibOwer> MemLibOwers { get; set; } = null!;
        public virtual DbSet<MemLibOwerSort> MemLibOwerSorts { get; set; } = null!;
        public virtual DbSet<MemLibTemp> MemLibTemps { get; set; } = null!;
        public virtual DbSet<MemLoginLog> MemLoginLogs { get; set; } = null!;
        public virtual DbSet<MemMap> MemMaps { get; set; } = null!;
        public virtual DbSet<MemMapComplaint> MemMapComplaints { get; set; } = null!;
        public virtual DbSet<MemMapCoordinate> MemMapCoordinates { get; set; } = null!;
        public virtual DbSet<MemNewsInterFace> MemNewsInterFaces { get; set; } = null!;
        public virtual DbSet<MemNoResume> MemNoResumes { get; set; } = null!;
        public virtual DbSet<MemNotPush> MemNotPushes { get; set; } = null!;
        public virtual DbSet<MemOfferLetter> MemOfferLetters { get; set; } = null!;
        public virtual DbSet<MemOfferLetterTmepate> MemOfferLetterTmepates { get; set; } = null!;
        public virtual DbSet<MemOpenHistory> MemOpenHistories { get; set; } = null!;
        public virtual DbSet<MemOrder> MemOrders { get; set; } = null!;
        public virtual DbSet<MemPackage> MemPackages { get; set; } = null!;
        public virtual DbSet<MemPageUrlPath> MemPageUrlPaths { get; set; } = null!;
        public virtual DbSet<MemPaymentOrder> MemPaymentOrders { get; set; } = null!;
        public virtual DbSet<MemPhoto> MemPhotos { get; set; } = null!;
        public virtual DbSet<MemPointsUsingRecord> MemPointsUsingRecords { get; set; } = null!;
        public virtual DbSet<MemPosDescriptionTemplate> MemPosDescriptionTemplates { get; set; } = null!;
        public virtual DbSet<MemPosJobFunction> MemPosJobFunctions { get; set; } = null!;
        public virtual DbSet<MemPosJobFunction1> MemPosJobFunctions1 { get; set; } = null!;
        public virtual DbSet<MemPosJobFunctionPt> MemPosJobFunctionPts { get; set; } = null!;
        public virtual DbSet<MemPosJobLocation> MemPosJobLocations { get; set; } = null!;
        public virtual DbSet<MemPosNoRefresh> MemPosNoRefreshes { get; set; } = null!;
        public virtual DbSet<MemPosUpdateLog> MemPosUpdateLogs { get; set; } = null!;
        public virtual DbSet<MemPosition> MemPositions { get; set; } = null!;
        public virtual DbSet<MemPositionJobTime> MemPositionJobTimes { get; set; } = null!;
        public virtual DbSet<MemPositionKeyWord> MemPositionKeyWords { get; set; } = null!;
        public virtual DbSet<MemPositionPartTime> MemPositionPartTimes { get; set; } = null!;
        public virtual DbSet<MemPositionSnapShoot> MemPositionSnapShoots { get; set; } = null!;
        public virtual DbSet<MemPositionsBack> MemPositionsBacks { get; set; } = null!;
        public virtual DbSet<MemProduct> MemProducts { get; set; } = null!;
        public virtual DbSet<MemProductCatalog> MemProductCatalogs { get; set; } = null!;
        public virtual DbSet<MemProductUser> MemProductUsers { get; set; } = null!;
        public virtual DbSet<MemProductUserLog> MemProductUserLogs { get; set; } = null!;
        public virtual DbSet<MemPush> MemPushes { get; set; } = null!;
        public virtual DbSet<MemPushRegistration> MemPushRegistrations { get; set; } = null!;
        public virtual DbSet<MemRecommendRecord> MemRecommendRecords { get; set; } = null!;
        public virtual DbSet<MemRemarkList> MemRemarkLists { get; set; } = null!;
        public virtual DbSet<MemResumeContact> MemResumeContacts { get; set; } = null!;
        public virtual DbSet<MemResumeField> MemResumeFields { get; set; } = null!;
        public virtual DbSet<MemResumePush> MemResumePushes { get; set; } = null!;
        public virtual DbSet<MemResumeTag> MemResumeTags { get; set; } = null!;
        public virtual DbSet<MemSearcher> MemSearchers { get; set; } = null!;
        public virtual DbSet<MemSelfhelpMeal> MemSelfhelpMeals { get; set; } = null!;
        public virtual DbSet<MemServiceConsultingRecord> MemServiceConsultingRecords { get; set; } = null!;
        public virtual DbSet<MemServiceOrder> MemServiceOrders { get; set; } = null!;
        public virtual DbSet<MemSetResumeTag> MemSetResumeTags { get; set; } = null!;
        public virtual DbSet<MemSm> MemSms { get; set; } = null!;
        public virtual DbSet<MemSmsRecord> MemSmsRecords { get; set; } = null!;
        public virtual DbSet<MemSmsforResume> MemSmsforResumes { get; set; } = null!;
        public virtual DbSet<MemSoftwareKey> MemSoftwareKeys { get; set; } = null!;
        public virtual DbSet<MemSysNewServiceMassage> MemSysNewServiceMassages { get; set; } = null!;
        public virtual DbSet<MemUser> MemUsers { get; set; } = null!;
        public virtual DbSet<MemUsersBack> MemUsersBacks { get; set; } = null!;
        public virtual DbSet<MemVideo> MemVideos { get; set; } = null!;
        public virtual DbSet<MemViewPassword> MemViewPasswords { get; set; } = null!;
        public virtual DbSet<MemWvideoApply> MemWvideoApplies { get; set; } = null!;
        public virtual DbSet<MemWxUser> MemWxUsers { get; set; } = null!;
        public virtual DbSet<MemWxUserBack> MemWxUserBacks { get; set; } = null!;
        public virtual DbSet<MemWxUserZph> MemWxUserZphs { get; set; } = null!;
        public virtual DbSet<MemWzpVisitor> MemWzpVisitors { get; set; } = null!;
        public virtual DbSet<MemWzph5> MemWzph5s { get; set; } = null!;
        public virtual DbSet<MenUpdatePassWordRecord> MenUpdatePassWordRecords { get; set; } = null!;
        public virtual DbSet<MessageRecord> MessageRecords { get; set; } = null!;
        public virtual DbSet<MngAd> MngAds { get; set; } = null!;
        public virtual DbSet<MngAdClass> MngAdClasses { get; set; } = null!;
        public virtual DbSet<MngAreaSite> MngAreaSites { get; set; } = null!;
        public virtual DbSet<MngChat> MngChats { get; set; } = null!;
        public virtual DbSet<MngCheckingResume> MngCheckingResumes { get; set; } = null!;
        public virtual DbSet<MngCommendPo> MngCommendPos { get; set; } = null!;
        public virtual DbSet<MngCompleteQd> MngCompleteQds { get; set; } = null!;
        public virtual DbSet<MngEmployee> MngEmployees { get; set; } = null!;
        public virtual DbSet<MngHtmlLabel> MngHtmlLabels { get; set; } = null!;
        public virtual DbSet<MngHtmlTemplate> MngHtmlTemplates { get; set; } = null!;
        public virtual DbSet<MngLive> MngLives { get; set; } = null!;
        public virtual DbSet<MngLiveComment> MngLiveComments { get; set; } = null!;
        public virtual DbSet<MngLiveCommentBlack> MngLiveCommentBlacks { get; set; } = null!;
        public virtual DbSet<MngLiveFabulou> MngLiveFabulous { get; set; } = null!;
        public virtual DbSet<MngLiveLottery> MngLiveLotteries { get; set; } = null!;
        public virtual DbSet<MngLiveMemSign> MngLiveMemSigns { get; set; } = null!;
        public virtual DbSet<MngLivePo> MngLivePos { get; set; } = null!;
        public virtual DbSet<MngLiveSubscribe> MngLiveSubscribes { get; set; } = null!;
        public virtual DbSet<MngMemStatistic> MngMemStatistics { get; set; } = null!;
        public virtual DbSet<MngPartnerContent> MngPartnerContents { get; set; } = null!;
        public virtual DbSet<MngPartnerPayCompany> MngPartnerPayCompanies { get; set; } = null!;
        public virtual DbSet<MngPartnerUser> MngPartnerUsers { get; set; } = null!;
        public virtual DbSet<MngPopSite> MngPopSites { get; set; } = null!;
        public virtual DbSet<MngResumeStatistic> MngResumeStatistics { get; set; } = null!;
        public virtual DbSet<MngWeekly> MngWeeklies { get; set; } = null!;
        public virtual DbSet<MngWxPusMassage> MngWxPusMassages { get; set; } = null!;
        public virtual DbSet<MngWxPusRecord> MngWxPusRecords { get; set; } = null!;
        public virtual DbSet<MngWxPushLimit> MngWxPushLimits { get; set; } = null!;
        public virtual DbSet<MyActivateInvitation> MyActivateInvitations { get; set; } = null!;
        public virtual DbSet<MyAppRegisterLog> MyAppRegisterLogs { get; set; } = null!;
        public virtual DbSet<MyAuthenId> MyAuthenIds { get; set; } = null!;
        public virtual DbSet<MyBackSendEmail> MyBackSendEmails { get; set; } = null!;
        public virtual DbSet<MyCompanyTopicAndComment> MyCompanyTopicAndComments { get; set; } = null!;
        public virtual DbSet<MyEducation> MyEducations { get; set; } = null!;
        public virtual DbSet<MyEducationEng> MyEducationEngs { get; set; } = null!;
        public virtual DbSet<MyEmailSend> MyEmailSends { get; set; } = null!;
        public virtual DbSet<MyExcludeMem> MyExcludeMems { get; set; } = null!;
        public virtual DbSet<MyFavouriate> MyFavouriates { get; set; } = null!;
        public virtual DbSet<MyFocusCompany> MyFocusCompanies { get; set; } = null!;
        public virtual DbSet<MyFulfil> MyFulfils { get; set; } = null!;
        public virtual DbSet<MyFulfilEng> MyFulfilEngs { get; set; } = null!;
        public virtual DbSet<MyImBlack> MyImBlacks { get; set; } = null!;
        public virtual DbSet<MyIsRead> MyIsReads { get; set; } = null!;
        public virtual DbSet<MyJobFunction> MyJobFunctions { get; set; } = null!;
        public virtual DbSet<MyJobFunction1> MyJobFunctions1 { get; set; } = null!;
        public virtual DbSet<MyJobLocation> MyJobLocations { get; set; } = null!;
        public virtual DbSet<MyLanguage> MyLanguages { get; set; } = null!;
        public virtual DbSet<MyLanguageEng> MyLanguageEngs { get; set; } = null!;
        public virtual DbSet<MyLetter> MyLetters { get; set; } = null!;
        public virtual DbSet<MyMailUnsubscribe> MyMailUnsubscribes { get; set; } = null!;
        public virtual DbSet<MyMobileCodeRecord> MyMobileCodeRecords { get; set; } = null!;
        public virtual DbSet<MyMobileRecord> MyMobileRecords { get; set; } = null!;
        public virtual DbSet<MyPhoneDisabled> MyPhoneDisableds { get; set; } = null!;
        public virtual DbSet<MyPosSubscribe> MyPosSubscribes { get; set; } = null!;
        public virtual DbSet<MyProject> MyProjects { get; set; } = null!;
        public virtual DbSet<MyProjectEng> MyProjectEngs { get; set; } = null!;
        public virtual DbSet<MyPush> MyPushes { get; set; } = null!;
        public virtual DbSet<MyPushRegistration> MyPushRegistrations { get; set; } = null!;
        public virtual DbSet<MyQqloginDatum> MyQqloginData { get; set; } = null!;
        public virtual DbSet<MyRecommendRecord> MyRecommendRecords { get; set; } = null!;
        public virtual DbSet<MyRecommendWx> MyRecommendWxes { get; set; } = null!;
        public virtual DbSet<MyRegisterForCrm> MyRegisterForCrms { get; set; } = null!;
        public virtual DbSet<MyRegisterLog> MyRegisterLogs { get; set; } = null!;
        public virtual DbSet<MyResume> MyResumes { get; set; } = null!;
        public virtual DbSet<MyResumeAnalysisRecord> MyResumeAnalysisRecords { get; set; } = null!;
        public virtual DbSet<MyResumeBack> MyResumeBacks { get; set; } = null!;
        public virtual DbSet<MyResumeEng> MyResumeEngs { get; set; } = null!;
        public virtual DbSet<MyResumeKeyWord> MyResumeKeyWords { get; set; } = null!;
        public virtual DbSet<MyResumeOldText> MyResumeOldTexts { get; set; } = null!;
        public virtual DbSet<MyResumePerNameRecord> MyResumePerNameRecords { get; set; } = null!;
        public virtual DbSet<MyResumeReceipt> MyResumeReceipts { get; set; } = null!;
        public virtual DbSet<MyResumeUploadRecord> MyResumeUploadRecords { get; set; } = null!;
        public virtual DbSet<MyResumeZph> MyResumeZphs { get; set; } = null!;
        public virtual DbSet<MyResumeZphReceipt> MyResumeZphReceipts { get; set; } = null!;
        public virtual DbSet<MySearcher> MySearchers { get; set; } = null!;
        public virtual DbSet<MySendResumeHistory> MySendResumeHistories { get; set; } = null!;
        public virtual DbSet<MyShouJiBack> MyShouJiBacks { get; set; } = null!;
        public virtual DbSet<MySm> MySms { get; set; } = null!;
        public virtual DbSet<MySource> MySources { get; set; } = null!;
        public virtual DbSet<MyStore> MyStores { get; set; } = null!;
        public virtual DbSet<MySysSubscribe> MySysSubscribes { get; set; } = null!;
        public virtual DbSet<MyTraceRecord> MyTraceRecords { get; set; } = null!;
        public virtual DbSet<MyTraceRecordDelBacke> MyTraceRecordDelBackes { get; set; } = null!;
        public virtual DbSet<MyTraining> MyTrainings { get; set; } = null!;
        public virtual DbSet<MyTrainingEng> MyTrainingEngs { get; set; } = null!;
        public virtual DbSet<MyUploadFile> MyUploadFiles { get; set; } = null!;
        public virtual DbSet<MyUser> MyUsers { get; set; } = null!;
        public virtual DbSet<MyUserType> MyUserTypes { get; set; } = null!;
        public virtual DbSet<MyUsersBack> MyUsersBacks { get; set; } = null!;
        public virtual DbSet<MyVideo> MyVideos { get; set; } = null!;
        public virtual DbSet<MyViewContact> MyViewContacts { get; set; } = null!;
        public virtual DbSet<MyViewPosCount> MyViewPosCounts { get; set; } = null!;
        public virtual DbSet<MyWapRegisterLog> MyWapRegisterLogs { get; set; } = null!;
        public virtual DbSet<MyWorkExp> MyWorkExps { get; set; } = null!;
        public virtual DbSet<MyWorkExpEng> MyWorkExpEngs { get; set; } = null!;
        public virtual DbSet<OtherPo> OtherPos { get; set; } = null!;
        public virtual DbSet<OuterResumeAccount> OuterResumeAccounts { get; set; } = null!;
        public virtual DbSet<OuterResumeApplyPosManager> OuterResumeApplyPosManagers { get; set; } = null!;
        public virtual DbSet<OuterResumeResume> OuterResumeResumes { get; set; } = null!;
        public virtual DbSet<OuterResumeResumeOperationLog> OuterResumeResumeOperationLogs { get; set; } = null!;
        public virtual DbSet<OuterResumeUploadResumeLog> OuterResumeUploadResumeLogs { get; set; } = null!;
        public virtual DbSet<PicGoodjob> PicGoodjobs { get; set; } = null!;
        public virtual DbSet<PicGoodjobWithPic> PicGoodjobWithPics { get; set; } = null!;
        public virtual DbSet<PubComplaint> PubComplaints { get; set; } = null!;
        public virtual DbSet<PubFunctionUseRecord> PubFunctionUseRecords { get; set; } = null!;
        public virtual DbSet<PubHelpItem> PubHelpItems { get; set; } = null!;
        public virtual DbSet<PubHelpTopic> PubHelpTopics { get; set; } = null!;
        public virtual DbSet<PubHxDynamicRecording> PubHxDynamicRecordings { get; set; } = null!;
        public virtual DbSet<PubImRoaming> PubImRoamings { get; set; } = null!;
        public virtual DbSet<PubImRoamingLog> PubImRoamingLogs { get; set; } = null!;
        public virtual DbSet<PubInformation> PubInformations { get; set; } = null!;
        public virtual DbSet<PubInformationMy> PubInformationMies { get; set; } = null!;
        public virtual DbSet<PubInterviewing> PubInterviewings { get; set; } = null!;
        public virtual DbSet<PubInterviewingZph> PubInterviewingZphs { get; set; } = null!;
        public virtual DbSet<PubInterviewingZphVideo> PubInterviewingZphVideos { get; set; } = null!;
        public virtual DbSet<PubMemOnline> PubMemOnlines { get; set; } = null!;
        public virtual DbSet<PubMessage> PubMessages { get; set; } = null!;
        public virtual DbSet<PubPerApplyPo> PubPerApplyPos { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosBack> PubPerApplyPosBacks { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosBackDel> PubPerApplyPosBackDels { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosPt> PubPerApplyPosPts { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosSub> PubPerApplyPosSubs { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosVideo> PubPerApplyPosVideos { get; set; } = null!;
        public virtual DbSet<PubPerApplyPosZph> PubPerApplyPosZphs { get; set; } = null!;
        public virtual DbSet<PubPerEvaluation> PubPerEvaluations { get; set; } = null!;
        public virtual DbSet<PubPhoneNumBlack> PubPhoneNumBlacks { get; set; } = null!;
        public virtual DbSet<PubRecordSession> PubRecordSessions { get; set; } = null!;
        public virtual DbSet<PubResumeBrowsedLog> PubResumeBrowsedLogs { get; set; } = null!;
        public virtual DbSet<PubResumeViewLog> PubResumeViewLogs { get; set; } = null!;
        public virtual DbSet<PubServiceHelp> PubServiceHelps { get; set; } = null!;
        public virtual DbSet<PubServiceHelpRecord> PubServiceHelpRecords { get; set; } = null!;
        public virtual DbSet<PubStraightCast> PubStraightCasts { get; set; } = null!;
        public virtual DbSet<PubUserqdRecord> PubUserqdRecords { get; set; } = null!;
        public virtual DbSet<QdResult> QdResults { get; set; } = null!;
        public virtual DbSet<RecomMyuserId> RecomMyuserIds { get; set; } = null!;
        public virtual DbSet<RecommendQueue> RecommendQueues { get; set; } = null!;
        public virtual DbSet<RecommendedRecord> RecommendedRecords { get; set; } = null!;
        public virtual DbSet<RecruitmentRegister> RecruitmentRegisters { get; set; } = null!;
        public virtual DbSet<RegisterSign> RegisterSigns { get; set; } = null!;
        public virtual DbSet<SelfServiceOrder> SelfServiceOrders { get; set; } = null!;
        public virtual DbSet<SeoUrl> SeoUrls { get; set; } = null!;
        public virtual DbSet<SetArea> SetAreas { get; set; } = null!;
        public virtual DbSet<SetLevel> SetLevels { get; set; } = null!;
        public virtual DbSet<SiteType> SiteTypes { get; set; } = null!;
        public virtual DbSet<Sqlmapoutput> Sqlmapoutputs { get; set; } = null!;
        public virtual DbSet<StatPromote> StatPromotes { get; set; } = null!;
        public virtual DbSet<StatPromoteResume> StatPromoteResumes { get; set; } = null!;
        public virtual DbSet<SysMatchingMem> SysMatchingMems { get; set; } = null!;
        public virtual DbSet<SysRegisterFrom> SysRegisterFroms { get; set; } = null!;
        public virtual DbSet<SysSalerDownload> SysSalerDownloads { get; set; } = null!;
        public virtual DbSet<TableMaxId> TableMaxIds { get; set; } = null!;
        public virtual DbSet<TempId> TempIds { get; set; } = null!;
        public virtual DbSet<TemplateSet> TemplateSets { get; set; } = null!;
        public virtual DbSet<TemplateType> TemplateTypes { get; set; } = null!;
        public virtual DbSet<TopicMemInfo> TopicMemInfos { get; set; } = null!;
        public virtual DbSet<TouchFeedBack> TouchFeedBacks { get; set; } = null!;
        public virtual DbSet<WapLoginLog> WapLoginLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.3.2;Initial Catalog=Goodjob;User ID=goodjobjishu;Password=juncaiwang/*-;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALinshi>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("A_linshi");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");
            });

            modelBuilder.Entity<APaiChu>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("A_PaiCHu");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");
            });

            modelBuilder.Entity<AbackMemId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aback_memID");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<ApplytRegisterForJob>(entity =>
            {
                entity.ToTable("ApplytRegisterForJob");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esid).HasColumnName("ESId");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaiDuResume>(entity =>
            {
                entity.ToTable("BaiDu_Resume");

                entity.Property(e => e.Birthday)
                    .HasMaxLength(20)
                    .HasColumnName("birthday");

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(20)
                    .HasColumnName("cellphone");

                entity.Property(e => e.CheckName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoverLetter)
                    .HasMaxLength(200)
                    .HasColumnName("cover_letter");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Education)
                    .HasMaxLength(20)
                    .HasColumnName("education");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Experience)
                    .HasMaxLength(200)
                    .HasColumnName("experience");

                entity.Property(e => e.HopeSalary)
                    .HasMaxLength(20)
                    .HasColumnName("hope_salary");

                entity.Property(e => e.Intention)
                    .HasMaxLength(20)
                    .HasColumnName("intention");

                entity.Property(e => e.Isdell)
                    .HasColumnName("isdell")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobArea)
                    .HasMaxLength(20)
                    .HasColumnName("job_area");

                entity.Property(e => e.JobCity)
                    .HasMaxLength(20)
                    .HasColumnName("job_city");

                entity.Property(e => e.MyUserId).HasColumnName("myUserId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.NoPrompt)
                    .HasMaxLength(20)
                    .HasColumnName("no_prompt");

                entity.Property(e => e.ProfStatus)
                    .HasMaxLength(20)
                    .HasColumnName("prof_status");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.Uid)
                    .HasMaxLength(50)
                    .HasColumnName("uid");

                entity.Property(e => e.WorkYears)
                    .HasMaxLength(20)
                    .HasColumnName("work_years");
            });

            modelBuilder.Entity<CrmErmemployee>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("CRM_ERMEmployee");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("EplID");

                entity.Property(e => e.DptId).HasColumnName("DptID");

                entity.Property(e => e.DptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EplName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.WeiXinHao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EplCallRecord>(entity =>
            {
                entity.ToTable("Epl_CallRecord");

                entity.Property(e => e.CallCount).HasColumnName("Call_count");

                entity.Property(e => e.EndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EplId).HasColumnName("Epl_Id");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.StarTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EplMobile>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("Epl_Mobile");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("Epl_Id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            });

            modelBuilder.Entity<GeResume>(entity =>
            {
                entity.ToTable("GE_Resume");

                entity.HasIndex(e => e.ReceiveDate, "PK_GE_Resume_RD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AddressT).HasColumnName("Address_T");

                entity.Property(e => e.EngWork)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("memID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Skills)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HomeDeductPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Home_DeductPoints");

                entity.Property(e => e.DownTiem).HasColumnType("datetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<HomeLoginLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Home_Login_log");

                entity.Property(e => e.GllId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gllID");

                entity.Property(e => e.IntTime)
                    .HasColumnType("datetime")
                    .HasColumnName("intTime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginIP");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loginName");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loginTime");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

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

            modelBuilder.Entity<HtrApplyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTR_ApplyList");

                entity.Property(e => e.ApplyTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.NewsMyuserId).HasColumnName("NewsMyuserID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResumeContext).HasColumnType("text");

                entity.Property(e => e.ResumeTxt)
                    .HasColumnType("text")
                    .HasColumnName("Resume_txt");

                entity.Property(e => e.WordFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HtrInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTR_Info");

                entity.Property(e => e.CompanyIntroduction).HasMaxLength(1000);

                entity.Property(e => e.EplId).HasColumnName("Epl_id");

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<HtrPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTR_Position");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("inTime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PayTxt)
                    .HasMaxLength(1000)
                    .HasColumnName("Pay_txt");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Posdecription).HasMaxLength(1800);

                entity.Property(e => e.PosfunBig1).HasColumnName("Posfun_big1");

                entity.Property(e => e.PosfunBig2).HasColumnName("Posfun_big2");

                entity.Property(e => e.RequestTxt)
                    .HasMaxLength(1000)
                    .HasColumnName("Request_txt");

                entity.Property(e => e.Reward)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HtrReward>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTR_Reward");

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MyEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MyPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResumeReason).HasColumnType("text");

                entity.Property(e => e.WordFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImAutMassage>(entity =>
            {
                entity.ToTable("IM_Aut_Massage");

                entity.Property(e => e.Createatime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Massage).HasColumnType("text");

                entity.Property(e => e.Updatetime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ImMyAutMassage>(entity =>
            {
                entity.ToTable("IM_My_Aut_Massage");

                entity.Property(e => e.Createatime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Massage).HasColumnType("text");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Updatetime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IpBlack>(entity =>
            {
                entity.ToTable("IP_Black");

                entity.Property(e => e.IpaddDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IPAddDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");
            });

            modelBuilder.Entity<IpBlackRecord>(entity =>
            {
                entity.ToTable("IP_BlackRecord");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.RecordCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IpLogInBlocked>(entity =>
            {
                entity.ToTable("IP_LogInBlocked");

                entity.HasComment("登录错误超过五次锁定记录");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountType).HasComment("账号类型 1 企业 ；2 个人");

                entity.Property(e => e.BlockedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("封禁时间");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyWordSimilarity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KeyWord_Similarity");

                entity.Property(e => e.KeyWordType).HasComment("关键字类别 1 JobDescription ； 2 IndividualStrengths ；3 Major ；4 Certification");

                entity.Property(e => e.Pkey)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("岗位关键字");

                entity.Property(e => e.Rkey)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("简历关键字");

                entity.Property(e => e.Similarity).HasComment("匹配结果");
            });

            modelBuilder.Entity<LevelDictionary>(entity =>
            {
                entity.ToTable("LevelDictionary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coding).HasMaxLength(50);

                entity.Property(e => e.Coding1).HasMaxLength(50);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HtemplateType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("HTemplateType");

                entity.Property(e => e.JobName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Joblocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JtemplateType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("JTemplateType");

                entity.Property(e => e.Length)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SiteType).HasMaxLength(100);
            });

            modelBuilder.Entity<MemAdvantage>(entity =>
            {
                entity.ToTable("Mem_Advantage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("添加时间");

                entity.Property(e => e.AdvantageId)
                    .HasColumnName("AdvantageID")
                    .HasComment("");

                entity.Property(e => e.AdvantageType).HasComment("企业优势关键词类别：1 融资情况；2 公司亮点；3 公司实力");

                entity.Property(e => e.MemId).HasColumnName("MemID");
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

            modelBuilder.Entity<MemBdPhoneRecord>(entity =>
            {
                entity.ToTable("Mem_BdPhoneRecord");

                entity.Property(e => e.BdDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoginDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.TureName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemBlack>(entity =>
            {
                entity.ToTable("Mem_Black");

                entity.Property(e => e.Bdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemBusStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_BusStation");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.StationId).HasColumnName("StationID");
            });

            modelBuilder.Entity<MemBusiness>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Business");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lng");
            });

            modelBuilder.Entity<MemBuyResume>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Mem_BuyResume");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemCopyBlackList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_CopyBlackList");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MemCurriculum>(entity =>
            {
                entity.ToTable("Mem_Curriculum");

                entity.Property(e => e.AddDatetime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CAddress)
                    .HasMaxLength(200)
                    .HasColumnName("C_Address");

                entity.Property(e => e.CBegDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("C_BegDateTime");

                entity.Property(e => e.CContext)
                    .HasMaxLength(500)
                    .HasColumnName("C_Context");

                entity.Property(e => e.CCover)
                    .HasMaxLength(200)
                    .HasColumnName("C_Cover")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CDiscount)
                    .HasColumnName("C_Discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CIntroduction)
                    .HasColumnType("text")
                    .HasColumnName("C_Introduction")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CMaxPeopleCount).HasColumnName("C_MaxPeopleCount");

                entity.Property(e => e.CName)
                    .HasMaxLength(100)
                    .HasColumnName("C_Name");

                entity.Property(e => e.CPrice)
                    .HasColumnName("C_Price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CTeacher)
                    .HasMaxLength(50)
                    .HasColumnName("C_Teacher");

                entity.Property(e => e.CTeacherIntroduction)
                    .HasColumnType("text")
                    .HasColumnName("C_TeacherIntroduction")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemCurriculumSignin>(entity =>
            {
                entity.ToTable("Mem_Curriculum_Signin");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CId).HasColumnName("C_Id");

                entity.Property(e => e.ContactDepartment).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(100);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.Isdell).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemAddress).HasMaxLength(50);

                entity.Property(e => e.MemName).HasMaxLength(50);

                entity.Property(e => e.SalerUserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SigninDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WxOpenId).HasMaxLength(100);
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

            modelBuilder.Entity<MemEmaliFlag>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_EmaliFlag");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");
            });

            modelBuilder.Entity<MemExcludeMy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Exclude_My");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MemExplosiveProductsResumeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ExplosiveProductsResume_Log");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PushDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemFirstLoginAd>(entity =>
            {
                entity.ToTable("Mem_FirstLoginAd");

                entity.Property(e => e.ShowTimestamp)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Show_Timestamp")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemFirstLoginAdType>(entity =>
            {
                entity.ToTable("Mem_FirstLoginAdType");

                entity.Property(e => e.Adname)
                    .HasMaxLength(50)
                    .HasColumnName("ADName");
            });

            modelBuilder.Entity<MemGood>(entity =>
            {
                entity.HasKey(e => e.GoodsId);

                entity.ToTable("Mem_Goods");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HposCount).HasColumnName("HPosCount");

                entity.Property(e => e.PtposCount).HasColumnName("PTPosCount");

                entity.Property(e => e.PtupdateCount).HasColumnName("PTUpdateCount");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MemGoodsRegion>(entity =>
            {
                entity.ToTable("Mem_GoodsRegion");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CountId).HasColumnName("countId");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createDateTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProvId).HasColumnName("provId");

                entity.Property(e => e.StreetId).HasColumnName("streetId");

                entity.Property(e => e.VillageName)
                    .HasMaxLength(50)
                    .HasColumnName("villageName")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemGoodsType>(entity =>
            {
                entity.ToTable("Mem_GoodsType");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
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

            modelBuilder.Entity<MemImBlack>(entity =>
            {
                entity.ToTable("Mem_IM_Black");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemImConsumption>(entity =>
            {
                entity.ToTable("Mem_IM_Consumption");

                entity.Property(e => e.Imcount)
                    .HasColumnName("IMCount")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Imdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IMDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemImage>(entity =>
            {
                entity.ToTable("Mem_Image");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileText)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewFilePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewFileText)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<MemInfo>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Info");

                entity.HasIndex(e => e.MemId, "PK_Mem_Info_MemID");

                entity.HasIndex(e => e.RegisterDate, "PK_Mem_Info_RegisterDate");

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

                entity.Property(e => e.MailCode).HasComment("");

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

            modelBuilder.Entity<MemInfoJy>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Info_JY");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressD)
                    .HasColumnName("Address_D")
                    .HasComment("区");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AddressT)
                    .HasColumnName("Address_T")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BelongType).HasColumnName("belongType");

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

                entity.Property(e => e.Esid).HasColumnName("ESId");

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

                entity.Property(e => e.Updatetime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("updatetime")
                    .HasDefaultValueSql("(getdate())");

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

            modelBuilder.Entity<MemInviteMsgTemplate>(entity =>
            {
                entity.ToTable("Mem_InviteMsgTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MessageTemplate)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemInvoice>(entity =>
            {
                entity.ToTable("Mem_Invoice");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(50)
                    .HasColumnName("Bank_Account")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditCode)
                    .HasMaxLength(50)
                    .HasColumnName("Credit_Code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvoceType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("发票类型  1普票（电子）   2 专票（纸质）");

                entity.Property(e => e.InvoceTypeName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDell).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Mem_Address")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemName)
                    .HasMaxLength(50)
                    .HasColumnName("Mem_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ZphId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MemJcb>(entity =>
            {
                entity.ToTable("Mem_JCB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Jcbcount).HasColumnName("JCBCount");

                entity.Property(e => e.Jtype)
                    .HasColumnName("JType")
                    .HasComment("--0 新增 1支出 2系统退回 ");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.SalerId).HasColumnName("SalerID");
            });

            modelBuilder.Entity<MemJzWxUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_JzWxUser");

                entity.Property(e => e.HeadPortrait)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrWxId).HasColumnName("HrWxID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UnionID");

                entity.Property(e => e.WxOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WxOpenID");
            });

            modelBuilder.Entity<MemLibCommend>(entity =>
            {
                entity.ToTable("Mem_LibCommend");

                entity.HasIndex(e => e.MemId, "PK_LibCommend_MemID");

                entity.HasIndex(e => e.MyUserId, "PK_LibCommend_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.SalerId).HasColumnName("SalerID");
            });

            modelBuilder.Entity<MemLibCommendVice>(entity =>
            {
                entity.ToTable("Mem_LibCommendVice");

                entity.HasIndex(e => e.SeeTime, "PK_Mem_LibCommendVice_");

                entity.HasIndex(e => e.AddTime, "PK_Mem_LibCommendVice_AdTime");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DeleteTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ReplId).HasColumnName("REpl_Id");

                entity.Property(e => e.SeeTime).HasColumnType("smalldatetime");
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

                entity.HasIndex(e => e.DownDate, "PK_LibDowload_DownDate");

                entity.HasIndex(e => e.MemFlag, "PK_LibDownLoad_MemFlag");

                entity.HasIndex(e => e.MemId, "PK_LibDownload_MemID");

                entity.HasIndex(e => e.MyUserId, "PK_LibDownload_MyUserID");

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

            modelBuilder.Entity<MemLoginLog>(entity =>
            {
                entity.ToTable("Mem_LoginLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LoginIp)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LoginIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginType).HasComment("1电脑 2手机浏览器  3安卓手机 4苹果手机 5小程序");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Map");

                entity.Property(e => e.MapUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OpenTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MemMapComplaint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_MapComplaint");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComplaintContent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MemMapCoordinate>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_MapCoordinate");

                entity.HasIndex(e => e.MemId, "PK_Mem_MapCoordinate_memID");

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

            modelBuilder.Entity<MemNewsInterFace>(entity =>
            {
                entity.HasKey(e => e.InviteId);

                entity.ToTable("Mem_NewsInterFace");

                entity.Property(e => e.InviteId).HasColumnName("InviteID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InviteMemo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InviteTite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Noon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeString)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemNoResume>(entity =>
            {
                entity.ToTable("Mem_NoResume");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemNotPush>(entity =>
            {
                entity.ToTable("Mem_NotPush");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MemOfferLetter>(entity =>
            {
                entity.ToTable("Mem_OfferLetter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OfferMidleContent)
                    .HasMaxLength(650)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDay)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("报到时间2");

                entity.Property(e => e.ReportTime)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("报到时间1");

                entity.Property(e => e.Salary)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("发送时间");

                entity.Property(e => e.WorkHours)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemOfferLetterTmepate>(entity =>
            {
                entity.ToTable("Mem_OfferLetterTmepate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("联系方式");

                entity.Property(e => e.MemAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("公司地址");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OfferMidleContent)
                    .HasMaxLength(650)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("薪资信息");

                entity.Property(e => e.TempName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("模板名");

                entity.Property(e => e.WorkHours)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("工作时间");
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

            modelBuilder.Entity<MemOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Mem_Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Crmcontract)
                    .HasMaxLength(50)
                    .HasColumnName("CRMContract")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CrmupDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CRMUpDate");

                entity.Property(e => e.EplId).HasColumnName("Epl_ID");

                entity.Property(e => e.GoodsId).HasColumnName("GoodsID");

                entity.Property(e => e.HposCount).HasColumnName("HPosCount");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MerchantNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderState).HasComment("0 待付款 1已付款 完成 2取消");

                entity.Property(e => e.OrderString)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderTimeDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayTimeDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(((1999)-(1))-(1))");

                entity.Property(e => e.PayType).HasComment("1 支付宝 2微信  俊才币");

                entity.Property(e => e.Process)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtposCount).HasColumnName("PTPosCount");

                entity.Property(e => e.PtupdateCount).HasColumnName("PTUpdateCount");

                entity.Property(e => e.SalerUserId).HasColumnName("SalerUserID");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MemPackage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Package");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoUserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DoUserID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemPageUrlPath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_PageUrlPath");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UrlPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemPaymentOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_PaymentOrder");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoUserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DoUserID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemPhoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Photo");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<MemPointsUsingRecord>(entity =>
            {
                entity.HasKey(e => e.PointsId);

                entity.ToTable("Mem_PointsUsingRecord");

                entity.Property(e => e.PointsId).HasColumnName("PointsID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
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

            modelBuilder.Entity<MemPosJobFunction>(entity =>
            {
                entity.ToTable("Mem_PosJobFunction");

                entity.HasIndex(e => e.PosId, "IX_Mem_PosJobFunction_PosID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_small");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobFunction1>(entity =>
            {
                entity.ToTable("Mem_PosJobFunction_s");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobFunctionId)
                    .HasColumnName("JobFunctionID")
                    .HasComment("三级");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_small");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobFunctionPt>(entity =>
            {
                entity.ToTable("Mem_PosJobFunction_PT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobLocationC).HasColumnName("JobLocation_C");

                entity.Property(e => e.JobLocationP).HasColumnName("JobLocation_P");

                entity.Property(e => e.JobLocationT).HasColumnName("JobLocation_T");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MemPosJobLocation>(entity =>
            {
                entity.ToTable("Mem_PosJobLocation");

                entity.HasIndex(e => e.PosId, "Mem_PosJobLocation_PosID");

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

            modelBuilder.Entity<MemPosUpdateLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_PosUpdateLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.Updatetime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemPosition>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("Mem_Position");

                entity.HasIndex(e => e.EndValidDate, "IX_Mem_Position_Endvalidate");

                entity.HasIndex(e => e.MemId, "IX_Mem_Position_MemID");

                entity.HasIndex(e => e.PosState, "IX_Mem_Position_PosState");

                entity.HasIndex(e => e.PostDate, "IX_Mem_Position_PostDate");

                entity.HasIndex(e => e.Hires, "PK_Mem_Position_Hires");

                entity.HasIndex(e => e.PosId, "PK_Mem_Position_PosID");

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

                entity.Property(e => e.EmailCodeFlag).HasComment("0简体中文；1繁体中文；2不接收");

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

                entity.Property(e => e.JobFunctionPart)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

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

                entity.Property(e => e.PosSalary).HasComment("固定薪资 用于存放 千元等 用户手动输入的金额");

                entity.Property(e => e.PosState).HasComment("0 暂停 1 已过期 2 发布中");

                entity.Property(e => e.PosType).HasComment("0 不限 1 全职 2兼职 3实习生 4 暑假工 5寒假工");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(1800)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterBy)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 俊才 1.前程 2.boss 3.58 4.智联 5拉钩");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegularWorker).HasComment("转正机会  1 提供转正  2 不提供转正  3 面议");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryMode).HasComment("0 薪资类型 1 固定薪资 2范围薪资");

                entity.Property(e => e.SalaryMonth)
                    .HasDefaultValueSql("((12))")
                    .HasComment("默认12薪");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryUnit).HasComment("薪资单位 1 元/每小时  2 元/每天  3 元/每周  4 元/每月  5 元/每次  6 元/每件");

                entity.Property(e => e.TagLib)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeekRequired).HasComment("0");

                entity.Property(e => e.Welfa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemPositionJobTime>(entity =>
            {
                entity.ToTable("Mem_PositionJobTime");

                entity.Property(e => e.JobOther)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobTime)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobWeek)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JsonTime)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemPositionKeyWord>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK__Mem_Positi__C37F3CC21C9D15DC");

                entity.ToTable("Mem_Position_KeyWord");

                entity.HasComment("岗位信息关键词");

                entity.Property(e => e.PosId).ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增时间");

                entity.Property(e => e.Certification)
                    .HasMaxLength(800)
                    .HasComment("技能证书");

                entity.Property(e => e.IndividualStrengths)
                    .HasMaxLength(1800)
                    .HasComment("个人优势");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(2000)
                    .HasComment("工作内容");

                entity.Property(e => e.Major)
                    .HasMaxLength(1500)
                    .HasComment("主修课程");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<MemPositionPartTime>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("Mem_PositionPartTime");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.BeginHiresDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Commission)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("提成百分比/提成金额/自定义提成");

                entity.Property(e => e.CommissionMode).HasComment("提成类型  1 业绩提成  2 计件提成  3 自定义");

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
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExamNotice)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Geyn).HasColumnName("GEYN");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("身高");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_Big");

                entity.Property(e => e.JobFunctionPart)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_Small");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocationC)
                    .HasMaxLength(20)
                    .HasColumnName("JobLocation_C")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobLocationP)
                    .HasMaxLength(20)
                    .HasColumnName("JobLocation_P")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MonthRequired).HasComment("时间要求 能工作1-6个月以上  数值 1-6");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosType).HasComment("0 不限 1 全职 2兼职 3实习生 4 暑假工 5寒假工");

                entity.Property(e => e.Posdecription)
                    .HasMaxLength(1800)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PostDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.ResulatDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalaryMode).HasComment("薪资类型 1 固定薪资 2范围薪资");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryUnit).HasComment("薪资单位 1 元/每小时  2 元/每天  3 元/每周  4 元/每月  5 元/每次  6 元/每件");

                entity.Property(e => e.SalryTimeType).HasComment("薪资时间类型 1 元/每小时  2 元/每周  3元/每月");

                entity.Property(e => e.SettlementMode).HasComment(" 结算方式  1 日结  2 周结  3 月结  4 次结  5 计件结  6 完工结  7 面议");

                entity.Property(e => e.WeekRequired).HasComment("每周至少工作1-7天  数值 1-7");

                entity.Property(e => e.Welfa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDate)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment(" 工作时间");

                entity.Property(e => e.WorkTime)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')")
                    .HasComment("上班时段");

                entity.Property(e => e.WorkType)
                    .HasDefaultValueSql("('')")
                    .HasComment("工作种类  1 短招  2 长招");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemPositionSnapShoot>(entity =>
            {
                entity.ToTable("Mem_PositionSnapShoot");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.BeginHiresDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

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
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryMonth)
                    .HasDefaultValueSql("((12))")
                    .HasComment("默认12薪");

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

            modelBuilder.Entity<MemPositionsBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Positions_Back");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.BeginHiresDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactFax).HasMaxLength(50);

                entity.Property(e => e.ContactFaxE)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_E");

                entity.Property(e => e.ContactFaxZ)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ContactFax_Z");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel).HasMaxLength(30);

                entity.Property(e => e.ContactTelE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_E");

                entity.Property(e => e.ContactTelZ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContactTel_Z");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndValidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExamAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExamNotice)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Geyn).HasColumnName("GEYN");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Posdecription).HasMaxLength(1800);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RegHometownC).HasColumnName("RegHometown_C");

                entity.Property(e => e.RegHometownP).HasColumnName("RegHometown_P");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReqDegreeId).HasColumnName("ReqDegreeID");

                entity.Property(e => e.SalaryRange)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TagLib)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Welfa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Product");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            });

            modelBuilder.Entity<MemProductCatalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ProductCatalog");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CatalogName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MemProductUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ProductUser");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MemProductUserLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ProductUserLog");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.OpenDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<MemPush>(entity =>
            {
                entity.ToTable("Mem_Push");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(200)
                    .HasColumnName("RegistrationID");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemPushRegistration>(entity =>
            {
                entity.ToTable("Mem_PushRegistration");

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(200)
                    .HasColumnName("RegistrationID");

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 Android 2 IOS");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemRecommendRecord>(entity =>
            {
                entity.ToTable("Mem_RecommendRecord");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemState).HasComment("会员状态");
            });

            modelBuilder.Entity<MemRemarkList>(entity =>
            {
                entity.ToTable("Mem_Remark_List");

                entity.HasIndex(e => e.MemId, "PK_Mem_Remark_List_MemID");

                entity.HasIndex(e => e.MyUserId, "PK_Mem_Remark_List_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MarkImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

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

                entity.Property(e => e.OpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemResumeContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ResumeContact");

                entity.Property(e => e.Creattime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("creattime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Isdell).HasColumnName("isdell");

                entity.Property(e => e.Memid).HasColumnName("memid");

                entity.Property(e => e.Myuserid).HasColumnName("myuserid");

                entity.Property(e => e.Zphid).HasColumnName("zphid");
            });

            modelBuilder.Entity<MemResumeField>(entity =>
            {
                entity.ToTable("Mem_ResumeField");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Location1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Location2).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Rcheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rtext).HasMaxLength(2000);
            });

            modelBuilder.Entity<MemResumePush>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ResumePush");

                entity.HasComment("简历推送");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InputDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PushDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PushMyUserIds)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PushMyUserIDs")
                    .HasComment("推送简历ID");
            });

            modelBuilder.Entity<MemResumeTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_Mem_Resume_Tag");

                entity.ToTable("Mem_ResumeTag");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.TagTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemSearcher>(entity =>
            {
                entity.ToTable("Mem_Searcher");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HomeTownC).HasColumnName("HomeTown_C");

                entity.Property(e => e.HomeTownP).HasColumnName("HomeTown_P");

                entity.Property(e => e.JobFunction)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LanguageLevel).HasDefaultValueSql("('')");

                entity.Property(e => e.LastPosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.LocationT).HasColumnName("Location_T");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NewJobLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDegreeId1).HasColumnName("ReqDegreeID1");

                entity.Property(e => e.ReqDegreeId2).HasColumnName("ReqDegreeID2");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearcherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemSelfhelpMeal>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_SelfhelpMeal");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.PosEndTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResumEndTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SmsEndTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateEndTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemServiceConsultingRecord>(entity =>
            {
                entity.ToTable("Mem_ServiceConsultingRecord");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.Massage)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProblemTypeName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemServiceOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Mem_ServiceOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApplyPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DoDate).HasColumnType("datetime");

                entity.Property(e => e.DoUserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DoUserID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MemSetResumeTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_SetResumeTag");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SetDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TagId).HasColumnName("TagID");
            });

            modelBuilder.Entity<MemSm>(entity =>
            {
                entity.ToTable("Mem_SMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.SentSmscount).HasColumnName("SentSMSCount");

                entity.Property(e => e.Smscount).HasColumnName("SMSCount");
            });

            modelBuilder.Entity<MemSmsRecord>(entity =>
            {
                entity.ToTable("Mem_SmsRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackContent)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')")
                    .HasComment("上行返回短信");

                entity.Property(e => e.Backstatus).HasComment("0 无回复； 1 有回复 ； 2 有回复已查看");

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

            modelBuilder.Entity<MemSoftwareKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Software_Key");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.Memkey)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemSysNewServiceMassage>(entity =>
            {
                entity.ToTable("Mem_SysNewServiceMassage");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsStamp).HasComment("用于是否 加红以及 加上最新图片");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<MemUser>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Mem_Users");

                entity.HasIndex(e => e.CheckFlag, "IX_Mem_Users_CheckFlag");

                entity.HasIndex(e => e.LastLoginDate, "PK_Mem_User_LastLoginDate");

                entity.HasIndex(e => e.PassWord, "PK_Mem_User_PassWord");

                entity.HasIndex(e => e.UserName, "PK_Mem_User_UserName");

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

                entity.Property(e => e.DateMaxViewNum).HasDefaultValueSql("((50))");

                entity.Property(e => e.EndValidDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsSearchResume)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Jcb).HasColumnName("JCB");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LastLoginIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxChatNum).HasComment("最大直聊点");

                entity.Property(e => e.MaxPosNum).HasDefaultValueSql("((999))");

                entity.Property(e => e.MemberClass).HasComment("-2 禁止使用会员 ; -1 服务过期会员 ; 0 普通注册会员 ; 2 正式会员 ; 3 云招聘会员");

                entity.Property(e => e.PartnerId)
                    .HasColumnName("PartnerID")
                    .HasComment("1毕业生就业网");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtposNum).HasColumnName("PTPosNum");

                entity.Property(e => e.PtupdateNum).HasColumnName("PTUpdateNum");

                entity.Property(e => e.RegisterBy).HasComment("0 1 pc 2 wap 3android 4ios 5wxx 1001.前程 1002.boss 1003.58 1004.智联 1005拉钩 1006珠宝外");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestVideoDate)
                    .HasColumnType("smalldatetime")
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

            modelBuilder.Entity<MemUsersBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_Users_back");

                entity.Property(e => e.BeginValidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckUserId).HasColumnName("CheckUserID");

                entity.Property(e => e.EndValidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LastLoginIP");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SalerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalerTel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SalerUserId).HasColumnName("SalerUserID");

                entity.Property(e => e.SalerUserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemVideo>(entity =>
            {
                entity.ToTable("Mem_Video");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckFlag)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0待审核 1通过 2拒绝");

                entity.Property(e => e.CheckUserId)
                    .HasColumnName("CheckUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyIntroduction).HasMaxLength(500);

                entity.Property(e => e.CoverUrl)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelayCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemName).HasMaxLength(50);

                entity.Property(e => e.OfflineDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OnlineDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OnlineState).HasComment("0 待处理 1 上线 2下线");

                entity.Property(e => e.RefreshDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TopDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UploadUserId).HasColumnName("UploadUserID");

                entity.Property(e => e.VideoUrl)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vlength).HasColumnName("VLength");

                entity.Property(e => e.Vtype)
                    .HasColumnName("VType")
                    .HasComment("0未分类  1 招聘类 2职场类");
            });

            modelBuilder.Entity<MemViewPassword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_ViewPassword");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LastLoginIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lookdate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemWvideoApply>(entity =>
            {
                entity.ToTable("Mem_WVideoApply");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MakeSate).HasComment("1 zhong  2 wancheng");

                entity.Property(e => e.Material).HasMaxLength(2000);

                entity.Property(e => e.MemIntoduction).HasMaxLength(500);

                entity.Property(e => e.PosIntoduction).HasMaxLength(4000);

                entity.Property(e => e.Rreason)
                    .HasMaxLength(50)
                    .HasColumnName("RReason")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MemWxUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_WxUser");

                entity.Property(e => e.CredateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeadPortrait)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrWxId).HasColumnName("HrWxID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UnionID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WxOpenID");
            });

            modelBuilder.Entity<MemWxUserBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_WxUser_back");

                entity.Property(e => e.HeadPortrait)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrWxId).HasColumnName("HrWxID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WxOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WxOpenID");
            });

            modelBuilder.Entity<MemWxUserZph>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mem_WxUser_Zph");

                entity.Property(e => e.HeadPortrait)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrWxId).HasColumnName("HrWxID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.UnionId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UnionID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WxOpenID");
            });

            modelBuilder.Entity<MemWzpVisitor>(entity =>
            {
                entity.ToTable("Mem_WZP_Visitor");

                entity.Property(e => e.VisitorIp)
                    .HasMaxLength(50)
                    .HasColumnName("VisitorIP");

                entity.Property(e => e.VisitorTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WzpId).HasColumnName("WZP_Id");

                entity.Property(e => e.Wzptype).HasColumnName("WZPType");
            });

            modelBuilder.Entity<MemWzph5>(entity =>
            {
                entity.ToTable("Mem_WZPH5");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("smalldatetime")
                    .HasComputedColumnSql("(dateadd(month,(1),[CreateDate]))", false);

                entity.Property(e => e.OpenMusic)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pic).HasMaxLength(50);

                entity.Property(e => e.Wdescribe)
                    .HasMaxLength(200)
                    .HasColumnName("WDescribe");

                entity.Property(e => e.WorKey).HasMaxLength(200);

                entity.Property(e => e.Wtitle)
                    .HasMaxLength(50)
                    .HasColumnName("WTitle");

                entity.Property(e => e.Wurl)
                    .HasMaxLength(200)
                    .HasColumnName("WUrl");

                entity.Property(e => e.Wzptype).HasColumnName("WZPType");
            });

            modelBuilder.Entity<MenUpdatePassWordRecord>(entity =>
            {
                entity.ToTable("Men_UpdatePassWordRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("insertDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");
            });

            modelBuilder.Entity<MessageRecord>(entity =>
            {
                entity.ToTable("Message_Records");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("发送内容");

                entity.Property(e => e.Mt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("对应的下行内容");

                entity.Property(e => e.SenderPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("手机号码");

                entity.Property(e => e.Target)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("上行的目标号");

                entity.Property(e => e.Uptime)
                    .HasColumnType("smalldatetime")
                    .HasComment("发送时间");
            });

            modelBuilder.Entity<MngAd>(entity =>
            {
                entity.ToTable("Mng_Ad");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AreaSite)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DevelopSite)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Logo)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId)
                    .HasMaxLength(50)
                    .HasColumnName("MemID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PartnerSite)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PopSite)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MngAdClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_AdClass");

                entity.Property(e => e.ClassCode).HasMaxLength(50);

                entity.Property(e => e.ClassInfo).HasMaxLength(200);

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<MngAreaSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_AreaSite");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .HasColumnName("EName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .HasColumnName("PName");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<MngChat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_Chat");

                entity.Property(e => e.AuditDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Images).HasMaxLength(200);

                entity.Property(e => e.StartDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MngCheckingResume>(entity =>
            {
                entity.ToTable("Mng_CheckingResume");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngCommendPo>(entity =>
            {
                entity.ToTable("Mng_CommendPos");

                entity.HasIndex(e => e.CommendDate, "PK_Mng_CommendPos_ComDate");

                entity.HasIndex(e => e.PosId, "PK_Mng_CommendPos_PosID");

                entity.HasIndex(e => e.MyUserId, "PK_Mng_Commendpos_MyUserID");

                entity.HasIndex(e => e.SalerId, "PK_Mng_Commendpos_SalerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommendDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.QdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.SalerId).HasColumnName("SalerID");
            });

            modelBuilder.Entity<MngCompleteQd>(entity =>
            {
                entity.ToTable("Mng_CompleteQd");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Describe).HasMaxLength(500);

                entity.Property(e => e.QdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngEmployee>(entity =>
            {
                entity.HasKey(e => e.EplId);

                entity.ToTable("Mng_Employee");

                entity.HasIndex(e => e.EplId, "PK_Mng_Employee_EplID");

                entity.Property(e => e.EplId)
                    .ValueGeneratedNever()
                    .HasColumnName("EplID");

                entity.Property(e => e.Eplname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPLName")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MngHtmlLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_HtmlLabel");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.AreaSiteConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CityConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClassNameField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataCondition)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataOrder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataTable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DevelopSiteConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PartnerSiteConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PopSiteConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceConditionField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TimeField)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitleField)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngHtmlTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_HtmlTemplate");

                entity.Property(e => e.AddTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MasterPagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaveEncoding)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaveFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngLive>(entity =>
            {
                entity.ToTable("Mng_Live");

                entity.Property(e => e.AnchorName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Briefing).HasMaxLength(200);

                entity.Property(e => e.ClickCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommentCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerServiceImg)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')")
                    .HasComment("直播介绍");

                entity.Property(e => e.EndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.FabulousCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.H5StartPatch)
                    .HasMaxLength(200)
                    .HasColumnName("H5_start_patch");

                entity.Property(e => e.IsDell).HasDefaultValueSql("((0))");

                entity.Property(e => e.LiveUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Live_url");

                entity.Property(e => e.LiveUrl1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LiveUrl2)
                    .HasMaxLength(200)
                    .HasColumnName("Live_url2");

                entity.Property(e => e.LocalPath).HasMaxLength(200);

                entity.Property(e => e.LotteryTime)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenBarrage).HasComment("开启弹幕");

                entity.Property(e => e.OpenMassage).HasComment("开启留言");

                entity.Property(e => e.PlayBackUrl)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("回放地址");

                entity.Property(e => e.PlayCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PreviewImg)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("预告图片");

                entity.Property(e => e.PushShowWay)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .HasComment("发布渠道 1 自我 2 小程序");

                entity.Property(e => e.ShowWay)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.WxDesc).HasMaxLength(500);

                entity.Property(e => e.WxImage).HasMaxLength(200);

                entity.Property(e => e.WxTitle).HasMaxLength(200);

                entity.Property(e => e.WxUrl).HasMaxLength(200);
            });

            modelBuilder.Entity<MngLiveComment>(entity =>
            {
                entity.ToTable("Mng_Live_Comment");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommContent).HasMaxLength(50);

                entity.Property(e => e.CommentKey).HasMaxLength(20);

                entity.Property(e => e.DellTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MngLiveCommentBlack>(entity =>
            {
                entity.ToTable("Mng_Live_CommentBlack");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BlackTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MngLiveFabulou>(entity =>
            {
                entity.ToTable("Mng_Live_Fabulous");

                entity.Property(e => e.FabulousKey)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FabulousTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngLiveLottery>(entity =>
            {
                entity.ToTable("Mng_Live_Lottery");

                entity.Property(e => e.LotteryKey)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LotteryTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MatchNumberRoundsKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatchPhoneKey)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MngLiveMemSign>(entity =>
            {
                entity.ToTable("Mng_Live_MemSign");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckUserId)
                    .HasColumnName("CheckUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactPerson).HasMaxLength(10);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.IsDel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTop).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lid).HasColumnName("LId");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PosDes).HasMaxLength(500);

                entity.Property(e => e.PosIds)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosName).HasMaxLength(200);

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SigDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MngLivePo>(entity =>
            {
                entity.ToTable("Mng_Live_Pos");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngLiveSubscribe>(entity =>
            {
                entity.ToTable("Mng_Live_Subscribe");

                entity.Property(e => e.SubscribeTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngMemStatistic>(entity =>
            {
                entity.ToTable("Mng_Mem_Statistics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ios).HasColumnName("IOS");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.Rstype).HasColumnName("RStype");

                entity.Property(e => e.StatisticsTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Xcx).HasColumnName("XCX");
            });

            modelBuilder.Entity<MngPartnerContent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_PartnerContent");

                entity.Property(e => e.FunctionBig).HasColumnName("Function_Big");

                entity.Property(e => e.FunctionSmall).HasColumnName("Function_Small");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<MngPartnerPayCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_PartnerPayCompany");

                entity.Property(e => e.BeginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<MngPartnerUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_PartnerUser");

                entity.Property(e => e.DisableDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LastLoginIP");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

                entity.Property(e => e.PartnerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SiteDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngPopSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mng_PopSite");

                entity.Property(e => e.Domain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngResumeStatistic>(entity =>
            {
                entity.ToTable("Mng_Resume_Statistics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bd).HasColumnName("BD");

                entity.Property(e => e.Bdxcx).HasColumnName("BDXCX");

                entity.Property(e => e.Boss)
                    .HasColumnName("BOSS")
                    .HasComment("Boss录入简历量");

                entity.Property(e => e.Ios).HasColumnName("IOS");

                entity.Property(e => e.Jrttxcx).HasColumnName("JRTTXCX");

                entity.Property(e => e.Nsxcx).HasColumnName("NSXCX");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.Pyxcx).HasColumnName("PYXCX");

                entity.Property(e => e.Qc)
                    .HasColumnName("QC")
                    .HasComment("前程简历录入量");

                entity.Property(e => e.Rstype).HasColumnName("RStype");

                entity.Property(e => e.StatisticsTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Xcx).HasColumnName("XCX");

                entity.Property(e => e.Zl)
                    .HasColumnName("ZL")
                    .HasComment("智联简历录入量");

                entity.Property(e => e.Zph).HasColumnName("ZPH");
            });

            modelBuilder.Entity<MngWeekly>(entity =>
            {
                entity.ToTable("Mng_Weekly");

                entity.Property(e => e.MemId).HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeeklyDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MngWxPusMassage>(entity =>
            {
                entity.ToTable("Mng_Wx_PusMassage");

                entity.Property(e => e.PusType).HasComment("0 为个人 1 为企业");
            });

            modelBuilder.Entity<MngWxPusRecord>(entity =>
            {
                entity.ToTable("Mng_WxPusRecord");

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SendDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WxPushContext)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MngWxPushLimit>(entity =>
            {
                entity.ToTable("Mng_WxPushLimit");

                entity.Property(e => e.CalingName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'‘’')");

                entity.Property(e => e.MemId)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MemKeyWored)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'‘’')");

                entity.Property(e => e.PosKeyWored)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'‘’')");

                entity.Property(e => e.RegionCid)
                    .HasMaxLength(100)
                    .HasColumnName("RegionCId");
            });

            modelBuilder.Entity<MyActivateInvitation>(entity =>
            {
                entity.ToTable("My_ActivateInvitation");

                entity.Property(e => e.RespondDateTime).HasColumnType("datetime");

                entity.Property(e => e.SendCount).HasComment("发送累计次数 用于职位推荐");

                entity.Property(e => e.SendDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type).HasComment("0 邀请激活 1 简历信息完善 2职位投诉 3职位推荐");

                entity.Property(e => e.Unsubscribe).HasComment("退订 0位默认1为退订");
            });

            modelBuilder.Entity<MyAppRegisterLog>(entity =>
            {
                entity.ToTable("My_AppRegister_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyAuthenId>(entity =>
            {
                entity.ToTable("MyAuthenID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EncryptionStr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SendDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyBackSendEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_BackSendEmail");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyCompanyTopicAndComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_CompanyTopicAndComment");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Content)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Topic)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<MyEducation>(entity =>
            {
                entity.ToTable("My_Education");

                entity.HasIndex(e => e.MyuserId, "PK_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SpecialityMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyEducationEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Education_Eng");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.Certificate).HasMaxLength(100);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");

                entity.Property(e => e.SchoolName).HasMaxLength(100);

                entity.Property(e => e.Speciality).HasMaxLength(100);

                entity.Property(e => e.SpecialityMemo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyEmailSend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_EmailSend");

                entity.Property(e => e.EmailDirection).HasColumnType("text");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyExcludeMem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Exclude_Mem");

                entity.Property(e => e.EDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("E_DateTime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("add date");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyFavouriate>(entity =>
            {
                entity.ToTable("My_Favouriate");

                entity.HasIndex(e => e.MyUserId, "PK_My_Favouriate_MyUserID");

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

            modelBuilder.Entity<MyFocusCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_FocusCompanies");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyFulfil>(entity =>
            {
                entity.ToTable("My_Fulfil");

                entity.HasIndex(e => e.MyUserId, "PK_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyFulfilEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Fulfil_Eng");

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyImBlack>(entity =>
            {
                entity.ToTable("My_IM_Black");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyIsRead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_IsRead");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<MyJobFunction>(entity =>
            {
                entity.ToTable("My_JobFunction");

                entity.HasIndex(e => e.JobFunctionBig, "PK_My_Big");

                entity.HasIndex(e => e.MyUserId, "PK_My_MyUserID");

                entity.HasIndex(e => e.JobFunctionSmall, "PK_My_Small");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_small");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyJobFunction1>(entity =>
            {
                entity.ToTable("My_JobFunction_s");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobFunctionBig).HasColumnName("JobFunction_big");

                entity.Property(e => e.JobFunctionId)
                    .HasColumnName("JobFunctionID")
                    .HasComment("三级");

                entity.Property(e => e.JobFunctionSmall).HasColumnName("JobFunction_small");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyJobLocation>(entity =>
            {
                entity.ToTable("My_JobLocation");

                entity.HasIndex(e => e.MyUserId, "PK_My_MyUserID");

                entity.HasIndex(e => e.JobLocationP, "PK_My_P");

                entity.HasIndex(e => e.JobLocationC, "PK_my_C");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobLocationC).HasColumnName("JobLocation_C");

                entity.Property(e => e.JobLocationP).HasColumnName("JobLocation_P");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyLanguage>(entity =>
            {
                entity.ToTable("My_Language");

                entity.HasIndex(e => e.MyUserId, "PK_My_Language_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyLanguageEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Language_Eng");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyLetter>(entity =>
            {
                entity.ToTable("My_Letter");

                entity.HasIndex(e => e.MyUserId, "PK_My_Letter_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyLetter1)
                    .HasColumnType("text")
                    .HasColumnName("MyLetter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyMailUnsubscribe>(entity =>
            {
                entity.ToTable("My_MailUnsubscribe");

                entity.HasComment("求职者邮件退订");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("添加时间");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.UnsubscribeType).HasComment("退订类型，1：录用通知退订");
            });

            modelBuilder.Entity<MyMobileCodeRecord>(entity =>
            {
                entity.ToTable("MyMobileCodeRecord");

                entity.HasIndex(e => e.PhoneNum, "PK_MyMobileCodeRecord_PhoneNum");

                entity.Property(e => e.Atype)
                    .HasColumnName("AType")
                    .HasDefaultValueSql("((0))")
                    .HasComment("1.注册 2.忘记密码 3.替换 4.绑定 5api招聘会登录 6招聘会报名短信发送短信  7 MemReg 8 MemLog 9登录");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("发送时间");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("过期时间");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.PhoneNum).HasMaxLength(50);

                entity.Property(e => e.Qtype)
                    .HasColumnName("QType")
                    .HasDefaultValueSql("((0))")
                    .HasComment("涞源 1 pc 2 chiping 3 android 4 ios 34 App企业 35 PC企业");
            });

            modelBuilder.Entity<MyMobileRecord>(entity =>
            {
                entity.ToTable("MyMobileRecord");

                entity.HasIndex(e => e.PhoneNum, "PK_MyMobileRecord_PhoneNum");

                entity.HasIndex(e => e.RigisterDate, "PK_MyMobileRecord_RD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RigisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyPhoneDisabled>(entity =>
            {
                entity.ToTable("My_PhoneDisabled");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DisabledPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId)
                    .HasColumnName("MemID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SetDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyPosSubscribe>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_PosSubscribe");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.PosJobFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosJobLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('''')");
            });

            modelBuilder.Entity<MyProject>(entity =>
            {
                entity.ToTable("My_Project");

                entity.HasIndex(e => e.MyUserId, "PK_My_Project_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ProjectDuty).HasColumnType("text");

                entity.Property(e => e.ProjectMemo).HasColumnType("text");

                entity.Property(e => e.ProjectName).HasMaxLength(30);
            });

            modelBuilder.Entity<MyProjectEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Project_Eng");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ProjectDuty).HasColumnType("text");

                entity.Property(e => e.ProjectMemo).HasColumnType("text");

                entity.Property(e => e.ProjectName).HasMaxLength(30);
            });

            modelBuilder.Entity<MyPush>(entity =>
            {
                entity.ToTable("My_Push");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PushType).HasComment("1。版本更新 2 面试邀请通知 3 简历查看通知 4招聘会通知");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyPushRegistration>(entity =>
            {
                entity.ToTable("My_PushRegistration");

                entity.Property(e => e.Mtype)
                    .HasMaxLength(200)
                    .HasColumnName("MType");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(200)
                    .HasColumnName("RegistrationID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyQqloginDatum>(entity =>
            {
                entity.ToTable("My_QQLoginData");

                entity.HasIndex(e => e.MyUserId, "PK_My_QQLoginData_MyuserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OpenId)
                    .HasMaxLength(50)
                    .HasColumnName("OpenID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyRecommendRecord>(entity =>
            {
                entity.ToTable("My_RecommendRecord");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsEffective)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否有效 0 否 1是");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PartnerTradeNo)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rtype)
                    .HasColumnName("RType")
                    .HasComment("0为初始 1为进 2为出");

                entity.Property(e => e.Source).HasComment("0未知 1注册 100提现");

                entity.Property(e => e.Tansfers)
                    .HasMaxLength(1500)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyRecommendWx>(entity =>
            {
                entity.ToTable("My_RecommendWx");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.WxImage)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WxName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.XcxCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyRegisterForCrm>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_RegisterForCrm");

                entity.HasIndex(e => e.EplId, "PK_My_RegisterForCrm_EplID");

                entity.HasIndex(e => e.ExtranetId, "PK_My_RegisterForCrm_Ex");

                entity.HasIndex(e => e.MyUserId, "PK_My_RegisterForCrm_MyUserID");

                entity.HasIndex(e => e.RegisterDate, "PK_My_RegisterForCrm_RegDate");

                entity.HasIndex(e => e.UpdateDate, "PK_My_RegisterForCrm_Update");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.EplId).HasColumnName("EplID");

                entity.Property(e => e.ExtranetId)
                    .HasMaxLength(250)
                    .HasColumnName("ExtranetID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VisitDescrption)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyRegisterLog>(entity =>
            {
                entity.ToTable("My_Register_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Belongtype)
                    .HasMaxLength(50)
                    .HasColumnName("belongtype");

                entity.Property(e => e.Createtime)
                    .HasColumnType("date")
                    .HasColumnName("createtime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Myuserid)
                    .HasMaxLength(50)
                    .HasColumnName("myuserid");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(500)
                    .HasColumnName("parameter");

                entity.Property(e => e.Registerfrom)
                    .HasMaxLength(50)
                    .HasColumnName("registerfrom");
            });

            modelBuilder.Entity<MyResume>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Resume");

                entity.HasIndex(e => e.MobileNum, "PK_My_Resume_MobileNum");

                entity.HasIndex(e => e.PerName, "PK_My_Resume_PerName");

                entity.HasIndex(e => e.RegisterDate, "PK_My_Resume_RD");

                entity.HasIndex(e => e.UpdateDate, "PK_My_Resume_UpdateDate");

                entity.HasIndex(e => e.MyUserId, "PK_My_myUserID")
                    .IsUnique();

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID")
                    .HasComment("个人账号编号");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("通讯地址");

                entity.Property(e => e.AllCount).HasComment("诚信分");

                entity.Property(e => e.AllWrite).HasComment("整体完整性\r\n0未填写完成，1基本完整，2很完整\r\n基本完整：除项目、证书、肖像photodisplay、语言以外的都填写\r\n很完整就要全部填写");

                entity.Property(e => e.BaseWrite).HasComment("基本信息完整\r\n0未填写，1已填写");

                entity.Property(e => e.Birthday)
                    .HasColumnType("smalldatetime")
                    .HasComment("出生日期");

                entity.Property(e => e.CardNum)
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')")
                    .HasComment("证件号码");

                entity.Property(e => e.CardType).HasComment("证件类型");

                entity.Property(e => e.CareerDirection)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')")
                    .HasComment("发展方向");

                entity.Property(e => e.CertWrite).HasComment("证书有上传\r\n0未填写，1已填写");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("审核日期");

                entity.Property(e => e.CheckFlag).HasComment("审核标志\r\n1=待审核，2=审核通过，3=审核不通过，4=更新后待复审");

                entity.Property(e => e.CheckinDate).HasComment("到职日期");

                entity.Property(e => e.ComputerLevel)
                    .HasDefaultValueSql("('')")
                    .HasComment("计算机能力");

                entity.Property(e => e.ComputerSkills)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')")
                    .HasComment("计算机技能描述");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("联系电话");

                entity.Property(e => e.DegreeId)
                    .HasColumnName("DegreeID")
                    .HasComment("学历\r\n0=无，70=博士，60=硕士，50=本科，40=大专，30=中专，20=高中");

                entity.Property(e => e.EatHouseNeeded)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("食宿要求");

                entity.Property(e => e.EduWrite).HasComment("教育经验有填写\r\n0未填写，1已填写");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("电子邮箱(和帐号表一样！要同步更新)");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Height).HasComment("身高");

                entity.Property(e => e.Homepage)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("个人主页");

                entity.Property(e => e.HometownC)
                    .HasColumnName("Hometown_C")
                    .HasComment("户籍（市）");

                entity.Property(e => e.HometownP)
                    .HasColumnName("Hometown_P")
                    .HasComment("户籍（省）");

                entity.Property(e => e.HopeWrite).HasComment("意向填写完整\r\n0未填写，1已填写");

                entity.Property(e => e.Imnum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMNum")
                    .HasDefaultValueSql("('')")
                    .HasComment("即时通讯号码");

                entity.Property(e => e.Interesting)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')")
                    .HasComment("兴趣爱好(老系统无，新加、显示时注意为空就不显)");

                entity.Property(e => e.JobSeeking)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("寻求职位描述(就是以前填写的三项加一起)");

                entity.Property(e => e.JobType).HasComment("求职类型");

                entity.Property(e => e.LanguageWrite).HasComment("语言有填写\r\n0未填写，1已填写");

                entity.Property(e => e.LocationC)
                    .HasColumnName("Location_C")
                    .HasComment("现所在地（市）");

                entity.Property(e => e.LocationP)
                    .HasColumnName("Location_P")
                    .HasComment("现所在地（省）");

                entity.Property(e => e.LocationT).HasColumnName("Location_T");

                entity.Property(e => e.MaritalStatus).HasComment("婚姻状况\r\n0=未婚，1=已婚，2=离异，3=保密");

                entity.Property(e => e.MobileNum)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("移动电话");

                entity.Property(e => e.Nationality).HasComment("民族");

                entity.Property(e => e.OtherNeeded)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("其它要求");

                entity.Property(e => e.OtherSkills)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')")
                    .HasComment("其它技能");

                entity.Property(e => e.PartComName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("姓名");

                entity.Property(e => e.PhotoDisplay).HasComment("照片显示\r\n0不存在，1不显示，2显示");

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("肖像照片的名称");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')")
                    .HasComment("职称");

                entity.Property(e => e.Professional)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectWrite).HasComment("项目有填写\r\n0未填写，1已填写");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("注册日期（简历的注册日期，不同于帐号表中的）");

                entity.Property(e => e.ResumeStatus).HasComment("简历的状态\r\n0=正常，1=隐藏简历，2=对指定的企业隐藏，3=待删除（独立功能操作）");

                entity.Property(e => e.Salary).HasComment("薪金要求");

                entity.Property(e => e.SelfDescription)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')")
                    .HasComment("自我评价");

                entity.Property(e => e.Sex).HasComment("性别\r\n0=不限，1=男，2=女 （增加“不限”的目的是与其它表相应字段进行配合）");

                entity.Property(e => e.SkillWrite).HasComment("技能专长完整");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新日期（同时更新帐号表中的更新日期）");

                entity.Property(e => e.WorkWrite).HasComment("工作经验有填写\r\n0未填写，1已填写");

                entity.Property(e => e.WorkedMonth).HasComment("曾工作的月份");

                entity.Property(e => e.WorkedYear).HasComment("曾工作的年份");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("邮政编码");
            });

            modelBuilder.Entity<MyResumeAnalysisRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_ResumeAnalysisRecord");

                entity.Property(e => e.AnalysisDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyResumeBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Resume_back");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.CardNum).HasMaxLength(18);

                entity.Property(e => e.CareerDirection).HasColumnType("text");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComputerSkills).HasColumnType("text");

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EatHouseNeeded).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Homepage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.HometownC).HasColumnName("Hometown_C");

                entity.Property(e => e.HometownP).HasColumnName("Hometown_P");

                entity.Property(e => e.Imnum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMNum");

                entity.Property(e => e.Interesting).HasColumnType("text");

                entity.Property(e => e.JobSeeking)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.LocationT).HasColumnName("Location_T");

                entity.Property(e => e.MobileNum).HasMaxLength(50);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OtherNeeded)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSkills).HasColumnType("text");

                entity.Property(e => e.PartComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionName).HasMaxLength(15);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SelfDescription).HasColumnType("text");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<MyResumeEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Resume_Eng");

                entity.Property(e => e.Address)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.CardNum).HasMaxLength(18);

                entity.Property(e => e.CareerDirection).HasColumnType("text");

                entity.Property(e => e.CheckDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ComputerSkills).HasColumnType("text");

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EatHouseNeeded).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Homepage)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.HometownC).HasColumnName("Hometown_C");

                entity.Property(e => e.HometownP).HasColumnName("Hometown_P");

                entity.Property(e => e.Imnum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMNum");

                entity.Property(e => e.Interesting).HasColumnType("text");

                entity.Property(e => e.JobSeeking)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.LocationT).HasColumnName("Location_T");

                entity.Property(e => e.MobileNum).HasMaxLength(50);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OtherNeeded)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSkills).HasColumnType("text");

                entity.Property(e => e.PartComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionName).HasMaxLength(15);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SelfDescription).HasColumnType("text");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<MyResumeKeyWord>(entity =>
            {
                entity.HasKey(e => e.MyUserId)
                    .HasName("PK__My_Resum__C37F3CC21C9D15DC");

                entity.ToTable("My_Resume_KeyWord");

                entity.HasComment("个人简历关键词");

                entity.Property(e => e.MyUserId).ValueGeneratedNever();

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("新增时间");

                entity.Property(e => e.Certification)
                    .HasMaxLength(800)
                    .HasComment("技能证书");

                entity.Property(e => e.IndividualStrengths)
                    .HasMaxLength(1800)
                    .HasComment("个人优势");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(2000)
                    .HasComment("工作内容");

                entity.Property(e => e.Major)
                    .HasMaxLength(1500)
                    .HasComment("主修课程");

                entity.Property(e => e.NoMatch).HasComment("无对应匹配岗位");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<MyResumeOldText>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Resume_OldText");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.EduText).HasMaxLength(2000);

                entity.Property(e => e.WorkText).HasMaxLength(2000);
            });

            modelBuilder.Entity<MyResumePerNameRecord>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Resume_PerNameRecord");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.NewPerName).HasMaxLength(50);

                entity.Property(e => e.OldPerName).HasMaxLength(50);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyResumeReceipt>(entity =>
            {
                entity.ToTable("My_Resume_Receipt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackTime).HasColumnType("smalldatetime");

                entity.Property(e => e.MessageSendTime).HasColumnType("smalldatetime");

                entity.Property(e => e.MobileNum).HasMaxLength(50);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyResumeUploadRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_ResumeUploadRecord");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.UploadDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UploadFile)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UploadName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyResumeZph>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("My_Resume_Zph");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DepartmentsId).HasColumnName("DepartmentsID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.HasSendSms)
                    .HasColumnName("HasSendSMS")
                    .HasComment("是否发送短信");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProfessionalId).HasColumnName("ProfessionalID");

                entity.Property(e => e.SchoolId).HasColumnName("SchoolID");

                entity.Property(e => e.SignDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SmssendTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SMSSendTime")
                    .HasComment("短信发送时间");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MyResumeZphReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Resume_Zph_Receipt");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Smsreceipt)
                    .HasColumnName("SMSReceipt")
                    .HasComment("短信回执");

                entity.Property(e => e.SmsreceiptTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SMSReceiptTime");

                entity.Property(e => e.WxReceipt).HasComment("微信回执");

                entity.Property(e => e.WxReceiptTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MySearcher>(entity =>
            {
                entity.ToTable("My_Searcher");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Calling)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IncludeDegree)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IncludeSalary)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IncludeWorkedYear)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobFunction)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyWord)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosType).HasDefaultValueSql("((3))");

                entity.Property(e => e.SearcherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MySendResumeHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_SendResumeHistory");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LetterContent).HasColumnType("text");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OtherRequest).HasColumnType("text");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MyShouJiBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_ShouJiBack");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");
            });

            modelBuilder.Entity<MySm>(entity =>
            {
                entity.ToTable("My_SMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SentTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MySource>(entity =>
            {
                entity.ToTable("My_Source");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyStore>(entity =>
            {
                entity.ToTable("My_Store");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.MobileNum).HasMaxLength(50);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StoreState).HasComment("0正常 1待定 2待定 3删除 4黑名单");
            });

            modelBuilder.Entity<MySysSubscribe>(entity =>
            {
                entity.ToTable("My_SysSubscribe");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromUserName)
                    .HasMaxLength(50)
                    .HasComment("用户openid");

                entity.Property(e => e.PopupScene)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('0')")
                    .HasComment("弹框场景，0代表在小程序页面内");

                entity.Property(e => e.SubType).HasComment("1 新职位发布 2 收到面试邀请通知 3简历被下载 4简历被游览");

                entity.Property(e => e.SubscribeStatusString)
                    .HasMaxLength(50)
                    .HasComment("订阅结果（accept接收；reject拒收）");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(50)
                    .HasComment("模板id（一次订阅可能有多个id）");

                entity.Property(e => e.ToUserName)
                    .HasMaxLength(50)
                    .HasComment("小程序帐号ID");
            });

            modelBuilder.Entity<MyTraceRecord>(entity =>
            {
                entity.ToTable("My_TraceRecord");

                entity.Property(e => e.MemFlag).HasComment("0未读,1未筛选,2通过,3不通过,4待定,5放入了人才库中,6删除");

                entity.Property(e => e.SendIm).HasColumnName("SendIM");

                entity.Property(e => e.TraceDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("getdate()");

                entity.Property(e => e.TraceTable)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TraceType).HasComment("0全部; 1 应聘 ;2 IM消息; 3 收藏; 4游览;5系统推荐 ;6客服推介 ;  7兼职应聘");
            });

            modelBuilder.Entity<MyTraceRecordDelBacke>(entity =>
            {
                entity.ToTable("My_TraceRecord_Del_Backe");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MemFlag).HasComment("0未读,1未筛选,2通过,3不通过,4待定,5放入了人才库中,6删除");

                entity.Property(e => e.SendIm).HasColumnName("SendIM");

                entity.Property(e => e.TraceDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("getdate()");

                entity.Property(e => e.TraceTable)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TraceType).HasComment("0全部; 1 应聘 ;2 IM消息; 3 收藏; 4游览;5系统推荐 ;6客服推介 ;  7兼职应聘");
            });

            modelBuilder.Entity<MyTraining>(entity =>
            {
                entity.ToTable("My_Training");

                entity.HasIndex(e => e.MyUserId, "PK_My_Training_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.Certificate).HasMaxLength(50);

                entity.Property(e => e.Course).HasMaxLength(30);

                entity.Property(e => e.EduMemo).HasMaxLength(1000);

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Organization).HasMaxLength(30);
            });

            modelBuilder.Entity<MyTrainingEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Training_Eng");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.Certificate).HasMaxLength(50);

                entity.Property(e => e.Course).HasMaxLength(30);

                entity.Property(e => e.EduMemo).HasMaxLength(1000);

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Organization).HasMaxLength(30);
            });

            modelBuilder.Entity<MyUploadFile>(entity =>
            {
                entity.ToTable("My_UploadFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilePath).HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Memo).HasMaxLength(500);

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<MyUser>(entity =>
            {
                entity.ToTable("My_Users");

                entity.HasIndex(e => e.CheckFlag, "IX_My_Users_CheckFlag");

                entity.HasIndex(e => e.Email, "IX_My_Users_Email");

                entity.HasIndex(e => e.PhoneNum, "IX_My_Users_PhoneNum");

                entity.HasIndex(e => e.LastLoginDate, "PK_My_User_LD");

                entity.HasIndex(e => e.RegisterDate, "PK_My_User_RD");

                entity.HasIndex(e => e.RegisterFrom, "PK_My_User_RegisterFrom");

                entity.HasIndex(e => e.UserName, "PK_My_Users_UserName");

                entity.HasIndex(e => new { e.UserName, e.Password }, "ix_index_My_Users_UserPass");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID")
                    .HasComment("个人帐号编号");

                entity.Property(e => e.BelongType).HasComment("简历所属 0为俊才 1为大岗 2为南沙 3为百度 4黄阁");

                entity.Property(e => e.CheckFlag).HasComment("0=未完成注册，1=待审核，2=审核通过，3=审核不通过，4=更新后待复审");

                entity.Property(e => e.ContactStatus).HasComment("0=公开，1=保密联系方式");

                entity.Property(e => e.DisplayFlag).HasComment("0=正试注册的(培训和教育及工作经历按表显示)，1=copy来的，按字段显示			");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("电子邮件地址");

                entity.Property(e => e.EngResumeFlag).HasComment("0=无英文简历，1=显示英文简历，2=隐藏英文简历");

                entity.Property(e => e.IsAuEmail).HasColumnName("isAuEmail");

                entity.Property(e => e.IsAuPhone).HasColumnName("isAuPhone");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("最后登录日期");

                entity.Property(e => e.LoginCount).HasComment("登录次数");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')")
                    .HasComment("密码");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiveMailType).HasComment("0=简体内码，1=繁体内码			");

                entity.Property(e => e.RegisterBy).HasComment("注册来源");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("账号注册日期");

                entity.Property(e => e.RegisterFrom).HasComment("0：PC 1：触摸版 2：安卓 3：苹果 5：小程序 7百度简历 8百度小程序 9今日头条 12 支付宝小程序 14 番禺小程序 15南沙小程序 20招聘会");

                entity.Property(e => e.RequestVideoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ResumeStatus).HasComment("0=正常，1=隐藏简历，2=对指定的企业隐藏，3=待删除");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("用户名");
            });

            modelBuilder.Entity<MyUserType>(entity =>
            {
                entity.ToTable("MyUserType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyTypeId).HasColumnName("MyTypeID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<MyUsersBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_Users_Back");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsAuEmail).HasColumnName("isAuEmail");

                entity.Property(e => e.IsAuPhone).HasColumnName("isAuPhone");

                entity.Property(e => e.LastLoginDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyVideo>(entity =>
            {
                entity.ToTable("My_Video");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Eid)
                    .HasColumnName("EId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LongTime).HasMaxLength(50);

                entity.Property(e => e.RejectReason).HasMaxLength(250);

                entity.Property(e => e.Vheight).HasColumnName("VHeight");

                entity.Property(e => e.Vwidth).HasColumnName("VWidth");
            });

            modelBuilder.Entity<MyViewContact>(entity =>
            {
                entity.ToTable("My_ViewContact");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ViewDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyViewPosCount>(entity =>
            {
                entity.ToTable("My_ViewPosCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ViewDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyWapRegisterLog>(entity =>
            {
                entity.ToTable("My_WapRegister_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MyWorkExp>(entity =>
            {
                entity.ToTable("My_WorkExp");

                entity.HasIndex(e => e.MyUserId, "PK_My_WorkExp_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComIntroduction)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ComSize).HasDefaultValueSql("('')");

                entity.Property(e => e.ComType).HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(7)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LeftReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MyWorkExpEng>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("My_WorkExp_Eng");

                entity.Property(e => e.BeginDate).HasMaxLength(7);

                entity.Property(e => e.ComIntroduction).HasMaxLength(200);

                entity.Property(e => e.ComName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndDate).HasMaxLength(7);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeftReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtherPo>(entity =>
            {
                entity.ToTable("Other_Pos");

                entity.Property(e => e.CompanyFullName)
                    .HasMaxLength(50)
                    .HasColumnName("companyFullName");

                entity.Property(e => e.CompanyId).HasColumnName("companyId");

                entity.Property(e => e.JcPosId).HasColumnName("jcPosId");

                entity.Property(e => e.PositionId).HasColumnName("positionId");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .HasColumnName("positionName");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(50)
                    .HasColumnName("sourceName");

                entity.Property(e => e.SourceType)
                    .HasColumnName("sourceType")
                    .HasComment("0 俊才 1.前程 2.boss 3.58 4.智联 5拉钩");
            });

            modelBuilder.Entity<OuterResumeAccount>(entity =>
            {
                entity.ToTable("OuterResume_Account");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("账号名称");

                entity.Property(e => e.BelongCalling)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasComment("所属行业");

                entity.Property(e => e.BelongCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("所属公司");

                entity.Property(e => e.BindPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatorId).HasComment("开户负责人");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("到期时间");

                entity.Property(e => e.ManagerId).HasComment("管理人员Id");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsiblePerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasComment("网站ID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("网站名称");

                entity.Property(e => e.Status).HasComment("状态：0 正常 ；1 已过期 ；-1 冻结");
            });

            modelBuilder.Entity<OuterResumeApplyPosManager>(entity =>
            {
                entity.ToTable("OuterResume_ApplyPosManager");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("账号");

                entity.Property(e => e.ApplicantName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("申请人");

                entity.Property(e => e.ApplyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CheckFlag).HasComment("审核状态：1 待审核 ；2 已发布 ；3 已拒绝 ；4 已结束 ；");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("岗位联系人");

                entity.Property(e => e.ContactPersonPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("联系电话");

                entity.Property(e => e.HasUpLoadCount).HasComment("已上传简历数量");

                entity.Property(e => e.IsHeadhuntPos).HasComment("是否是猎才岗位");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PosName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PublishChannel).HasComment("发布渠道：12 boos ；13 智联 ；14 前程");

                entity.Property(e => e.PublishChannelName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("发布渠道名");

                entity.Property(e => e.ReceiveEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("简历接收邮箱");

                entity.Property(e => e.YetPublishPositionInfo)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("俊才网未发布的岗位信息，此时PosID为随机生成");
            });

            modelBuilder.Entity<OuterResumeResume>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OuterResume_Resume");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InputDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PushCount).HasComment("推介数");

                entity.Property(e => e.ResumeStatus).HasComment("简历状态：0 正常；1 已过期 ；-1 冻结");

                entity.Property(e => e.ResumeTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Source).HasComment("来源网站：12 boos ；13 智联 ；14 前程");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OuterResumeResumeOperationLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OuterResume_ResumeOperationLog");

                entity.HasComment("简历操作记录");

                entity.Property(e => e.DptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EplName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OperationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OperationLog)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OuterResumeUploadResumeLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OuterResume_UploadResumeLog");

                entity.HasComment("岗位上传简历记录");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UploadEplId).HasComment("简历上传人ID");

                entity.Property(e => e.ViewFlag).HasComment("查看状态，0未读；1已读");
            });

            modelBuilder.Entity<PicGoodjob>(entity =>
            {
                entity.ToTable("PicGoodjob");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CoverPhotoPath).HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<PicGoodjobWithPic>(entity =>
            {
                entity.ToTable("PicGoodjob_WithPic");

                entity.Property(e => e.BigPicSize).HasMaxLength(10);

                entity.Property(e => e.PhotoPath).HasMaxLength(200);

                entity.Property(e => e.SmallPicSize).HasMaxLength(10);
            });

            modelBuilder.Entity<PubComplaint>(entity =>
            {
                entity.ToTable("Pub_Complaints");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ProcessingDetail)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalerUserId).HasColumnName("SalerUserID");

                entity.Property(e => e.SalerUserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubFunctionUseRecord>(entity =>
            {
                entity.ToTable("Pub_FunctionUseRecord");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fcount).HasColumnName("FCount");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PubHelpItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_HelpItem");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubHelpTopic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_HelpTopic");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Answer).HasColumnType("text");

                entity.Property(e => e.IssuerId).HasColumnName("IssuerID");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Question)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<PubHxDynamicRecording>(entity =>
            {
                entity.ToTable("Pub_Hx_DynamicRecording");

                entity.Property(e => e.ConfrId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreadteDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DynamicType).HasComment("0常规 1应聘简历 2视频排队申请  3咨询消息发送 4视频面试请求 5取消视频排队申请 6视频面试中 7视频面试挂断结束");

                entity.Property(e => e.Explain)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid)
                    .HasColumnName("PId")
                    .HasComment("招聘会id");

                entity.Property(e => e.VideoTime)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PubImRoaming>(entity =>
            {
                entity.ToTable("Pub_IM_Roaming");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoamingTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PubImRoamingLog>(entity =>
            {
                entity.ToTable("Pub_IM_Roaming_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direction).HasComment("消息方向，即该消息是企业发送的还是接收的：1 发送,2 接收");

                entity.Property(e => e.InsertTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("消息时间");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<PubInformation>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.ToTable("Pub_Information");

                entity.Property(e => e.InfoId).HasColumnName("InfoID");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssuedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.PosType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.Reader)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalerId).HasColumnName("SalerID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PubInformationMy>(entity =>
            {
                entity.HasKey(e => e.InfoId);

                entity.ToTable("Pub_Information_My");

                entity.Property(e => e.InfoId).HasColumnName("InfoID");

                entity.Property(e => e.ClerkId).HasColumnName("ClerkID");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssuedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
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

                entity.Property(e => e.MyRefuseReason)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("录用拒绝理由，默认为null");

                entity.Property(e => e.MyResultFlag).HasComment("1 未读； 2 已读待确认；3 已读已确认 ；4 已读已拒绝 ");

                entity.Property(e => e.MyResultTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("个人面试结果反馈时间");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.OfferLetterId)
                    .HasColumnName("OfferLetterID")
                    .HasComment("录用通知书详情");

                entity.Property(e => e.PerFlag).HasComment("4 拒绝 3接受 0默认 1未读 2已读");

                entity.Property(e => e.PerTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ResultFlag).HasComment("1 被放鸽子; 2面试通过; 5 已发offer;3 淘汰/放弃;4结果待定");

                entity.Property(e => e.ResultTime)
                    .HasColumnType("smalldatetime")
                    .HasComment("企业面试结果确定时间");
            });

            modelBuilder.Entity<PubInterviewingZph>(entity =>
            {
                entity.ToTable("Pub_Interviewing_Zph");

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

                entity.Property(e => e.PerFlag).HasComment("4 拒绝 3接受 0默认 1未读 2已读");

                entity.Property(e => e.PerTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<PubInterviewingZphVideo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_InterviewingZphVideo");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MemState).HasComment("企业是否同意状态");

                entity.Property(e => e.MyUserState).HasComment("用户是否同意状态 1同意 2 拒绝");

                entity.Property(e => e.MyUserStateUpTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PubApplyZphTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PubMemOnline>(entity =>
            {
                entity.ToTable("Pub_MemOnline");

                entity.Property(e => e.RefreshDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Refresh_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PubMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("Pub_Message");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MessageString)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MessageTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageType).HasComment("1 My 2 Hr");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<PubPerApplyPo>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos");

                entity.HasIndex(e => e.ReceiveDate, "PK_Pub_PerApplyPos_Date");

                entity.HasIndex(e => e.MemFlag, "PK_Pub_PerApplyPos_MemFlag");

                entity.HasIndex(e => e.MemId, "PK_Pub_PerApplyPos_MemID");

                entity.HasIndex(e => e.MyUserId, "PK_Pub_PerApplyPos_MyUserID");

                entity.HasIndex(e => e.PosId, "PK_Pub_PerApplyPos_PosID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommendType).HasComment("0 正常应聘 2模拟应聘 3兼职应聘");

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

            modelBuilder.Entity<PubPerApplyPosBack>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos_back");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

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

            modelBuilder.Entity<PubPerApplyPosBackDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_PerApplyPos_back_del");

                entity.Property(e => e.CommendType).HasComment("0 正常应聘 2模拟应聘 3兼职应聘");

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

            modelBuilder.Entity<PubPerApplyPosPt>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos_PT");

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

            modelBuilder.Entity<PubPerApplyPosSub>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pub_PerApplyPos_Sub");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PosId).HasColumnName("PosID");
            });

            modelBuilder.Entity<PubPerApplyPosVideo>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos_Video");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PubPerApplyPosZph>(entity =>
            {
                entity.ToTable("Pub_PerApplyPos_Zph");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApplyType).HasComment("2为应聘 3为咨询");

                entity.Property(e => e.ConfrId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("会议是ID");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PerTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.ReceiveCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.VideoApplyState).HasComment("0  1;//.企业未确认（按钮显示： 待确认） 2;//企业已确认  （按钮显示：发起视频） 3;//企业已拒绝     （按钮显示:  已拒绝）");

                entity.Property(e => e.VideoBegDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VideoDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VideoEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VideoLaunch).HasComment("0 个人 1企业");

                entity.Property(e => e.VideoMinute)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("视频面试分钟");

                entity.Property(e => e.VideoMinuteString)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PubPerEvaluation>(entity =>
            {
                entity.ToTable("Pub_PerEvaluation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.EvaluateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EvaluationMessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.ReplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReplyMessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PubPhoneNumBlack>(entity =>
            {
                entity.ToTable("Pub_PhoneNumBlack");

                entity.Property(e => e.CreaDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNum).HasMaxLength(50);
            });

            modelBuilder.Entity<PubRecordSession>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Pub_RecordSession");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.SendDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PubResumeBrowsedLog>(entity =>
            {
                entity.ToTable("Pub_ResumeBrowsedLog");

                entity.HasIndex(e => e.LatestBrowsedDate, "PK_Pub_ResumeBrowsedLog_Date");

                entity.HasIndex(e => e.MemId, "PK_Pub_ResumeBrowsedLog_MemID");

                entity.HasIndex(e => e.MyUserId, "PK_Pub_ResumeBrowsedLog_MyUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LatestBrowsedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");

                entity.Property(e => e.PerTime).HasColumnType("datetime");
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

            modelBuilder.Entity<PubServiceHelp>(entity =>
            {
                entity.ToTable("Pub_Service_Help");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HelpMemo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HelpTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReplyMemo)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tel)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<PubServiceHelpRecord>(entity =>
            {
                entity.ToTable("Pub_Service_Help_Record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createtime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Massage)
                    .HasMaxLength(100)
                    .HasColumnName("massage");

                entity.Property(e => e.Memid).HasColumnName("memid");

                entity.Property(e => e.Recordid).HasColumnName("recordid");
            });

            modelBuilder.Entity<PubStraightCast>(entity =>
            {
                entity.ToTable("Pub_StraightCast");

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.Uid)
                    .HasMaxLength(50)
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<PubUserqdRecord>(entity =>
            {
                entity.ToTable("Pub_UserqdRecord");

                entity.Property(e => e.QdDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("qdDate");
            });

            modelBuilder.Entity<QdResult>(entity =>
            {
                entity.ToTable("qdResult");

                entity.Property(e => e.QdTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Result).HasMaxLength(20);
            });

            modelBuilder.Entity<RecomMyuserId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RecomMyuserID");

                entity.Property(e => e.ComDate).HasColumnType("datetime");

                entity.Property(e => e.LocationC).HasColumnName("Location_C");

                entity.Property(e => e.LocationP).HasColumnName("Location_P");

                entity.Property(e => e.MyuserId).HasColumnName("MyuserID");

                entity.Property(e => e.PerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RecommendQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RecommendQueue");

                entity.Property(e => e.DataType).HasComment("队列数据类型，1为企业，2为个人");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalerTel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("企业对应业务员号码，个人无此项");

                entity.Property(e => e.SalerUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("企业对应业务员，个人无此项");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecommendedRecord>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RecommendDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RecommendTimes).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasComment("数据类型，1为企业，2为个人");
            });

            modelBuilder.Entity<RecruitmentRegister>(entity =>
            {
                entity.ToTable("RecruitmentRegister");

                entity.Property(e => e.Address).HasMaxLength(80);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esid).HasColumnName("ESId");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PosName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegisterSign>(entity =>
            {
                entity.ToTable("RegisterSign");

                entity.HasComment("存储登记失业标签");

                entity.Property(e => e.BelongType).HasComment("1 大岗，2 南沙，4 黄阁");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Esid)
                    .HasColumnName("ESId")
                    .HasComment("录入驿站ID");

                entity.Property(e => e.Type).HasComment("1 失业人员 2 退伍军人");
            });

            modelBuilder.Entity<SelfServiceOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Self_Service_Orders");

                entity.Property(e => e.Detail).HasMaxLength(3000);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(64)
                    .HasColumnName("Out_trade_no");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TotalAmout)
                    .HasMaxLength(50)
                    .HasColumnName("Total_amout");
            });

            modelBuilder.Entity<SeoUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Seo_Url");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SeoUrlId).HasColumnName("SeoUrlID");
            });

            modelBuilder.Entity<SetArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SetArea");

                entity.Property(e => e.AddressC).HasColumnName("Address_C");

                entity.Property(e => e.AddressP).HasColumnName("Address_P");

                entity.Property(e => e.AreaEnName).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.Comprehensive)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Focus)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keywords).HasMaxLength(1000);

                entity.Property(e => e.PosidAll)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.TitleC)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Title_C");

                entity.Property(e => e.TitleD)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Title_D");

                entity.Property(e => e.TitleL)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Title_L");

                entity.Property(e => e.TitleR)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Title_R");

                entity.Property(e => e.TitleT)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Title_T");

                entity.Property(e => e.Yngeneration)
                    .HasMaxLength(10)
                    .HasColumnName("YNGeneration")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SetLevel>(entity =>
            {
                entity.ToTable("SetLevel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CAboutO)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_about_o");

                entity.Property(e => e.CAboutS)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_about_s");

                entity.Property(e => e.CAboutT)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_about_t");

                entity.Property(e => e.CBanner)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_banner");

                entity.Property(e => e.CBottom)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_bottom");

                entity.Property(e => e.CButton)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_button");

                entity.Property(e => e.CLogo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_logo");

                entity.Property(e => e.CMiddle)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_middle");

                entity.Property(e => e.CName)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_Name");

                entity.Property(e => e.CProduct)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_product");

                entity.Property(e => e.CTop)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("C_top");

                entity.Property(e => e.CnLogo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("CN_logo");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Keywords).HasMaxLength(1000);

                entity.Property(e => e.MemId).HasColumnName("MemID");

                entity.Property(e => e.MemName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PosIdall)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PosIDAll");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.Yncreate)
                    .HasMaxLength(10)
                    .HasColumnName("YNCreate")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SiteType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SiteType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.SiteType1)
                    .HasMaxLength(100)
                    .HasColumnName("SiteType");
            });

            modelBuilder.Entity<Sqlmapoutput>(entity =>
            {
                entity.ToTable("sqlmapoutput");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(4000)
                    .HasColumnName("data");
            });

            modelBuilder.Entity<StatPromote>(entity =>
            {
                entity.HasKey(e => e.PromoteId);

                entity.ToTable("Stat_Promote");

                entity.Property(e => e.PromoteId).HasColumnName("promoteID");

                entity.Property(e => e.CountNum).HasColumnName("countNum");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("openDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PromoteType).HasColumnName("promoteType");
            });

            modelBuilder.Entity<StatPromoteResume>(entity =>
            {
                entity.HasKey(e => e.PromoteId);

                entity.ToTable("Stat_PromoteResume");

                entity.Property(e => e.PromoteId).HasColumnName("promoteID");

                entity.Property(e => e.ComRegNum).HasColumnName("comRegNum");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("openDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonalRegNum).HasColumnName("personalRegNum");

                entity.Property(e => e.PromoteType).HasColumnName("promoteType");

                entity.Property(e => e.ResumeId).HasColumnName("resumeID");
            });

            modelBuilder.Entity<SysMatchingMem>(entity =>
            {
                entity.ToTable("Sys_MatchingMem");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysRegisterFrom>(entity =>
            {
                entity.HasKey(e => e.MyUserId);

                entity.ToTable("Sys_RegisterFrom");

                entity.Property(e => e.MyUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyUserID");

                entity.Property(e => e.RegisterFrom).HasComment("1.赶集,2.58,3.51job,4.南方/番禺人才网,5.智联招聘,6.门店,7.现场招聘,8.黄阁镇人社局,9.达内教育培训(省人才),10未知 11未知 12 boss,13 智联 14 前程 17南沙驿站  100.其他,");

                entity.Property(e => e.RegisterFromDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SysSalerDownload>(entity =>
            {
                entity.ToTable("Sys_SalerDownloads");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrowseTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MyUserId)
                    .HasColumnName("MyUserID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalerId)
                    .HasColumnName("SalerID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TableMaxId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableMaxID");

                entity.Property(e => e.MaxId).HasColumnName("MaxID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempID");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<TemplateSet>(entity =>
            {
                entity.ToTable("TemplateSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TemplateCoding).HasMaxLength(100);

                entity.Property(e => e.TemplateConnten).HasColumnType("text");

                entity.Property(e => e.TemplateFormat).HasMaxLength(100);

                entity.Property(e => e.TemplateName).HasMaxLength(100);

                entity.Property(e => e.TemplateSiteName).HasMaxLength(100);

                entity.Property(e => e.TemplateType).HasMaxLength(100);
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.ToTable("TemplateType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteType).HasMaxLength(100);

                entity.Property(e => e.TemplateType1)
                    .HasMaxLength(100)
                    .HasColumnName("TemplateType");

                entity.Property(e => e.TemplateTypeEn)
                    .HasMaxLength(100)
                    .HasColumnName("TemplateTypeEN");
            });

            modelBuilder.Entity<TopicMemInfo>(entity =>
            {
                entity.HasKey(e => e.MemId);

                entity.ToTable("Topic_MemInfo");

                entity.Property(e => e.MemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<TouchFeedBack>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("Touch_FeedBack");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.FeedContact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FeedDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MyUserId).HasColumnName("MyUserID");
            });

            modelBuilder.Entity<WapLoginLog>(entity =>
            {
                entity.HasKey(e => e.MyuserId);

                entity.ToTable("Wap_Login_Log");

                entity.Property(e => e.MyuserId)
                    .ValueGeneratedNever()
                    .HasColumnName("MyuserID");

                entity.Property(e => e.LastCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.LastReFreshDate).HasColumnType("datetime");

                entity.Property(e => e.Logincount).HasColumnName("logincount");

                entity.Property(e => e.MyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sxcount).HasColumnName("sxcount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
