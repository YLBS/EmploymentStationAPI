//using Component.Dictionary;

using Goodjob.Common;

namespace Models
{
    public class OutMemPositionDto
    {
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        public byte Calling { get; set; }
        public string CallingName
        {
            get { return NameProvider.GetIndustryName(Calling); }
        }
        public byte PosState { get; set; }
        public string PosStateName
        {
            get { return NameOtherProvider.GetPosStateName(PosState); }
        }
        /// <summary>
        /// 经验要求
        /// </summary>
        public byte ReqWorkyear { get; set; }

        public string ReqWorkYearName
        {
            get { return NameProvider.GetReqWorkYearName(ReqWorkyear); }
        }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public int CandidatesNum { get; set; }
        public string CandidatesNumName
        {
            get
            {
                if (CandidatesNum == 0) return "若干";
                return CandidatesNum.ToString() + " 人";
            }
        }
        
        public int ReqDegreeId { get; set; }
        public string ReqDegreeName
        {
            get { return NameProvider.GetDegreeName(ReqDegreeId); }
        }
       

    }
}
