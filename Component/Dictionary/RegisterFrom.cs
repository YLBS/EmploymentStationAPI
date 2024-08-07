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
            //弃用
            {"dg",24},
            {"hg",23},
            {"ns",25},
            {"nc",26},
            //现用
            {"1",24},//大岗
            {"4",23},//黄阁
            {"2",25},//南沙
            {"5",26},//南村
        };
        /// <summary>
        /// 简历属性
        /// </summary>
        public static IDictionary<string, int> Dictionarys1 = new Dictionary<string, int>
        {
            {"1",1},//大岗
            {"4",4},//黄阁
            {"2",2},//南沙
            {"5",5},//南村
        };
    }
}
