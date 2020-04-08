using BinarySerialization;

namespace Respirator.Lib
{
    class EFloat : EType
    {
        [FieldOrder(0)]

        public float Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
