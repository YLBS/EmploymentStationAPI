using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PubInfoType
    {
        public PubInfoType()
        {
            PubInformations = new HashSet<PubInformation>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; } = null!;
        public int IssuedArea { get; set; }
        public string? AreaRemark { get; set; }

        public virtual ICollection<PubInformation> PubInformations { get; set; }
    }
}
