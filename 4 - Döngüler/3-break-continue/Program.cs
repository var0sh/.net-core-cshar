// string name = "furkan";

// for (int i = 0; i < name.Length; i++) {
    
//     if (name[i] == 'r')
//         continue;
    
//     System.Console.WriteLine(name[i]);
// }

// ***************************

// int x = 0;

// while (x < 5) {
    
//     if (x == 2)
//         break;

//     System.Console.WriteLine(x);
//     x++;
// }

// ***************************

int x = 0, top = 0;

while (x < 100) {
    x++;

    if (x % 2 == 0)
        continue;

    top += x;
}

System.Console.WriteLine("toplam: " + top);