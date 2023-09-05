// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine(0b11);        // 3
Console.WriteLine(0b1011);      // 11
Console.WriteLine(0b100001);    // 33

string name = "Tom";
int age = 33;
bool isEmloyed = false;
double weight = 78.65;

Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmloyed}");


// Консольный ввод-вывод

string name1 = "Tom";
int age1 = 34;
double height = 1.7;
Console.WriteLine($"Имя: {name1}  Возраст: {age1}  Рост: {height}м");

//Поразрядные операции
/*
int x1 = 2; //010
int y1 = 5;//101
Console.WriteLine(x1 & y1); // выведет 0

int x2 = 4; //100
int y2 = 5; //101
Console.WriteLine(x2 & y2); //выведет 4
*/

//Логическое сложение
/*
int x1 = 2; //010
int y1 = 5; //101
Console.WriteLine(x1 | y1);
int x2 = 4;
int y2 = 5;
Console.WriteLine(x2 | y2);
*/

//^(логическое исключающее ИЛИ)
/*
int x = 45;// Значение, которое надо зашифровать - в двоичной форме 101101
int key = 102; //Пусть это будет ключ - в двоичной форме 1100110

int encrypt = x ^ key;
Console.WriteLine($"Зашифрованное число: {encrypt}");

int decrypt = encrypt ^ key; // Результатом будет исходное число 45
Console.WriteLine($"Расшифрованное число: {decrypt}");
*/

//Представление отрицательных чисел

/*
int x = 12;
int y = ~x;
y += 1;
Console.WriteLine(y); // -12
*/

/*
int a = 16; // в двоичной форме 10000
int b = 2; // в двоичной форме
int c = a << b; // Сдвиг числа 10000 влево на 2 разряда, равно 1000000 или 64 в десятичной системе

Console.WriteLine($"Зашифрованное число: {c}"); //64

int d = a >> b; // Сдвиг числа 10000 вправо на 2 разряда, равно 100 или 4 в десятичной системе
Console.WriteLine($"Зашифрованное число: {d}");     // 4
*/

/*
int a = 22; //в двоичной форме 10110
int b = 2;
int c = a << b;
Console.WriteLine($"Зашифрованное число: {c}");

int d = a >> b;
Console.WriteLine($"Зашифрованное число: {d}");
*/

//Преобразования базовых типов данных
/*
try
{
    int a = 33;
    int b = 600;
    byte c = checked((byte)(a + b));
    Console.WriteLine(c);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
*/

/*
int num1 = 8;
int num2 = 6;
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
*/

/*
string name = "Alex";

if (name == "Tom")
    Console.WriteLine("Вас зовут Tomas");
else if (name == "Bob")
    Console.WriteLine("Вас зовут Robert");
else if (name == "Mike")
    Console.WriteLine("Вас зовут Michael");
else
    Console.WriteLine("Неизвестное имя");
*/

//Циклы

using System.Threading.Tasks.Sources;
/*
int i = 1;
for (; ; )
{
    Console.WriteLine($"i = {i}");
    i++;
}
*/

/*
for (int i = 1, j = 1; i < 10; i++, j++)
    Console.WriteLine($"{i * j}");
*/

//Цикл do..while

/*
int i = 6;
do
{
    Console.WriteLine(i);
    i--;
}
while (i > 0);
*/

// Цикл while

/*
int i = 6;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}   
*/

//Цикл Foreach

/*
foreach (var c in "Tom")
{
    Console.WriteLine(c);
}
*/

//Операторы continue и break

/*
for(int i = 0; i < 10; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}
*/

/*
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}
*/

//Вложенные циклы

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}