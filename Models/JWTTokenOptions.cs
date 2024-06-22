using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JWTTokenOptions
    {
        public string Audience { get; set; } = null!;
        public string Isuser { get; set; } = null!;
        public string SecurityKey { get; set; } = null!;


    }
}
