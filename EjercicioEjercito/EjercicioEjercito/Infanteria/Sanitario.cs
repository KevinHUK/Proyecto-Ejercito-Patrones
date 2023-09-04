using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Infanteria
{
    public class Sanitario : IMovil, IBlindado, IInfanteria
    {
        private double _velocidad;
        private double _precio;
        private double _blindaje;

        public Sanitario(double velocidad, double blindaje, double precio)
        {
            Velocidad = velocidad;
            Precio = precio;
            Blindaje = blindaje;
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
