System.Console.Write("name: ");
var name = Console.ReadLine();
System.Console.Write("surname: ");
var surName = Console.ReadLine();
System.Console.Write("age: ");
var age = Console.ReadLine();

// var str = $"my name is {name} {surName} and i'm {age} years old";
var str = string.Format("my name is {0} {1} and i'm {2} years old.", name, surName, age);

System.Console.WriteLine(str);