namespace Finance.Core.Common
{
    public static class DateTimeExtension
    {
        public static DateTime GetFirstDay(this DateTime date, int? year = null, int? month = null)
        {
            var targetYear = year ?? date.Year;
            var targetMonth = month ?? date.Month;

            return new DateTime(targetYear, targetMonth, 1);
        }

        public static DateTime GetLastDay(this DateTime date, int? year = null, int? month = null)
        {
            var targetYear = year ?? date.Year;
            var targetMonth = month ?? date.Month;

            return new DateTime(targetYear, targetMonth, 1)
                .AddMonths(1)
                .AddDays(-1);
        }
    }
}
