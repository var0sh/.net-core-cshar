using System.Collections;

Dictionary<int, string> plakalar = new Dictionary<int, string>();
Dictionary<int, string> sayilar = new Dictionary<int, string> {
    {1, "bir"},
    {2, "iki"},
    {3, "üç"}
};

plakalar.Add(34, "istanbul");
plakalar.Add(35, "izmir");
plakalar.Add(53, "rize");

// System.Console.WriteLine(sayilar[1]);

// foreach (var item in plakalar) {
//     System.Console.WriteLine($"plaka: {item.Key} | şehir: {item.Value} ");
// }

// for (int i = 0; i < plakalar.Count(); i++) {
//     System.Console.WriteLine($"plaka: {plakalar.Keys.ElementAt(i)} | şehir: {plakalar.Values.ElementAt(i)}");
// }

// System.Console.WriteLine(plakalar.ContainsKey(34));
// System.Console.WriteLine(plakalar.Contains(new KeyValuePair<int, string>(34, "istanbul")));

// plakalar.Remove(34);
// plakalar.Remove(53);

// foreach (var item in plakalar) {
//     System.Console.WriteLine($"plaka: {item.Key} | şehir: {item.Value} ");
// }

Hashtable ht = new Hashtable();

ht.Add(1, "bir");
ht.Add(2, "iki");
ht.Add(3, "üç");