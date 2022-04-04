//Dichiariamo le variabili in base ai tipi
string titolo = "Clean Code";
string autore = "Robert C. Martin";
string isbn13 = "978-0132350884";

int numeroPagine = 431;
int pesoLibro = 660;

float larghezza = 17.91f;
float lunghezza = 2.54f;
float profondita = 23.5f;

float valutazioneMedia = 4.7f;
int numeroRecensioni = 3307;

bool kindle = true;
bool copertinaFlessibile = true;


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

if (kindle)
    Console.WriteLine("Kindle disponibile: SI");
else
    Console.WriteLine("Kindle disponibile: NO");

if (copertinaFlessibile)
    Console.WriteLine("Copertina flessibile disponibile: SI");
else
    Console.WriteLine("Copertina flessibile disponibile: NO");
