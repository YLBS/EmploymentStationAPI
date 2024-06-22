using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class TableMaxId
    {
        public string TableName { get; set; } = null!;
        public int? MaxId { get; set; }
    }
}
