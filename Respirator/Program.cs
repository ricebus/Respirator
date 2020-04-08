using System;
using System.IO;
using BinarySerialization;
using Respirator.Lib;

namespace Respirator.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "0Foo.txt";
            var binarySerializer = new BinarySerializer();
            var fileStream = new FileStream(fileName, FileMode.Open);
            var resp = binarySerializer.Deserialize<Lib.Respirator>(fileStream);
            Console.WriteLine($"UniqueID: {resp.UniqueId}");
            Console.WriteLine($"DeviceType: {resp.DeviceType}");
            Console.WriteLine($"SerialNumber: {resp.SerialNumber}");
            foreach(EField field in resp.Fields)
                Console.WriteLine($"Key {field.Key}: {field.Value.ToString()}");
        }
    }
}
