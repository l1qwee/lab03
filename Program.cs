using System.Text;

int number = 305419896;
Console.WriteLine($"Число: {number}");
Console.WriteLine($"B hex: 0x{number:X8}");
Console.WriteLine($"Little-endian: {BitConverter.IsLittleEndian}");
byte[] numberBytes = BitConverter.GetBytes(number);
Console.WriteLine($"Байты числа:");
Console.WriteLine(BitConverter.ToString(numberBytes));
string text = "Привет";
Console.WriteLine();
Console.WriteLine($"Текст: {text}");
byte[] textBytes = Encoding.UTF8.GetBytes(text);
Console.WriteLine($"Байты Текста UTF-8: ");
Console.WriteLine(BitConverter.ToString(textBytes));

string text2 = "ABC";
byte[] textBytes2 = Encoding.UTF8.GetBytes(text2);
Console.WriteLine();
Console.WriteLine($"Текст: {text2}");
Console.WriteLine($"Количество символов: {text2.Length}");
Console.WriteLine($"Количество байтов UTF-8: {textBytes2.Length}");
Console.WriteLine($"Байты: {BitConverter.ToString(textBytes2)}");

string english = "A";
string russian = "А";

byte[] englishBytes = Encoding.UTF8.GetBytes(english);
byte[] russianBytes = Encoding.UTF8.GetBytes(russian);
Console.WriteLine($"A: {BitConverter.ToString(englishBytes)}");
Console.WriteLine($"А: {BitConverter.ToString(russianBytes)}");

string text3 = "Привет";
byte[] bytes = Encoding.UTF8.GetBytes(text3);
string restored = Encoding.UTF8.GetString(bytes);
Console.WriteLine($"Исходная строка: {text3}");
Console.WriteLine($"Восстановленная: {restored}");

