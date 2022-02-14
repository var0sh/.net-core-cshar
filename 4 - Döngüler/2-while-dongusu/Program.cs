// while

// int i = 0;

// while (i < 10) {
    
//     if (i % 2 == 0) {
//         System.Console.WriteLine("çift: " + i);
//     } else {
//         System.Console.WriteLine("tek: " + i);
//     }

//     i++;
// }


string name = "";

// while (string.IsNullOrEmpty(name)) {
//     System.Console.Write("isminiz: ");
//     name = Console.ReadLine();
// }

// System.Console.WriteLine("merhaba " + name);

// do-while

do
{

    System.Console.Write("isminiz: ");
    name = Console.ReadLine();

} while (string.IsNullOrEmpty(name));

System.Console.WriteLine("merhaba " + name);