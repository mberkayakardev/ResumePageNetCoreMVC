using System.Text.RegularExpressions;

namespace AkarSoftware.Resume.MVC.Helpers.ViewHelpers
{
    public static class ViewHelpers
    {
        public static string BaslangicBitisDonum(DateTime date1, DateTime? date2, string date1format, string date2format)
        {
            string zaman1 = string.Empty;
            string zaman2 = string.Empty;

            zaman1 = date1.ToString(date1format);

            if (date2 != null)
            {
                zaman2 = date2.Value.ToString(date2format);
            }
            else
            {
                zaman2 = "Devam etmekte";
            }
            return zaman1 + " - " + zaman2;

        }
        public static string StripHtmlTags(string html)
        {
            return Regex.Replace(html, "<.*?>", string.Empty);
        }
        public static string StripHtmlTags(string html, int SubstringLengt)
        {
            string result = Regex.Replace(html, "<.*?>", string.Empty);
            return (result.Length > SubstringLengt ? result.Substring(0, SubstringLengt) : result + "...");
        }
    }
}
