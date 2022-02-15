// var s1 = new Student("Furkan", 447);
// var s2 = new Student("Ayşe", 241);
// var s3 = new Student("Taha", 352);

// s1.DisplayStudentDetails();
// Student.DisplaySchoolDetails();

string str = "ölçme ve değerlendirme";
System.Console.WriteLine(HelperMethods.KarakterDuzelt(str));
static class HelperMethods {
    public static string KarakterDuzelt(string str) {
        return str.Replace("ö", "o")
            .Replace("ç", "c")
                .Replace(" ", "-")
                    .Replace("ğ", "g");
    }
}
class Student {

    public Student(string name, int number) {
        this.Name = name;
        this.Number = number;
    }

    public string Name { get; set; }
    public int Number { get; set; }
    static string School = "my school";
    static string Address = "my school address";

    public void DisplayStudentDetails() {
        Console.WriteLine($"name: {this.Name} | number: {this.Number} ");
    }
    public static void DisplaySchoolDetails() {
        System.Console.WriteLine($"school name: {Student.School} | school address: {Student.Address}");
    }
}