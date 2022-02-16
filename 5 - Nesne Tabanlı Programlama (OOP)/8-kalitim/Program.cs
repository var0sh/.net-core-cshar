Person p1 = new Person("furkan", "akçatepe");
Student s1 = new Student("taha", "akçatepe", "120");
Teacher t = new Teacher("ayşe", "akçatepe", "matematik");

p1.Intro();
s1.Intro();
t.Intro();
t.Teac();

class Person {
    
    public Person (string name, string surName) {
        this.Name = name;
        this.SurName = surName;
        System.Console.WriteLine("Person nesnesi oluşturuldu");
    }
    
    public string Name { get; set; }
    public string SurName { get; set; }

    public virtual void Intro() {
        System.Console.WriteLine($"name: {this.Name} | surname: {this.SurName} ");
    }

}
class Student: Person {

    public Student (string name, string surName, string number): base(name, surName) {
        this.Number = number;
        System.Console.WriteLine("Student nesnesi oluşturuldu");
    }
    public string Number { get; set; }

    public override void Intro() {
        System.Console.WriteLine($"name: {this.Name} | surname: {this.SurName} | number: {this.Number} ");
    }

}
class Teacher: Person {
    public Teacher (string name, string surName, string branch): base(name, surName) {
        this.Branch = branch;
    }
    public string Branch { get; set; }

    public void Teac() {
        System.Console.WriteLine("i am teaching..");
    }
    public override void Intro() {
        System.Console.WriteLine($"name: {this.Name} | surname: {this.SurName} | branch: {this.Branch} ");
    }
}