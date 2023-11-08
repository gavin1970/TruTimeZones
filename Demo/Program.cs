using System.Reflection;
using TruTimeZonez;

TruTimeZone local = TimeZoneSearch.CurrentTimeZone();
DisplayInfo(local);

Console.WriteLine("\n\nPress any key to continue.");
Console.ReadKey(true);
Console.Clear();
TruTimeZone ca = TimeZoneSearch.SearchById("Pacific", true);
DisplayInfo(ca);

Console.WriteLine("\n\nPress any key to continue.");
Console.ReadKey(true);
Console.Clear();
TruTimeZone hi = TimeZoneSearch.SearchByName("Mumbai", true);
DisplayInfo(hi);

Console.WriteLine("\n\nPress any key to continue.");
Console.ReadKey(true);
Console.Clear();
foreach (TruTimeZone tz in TimeZoneSearch.GetTimeZones())
    Console.WriteLine($"{tz.Id} - {tz.DisplayName}");

Console.WriteLine("\n\nPress any key to continue.");
Console.ReadKey(true);
Console.Clear();

static void DisplayInfo(TruTimeZone tz)
{
    if (tz == null)
        Console.WriteLine($"Timezone not found.");
    else
    {
        foreach (PropertyInfo propertyInfo in tz.GetType().GetProperties())
        {
            Console.WriteLine($"{propertyInfo.Name}:\n\t{propertyInfo.GetValue(tz, null)}");
        }
    }
    Console.WriteLine(new String('=', 50));
}