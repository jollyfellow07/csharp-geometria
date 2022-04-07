// See https://aka.ms/new-console-template for more information
using Geometria;
//rettangolo stampato con valori predefinitio
Rettangolo myRectangle1 = new Rettangolo(10,5);
myRectangle1.calcolaArea();
myRectangle1.calcolaPerimetro();
myRectangle1.stampaRettangolo(myRectangle1.calcolaArea(), myRectangle1.calcolaPerimetro());

//Compongo il mio rettangolo
Console.Write("\ninserisci la base del tuo rettangolo: ");
int laBase = int.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del tuo rettangolo: ");
int altezza = int.Parse(Console.ReadLine());
Console.Write("\n\n");
Rettangolo myRectangle2 = new Rettangolo(laBase, altezza);
myRectangle2.calcolaArea();
myRectangle2.calcolaPerimetro();
myRectangle2.stampaRettangolo(myRectangle2.calcolaArea(), myRectangle2.calcolaPerimetro());
