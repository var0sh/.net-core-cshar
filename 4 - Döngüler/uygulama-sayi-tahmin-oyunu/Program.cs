do {
    var tutulan = new Random().Next(1, 4);
    int hak = 5, puan = 1, soruPuani = 100 / hak;

    while (hak != 0) {

        hak--;

        System.Console.Write("tahmin: ");
        int tahmin = int.Parse(Console.ReadLine());

        if (tahmin == tutulan) {
            System.Console.WriteLine("bildin");
            System.Console.WriteLine($"puan: {puan = (hak + 1) * soruPuani}");
            break;
        } else if (hak == 0) {
            System.Console.WriteLine("puan: 0");
            break;
        }
        else if (tahmin < tutulan) {
            System.Console.WriteLine("yukarı");
            continue;
        }
        else {
            System.Console.WriteLine("aşağı");
            continue;
        }

    }

    System.Console.WriteLine("sayı: " + tutulan);
    System.Console.Write("devam etmek istiyormusunuz? (e/h): ");
    char result = char.Parse(Console.ReadLine());

    if (result == 'h')
        break;

} while (true);