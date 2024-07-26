using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Base
{
    public partial class BaseMemPosJobLocation
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int JobLocationP { get; set; }
        public int JobLocationC { get; set; }
    
    }
}
