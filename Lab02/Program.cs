Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; //char можно неявно превратить в int - это код символа в таблице Unicode
Console.WriteLine($"Символ: {firstLetter},разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20; //компилятор вывел int
var gpa = 4.75; //компилятор вывел double
var fullName = "Смирнова А.С."; //компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");


Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.WriteLine("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.WriteLine("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}");


Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.WriteLine("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse:       {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030-birthYearConvert} лет");


Console.WriteLine();
Console.WriteLine("Ввод чисел : TryParse");

Console.WriteLine("Введите число прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");


Console.WriteLine("Пожалуйста,укажите ваш рост в метрах: ");
string mtr = Console.ReadLine()[0..^3];
double meter = Convert.ToDouble(mtr);

Console.WriteLine("Пожалуйста,укажите ваш вес в килограммах: ");
string kg = Console.ReadLine();
double KG = Convert.ToDouble(kg);

Console.WriteLine($"ИМТ: {(KG / 100) / ((meter / 100) * (meter / 100)):F2}");


Console.WriteLine("Введите целое число: ");
string ch = Console.ReadLine();
bool CH = int.TryParse(ch, out int CHS);

Console.WriteLine("Введите десятичную дробь");
string db = Console.ReadLine();
bool DB = double.TryParse(db, out double DBS);

Console.WriteLine("Введите дату: ");
string dt = Console.ReadLine();
bool DT = DateTime.TryParse(dt, out DateTime DTS);

Console.WriteLine($"Success: {CH}");
Console.WriteLine($"Number: {CHS}");
Console.WriteLine($"Success: {DB}");
Console.WriteLine($"Num/: {DBS}");
Console.WriteLine($"Success: {DT}");
Console.WriteLine($"Date: {DTS}");