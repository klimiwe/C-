Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine ();

if (userName.ToLower() == "варя"){
    Console.Write("Ура, это ВАРЯ!!!");
}
else 
{
    Console.Write("Привет.  ");
    Console.WriteLine(userName);
}
