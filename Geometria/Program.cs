// See https://aka.ms/new-console-template for more information
using Geometria;
//rettangolo stampato con valori predefinitio
Rettangolo myRectangle1 = new Rettangolo(20,10);
myRectangle1.calcolaArea();
myRectangle1.calcolaPerimetro();
myRectangle1.stampaRettangolo(myRectangle1.calcolaArea(), myRectangle1.calcolaPerimetro());

//Compongo il mio rettangolo
Console.Write("\ninserisci la base del tuo rettangolo: ");
double laBase = double.Parse(Console.ReadLine());
Console.Write("inserisci l'altezza del tuo rettangolo: ");
double altezza = double.Parse(Console.ReadLine());
Console.Write("\n\n");
Rettangolo myRectangle2 = new Rettangolo(laBase, altezza);
myRectangle2.calcolaArea();
myRectangle2.calcolaPerimetro();
myRectangle2.stampaRettangolo(myRectangle2.calcolaArea(), myRectangle2.calcolaPerimetro());
Console.ReadKey();
Console.Clear();

//vuoi disegnare il rettangolo?
Console.WriteLine("Vuoi disegnare il rettangolo?[si/no]");
string scelta = Console.ReadLine();
bool variabile = false;
do
    switch (scelta)
    {
        case ("si"):
            Console.Write("Di quale rettangolo vuoi stampare il disegno?\n\tSCELTA NUMERO 1 \n\n");
            myRectangle1.stampaRettangolo(myRectangle1.calcolaArea(), myRectangle1.calcolaPerimetro());
            Console.Write("\n\n\tSCELTA NUMERO 2 \n\n");
            myRectangle2.stampaRettangolo(myRectangle2.calcolaArea(), myRectangle2.calcolaPerimetro());
            Console.WriteLine("\n\nInserisci la tua scelta [1/2]");
            string numero = Console.ReadLine();
            Console.Clear();
            switch (numero)
            {
                case ("1"):
                    myRectangle1.disegno();
                    break;
                case ("2"):
                    myRectangle2.disegno();
                    break;
                default:
                    Console.WriteLine("mi dispiace non hai digitato il numero associato al rettangolo");
                    break;
            }
            variabile = true;
            break;
        case ("no"):
            Console.WriteLine("arrivederci");
            variabile = true;
            break;
        default:
            Console.WriteLine("scelta non corretta");
            variabile = true;
            break;     
    } while (variabile == false);
