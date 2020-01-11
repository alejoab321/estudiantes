using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo2
{
    public class Maquina
    {
        public int Dinero { get; set; }
        public string Marca { get; set; }
        List<Cafe> Cafes { get; set; }
        public int CapacidadMaxima { get; set; }
        public int BotonInstruccion { get; set; }

        public Maquina ()
        {
            Cafes = new List<Cafe>();
        }

        public void SurtirMaquina(Cafe cafe)
        {
            if (CapacidadMaxima > Cafes.Count)
            {
                Cafes.Add(cafe);
                Console.Write("Cafe agregado a la maquina satisfactoriamente \n");
            }

            else
            {
                 Console.Write("No se puede agregar más cafe el máximo es de : " + CapacidadMaxima + "\n"); 
            }
        }

        public void ComprarCafe(int dinero)
        {
            if (Cafes.Count != 0)
            {

                if(dinero >= 1000)
                {
                    Cafes.RemoveAt(0);
                    Console.WriteLine("\nCafe vendido satisfactoriamente. \n" +
                           "La cantidad de cafe disponible es de :  " + Cafes.Count);

                }
            }
            else
            {
                Console.WriteLine("No hay cafe disponible");
            }
          
            

        }


    }
}
