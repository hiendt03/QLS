using System.Drawing;

namespace QLS
{
    internal static class ExtenssionMethods
    {
        public static Color FromHex(this string hex) =>
            ColorTranslator.FromHtml(hex);
    }
}
