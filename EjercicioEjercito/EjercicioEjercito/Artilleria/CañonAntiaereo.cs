using EjercicioEjercito.Artilleria;
using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class CañonAntiaereo : IArtilleria, IDestructor, IMovil
    {
        private double _precio;
        private double _velocidad;
        private double _potenciaDeFuego;

        public CañonAntiaereo(double velocidad, double potenciaDeFuego, double precio)
        {
            Precio = precio;
            Velocidad = velocidad;
            PotenciaDeFuego = potenciaDeFuego;
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
    }
}