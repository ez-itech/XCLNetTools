﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace XCLNetTools.Serialize
{
    /// <summary>
    /// 其它对象序列化相关
    /// </summary>
    public class Lib
    {
        #region Byte相关

        /// <summary>
        /// 把字节反序列化成相应的对象
        /// </summary>
        /// <param name="pBytes">字节流</param>
        /// <returns>T</returns>
        public T DeserializeObject<T>(byte[] pBytes) where T : class
        {
            T result = default(T);
            if (pBytes == null || pBytes.Length == 0)
            {
                return result;
            }
            using (System.IO.MemoryStream memory = new System.IO.MemoryStream(pBytes))
            {
                memory.Position = 0;
                BinaryFormatter formatter = new BinaryFormatter();
                result = formatter.Deserialize(memory) as T;
            }
            return result;
        }

        #endregion Byte相关

        #region 序列化方式的深度克隆对象

        /// <summary>
        /// 对象深度clone（被clone对象必须可以序列化）
        /// </summary>
        public static T DeepClone<T>(T source) where T : class
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }
            T result = default(T);
            if (Object.ReferenceEquals(source, null))
            {
                return result;
            }
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                result = formatter.Deserialize(stream) as T;
            }
            return result;
        }

        #endregion 序列化方式的深度克隆对象
    }
}