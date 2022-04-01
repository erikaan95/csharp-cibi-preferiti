// See https://aka.ms/new-console-template for more information
/* Argomento di oggi: lista di cibi preferiti */
string[] cibiPreferiti = { "Pasta", "Patate", "Mango", "Mirtilli", "Carote", "Salame", "Formaggio", "Verdura", "Yogurt", "Cioccolato" };
Console.WriteLine("Lista dei cibi preferiti:");

/* Numero di cibi presenti in lista */
Console.WriteLine("La mia lista comprende " + cibiPreferiti.Length + "cibi");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(i + 1 + " " + cibiPreferiti[i]);
}

/* Preferenza */
Console.WriteLine("Il mio cibo top è: " + cibiPreferiti[cibiPreferiti.Length - 7]);
Console.WriteLine("Il cibo che preferisco meno è: " + cibiPreferiti[cibiPreferiti.Length - 2]);


/* BONUS */
int posizioneMediana = cibiPreferiti.Length / 2;
if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("Classifica media: " + cibiPreferiti[posizioneMediana]);
}