string fraseDigitada, fraseMemeToNervoso;
Console.Write("Usuário, o que você pensa sobre mim? ");
fraseDigitada = Console.ReadLine()!;

fraseMemeToNervoso = 
 $"{fraseDigitada.Remove(10)}...NÃO PERA.\nto nervoso";

Console.WriteLine(fraseMemeToNervoso);