//Год рождения константа потому что он никак поменяться не может,если говорим об одном студенте
const int birth_year = 2007; 
string name = "Дьяченко Иван Сергеевич";
string group = "ИСП 251";
int course = 2;
bool stipendiya = true;
//Не int потому что средний балл может быть любой
double score = 5.0;

Console.WriteLine(" Визитная Карточка студента");
Console.WriteLine($"ФИО: {name}");
Console.WriteLine($"Группа: {group}");
//Ставлю \n,чтобы линий раз не проприсывать Console.WriteLine();
Console.WriteLine($"Курс: {course}\n");
Console.WriteLine($"Лет: {2026-birth_year}\n");
Console.WriteLine($"Средний балл за прошлый курс: {score}");
Console.WriteLine($"Стипендия: {stipendiya}");