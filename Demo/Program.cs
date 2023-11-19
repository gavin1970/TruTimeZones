using System.Reflection;
using TruTimeZones;

TruTimeZone local = TimeZoneSearch.CurrentTimeZone();
DisplayInfo(local, "Results of: TimeZoneSearch.CurrentTimeZone()");

//Search By ID,  True represents to use Contains instead of Equals.
TruTimeZone ca = TimeZoneSearch.SearchById("Pacific", true);
DisplayInfo(ca, "Results of: SearchById(\"Pacific\", true) <- True = Contains, False = Equals");

//Search By DisplayName,  True represents to use Contains instead of Equals.
TruTimeZone hi = TimeZoneSearch.SearchByName("Mumbai", true);
DisplayInfo(hi, "Results of: SearchByName(\"Mumbai\", true) <- True = Contains, False = Equals");

//Dump the full Timezone list to screen.
int i = 1;
foreach (TruTimeZone tz in TimeZoneSearch.GetTimeZones())
    Console.WriteLine($"({i++:000})\tId:\t\t{tz.Id}\n-\tDisplayName:\t{tz.DisplayName}");

Pause();

static void DisplayInfo(TruTimeZone tz, string msg)
{
    Console.WriteLine($"{msg}\n");

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
    Pause();
}

static void Pause()
{
    Console.WriteLine("\n\nPress any key to continue.");
    Console.ReadKey(true);
    Console.Clear();
}