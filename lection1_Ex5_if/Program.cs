Console.Write("Введите имя пользователя (англ): ");
string username = Console.ReadLine();

if (username.ToLower() == "natalya")
{
    Console.WriteLine ("Ура, это же Natalya!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}