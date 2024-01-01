namespace AkarSoftware.Resume.MVC.Helpers.ViewHelpers
{
    public static class StartAndEndDateHelper
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
    }
}
