//Dichiariamo le variabili in base ai tipi
Console.Write("Inserisci titolo del libro: ");
string? titolo = Console.ReadLine();
Console.Write("Inserisci nome autore: ");
string? autore = Console.ReadLine();

Console.Write("Inserisci ISBN: ");
ulong isbn13 = Convert.ToUInt64(Console.ReadLine());

Console.Write("Inserisci numero pagine: ");
uint numeroPagine = Convert.ToUInt32(Console.ReadLine());
Console.Write("Inserisci peso del libro: ");
uint pesoLibro = Convert.ToUInt32(Console.ReadLine());

Console.Write("Inserisci larghezza del libro: ");
float larghezza = Convert.ToSingle(Console.ReadLine());
Console.Write("Inserisci lunghezza del libro: ");
float lunghezza = Convert.ToSingle(Console.ReadLine());
Console.Write("Inserisci profondita del libro: ");
float profondita = Convert.ToSingle(Console.ReadLine());

Console.Write("Inserisci valutazione media: ");
float valutazioneMedia = Convert.ToSingle(Console.ReadLine());
Console.Write("Inserisci numero di recensioni: ");
uint numeroRecensioni = Convert.ToUInt32(Console.ReadLine());

Console.Write("Inserisci yes or no se e' presente kindle: ");
string? kindle = Console.ReadLine();
Console.Write("Inserisci yes or no se e' presente la copertina flessibile: ");
string? copertinaFlessibile = Console.ReadLine();


//Stampiamo le variabili

Console.WriteLine("IL LIBRO IN QUESTIONE E': " + titolo + " di " + autore);

Console.WriteLine("Informazioni generiche: ");
Console.WriteLine("ISBN: " + isbn13);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine ");
Console.WriteLine("Peso del libro: " + pesoLibro + " g ");
Console.WriteLine("Dimensioni del libro: " + larghezza + " cm x " + lunghezza + " cm x " + profondita + " cm ");

Console.WriteLine("Informazioni Amazon: ");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " pagine ");
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline ");

//Trim serve per togliere gli spazi all'inizio e alla fine della stringa, mentre ToLower rende il testo in minuscolo
if (kindle?.Trim().ToLower() == "yes")
    Console.WriteLine("Kindle disponibile: SI");
else if (kindle?.Trim().ToLower() == "no")
    Console.WriteLine("Kindle disponibile: NO");
else
    Console.WriteLine("Non hai detto se e' presente la versione!");

if (copertinaFlessibile?.Trim().ToLower() == "yes")
    Console.WriteLine("Copertina flessibile disponibile: SI");
else if (copertinaFlessibile?.Trim().ToLower() == "no")
    Console.WriteLine("Copertina flessibile disponibile: NO");
else 
    Console.WriteLine("Non hai detto se e' presente la versione!");