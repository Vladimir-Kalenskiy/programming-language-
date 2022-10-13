Console.WriteLine("Введите имя пользовотеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "галя")
{
    Console.WriteLine("Ура, это же Галя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}