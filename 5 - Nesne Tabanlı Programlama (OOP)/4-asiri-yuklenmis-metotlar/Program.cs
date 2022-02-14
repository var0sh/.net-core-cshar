var islem = new Islem();
var mazda = new Araba {
    Marka = "mazda",
    Model = "cx3",
    Renk = "kırmızı",
    Otomatik = true,
    MaxHiz = 220
};

mazda.Menu();

System.Console.WriteLine(islem.Toplama(10, 20));


class Islem {
    // public int X { get; set; }
    // public int Y { get; set; }

    // public int Toplama(int x, int y, int z = 0) {
    //     return x + y + z;
    // }

    public int Toplama(int a, int b) {
        return a + b;
    }
    public int Toplama(int a, int b, int c) {
        return a + b + c;
    }
    public int Toplama(int a, int b, int c, int d) {
        return a + b + c + d;
    }
}
class Araba {
    
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public bool Otomatik { get; set; }
    public int MaxHiz { get; set; }

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
    public void Hizlan(int km) {
        if (km > this.MaxHiz)
            System.Console.WriteLine("max hızı aşamayız");
        else
            System.Console.WriteLine($"{this.Marka} {this.Model} {km} km/saat hıza getiriliyor");

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
                    System.Console.Write("hız bilgisi girmek istiyormusunuz? (e/h)");
                    string secim = Console.ReadLine();

                    if (secim == "e") {
                        System.Console.Write("hız: ");
                        int km = int.Parse(Console.ReadLine());
                        this.Hizlan(km);
                    } else {
                        this.Hizlan();
                    }
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