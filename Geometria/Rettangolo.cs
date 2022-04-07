using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;


        //Costruttore con parametri di base e altezza
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        //Metodo per calcolare l'area
        public int calcolaArea()
        {
           int area = baseRettangolo * altezzaRettangolo;
            Console.WriteLine("L'area del mio rettangolo è: " + area);
            return area;
        }

        //Metodo per calcolare il perimetro
        public int calcolaPerimetrp()
        {
          int  perimetro = (baseRettangolo + altezzaRettangolo)*2;
            Console.WriteLine("Il perimetro del mio rettangolo è: " + perimetro);
            return perimetro;
        }
    }
}
    