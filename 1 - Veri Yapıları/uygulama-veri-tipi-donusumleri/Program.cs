Console.Write("kısa kenar: ");
var shortEdge = int.Parse(Console.ReadLine());

Console.Write("uzun kenar: ");
var longEdge = int.Parse(Console.ReadLine());

var alan = shortEdge * longEdge;
var cevre = (shortEdge * 2) + (longEdge * 2);

Console.WriteLine($"alan: {alan} çevre: {cevre}");