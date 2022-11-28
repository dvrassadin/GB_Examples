Console.Write("Введите Ваше имя: ");
string userName = Console.ReadLine();
if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}