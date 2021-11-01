using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    abstract class Electrodomesticos
    {
        protected string color = "blanco";
        protected char consumoEnergetico = 'F';
        protected float peso = 5.0f;
        protected double precioBase = 100.0;
        protected readonly string[] colores = { "blanco", "Blanco", "negro", "Negro", "azul", "Azul", "gris", "Gris" };


        public Electrodomesticos() { }

        public Electrodomesticos(double precioBase, string color)
        {
            this.precioBase = precioBase;
            this.color = color;
        }

        public Electrodomesticos(double precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomesticos(double precioBase, string color, char consumoEnergetico, float peso)
        {
            this.precioBase = precioBase;
            ComprobarColor(color);
            comprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        public double PrecioBase
        {
            get => precioBase;
            set => precioBase = value;
        }

        public string[] ColoresDisponibles
        {
            get
            {
                return this.colores;
            }
        }
        public string Color
        {
            get => color;
            set => color = value;
        }

        public char ConsumoEnergetico
        {
            get => consumoEnergetico;
            set => consumoEnergetico = value;
        }

        public float Peso
        {
            get => peso;
            set => peso = value;
        }

        private void comprobarConsumoEnergetico(char letra)
        {
            switch (letra.ToString().ToUpper().ToCharArray()[0])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                    ConsumoEnergetico = letra;
                    break;
                default:
                    ConsumoEnergetico = 'F';
                    break;
            }
        }

        private void ComprobarColor(string color)
        {
            color = color.ToLower();
            foreach (string compruebaColor in ColoresDisponibles)
            {
                if (color == compruebaColor)
                {
                    Color = color;
                    return;
                }
            }
            Color = "blanco";
        }

        public void precioFinal()
        {

            switch (consumoEnergetico)
            {
                case 'A':
                    precioBase = 100;
                    break;

                case 'B':
                    precioBase = 80;
                    break;

                case 'C':
                    precioBase = 60;
                    break;

                case 'D':
                    precioBase = 50;
                    break;

                case 'E':
                    precioBase = 30;
                    break;

                case 'F':
                    precioBase = 10;
                    break;
            }

            if (peso <= 19)
            {
                precioBase += 10;
            }
            else if (peso <= 20 && peso >= 49)
            {
                precioBase += 50;
            }
            else if (peso <= 50 && peso >= 79)
            {
                precioBase += 80;
            }
            else
            {
                precioBase += 100;

            }
        }
    }
}