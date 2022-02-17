using System.Collections;

// ArrayList

ArrayList myList = new ArrayList();
ArrayList myList2 = new ArrayList {
    10,
    "10",
    "abc",
    10.5
};

myList.Add(10);
myList.Add("10");
myList.Add("abc");
myList.Add(10.5);


// Accessing Items

// System.Console.WriteLine(myList[0]);

// var sayi = myList[0];
// myList.Insert(1, 20);
// myList.InsertRange(1, myList2);


// Remove Items

myList.Remove(10);
myList.RemoveAt(1);
myList.RemoveRange(0, 2);

foreach (var item in myList) {
    System.Console.WriteLine(item);
}

System.Console.WriteLine(myList.Contains(10));


ArrayList sayilar = new ArrayList {
    1, 5, 2, 8, 4, 0, 7
};

foreach (var item in sayilar) {
    System.Console.WriteLine(item);
}

sayilar.Sort();

foreach (var item in sayilar) {
    System.Console.WriteLine(item);
}