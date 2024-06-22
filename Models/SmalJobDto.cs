using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SmalJobDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<OutDicModels> JobList { get; set; } = null!;
    }
}
