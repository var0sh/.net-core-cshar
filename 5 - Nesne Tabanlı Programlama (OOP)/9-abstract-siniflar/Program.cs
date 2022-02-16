var shapes = new Shape[3];

shapes[0] = new Diktortgen(10, 3);
shapes[1] = new Kare(5, 7);
shapes[2] = new Diktortgen(3, 9);

foreach (var item in shapes) {
    item.Draw();
    System.Console.WriteLine(item.CalculateArea());
}

abstract class Person {
    
    public Person (string name, string surName) {
        this.Name = name;
        this.SurName = surName;
        System.Console.WriteLine("Person nesnesi oluşturuldu");
    }
    
    public string Name { get; set; }
    public string SurName { get; set; }

    public abstract void Intro();
    public void Greeting() {
        System.Console.WriteLine("i am a person");
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
abstract class Shape {
    public Shape(int w, int h) {
        this.Width = w;
        this.Height = h;
    }
    public int Width { get; set; }
    public int Height { get; set; }

    public int CalculateArea() {
        return this.Width * this.Height;
    }
    public abstract void Draw();
}
class Kare: Shape {
    public Kare(int w, int h): base(w, h) {}
    public override void Draw() {
        System.Console.WriteLine("draw a square");
    }
}
class Diktortgen: Shape {
    public Diktortgen(int w, int h): base(w, h) {}
    public override void Draw() {
        System.Console.WriteLine("draw a rectangle");
    }
}