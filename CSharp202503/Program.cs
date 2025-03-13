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

//tableau à 2 dimensions
string[,] departements = {
     {"01", "Ain"},
     {"02", "Aisne"},
     {"03", "Allier"},
     {"04", "Alpes-de-Haute-Provence"},
     {"2A", "Corse du Sud"},
     {"16", "Charente"},
     {"17", "Charente-Maritime"},
};

string continuer = "O";
while (continuer.ToUpper() == "O")
{
    Console.WriteLine("Donne moi un numéro de département");
    string departementUser = Console.ReadLine();
    if (departementUser.Length==1)
    {
        departementUser = "0" + departementUser;
    }
    bool trouve = false;
    string numdepartement = "";
    string nomdepartement = "";
    for (int i = 0;i<departements.GetLength(0);i++)
    {
        numdepartement = departements[i,0];
        nomdepartement = departements[i,1];
        if (departementUser.ToUpper()== numdepartement.ToUpper())
        {
            Console.WriteLine(nomdepartement);
            trouve = true;
        }


    }
    if (trouve==false)
    {
        Console.WriteLine("Ce numéro de département: " + nomdepartement + " n'est pas valide");
    }
    //int departementint = Convert.ToInt16(departement);
    /*
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
    */
    Console.WriteLine("continuer ? (O/N): ");
    continuer = Console.ReadLine();
}