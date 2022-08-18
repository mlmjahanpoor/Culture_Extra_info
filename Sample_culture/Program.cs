using Sample_culture;
using static Sample_culture.TestCulture;

var info = TimeZoneInfo.Local.Id;

Console.WriteLine(TestCulture.GetRequestedDateTime(DateTime.UtcNow, TimeZoneId.Arabian));