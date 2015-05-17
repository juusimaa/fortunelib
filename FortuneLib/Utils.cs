using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FortuneLib
{
    public static class Utils
    {
        /// <summary>
        /// Get enum values as a list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        /// <summary>
        /// Serialize object using BinaryFormatter.
        /// </summary>
         /// <param name="list"></param>
        /// <param name="filename"></param>
        public static void SerializeList<T>(T @object, string filename)
        {
            try
            {
                using (var s = File.Open(filename, FileMode.Create))
                {
                    var b = new BinaryFormatter();
                    b.Serialize(s, @object);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        /// <summary>
        /// Deserialize object using BinaryFormatter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T DeserializeList<T>(string filename)
        {
            try
            {
                using (var s = File.Open(filename, FileMode.Open))
                {
                    var b = new BinaryFormatter();
                    return (T)b.Deserialize(s);
                }
            }
            catch (IOException)
            {                
                throw;
            }
        }
    }
}
