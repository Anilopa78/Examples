Console.Write("Введите имя пользователя: ");

string username1 = Console.ReadLine();
Console.WriteLine(username1);
 
if  (
    username1.ToLower() == "маша"
    )
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username1);
}
