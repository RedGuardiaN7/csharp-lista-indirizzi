//Consegna:  leggere un file CSV e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo

using ListaIndirizzi;

try
{
    //Viene creata la lista contenente i nostri oggetti

    List<object> AddressList = new List<object>();

    StreamReader file = File.OpenText("addresses.csv");

    file.ReadLine();    //Viene saltata la prima riga, che non contiene informazioni

    while (!file.EndOfStream)
    {
        //Durante il ciclo while, viene creato un nuovo oggetto ReadPerson, i quali attributi verranno letti dal file CVS

        Person ReadPerson = new Person();
        string line = file.ReadLine();

        //Per leggere le informazioni che ci servono, è necessario dividere la riga ogni volta che viene letta una virgola
        //e creare un array contenente le singole stringhe di informazioni

        string[] ReadWords = line.Split(",");

        //Nel caso in cui la riga presenta anomalie, viene "sanificata" la lettura con due condizioni
        //Per fare ciò, è necessario creare un'array di lunghezza necessaria in questo caso (5)

        string[] FinalReadWords = new string[6];
        
        //Se la riga presenta più informazioni del dovuto, probabilmente l'indirizzo contiene una virgola, in qeusto caso vengono concatenate le due "parti" di indirizzo

        if (ReadWords.Length > 6) {
            FinalReadWords[0] = ReadWords[0];
            FinalReadWords[1] = ReadWords[1];
            string CorrectedStreet = ReadWords[2] + " " + ReadWords[3];
            FinalReadWords[2] = CorrectedStreet;
            FinalReadWords[3] = ReadWords[4];
            FinalReadWords[4] = ReadWords[5];
            FinalReadWords[5] = ReadWords[6];   
        } else if (ReadWords.Length < 6)                            //Se invece la riga presenta meno informazioni del dovuto, si presuppone che siano state inserite 
        {                                                           //
            FinalReadWords[0] = ReadWords[0];
            FinalReadWords[1] = "";
            FinalReadWords[2] = "";
            FinalReadWords[3] = ReadWords[1];
            FinalReadWords[4] = ReadWords[2];
            FinalReadWords[5] = ReadWords[3];
        } else { ReadWords.CopyTo(FinalReadWords, 0); }             //Altrimenti, se tutto è regolare, viene semplicemente creata una copia

        //Ora che la riga è stata divisa e "scritta" in un array temporaneo
        //verranno assegnati i vari attributi dell'oggetto ReadPerson leggendo le stringhe dell'array appena creato
        ReadPerson.Name = FinalReadWords[0];
        ReadPerson.Surname = FinalReadWords[1];
        ReadPerson.Street = FinalReadWords[2];
        ReadPerson.City = FinalReadWords[3];
        ReadPerson.Province = FinalReadWords[4];
        ReadPerson.ZIP = Int32.Parse(FinalReadWords[5]);

        //Avendo tutte le informazioni neccessarie, ora è possibile aggiungere l'oggetto alla lista

        AddressList.Add(ReadPerson);
    }

    file.Close();

    //Chiuso il file, vengono stampati a video tutti gli oggetti all'interno della nsotra lista

    int i = 1;
    foreach (Person Person in AddressList) 
    {
        
        Person.Print(i);
        i++;
    }

}
//In caso di eventuali eccezioni viene usato try, catch

catch (Exception e)
{
    Console.WriteLine(e.Message);
}