using System.Text;

namespace StringBuilderPerformance
{
    public class Util
    {
        private static readonly string LONG_STRING = "LongString!";
        public static string LongStringAppendWithStringBuilder(int n)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                sb.Append(LONG_STRING);
            }
            return sb.ToString();
        }


        public static string LongStringAppendWithString(int n)
        {
            var sb = string.Empty;
            for (int i = 0; i < n; i++)
            {
                sb += LONG_STRING;
            }
            return sb;
        }

        public static string LongStringPrependWithStringBuilder(int n)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Insert(0, LONG_STRING);
            }
            return sb.ToString();
        }

        public static string LongStringPrependWithString(int n)
        {
            var sb = string.Empty;
            for (int i = 0; i < n; i++)
            {
                sb = LONG_STRING + sb;
            }
            return sb;
        }
    }
}
