using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SysHtmlLabel
    {
        public int Id { get; set; }
        public string LabelName { get; set; } = null!;
        public int TemplateId { get; set; }
        public int ParentId { get; set; }
        public int DataRecordCount { get; set; }
        public string IdField { get; set; } = null!;
        public string TitleField { get; set; } = null!;
        public string ClassNameField { get; set; } = null!;
        public string ImageField { get; set; } = null!;
        public string UrlField { get; set; } = null!;
        public string TimeField { get; set; } = null!;
        public string OtherField { get; set; } = null!;
        public string DataTable { get; set; } = null!;
        public string DataCondition { get; set; } = null!;
        public string AreaSiteConditionField { get; set; } = null!;
        public string DataGroup { get; set; } = null!;
        public string DataOrder { get; set; } = null!;
        public int TitleLength { get; set; }
        public int AllTitleLength { get; set; }
        public int RowRecordCount { get; set; }
        public DateTime AddTime { get; set; }
        public bool AutoRefresh { get; set; }
        public bool Disabled { get; set; }
    }
}
