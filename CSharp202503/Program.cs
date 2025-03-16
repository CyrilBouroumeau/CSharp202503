#region testmdp
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
#endregion

#region VariablesTableaux
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
#endregion

#region ChercheDepartement
string continuer = "O";
while (continuer.ToUpper() == "O")
{
    Console.WriteLine("Donne moi un numéro de département");
    string departementUser = Console.ReadLine();
    if (departementUser.Length==1)
    {
        departementUser = "0" + departementUser;
    }
    Console.WriteLine(getNomdepartementByNum(departementUser));

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
#endregion

#region fonctions
/* char mafonction = fonction qui retourne un char
 * void mafocntion = fonction qui ne retorune rien = procedure

char mafonction(string Mondepartement)
{
    char firstletter = Mondepartement[0];
    return firstletter;
}
 * */
string getNomdepartementByNum(string UserDepartment)
{
    string numdepartement = "";
    string nomdepartement = "";
    for (int i = 0; i < departements.GetLength(0); i++)
    {
        numdepartement = departements[i, 0];
        nomdepartement = departements[i, 1];
        if (UserDepartment.ToUpper() == numdepartement.ToUpper())
        {
            return nomdepartement;
        }
    }
    return "Ce numéro de département: " + UserDepartment + " n'est pas valide";
}
#endregion