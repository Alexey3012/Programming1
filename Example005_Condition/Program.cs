Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Аня")
{
    Console.WriteLine("Ура! Это же АНЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}