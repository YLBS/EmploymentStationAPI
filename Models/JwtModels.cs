using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JwtModels
    {
        public int Id { get; set; }
        public string EplName { get; set; } = null!;
        public string AffiliatedUnit { get; set; } = null!;
        //public string Role { get; set; } = null!;
    }
}
