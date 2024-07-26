using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Base
{
    public partial class BaseMemPosJobFunction
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int JobFunctionBig { get; set; }
        public int JobFunctionSmall { get; set; }
    }
}
