using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    public static class Tools
    {
        /// <summary>
        /// 对比两个对象是否相等
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool AreObjectsEqual<T>(T obj1, T obj2) where T : class
        {
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                var val1 = property.GetValue(obj1);
                var val2 = property.GetValue(obj2);

                if (!Equals(val1, val2))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
