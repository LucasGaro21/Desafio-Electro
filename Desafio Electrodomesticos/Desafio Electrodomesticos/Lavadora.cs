using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Lavadora : Electrodomesticos
    {
        private double carga = 5;

        public Lavadora() { }
        public Lavadora(double precioBase, float peso)
           : base(precioBase, peso)
        { }

        public Lavadora(double carga, double precioBase, string color, char consumoEnergetico, float peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public double Carga
        {
            get => carga;
        }

        public void precioFinal()
        {
            if (carga >= 30)
            {
                precioBase += 50;
            }
        }
    }
}