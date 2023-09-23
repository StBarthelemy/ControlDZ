string[] massiv = new string[] {};

string VvodPolzovatel = ReadInput("Введите команду: ");
switch (VvodPolzovatel)
{
    case "1":
        massiv = new string[] { "Hello", "2", "world", ":-)"};
        break;
    case "2":
        massiv = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        massiv = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{VvodPolzovatel} - Такой команды нет");
        break;
}


int array = 0;
for (int i = 0; i <= massiv.Length - 1; i++)
{
    if (massiv[i].Length <= 3) array++;
}

string[] newArray = new string[array];
int inde = 0;

for (int i = 0; i <= massiv.Length - 1; i++)
{
    if (massiv[i].Length <= 3)
    {
        newArray[inde] = massiv[i];
        inde++;
    }
}