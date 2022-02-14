var p1 = new Product {
    Name = "",
    Price = 100,
    IsApproved = true
};

System.Console.WriteLine($"name: {p1.Name} | price: {p1.Price} | onaylımı: {p1.IsApproved} ");

// p1.SetPrice(-1000);
// System.Console.WriteLine($"name: {p1.Name} | price: {p1.GetPrice()}");

class Product {
    private string _name;
    public string Name {
        get {
            return this._name;
        }
        set {
            if (!string.IsNullOrEmpty(value))
                this._name = value;
            else
                throw new Exception("name alanı zorunlu");
        }
    }
    private double _price;
    public double Price { 
        get {
            return this._price;
        }
        set {
            if (value < 0)
                this._price = 0;
            else
                this._price = value;
        }
    }
    public bool IsApproved { get; set; }

    // public void SetPrice(double price) {
    //     if (price < 0)
    //         this.Price = 0;
    //     else
    //         this.Price = price;
    // }

    // public double GetPrice() {
    //     return this.Price;
    // }

};