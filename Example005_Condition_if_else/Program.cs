Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ринат")
{
    Console.WriteLine("Ура! это же Ринат!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}