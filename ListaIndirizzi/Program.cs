//Consegna:  leggere un file CSV e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo

try
{
    StreamReader file = File.OpenText("F:/Users/Artiom/Desktop/Esercizi GIT/ListaIndirizzi/ListaIndirizzi/addresses.csv");

    while (!file.EndOfStream)
    {
        string line = file.ReadLine();
        Console.WriteLine(line);
    }

    file.Close();

}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}