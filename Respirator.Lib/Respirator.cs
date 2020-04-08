using System;
using System.Collections.Generic;
using BinarySerialization;

namespace Respirator.Lib
{
    public class Respirator
    {
        [FieldOrder(0)]
        public uint UniqueId { get; set; }
        [FieldOrder(1)]
        public EDeviceType DeviceType { get; set; }
        [FieldOrder(2)]
        public byte SerialNumberStringLength { get; set; }
        [FieldOrder(3)]
        [FieldLength("SerialNumberStringLength")]
        public string SerialNumber { get; set; }
        [FieldOrder(4)]
        public byte NumberOfFields { get; set; }
        [FieldOrder(5)]
        public List<EField> Fields { get; set; }


    }
}