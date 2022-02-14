int[] ogrNo = {100, 200, 300};
string[] ad = {"Furkan", "Taha", "Ayşe"};
string[] sube = {"10/A", "10/B", "10/C"};

// System.Console.WriteLine($"no: {ogrNo[0]}\nad: {ad[0]}\nşube: {sube[0]}");


Ogrenci ogr1 = new Ogrenci();
ogr1.OgrNo = 100;
ogr1.Ad = "Furkan";
ogr1.Sube = "12/A";

Ogrenci ogr2 = new Ogrenci() {
    Ad = "Taha",
    OgrNo = 200,
    Sube = "12/B"
};

Ogrenci ogr3 = new Ogrenci() {
    Ad = "Ayşe",
    OgrNo = 300,
    Sube = "11/C"
};

System.Console.WriteLine($"Öğrenci 1..\nno: {ogr1.OgrNo}\nad: {ogr1.Ad}\nşube: {ogr1.Sube}");
System.Console.WriteLine($"Öğrenci 2..\nno: {ogr2.OgrNo}\nad: {ogr2.Ad}\nşube: {ogr2.Sube}");
System.Console.WriteLine($"Öğrenci 3..\nno: {ogr3.OgrNo}\nad: {ogr3.Ad}\nşube: {ogr3.Sube}");

System.Console.WriteLine("********************************************");

Ogrenci[] students = new Ogrenci[3];

students[0] = ogr1;
students[1] = ogr2;
students[2] = ogr3;

for (int i = 0; i < students.Length; i++) {
    System.Console.WriteLine(students[i].Ad);
}

class Ogrenci {
    public int? OgrNo { get; set; }
    public string? Ad { get; set; }
    public string? Sube { get; set; }
}
