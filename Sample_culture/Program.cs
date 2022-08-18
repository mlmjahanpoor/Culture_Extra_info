using Sample_culture;
using System.Text;
using static Sample_culture.TestCulture;

//var info = TimeZoneInfo.Local.Id;

//Console.WriteLine(TestCulture.GetRequestedDateTime(DateTime.UtcNow, TimeZoneId.Arabian));

#region get all timezones

var orderd = TimeZoneInfo.GetSystemTimeZones().OrderBy(x => x.Id);

var sb = new StringBuilder();
foreach (var timeZoneInfo in orderd)
{
    var str = $"{timeZoneInfo.StandardName} => " + TestCulture.GetRequestedDateTime(DateTime.UtcNow, timeZoneInfo.Id);
    sb.AppendLine(str);
    Console.WriteLine(str);
}

var bytes = Encoding.UTF8.GetBytes(sb.ToString());

File.WriteAllBytes("timeZones.txt", bytes);

#endregion get all timezones