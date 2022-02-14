var mazda = new Araba("mazda", "cx3", "kırmızı", true, 100);
var opel = new Araba(200) {
    Marka = "opel",
    Model = "astra",
    Renk = "beyaz",
    Otomatik = true
};

System.Console.WriteLine(opel.MaxHiz);
System.Console.WriteLine(mazda.MaxHiz);


class Araba {

    public Araba() {
        this.MaxHiz = 180;
        System.Console.WriteLine("constructor çalıştı");
    }
    public Araba(int maxHiz) {
        this.MaxHiz = maxHiz;
    }
    public Araba(string marka, string model, string renk, bool otomatik, int maxHiz) {
        this.Marka = marka;
        this.Model = model;
        this.Renk = renk;
        this.Otomatik = otomatik;
        this.MaxHiz = maxHiz;
    }
    
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