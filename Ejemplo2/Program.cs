using System;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina maquina = new Maquina();
            maquina.CapacidadMaxima = 10;

            Cafe cafe1  = new Cafe();
            Cafe cafe2  = new Cafe();
            Cafe cafe3  = new Cafe();
            Cafe cafe4  = new Cafe();
            Cafe cafe5  = new Cafe();
            Cafe cafe6  = new Cafe();
            Cafe cafe7  = new Cafe();
            Cafe cafe8  = new Cafe();
            Cafe cafe9  = new Cafe();
            Cafe cafe10 = new Cafe();
            Cafe cafe11 = new Cafe();

            maquina.SurtirMaquina(cafe1);
            maquina.SurtirMaquina(cafe2);
            maquina.SurtirMaquina(cafe3);
            maquina.SurtirMaquina(cafe4);
            maquina.SurtirMaquina(cafe5);
            maquina.SurtirMaquina(cafe6);
            maquina.SurtirMaquina(cafe7);
            maquina.SurtirMaquina(cafe8);
            maquina.SurtirMaquina(cafe9);
            maquina.SurtirMaquina(cafe10);
            maquina.SurtirMaquina(cafe11);

            maquina.ComprarCafe(1000);
            maquina.ComprarCafe(1000);
            maquina.ComprarCafe(1000);


            Console.Read();
            


        }
    }
}
