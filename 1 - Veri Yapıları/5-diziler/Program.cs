var msg = "my name is furkan";
var result = msg.Split("a");

// string[] names = new string[5];
// names[0] = "furkan";
// names[1] = "taha";
// names[2] = "halil";
// names[3] = "ayşe";
// names[4] = "bilal";

// OR

string[] names = {"furkan", "taha", "ayşe", "halil"};
names[0] = "new name";


// int[] numbers = new int[5];
// numbers[0] = 0;
// numbers[1] = 1;
// numbers[2] = 2;
// numbers[3] = 3;
// numbers[4] = 4;

// OR

int[] numbers = {1, 2, 3, 4, 5};

System.Console.WriteLine(names[0]);

string value = "Merhaba Dünya";
char[] chars = {'y', 'a', 'a'};
int index = value.LastIndexOfAny(chars);
Console.WriteLine(index);