Console.WriteLine("введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("ура, это же Маша");
} 
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}