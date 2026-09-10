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

