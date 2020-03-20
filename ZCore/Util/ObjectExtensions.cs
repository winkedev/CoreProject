using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ZCore.Util
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Create new instance of <see cref="T"/> with values of <see cref="T"/>
        /// (new instance values will have new memory references)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T CloneObject<T>(this T t) where T : class
        {
            using (MemoryStream m = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(m, t);
                m.Position = 0;
                return (T)bf.Deserialize(m);
            }
        }
    }
}
