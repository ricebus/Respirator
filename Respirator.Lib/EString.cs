using BinarySerialization;

namespace Respirator.Lib
{
    public class EString : EType
    {
        [FieldOrder(0)]
        public byte Length { get; set; }
        [FieldOrder(1)]
        [FieldLength("Length")]
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
