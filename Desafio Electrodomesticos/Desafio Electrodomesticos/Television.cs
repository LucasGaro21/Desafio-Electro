using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomesticos
    {
        private double resolucion = 20;
        private bool tdt = false;

        public Television() { }

        public Television(double precioBase, float peso)
           : base(precioBase, peso)
        { }

        public Television(double resolucion, bool tdt, double precioBase, string color, char consumoEnergetico, float peso)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.tdt = tdt;
        }

        public double Resolucion
        {
            get => resolucion;
        }

        public bool Tdt
        {
            get => Tdt;
        }

        public void precioFinal()
        {
            if (resolucion >= 40)
            {
                precioBase = precioBase * 1.3;
            }

            if (tdt == true)
            {
                precioBase = precioBase * 1.5;
            }
        }
    }
}