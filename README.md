# ![Logo1](https://github.com/gavin1970/TruTimeZone/blob/master/imgs/TruTimeZones_200.png)
# TruTimeZones

[![NuGet version (TruTimeZones)](https://img.shields.io/nuget/v/TruTimeZones.svg?style=flat-square)](https://www.nuget.org/packages/TruTimeZones/)

TruTimeZones is a popular TimeZone library to resolve Microsoft's glitch in Timezone's during DST.
It's very lightweight library to use that comes with a .NET6 demo console.

## Build with
- Visual Studio 2022 Professional

## Supported by
- netstandard2.0
- netstandard2.1
- net47
- net48
- net6.0
- net7.0

## Dependency
- None

## TruTimeZone Model
```csharp
TruTimeZone Model:
    TimeSpan BaseUtcOffset
    TimeSpan DSTUtcOffset
    string DisplayName
    string DaylightName
    string Id
    string StandardName
    bool SupportsDaylightSavingTime
    bool IsDaylightSavingTime
```

## Example of use
```csharp
using System.Reflection;
using TruTimeZones;

int i = 1;

TruTimeZone local = TimeZoneSearch.CurrentTimeZone();
DisplayInfo(local, "Results of: TimeZoneSearch.CurrentTimeZone()");

//Search By ID,  True represents to use Contains instead of Equals.
TruTimeZone ca = TimeZoneSearch.SearchById("Pacific", true);
DisplayInfo(ca, "Results of: SearchById(\"Pacific\", true) <- True = Contains, False = Equals");

//Search By DisplayName,  True represents to use Contains instead of Equals.
TruTimeZone hi = TimeZoneSearch.SearchByName("Mumbai", true);
DisplayInfo(hi, "Results of: SearchByName(\"Mumbai\", true) <- True = Contains, False = Equals");

//Dump the full 141 Timezon list to screen.
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
```

## Links

- [Homepage](http://www.chizl.com/TruTimeZone)
- [Documentation](http://www.chizl.com/TruTimeZone/help)
- [NuGet Package](https://www.nuget.org/packages/TruTimeZone)
- [Release Notes](https://github.com/gavin1970/TruTimeZone/releases)
- [Contributing Guidelines](https://github.com/gavin1970/TruTimeZone/blob/master/CONTRIBUTING.md)
- [License](https://github.com/gavin1970/TruTimeZone/blob/master/LICENSE.md)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/TruTimeZone)
