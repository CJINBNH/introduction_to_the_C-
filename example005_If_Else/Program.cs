﻿Console.Write("Введите имя пользователя ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это же Маша, привет!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}