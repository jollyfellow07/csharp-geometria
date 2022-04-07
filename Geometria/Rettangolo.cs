using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        private double baseRettangolo;
        private double altezzaRettangolo;


        //Costruttore con parametri di base e altezza
        public Rettangolo(double baseRettangolo, double altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        //Metodo per calcolare l'area
        public double calcolaArea()
        {
           double area = (double)baseRettangolo * (double)altezzaRettangolo;
            return area;
        }

        //Metodo per calcolare il perimetro
        public double calcolaPerimetro()
        {
          double  perimetro = (baseRettangolo + altezzaRettangolo)*2;
            return perimetro;
        }
        public void stampaRettangolo(double area, double perimetro)
        {
            Console.WriteLine("*************RETTANGOLO*************");
            Console.WriteLine("La base del mio rettangolo è: " + baseRettangolo +" cm");
            Console.WriteLine("L'altezza del mio rettangolo è: " + altezzaRettangolo + " cm");
            Console.WriteLine("Il perimetro del mio rettangolo è: " + perimetro + " cm");
            Console.WriteLine("L'area del mio rettangolo è: " + area + " cm2");
        }

        public void disegno()
        {
            //righe = altezza-colonne = base
            for (int i = 0; i < (int)altezzaRettangolo; i++)
            {
                for(int j = 0; j < (int)baseRettangolo; j++)
                {
                    //se ci troviamo nella prima riga oppure l'ultima stampiamo le righe di lunghezza base
                    if (i == 0 || i == (altezzaRettangolo - 1))
                    {
                        Console.Write("-");

                    }
                    //altrimenti se ci troviamo nella prima o ultima colonna stampiamo i lati sinistra e destra
                    else if (j == 0 || j == (baseRettangolo - 1))
                    {
                        Console.Write("|");
                    }
                    //altrimenti stampiamo il vuoto
                    else {
                        Console.Write(" ");
                    }
                }
                //alla fine di ogni riga andiamo a capo
                Console.Write("\n");

            }
         


        }

    }
}
    