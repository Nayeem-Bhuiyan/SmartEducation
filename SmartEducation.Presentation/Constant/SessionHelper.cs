using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Presentation.Constant
{
    public static class SessionHelper
    {

        private const string _pRefix = "_session_SmartEducation";


        public static T Get<T>(this ISession session, string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            var ret = session.Get(key.SafeKey());
            if (ret != null)
            {
                return ret.Deserializer<T>();
            }

            return default;
        }

        public static void Set(this ISession session, string key, object value)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            var data = value.Serializer();
            session.Set(key.SafeKey(), data);
        }

        public static void SetString(this ISession session, string key, string value)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            session.SetString(key.SafeKey(), value);
        }

        public static string GetString(this ISession session, string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            return session.GetString(key.SafeKey());
        }

        public static void Remove(this ISession session, string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            session.Remove(key.SafeKey());
        }
    }

    internal static class SessionExtension
    {
        //public static byte[] Serializer(this object _object)
        //{
        //    byte[] bytes;
        //    using (var _MemoryStream = new MemoryStream())
        //    {
        //        IFormatter _BinaryFormatter = new BinaryFormatter();
        //        _BinaryFormatter.Serialize(_MemoryStream, _object);
        //        bytes = _MemoryStream.ToArray();
        //    }
        //    return bytes;
        //}
        public static byte[] Serializer(this object _object)
        {
            string json = JsonConvert.SerializeObject(_object); // Using JSON.NET library
            return Encoding.UTF8.GetBytes(json);
        }


        //public static T Deserializer<T>(this byte[] _byteArray)
        //{
        //    T ReturnValue;
        //    using (var _MemoryStream = new MemoryStream(_byteArray))
        //    {
        //        IFormatter _BinaryFormatter = new BinaryFormatter();
        //        ReturnValue = (T)_BinaryFormatter.Deserialize(_MemoryStream);
        //    }
        //    return ReturnValue;
        //}
        public static T Deserializer<T>(this byte[] _byteArray)
        {
            string json = Encoding.UTF8.GetString(_byteArray);
            return JsonConvert.DeserializeObject<T>(json); // Using JSON.NET library
        }

        internal static string SafeKey(this string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            return $"_redis_yoursitename_{key}";
        }
    }
}
