using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cafe
    {
        public string Agua { get; set; }
        public string Vaso { get; set; }
        public int CantidadCafe { get; set; }
        public int CantidadAzucar { get; set; }

        //Metodo encargado de obtener los ingredientes
        public Cafe(string agua, string vaso, int cantidadCafe, int cantidadAzucar)
        {
            Agua = agua;
            Vaso = vaso;
            CantidadCafe = cantidadCafe;
            CantidadAzucar = cantidadAzucar;
        }

        public string EntregarCafe()
        {
            string datosCafe = "Su cafe se ha realizado con èxito y tiene lo siguiente : \n"
                                + "1. Cantidad de agua : "  + Agua                       +"\n"
                                + "2. Cantidad de café : "  + CantidadCafe   + " Gramos" + "\n"
                                + "3. Cantidad de azucar: " + CantidadAzucar + " Gramos";
            return datosCafe;
        }
    }
}
