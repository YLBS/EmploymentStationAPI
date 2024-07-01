using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OutDicTown
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<OutBigDicJobDto> JobList { get; set; } = null!;
    }
}
