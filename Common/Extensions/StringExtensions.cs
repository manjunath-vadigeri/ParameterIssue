
namespace CG.UI.Common.Extensions
{
    public static class StringExtensions
    {
        public static uint ToUInt(this string value)
        {
            _ = uint.TryParse(value, out uint numericValue);
            return numericValue;
        }
    }
}