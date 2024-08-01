using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Base
{
    public partial class BaseNewsInfoEntity
    {
        public int NewsId { get; set; }
        public string Title { get; set; } = null!;
        public string ArticleType { get; set; } = null!;
        public string ImagePath { get; set; } = "";
        public string Introduction { get; set; } = "";
        public string ContentText { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HitCount { get; set; }
        public int Matk { get; set; }
        public int UserId { get; set; }
    }
}
