Console.Write("Введите им пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // ToLower- позволяет все символы строки перевести в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}