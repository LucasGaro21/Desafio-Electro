using System;
using System.Collections.Generic;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Electrodomesticos> electrodomesticos = new List<Electrodomesticos>();
            List<Lavadora> lavadoras = new List<Lavadora>();
            List<Television> televisores = new List<Television>();

            double precioLavadoras = 0.0, precioTelevisores = 0.0, precioElectrodomesticos = 0.0;

            Lavadora lavadora1 = new Lavadora(50, 35);
            electrodomesticos.Add(lavadora1);
            lavadoras.Add(lavadora1);

            Lavadora lavadora2 = new Lavadora(10, 70);
            electrodomesticos.Add(lavadora2);
            lavadoras.Add(lavadora2);

            Television led = new Television(60, true, 10, "gris", 'C', 20);
            electrodomesticos.Add(led);
            televisores.Add(led);

            foreach (Electrodomesticos e in electrodomesticos)
            {
                e.precioFinal();

            }

           

            foreach (Lavadora l in lavadoras)
            {
                precioLavadoras += l.PrecioBase;
            }

            foreach (Television t in televisores)
            {
                precioTelevisores += t.PrecioBase;
            }

            precioElectrodomesticos = precioLavadoras + precioTelevisores;

            Console.WriteLine("Total Lavadoras:$" + precioLavadoras);

            Console.WriteLine("Total Televisores: $" + precioTelevisores);

            Console.WriteLine("El precio final es: $" + precioElectrodomesticos);

            Console.ReadKey();
        }
    }
}