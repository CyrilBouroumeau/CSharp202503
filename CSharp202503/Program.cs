// See https://aka.ms/new-console-template for more information
Console.WriteLine("donne moi ton mdp à tester");
string reponse = Console.ReadLine();
int testmdpok = reponse.Length;

if (testmdpok >= 8)
{
    Console.WriteLine("ton mdp est robuste: "+ reponse);
}
else if (testmdpok == 0)
{
    Console.WriteLine("Vous n'avez pas saisi de mdp");
}
else
{
    Console.WriteLine("ton mdp : " + reponse + "n'est pas robuste");
}


string continuer = "O";
while (continuer == "O")
{
    Console.WriteLine("Donne moi un numéro de département");
    string departement = Console.ReadLine();
    int departementint = Convert.ToInt16(departement);
    switch (departementint)
{
    case 1:
        Console.WriteLine("AIN");
        break;
    case 2:
        Console.WriteLine("ALLIER");
        break;
    default:
        Console.WriteLine("Departement inconnu");
        break;
}
    Console.WriteLine("continuer ? (O/N): ");
    continuer = Console.ReadLine();
}