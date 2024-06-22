using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class KeyWordSimilarity
    {
        public int MyUserId { get; set; }
        /// <summary>
        /// 简历关键字
        /// </summary>
        public string Rkey { get; set; } = null!;
        /// <summary>
        /// 岗位关键字
        /// </summary>
        public string Pkey { get; set; } = null!;
        /// <summary>
        /// 匹配结果
        /// </summary>
        public double Similarity { get; set; }
        public int PosId { get; set; }
        /// <summary>
        /// 关键字类别 1 JobDescription ； 2 IndividualStrengths ；3 Major ；4 Certification
        /// </summary>
        public int KeyWordType { get; set; }
    }
}
