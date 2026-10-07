Console.WriteLine("Введите пароль:\n");
string smth = Console.ReadLine();
Console.WriteLine();
while (IsPasswordValid(smth) != true){
    Console.WriteLine($"Пароль неверный \n8 или более символов: {HasMinLength(smth,8)} \nЕсть заглавная буква: {HasUpperCase(smth)}\nЕсть цифры: {HasDigits(smth)}\n");smth = Console.ReadLine();Console.WriteLine();
}
Console.WriteLine("Верный пароль✅");


bool HasMinLength(string password, int minLength) {
    if (password.Length >= minLength) return true;
    else return false;
}

bool HasDigits(string password){
    foreach (char symbol in password) {
        if (char.IsDigit(symbol) == true) return true;
    }
    return false;
}

bool HasUpperCase(string password){
    foreach (char symbol in password){
        if (char.IsUpper(symbol) == true) return true;
    }
    return false;
}

bool IsPasswordValid(string password){
    if (HasMinLength(password,8) == true && HasDigits(password) == true && HasUpperCase(password) == true) return true;
    else return false;
}