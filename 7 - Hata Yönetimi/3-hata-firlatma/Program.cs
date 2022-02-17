// string parola = "asda";

// try {
//     check_password(parola);
//     System.Console.WriteLine("parola geçerli");
// } catch (System.Exception err) {
//     System.Console.WriteLine(err.Message);
// }
try {
    var p = new Person {
        Name = "furkan                           "
    };
} catch (System.Exception err) {
    System.Console.WriteLine(err.Message);
}

// static void check_password(string password) {
//     if (password.Length < 8 || password.Length > 15) {
//         throw new Exception("parola uzunluğu 8-15 aralığında olmalıdır");
//     } else if (!password.Any(char.IsDigit)) {
//         throw new Exception("parola en az 1 rakam içermelidir");
//     } else if (!password.Any(char.IsLetter)){
//         throw new Exception("parola en az 1 harf içermelidir");
//     }
// }

class Person {
    string _name;
    public string Name { 
        get{
            return _name;
        }
        set{
            if (value.Length > 15) 
                throw new Exception("name için en fazla 15 karakter girmelisinz");
            else
                _name = value;
        }}
}