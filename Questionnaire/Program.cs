Console.WriteLine("Пожалуйста,укажите ваше ФИ: ");
string name = Console.ReadLine();

Console.WriteLine("Пожалуйста,укажите название вашей группы: ");
string group = Console.ReadLine();

Console.WriteLine("Пожалуйста,укажите ваш год рождения");
string yr = Console.ReadLine();
int year = Convert.ToInt32(yr);

Console.WriteLine("Пожалуйста,укажите ваш средний балл за прошлый семестр: ");
string scr = Console.ReadLine();
double score = double.Parse(scr);

Console.WriteLine("Пожалуйста,укажите вашу любимую букву алфавита");
char bukva = Console.ReadLine()[0];

Console.WriteLine(" Анкета");
Console.WriteLine($"{name}, группа {group}");
Console.WriteLine($"Год рождения: {year}, в 2030 году вам будет {2030 - year}");
Console.WriteLine($"Средний балл: {score}");
Console.WriteLine($"Ваша любимая буква - {bukva}");