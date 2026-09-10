Console.WriteLine("Пожалуйста,укажите ваше имя: ");
char name = Console.ReadLine()[0];

Console.WriteLine("Пожалуйста,укажите вашу фамилию: ");
string fam = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {fam} {name}.");
