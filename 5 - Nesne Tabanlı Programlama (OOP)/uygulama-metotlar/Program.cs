Araba opel = new Araba {
    Marka = "opel",
    Model = "astra",
    Renk = "beyaz",
    Otomatik = true
};

Araba mazda = new Araba {
    Marka = "mazda",
    Model = "cx3",
    Renk = "kırmızı",
    Otomatik = true
};

// opel.Menu();
mazda.Menu();

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