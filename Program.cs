// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
// Tamagochi lever menads mätthet > 0 och tråkighet < 10.
Console.WriteLine("Tjenare kexett!! DAx att skapa en tamagochi kompis:D ! Vad ska den heta?");
string name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name)) {
    name = "Namnlös ej älskad gubbe";
}
Tamagotchi cat = new Tamagotchi(name);
Console.WriteLine("\n"+ name +":hej hejj!!");
while (cat.GetAlive())
{
    Console.WriteLine(name + " lever. Här har du stats:");
    cat.PrintStats();
    Console.WriteLine(name + " vill säga något till dig:");
    cat.Hi();
    Console.WriteLine("Vad vill du göra med " + name + "?\n" + "1:mata  2:Lek  3:Lära ord. Skriv siffran:");
    string answer = Console.ReadLine();
    cat.Tick();
    if (answer == "1") { cat.Feed(Random.Shared.Next(1, 3)); }
    else if (answer == "2") { cat.ReduceBoredom(); }
    else if (answer == "3")
    {
        Console.WriteLine("vad vill du lära " + name + "??");
        string newWord = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(newWord)) { newWord = "Bitch"; }
        cat.Teach(newWord);
    }
    else
    {
        Console.WriteLine("Du gör inget. " + answer + " Var inte ett godtagbart svar.");
    }
}
for (int x = 1; x < 50; x++) {
    Console.WriteLine(name + " Dog. Dålig behandling av stakarn. Taskig du e");
}
Console.ReadLine();


