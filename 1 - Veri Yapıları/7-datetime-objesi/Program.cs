using System.Globalization;

DateTime now = DateTime.Now;
DateTime dt = new DateTime(2008, 1, 7, 18, 5, 12);
DateTime dt1 = dt.AddDays(2.5123124234);
DateTime dt2 = dt.AddDays(-4);
var diff = now - dt;

System.Console.WriteLine(now);
// System.Console.WriteLine(now.ToString("d"));
// System.Console.WriteLine(now.ToString("D"));
// System.Console.WriteLine(now.ToString("F"));
// System.Console.WriteLine(now.ToString("M"));
// System.Console.WriteLine(now.ToString("t"));
// System.Console.WriteLine(now.ToString("T"));
// System.Console.WriteLine(now.ToString("Y"));

System.Console.WriteLine(now.ToString("h-m-s-yyyy-d"));
System.Console.WriteLine(now.ToString("ddd MMM %d, yyyy"));

CultureInfo culture = new CultureInfo("en");
System.Console.WriteLine(now.ToString("F", culture));