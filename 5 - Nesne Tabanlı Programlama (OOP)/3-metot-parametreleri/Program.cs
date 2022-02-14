var islem = new Islem {
    // X = 10,
    // Y = 20
};

// System.Console.WriteLine(islem.Toplama(10, 20, 50));
// System.Console.WriteLine(islem.Toplama(y: 10, z: 20, x: 50)); // named => isimlendirilmiş parametre
// System.Console.WriteLine(islem.Toplama(y: 10, x: 50)); // default
System.Console.WriteLine(islem.Toplama(10, 20, 30, 40, 50, 60));


class Islem {
    // public int X { get; set; }
    // public int Y { get; set; }

    // public int Toplama(int x, int y, int z = 0) {
    //     return x + y + z;
    // }

    public int Toplama(params int[] sayilar) {
        int toplam = 0;
        
        foreach (var sayi in sayilar) {
            toplam += sayi;
        }

        return toplam;
    }
}
class Araba {
    
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public bool Otomatik { get; set; }

    public void Start() {
        System.Console.WriteLine($"{this.Marka} {this.Model} çalıştı");
    }
    public void Stop() {
        System.Console.WriteLine($"{this.Marka} {this.Model} durdu");
    }
    public void Yavasla() {
        System.Console.WriteLine($"{this.Marka} {this.Model} yavaşlıyor");
    }
    public void Hizlan() {
        System.Console.WriteLine($"{this.Marka} {this.Model} hızlanıyor");
    }
    public void Menu() {
        string komut = "";

        do
        {
            System.Console.Write($"araba: {this.Marka} {this.Model}\n1-start, 2-hızlan, 3-yavaşla, 4-stop ç-çıkış\nseçiminiz: ");
            komut = Console.ReadLine();

            switch (komut)
            {
                case "1":
                    this.Start();
                    break;
                case "2":
                    this.Hizlan();
                    break;
                case "3":
                    this.Yavasla();
                    break;
                case "4":
                    this.Stop();
                    break;
                default:
                    System.Console.WriteLine("uygulamadan çıkıldı");
                    break;
            }

        } while (komut != "ç");

    }

}
