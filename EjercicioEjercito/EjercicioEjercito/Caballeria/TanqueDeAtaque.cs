using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Caballeria
{
    public class TanqueDeAtaque : ICaballeria, IDestructor, IMovil, IBlindado
    {
        private double _velocidad;
        private double _blindaje;
        private double _precio;
        private double _potenciaDeFuego;

        public TanqueDeAtaque(double velocidad, double blindaje, double potencia, double precio)
        {
            Velocidad = velocidad;
            Blindaje = blindaje;
            PotenciaDeFuego = potencia;
            Precio = precio;
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

        public double PotenciaDeFuego
        {
            get => _potenciaDeFuego;
            set
            {
                if (value > 1)
                {
                    this._potenciaDeFuego = value;
                }
                else
                {
                    this._potenciaDeFuego = 1;
                }
            }
        }

        public double capacidadDeDestruccion()
        {
            return PotenciaDeFuego;
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
