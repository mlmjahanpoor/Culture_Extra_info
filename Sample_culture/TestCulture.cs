using System.Globalization;

namespace Sample_culture;

public static class TestCulture
{
    public static void RunCulure()
    {
        #region one

        //CultureInfo enGb = new CultureInfo("en-GB");
        //CultureInfo enUs = new CultureInfo("en-US");
        //Console.WriteLine(enGb.DisplayName);
        //Console.WriteLine(enUs.DisplayName);
        //Console.WriteLine(enGb.Parent.DisplayName);
        //Console.WriteLine(enUs.Parent.DisplayName);

        #endregion one

        #region two

        //CultureInfo[] specificCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        //foreach (CultureInfo ci in specificCultures)
        //{
        //    Console.WriteLine(ci.DisplayName);
        //    Console.WriteLine(ci.Name);
        //}

        //Console.WriteLine("Total: " + specificCultures.Length);

        #endregion two

        #region three

        //CultureInfo[] neutralCultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
        //foreach (CultureInfo ci in neutralCultures)
        //    Console.WriteLine(ci.DisplayName);
        //Console.WriteLine("Total: " + neutralCultures.Length);

        #endregion three

        #region four

        //CultureInfo enUs = new CultureInfo("en-US");
        //Console.WriteLine("First day of the: " + enUs.DateTimeFormat.FirstDayOfWeek.ToString());
        //Console.WriteLine("First calendar week starts with: " + enUs.DateTimeFormat.CalendarWeekRule.ToString());

        #endregion four

        #region five

        //CultureInfo enUs = new CultureInfo("en-US");

        //foreach (string monthName in enUs.DateTimeFormat.MonthNames)
        //    Console.WriteLine(monthName);
        //Console.WriteLine("Current month: " + enUs.DateTimeFormat.GetMonthName(DateTime.Now.Month));

        #endregion five

        #region six

        //CultureInfo enUs = new CultureInfo("fa-ir");

        //foreach (string dayName in enUs.DateTimeFormat.DayNames)
        //    Console.WriteLine(dayName);
        //Console.WriteLine("Today is: " + enUs.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));

        #endregion six

        #region seven

        //CultureInfo enUs = new CultureInfo("en-US");
        //Console.WriteLine(enUs.DisplayName + ":");
        //Console.WriteLine("NumberGroupSeparator: " + enUs.NumberFormat.NumberGroupSeparator);
        //Console.WriteLine("NumberDecimalSeparator: " + enUs.NumberFormat.NumberDecimalSeparator);

        //CultureInfo deDe = new CultureInfo("de-DE");
        //Console.WriteLine(deDe.DisplayName + ":");
        //Console.WriteLine("NumberGroupSeparator: " + deDe.NumberFormat.NumberGroupSeparator);
        //Console.WriteLine("NumberDecimalSeparator: " + deDe.NumberFormat.NumberDecimalSeparator);

        #endregion seven

        #region eight

        //CultureInfo enUs = new CultureInfo("en-US");
        //Console.WriteLine(enUs.DisplayName + " - currency symbol: " + enUs.NumberFormat.CurrencySymbol);
        //CultureInfo deDe = new CultureInfo("de-DE");
        //Console.WriteLine(deDe.DisplayName + " - currency symbol: " + deDe.NumberFormat.CurrencySymbol);
        //CultureInfo ruRu = new CultureInfo("ru-RU");
        //Console.WriteLine(ruRu.DisplayName + " - currency symbol: " + ruRu.NumberFormat.CurrencySymbol);

        #endregion eight

        #region nine

        //var culture = new CultureInfo("fa-ir");

        //var d = culture.LCID;
        //Console.WriteLine(d);
        //var region = new RegionInfo("fa-ir");
        //var y = region.NativeName;
        //Console.WriteLine(y);

        #endregion nine

        #region ten

        var date = DateTime.UtcNow;
        var timeZone = "Iran Standard Time";
        var info = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
        DateTime localZone = TimeZoneInfo.ConvertTimeFromUtc(date, info);

        #endregion ten
    }

    public static DateTime GetRequestedDateTime(this DateTime utcDateTime, string timeZoneId)
    {
        var info = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, info);
    }

    public static class TimeZoneId
    {
        public static string Iran { get; } = "Iran Standard Time";
        public static string Arabian { get; } = "Arabian Standard Time";
        public static string Israel { get; } = "Israel Standard Time";
        public static string Jordan { get; } = "Jordan Standard Time";
        public static string Samoa { get; } = "Samoa Standard Time";
    }
}