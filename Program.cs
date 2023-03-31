Console.WriteLine("--- Pet Hotel Nicolly ---");

Console.Write("Espécie ________: ");
string especie = Console.ReadLine()!;

Console.Write("Raça_____________: ");
string raca = Console.ReadLine()!;

Console.Write("Alcunha_____________: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade ___________: ");
string idade = Console.ReadLine()!;

Console.Write("cor:_________ ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+****************************************");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Pet Hotel \"Nicolly\"");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+************************************************+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.Black;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+****************************************************+");
Console.Write("| Atende pelo apelido de: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ");
Console.ForegroundColor = ConsoleColor.Black;
Console.Write(" | cor: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Black;
Console.Write("+********************************************+");

Console.ResetColor();
