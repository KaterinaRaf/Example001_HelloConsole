﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); //вызов метода ИмяМетода();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);  //через присвоение (:) можно писать аргументы в любом порядке
//Method21(count: 4, msg: "Текст");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// Вид 4
string Method4(int count, string text)
{
int i =0;
string result = String.Empty;

while (i < count)
{
    result = result + text;
    i++;
}
return result;
}
string res = Method4(10, "word ");
//Console.WriteLine(res);

        //цикл for собирает в себе все данные и условия

string Method5(int count, string text)
{

string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
    result = result + text;
     }
    return result;
}
string res1 = Method5(10, "word ");
//Console.WriteLine(res1);

// цикл внутри цикла Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");  //$ - интерполяция строк
    }
     Console.WriteLine(); // искуственный разрыв
}