char[] chars = new char[10];
char[] vogais = new char[10];
char[] consoantes = new char[10];

Console.WriteLine("Digite uma letra por vez");
for (int i = 0; i < 10; i++)
{
    chars[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    switch (chars[i]) {
        case 'a' :
            vogais[i] = chars[i];    
            break;
        case 'e':
            vogais[i] = chars[i];
            break;
        case 'i':
            vogais[i] = chars[i];
            break;
        case 'o':
            vogais[i] = chars[i];
            break;
        case 'u':
            vogais[i] = chars[i];
            break;
        case 'A':
            vogais[i] = 'a';
            break;
        case 'E':
            vogais[i] = 'e';
            break;
        case 'I':
            vogais[i] = 'i';
            break;
        case 'O':
            vogais[i] = 'o';
            break;
        case 'U':
            vogais[i] = 'u';
            break;
        default:
            consoantes[i] = chars[i];
            break;
    }
}
Console.WriteLine("Vogais:");
for (int i = 0; i < 10; i++)
{
    if (chars[i] == vogais[i])
    {
        Console.Write($" {vogais[i]}");
    }
}

Console.WriteLine("\nConsoantes: ");
for (int i = 0;i < 10; i++)
{
    if (chars[i] == consoantes[i])
    {
        Console.Write($" {consoantes[i]}");
    }
}