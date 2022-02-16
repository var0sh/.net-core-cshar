var personeller = new IPersonel[3];

personeller[0] = new Yonetici("Furkan", "eskişehir", "yazılım");
personeller[1] = new Robot("bilişim");
personeller[2] = new Isci("ayşe", "eskişehir", "bilgisayar");

foreach (var item in personeller) {
    item.bilgi();
}

interface IPersonel {
    string departman { get; set; }

    void bilgi();
}
interface IKisi {
    string adSoyad { get; set; }
    string address { get; set; }
    string departman { get; set; }

    void bilgi();
}
class Yonetici : IPersonel, IKisi {

    public Yonetici(string _adSoyad, string _address, string _departman) {
        this.adSoyad = _adSoyad;
        this.address = _address;
        this.departman = _departman;
    }

    public string adSoyad { get; set; }
    public string address { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi() {
        System.Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde yöneticidir ");
    }
}
class Isci : IPersonel, IKisi {

    public Isci(string _adSoyad, string _address, string _departman) {
        this.adSoyad = _adSoyad;
        this.address = _address;
        this.departman = _departman;
    }

    public string adSoyad { get; set; }
    public string address { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi()
    {
        System.Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde işçidir");
    }
}
class Robot : IPersonel {

    public Robot(string _departman) {
        this.departman = _departman;
    }

    public string departman { get; set; }

    public void bilgi() {
        System.Console.WriteLine($"{this.departman} bölümünde bir robot");
    }
}