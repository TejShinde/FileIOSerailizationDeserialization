using System;
using System.IO;

namespace FileIOAssignment
{
    internal class JsonSerializer
    {
        internal static T Deserialize<T>(FileStream fs)
        {
            throw new NotImplementedException();
        }

        internal static object Deserialize<T>(string jsonString)
        {
            throw new NotImplementedException();
        }

        internal static void Serialize<T>(FileStream fs, T prod)
        {
            throw new NotImplementedException();
        }

        internal static string Serialize(object product)
        {
            throw new NotImplementedException();
        }
    }
}