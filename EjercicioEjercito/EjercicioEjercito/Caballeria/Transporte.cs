using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Caballeria
{
    public class Transporte : ICaballeria, IMovil, IBlindado
    {
        private double _precio;
        private double _blindaje;
        private double _velocidad;

        public Transporte(double velocidad, double blindaje, double precio)
        {
            Precio = precio;
            Blindaje = blindaje;
            Velocidad = velocidad;
        }

        public double Precio
        {
            get => _precio;
            set
            {
                if (value > 1)
                {
                    _precio = value;
                }
                else
                {
                    _precio = 1;
                }
            }
        }

        public double Blindaje
        {
            get => _blindaje;
            set
            {
                if (value > 1)
                {
                    _blindaje = value;
                }
                else
                {
                    _blindaje = 1;
                }
            }
        }

        public double Velocidad
        {
            get => _velocidad;
            set
            {
                if (value > 1)
                {
                    this._velocidad = value;
                }
                else
                {
                    this._velocidad = 1;
                }
            }
        }

        public double capacidadDeMovimiento()
        {
            return Velocidad;
        }

        public double damePrecio()
        {
            return Precio;
        }

        public double resistenciaAlAtaque()
        {
            return Blindaje;
        }
    }
}
