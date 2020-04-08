using BinarySerialization;

namespace Respirator.Lib
{
    public class EField
    {
        [FieldOrder(0)]
        public ushort Key { get; set; }
        [FieldOrder(1)]
        public EValueType ValueType { get; set; }
        [FieldOrder(2)]
        [Subtype("ValueType", EValueType.eFloat, typeof(EFloat))]
        [Subtype("ValueType", EValueType.eInteger, typeof(EInteger))]
        [Subtype("ValueType", EValueType.eString, typeof(EString))]
        public EType Value { get; set; }
    }
}
