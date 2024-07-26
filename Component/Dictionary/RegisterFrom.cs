using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.Dictionary
{
    public class RegisterFrom
    {
        /// <summary>
        /// 失业录入来源
        /// </summary>
        public static IDictionary<string, int> Dictionarys = new Dictionary<string, int>
        {
            {"dg",15},
            {"hg",16},
            {"ns",17},
            {"1",15},
            {"4",16},
            {"2",17},
        };
        /// <summary>
        /// 简历属性
        /// </summary>
        public static IDictionary<string, int> Dictionarys1 = new Dictionary<string, int>
        {
            {"1",1},
            {"4",4},
            {"2",2},
        };
    }
}
