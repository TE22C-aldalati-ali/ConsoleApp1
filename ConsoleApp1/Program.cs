using System;

int Score = 0;
Console.WriteLine("welcome to alis game");

Console.WriteLine("1.vad heter jag");
Console.WriteLine("a)alawi    b)ali   c)sakdik");
string svar1 = Console.ReadLine();
if (svar1 == "b")
{
    Score++;
    Console.WriteLine("Right, good job");
}
else
{
    Score--;
    Console.WriteLine("False");
}

Console.WriteLine("2. vad är min favorit färg");
Console.WriteLine("a)black   b)red   c)blue");
string svar2 = Console.ReadLine();
if (svar2 == "a"){

Score++;
Console.WriteLine("Right, good job");
}
else
{
Score--;
Console.WriteLine("False");
}


Console.WriteLine("3.vad gör jag i min fritid");
Console.WriteLine("a) spelar  b)läser nåt  c)programerar");
string svar3 = Console.ReadLine();
if (svar3 == "a")
{
Score++;
Console.WriteLine("Right, good job");
}
else
{
Score--;
Console.WriteLine("False");
}
Console.WriteLine($"Du fick {Score}.");
if (Score == 0)
{
  Console.WriteLine("Tyvär så fick du alla fel");
}
else if (Score < 3)
{
  Console.WriteLine("bra jobbat hoppas du får alla rätt nästa gång");
}
else 
{
  Console.WriteLine(" Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();