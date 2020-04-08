using BinarySerialization;

namespace Respirator.Lib
{
    public class EInteger : EType
    {
        [FieldOrder(0)]

        public int Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
