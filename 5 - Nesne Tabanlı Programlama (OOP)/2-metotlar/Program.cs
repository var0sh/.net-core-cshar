Person p1 = new Person {
    Name = "Furkan",
    Year = 2003
};
Person p2 = new Person {
    Name = "Taha",
    Year = 2011
};
Person p3 = new Person {
    Name = "Ayşe",
    Year = 1981
};

// System.Console.WriteLine($"name: {p1.Name} age: {2022 - p1.Year}");
// System.Console.WriteLine($"name: {p2.Name} age: {2022 - p2.Year}");
// System.Console.WriteLine($"name: {p3.Name} age: {2022 - p3.Year}");

var str1 = p1.Intro();
var str2 = p2.Intro();
var str3 = p3.Intro();

System.Console.WriteLine(str1 + "\n" + str2 + "\n" + str3);

class Person {
    public string Name { get; set; }
    public int Year { get; set; }

    public string Intro() {
        return $"name: {this.Name} age: {this.CalculateAge()}";
    }

    public int CalculateAge() {
        return DateTime.Now.Year - this.Year;
    }

}
