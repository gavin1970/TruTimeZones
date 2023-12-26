# ![Logo1](https://github.com/gavin1970/TruTimeZones/blob/master/imgs/WindowsIssue01.png)
# TruTimeZones

[![NuGet version (TruTimeZones)](https://img.shields.io/nuget/v/TruTimeZones.svg?style=flat-square)](https://www.nuget.org/packages/TruTimeZones/) <- Not setup yet

TruTimeZones is a popular TimeZone library to resolve Microsoft's glitch in Timezone's during DST.
It's a very lightweight library to use and comes with a .NET6 demo console.

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

TruTimeZone local = TimeZoneSearch.CurrentTimeZone();
DisplayInfo(local, "Results of: TimeZoneSearch.CurrentTimeZone()");

//Search By ID,  True represents to use Contains instead of Equals.
TruTimeZone ca = TimeZoneSearch.SearchById("Pacific", true);
DisplayInfo(ca, "Results of: SearchById(\"Pacific\", true);

//Search By DisplayName,  True represents to use Contains instead of Equals.
TruTimeZone hi = TimeZoneSearch.SearchByName("Mumbai", true);
DisplayInfo(hi, "Results of: SearchByName(\"Mumbai\", true);

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
```

## Results
```csharp
Results of: TimeZoneSearch.CurrentTimeZone()

BaseUtcOffset:
        -05:00:00
DSTUtcOffset:
        -04:00:00
DisplayName:
        (-05:00) Eastern Time (US & Canada)
DaylightName:
        Eastern Daylight Time
Id:
        Eastern Standard Time
StandardName:
        Eastern Standard Time
SupportsDaylightSavingTime:
        True
IsDaylightSavingTime:
        False
==================================================

Results of: SearchById("Pacific", true) <- True = Contains, False = Equals

BaseUtcOffset:
        -08:00:00
DSTUtcOffset:
        -07:00:00
DisplayName:
        (-08:00) Baja California
DaylightName:
        Pacific Daylight Time (Mexico)
Id:
        Pacific Standard Time (Mexico)
StandardName:
        Pacific Standard Time (Mexico)
SupportsDaylightSavingTime:
        True
IsDaylightSavingTime:
        False
==================================================

Results of: SearchByName("Mumbai", true) <- True = Contains, False = Equals

BaseUtcOffset:
        05:30:00
DSTUtcOffset:
        05:30:00
DisplayName:
        (+05:30) Chennai, Kolkata, Mumbai, New Delhi
DaylightName:
        India Daylight Time
Id:
        India Standard Time
StandardName:
        India Standard Time
SupportsDaylightSavingTime:
        False
IsDaylightSavingTime:
        False
==================================================

(001)   Id:             Dateline Standard Time
-       DisplayName:    (-12:00) International Date Line West
(002)   Id:             UTC-11
-       DisplayName:    (-11:00) Coordinated Universal Time-11
(003)   Id:             Aleutian Standard Time
-       DisplayName:    (-10:00) Aleutian Islands
(004)   Id:             Hawaiian Standard Time
-       DisplayName:    (-10:00) Hawaii
(005)   Id:             Marquesas Standard Time
-       DisplayName:    (-09:30) Marquesas Islands
(006)   Id:             Alaskan Standard Time
-       DisplayName:    (-09:00) Alaska
(007)   Id:             UTC-09
-       DisplayName:    (-09:00) Coordinated Universal Time-09
(008)   Id:             Pacific Standard Time (Mexico)
-       DisplayName:    (-08:00) Baja California
(009)   Id:             UTC-08
-       DisplayName:    (-08:00) Coordinated Universal Time-08
(010)   Id:             Pacific Standard Time
-       DisplayName:    (-08:00) Pacific Time (US & Canada)
(011)   Id:             US Mountain Standard Time
-       DisplayName:    (-07:00) Arizona
(012)   Id:             Mountain Standard Time (Mexico)
-       DisplayName:    (-07:00) La Paz, Mazatlan
(013)   Id:             Mountain Standard Time
-       DisplayName:    (-07:00) Mountain Time (US & Canada)
(014)   Id:             Yukon Standard Time
-       DisplayName:    (-07:00) Yukon
(015)   Id:             Central America Standard Time
-       DisplayName:    (-06:00) Central America
(016)   Id:             Central Standard Time
-       DisplayName:    (-06:00) Central Time (US & Canada)
(017)   Id:             Easter Island Standard Time
-       DisplayName:    (-06:00) Easter Island
(018)   Id:             Central Standard Time (Mexico)
-       DisplayName:    (-06:00) Guadalajara, Mexico City, Monterrey
(019)   Id:             Canada Central Standard Time
-       DisplayName:    (-06:00) Saskatchewan
(020)   Id:             SA Pacific Standard Time
-       DisplayName:    (-05:00) Bogota, Lima, Quito, Rio Branco
(021)   Id:             Eastern Standard Time (Mexico)
-       DisplayName:    (-05:00) Chetumal
(022)   Id:             Eastern Standard Time
-       DisplayName:    (-05:00) Eastern Time (US & Canada)
(023)   Id:             Haiti Standard Time
-       DisplayName:    (-05:00) Haiti
(024)   Id:             Cuba Standard Time
-       DisplayName:    (-05:00) Havana
(025)   Id:             US Eastern Standard Time
-       DisplayName:    (-05:00) Indiana (East)
(026)   Id:             Turks And Caicos Standard Time
-       DisplayName:    (-05:00) Turks and Caicos
(027)   Id:             Paraguay Standard Time
-       DisplayName:    (-04:00) Asuncion
(028)   Id:             Atlantic Standard Time
-       DisplayName:    (-04:00) Atlantic Time (Canada)
(029)   Id:             Venezuela Standard Time
-       DisplayName:    (-04:00) Caracas
(030)   Id:             Central Brazilian Standard Time
-       DisplayName:    (-04:00) Cuiaba
(031)   Id:             SA Western Standard Time
-       DisplayName:    (-04:00) Georgetown, La Paz, Manaus, San Juan
(032)   Id:             Pacific SA Standard Time
-       DisplayName:    (-04:00) Santiago
(033)   Id:             Newfoundland Standard Time
-       DisplayName:    (-03:30) Newfoundland
(034)   Id:             Tocantins Standard Time
-       DisplayName:    (-03:00) Araguaina
(035)   Id:             E. South America Standard Time
-       DisplayName:    (-03:00) Brasilia
(036)   Id:             SA Eastern Standard Time
-       DisplayName:    (-03:00) Cayenne, Fortaleza
(037)   Id:             Argentina Standard Time
-       DisplayName:    (-03:00) City of Buenos Aires
(038)   Id:             Montevideo Standard Time
-       DisplayName:    (-03:00) Montevideo
(039)   Id:             Magallanes Standard Time
-       DisplayName:    (-03:00) Punta Arenas
(040)   Id:             Saint Pierre Standard Time
-       DisplayName:    (-03:00) Saint Pierre and Miquelon
(041)   Id:             Bahia Standard Time
-       DisplayName:    (-03:00) Salvador
(042)   Id:             UTC-02
-       DisplayName:    (-02:00) Coordinated Universal Time-02
(043)   Id:             Greenland Standard Time
-       DisplayName:    (-02:00) Greenland
(044)   Id:             Mid-Atlantic Standard Time
-       DisplayName:    (-02:00) Mid-Atlantic - Old
(045)   Id:             Azores Standard Time
-       DisplayName:    (+01:00) Azores
(046)   Id:             Cape Verde Standard Time
-       DisplayName:    (-01:00) Cabo Verde Is.
(047)   Id:             UTC
-       DisplayName:    (+00:00) Coordinated Universal Time
(048)   Id:             GMT Standard Time
-       DisplayName:    (+00:00) Dublin, Edinburgh, Lisbon, London
(049)   Id:             Greenwich Standard Time
-       DisplayName:    (+00:00) Monrovia, Reykjavik
(050)   Id:             Sao Tome Standard Time
-       DisplayName:    (+00:00) Sao Tome
(051)   Id:             Morocco Standard Time
-       DisplayName:    (+00:00) Casablanca
(052)   Id:             W. Europe Standard Time
-       DisplayName:    (+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna
(053)   Id:             Central Europe Standard Time
-       DisplayName:    (+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague
(054)   Id:             Romance Standard Time
-       DisplayName:    (+01:00) Brussels, Copenhagen, Madrid, Paris
(055)   Id:             Central European Standard Time
-       DisplayName:    (+01:00) Sarajevo, Skopje, Warsaw, Zagreb
(056)   Id:             W. Central Africa Standard Time
-       DisplayName:    (+01:00) West Central Africa
(057)   Id:             GTB Standard Time
-       DisplayName:    (+02:00) Athens, Bucharest
(058)   Id:             Middle East Standard Time
-       DisplayName:    (+02:00) Beirut
(059)   Id:             Egypt Standard Time
-       DisplayName:    (+02:00) Cairo
(060)   Id:             E. Europe Standard Time
-       DisplayName:    (+02:00) Chisinau
(061)   Id:             Syria Standard Time
-       DisplayName:    (+02:00) Damascus
(062)   Id:             West Bank Standard Time
-       DisplayName:    (+02:00) Gaza, Hebron
(063)   Id:             South Africa Standard Time
-       DisplayName:    (+02:00) Harare, Pretoria
(064)   Id:             FLE Standard Time
-       DisplayName:    (+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius
(065)   Id:             Israel Standard Time
-       DisplayName:    (+02:00) Jerusalem
(066)   Id:             South Sudan Standard Time
-       DisplayName:    (+02:00) Juba
(067)   Id:             Kaliningrad Standard Time
-       DisplayName:    (+02:00) Kaliningrad
(068)   Id:             Sudan Standard Time
-       DisplayName:    (+02:00) Khartoum
(069)   Id:             Libya Standard Time
-       DisplayName:    (+02:00) Tripoli
(070)   Id:             Namibia Standard Time
-       DisplayName:    (+02:00) Windhoek
(071)   Id:             Jordan Standard Time
-       DisplayName:    (+03:00) Amman
(072)   Id:             Arabic Standard Time
-       DisplayName:    (+03:00) Baghdad
(073)   Id:             Turkey Standard Time
-       DisplayName:    (+03:00) Istanbul
(074)   Id:             Arab Standard Time
-       DisplayName:    (+03:00) Kuwait, Riyadh
(075)   Id:             Belarus Standard Time
-       DisplayName:    (+03:00) Minsk
(076)   Id:             Russian Standard Time
-       DisplayName:    (+03:00) Moscow, St. Petersburg
(077)   Id:             E. Africa Standard Time
-       DisplayName:    (+03:00) Nairobi
(078)   Id:             Volgograd Standard Time
-       DisplayName:    (+03:00) Volgograd
(079)   Id:             Iran Standard Time
-       DisplayName:    (+03:30) Tehran
(080)   Id:             Arabian Standard Time
-       DisplayName:    (+04:00) Abu Dhabi, Muscat
(081)   Id:             Astrakhan Standard Time
-       DisplayName:    (+04:00) Astrakhan, Ulyanovsk
(082)   Id:             Azerbaijan Standard Time
-       DisplayName:    (+04:00) Baku
(083)   Id:             Russia Time Zone 3
-       DisplayName:    (+04:00) Izhevsk, Samara
(084)   Id:             Mauritius Standard Time
-       DisplayName:    (+04:00) Port Louis
(085)   Id:             Saratov Standard Time
-       DisplayName:    (+04:00) Saratov
(086)   Id:             Georgian Standard Time
-       DisplayName:    (+04:00) Tbilisi
(087)   Id:             Caucasus Standard Time
-       DisplayName:    (+04:00) Yerevan
(088)   Id:             Afghanistan Standard Time
-       DisplayName:    (+04:30) Kabul
(089)   Id:             West Asia Standard Time
-       DisplayName:    (+05:00) Ashgabat, Tashkent
(090)   Id:             Ekaterinburg Standard Time
-       DisplayName:    (+05:00) Ekaterinburg
(091)   Id:             Pakistan Standard Time
-       DisplayName:    (+05:00) Islamabad, Karachi
(092)   Id:             Qyzylorda Standard Time
-       DisplayName:    (+05:00) Qyzylorda
(093)   Id:             India Standard Time
-       DisplayName:    (+05:30) Chennai, Kolkata, Mumbai, New Delhi
(094)   Id:             Sri Lanka Standard Time
-       DisplayName:    (+05:30) Sri Jayawardenepura
(095)   Id:             Nepal Standard Time
-       DisplayName:    (+05:45) Kathmandu
(096)   Id:             Central Asia Standard Time
-       DisplayName:    (+06:00) Astana
(097)   Id:             Bangladesh Standard Time
-       DisplayName:    (+06:00) Dhaka
(098)   Id:             Omsk Standard Time
-       DisplayName:    (+06:00) Omsk
(099)   Id:             Myanmar Standard Time
-       DisplayName:    (+06:30) Yangon (Rangoon)
(100)   Id:             SE Asia Standard Time
-       DisplayName:    (+07:00) Bangkok, Hanoi, Jakarta
(101)   Id:             Altai Standard Time
-       DisplayName:    (+07:00) Barnaul, Gorno-Altaysk
(102)   Id:             W. Mongolia Standard Time
-       DisplayName:    (+07:00) Hovd
(103)   Id:             North Asia Standard Time
-       DisplayName:    (+07:00) Krasnoyarsk
(104)   Id:             N. Central Asia Standard Time
-       DisplayName:    (+07:00) Novosibirsk
(105)   Id:             Tomsk Standard Time
-       DisplayName:    (+07:00) Tomsk
(106)   Id:             China Standard Time
-       DisplayName:    (+08:00) Beijing, Chongqing, Hong Kong, Urumqi
(107)   Id:             North Asia East Standard Time
-       DisplayName:    (+08:00) Irkutsk
(108)   Id:             Singapore Standard Time
-       DisplayName:    (+08:00) Kuala Lumpur, Singapore
(109)   Id:             W. Australia Standard Time
-       DisplayName:    (+08:00) Perth
(110)   Id:             Taipei Standard Time
-       DisplayName:    (+08:00) Taipei
(111)   Id:             Ulaanbaatar Standard Time
-       DisplayName:    (+08:00) Ulaanbaatar
(112)   Id:             Aus Central W. Standard Time
-       DisplayName:    (+08:45) Eucla
(113)   Id:             Transbaikal Standard Time
-       DisplayName:    (+09:00) Chita
(114)   Id:             Tokyo Standard Time
-       DisplayName:    (+09:00) Osaka, Sapporo, Tokyo
(115)   Id:             North Korea Standard Time
-       DisplayName:    (+09:00) Pyongyang
(116)   Id:             Korea Standard Time
-       DisplayName:    (+09:00) Seoul
(117)   Id:             Yakutsk Standard Time
-       DisplayName:    (+09:00) Yakutsk
(118)   Id:             Cen. Australia Standard Time
-       DisplayName:    (+09:30) Adelaide
(119)   Id:             AUS Central Standard Time
-       DisplayName:    (+09:30) Darwin
(120)   Id:             E. Australia Standard Time
-       DisplayName:    (+10:00) Brisbane
(121)   Id:             AUS Eastern Standard Time
-       DisplayName:    (+10:00) Canberra, Melbourne, Sydney
(122)   Id:             West Pacific Standard Time
-       DisplayName:    (+10:00) Guam, Port Moresby
(123)   Id:             Tasmania Standard Time
-       DisplayName:    (+10:00) Hobart
(124)   Id:             Vladivostok Standard Time
-       DisplayName:    (+10:00) Vladivostok
(125)   Id:             Lord Howe Standard Time
-       DisplayName:    (+10:30) Lord Howe Island
(126)   Id:             Bougainville Standard Time
-       DisplayName:    (+11:00) Bougainville Island
(127)   Id:             Russia Time Zone 10
-       DisplayName:    (+11:00) Chokurdakh
(128)   Id:             Magadan Standard Time
-       DisplayName:    (+11:00) Magadan
(129)   Id:             Norfolk Standard Time
-       DisplayName:    (+11:00) Norfolk Island
(130)   Id:             Sakhalin Standard Time
-       DisplayName:    (+11:00) Sakhalin
(131)   Id:             Central Pacific Standard Time
-       DisplayName:    (+11:00) Solomon Is., New Caledonia
(132)   Id:             Russia Time Zone 11
-       DisplayName:    (+12:00) Anadyr, Petropavlovsk-Kamchatsky
(133)   Id:             New Zealand Standard Time
-       DisplayName:    (+12:00) Auckland, Wellington
(134)   Id:             UTC+12
-       DisplayName:    (+12:00) Coordinated Universal Time+12
(135)   Id:             Fiji Standard Time
-       DisplayName:    (+12:00) Fiji
(136)   Id:             Kamchatka Standard Time
-       DisplayName:    (+12:00) Petropavlovsk-Kamchatsky - Old
(137)   Id:             Chatham Islands Standard Time
-       DisplayName:    (+12:45) Chatham Islands
(138)   Id:             UTC+13
-       DisplayName:    (+13:00) Coordinated Universal Time+13
(139)   Id:             Tonga Standard Time
-       DisplayName:    (+13:00) Nuku'alofa
(140)   Id:             Samoa Standard Time
-       DisplayName:    (+13:00) Samoa
(141)   Id:             Line Islands Standard Time
-       DisplayName:    (+14:00) Kiritimati Island
```

## Links

- [Homepage]<!--(http://www.chizl.com/TruTimeZones)-->
- [Documentation]<!--(http://www.chizl.com/TruTimeZones/help)-->
- [NuGet Package]<!--(https://www.nuget.org/packages/TruTimeZones)-->
- [Release Notes]<!--(https://github.com/gavin1970/TruTimeZones/releases)-->
- [Contributing Guidelines]<!--(https://github.com/gavin1970/TruTimeZones/blob/master/CONTRIBUTING.md)-->
- [License](https://github.com/gavin1970/TruTimeZones/blob/master/LICENSE.md)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/TruTimeZones)
