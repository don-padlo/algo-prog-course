Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");

char firsLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; //char можно неявно превратить в int - это код символа в таблице Unicode
Console.WriteLine($"Символ: {firstLetter},разделитель: {separator}");
Console.WriteLine($"Код символа '{firsLetter}' в Unicode {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

