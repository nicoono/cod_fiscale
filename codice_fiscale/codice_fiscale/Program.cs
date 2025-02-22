void codice_fiscale(string c, char[] consonanti, string n, string a, string m, string[] mesi, string lettere, int g, string sesso)
{
    c = c.ToUpper();
    n = n.ToUpper();

    int countCognome = 0, countNome = 0;
    string var = "";

    for (int i = 0; i < c.Length && countCognome < 3; i++)
    {
        for (int j = 0; j < consonanti.Length; j++)
        {
            if (c[i] == consonanti[j])
            {
                var += c[i];
                countCognome++;
                break;
            }
        }
    }
    // Se nel cognome mancano consonanti, si completa con "X"
    while (countCognome < 3)
    {
        var += "X";
        countCognome++;
    }


    for (int i = 0; i < n.Length; i++)
    {
        for (int j = 0; j < consonanti.Length; j++)
        {
            if (n[i] == consonanti[j])
            {
                var += n[i];
                break;
            }
        }
    }
    string ultimeDue = a.Substring(2);
    var += ultimeDue;
    for (int i = 0; i < mesi.Length; i++)
    {
        if (m == mesi[i])
        {
            var += lettere[i];
        }
    }
    if (sesso == "F")
    {
        g = g + 40;
        var += g;
    }
    else
    {
        var += g;
    }

    Console.WriteLine(var);
}

// MAIN
string lettere = "ABCDEHLMPRST";
char[] consonanti = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
string[] mesi = { "gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };
Console.WriteLine("Scrivi tutto in maiuscolo");
Console.WriteLine("dimmi il tuo sesso (M/F)");
string sesso = Console.ReadLine();
Console.WriteLine("Dimmi il tuo cognome");
string cognome = Console.ReadLine();
Console.WriteLine("Dimmi il tuo nome");
string nome = Console.ReadLine();
Console.WriteLine("in che anno sei nato?");
string anno = Console.ReadLine();
Console.WriteLine("dimmi mese di nascita");
string mese = Console.ReadLine();
Console.WriteLine("dimmi giorno di nascita");
int giorno = int.Parse(Console.ReadLine());
codice_fiscale(cognome, consonanti, nome, anno, mese, mesi, lettere, giorno, sesso);
