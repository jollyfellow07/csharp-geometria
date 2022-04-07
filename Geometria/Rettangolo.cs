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
            return area;
        }

        //Metodo per calcolare il perimetro
        public int calcolaPerimetro()
        {
          int  perimetro = (baseRettangolo + altezzaRettangolo)*2;
            return perimetro;
        }
        public void stampaRettangolo(int area, int perimetro)
        {
            Console.WriteLine("*************RETTANGOLO*************");
            Console.WriteLine("La base del mio rettangolo è: " + baseRettangolo);
            Console.WriteLine("L'altezza del mio rettangolo è: " + altezzaRettangolo);
            Console.WriteLine("L'area del mio rettangolo è: " + area);
            Console.WriteLine("Il perimetro del mio rettangolo è: " + perimetro);
        }
    }
}
    