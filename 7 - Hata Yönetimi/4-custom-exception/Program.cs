try {
    Login("furkan", "456");
    System.Console.WriteLine("login başarılı");
} catch (LoginException err) {
    System.Console.WriteLine(err.Message);
}

static void Login (string username, string password) {
    if (username.Contains(" "))
        throw new LoginException("username boşluk içeremez");
    else if(password.Length < 8)
        throw new LoginException("parola min 8 karakter olmalıdır");
}

class LoginException: Exception {
    public LoginException(string message): base(message) {}
}