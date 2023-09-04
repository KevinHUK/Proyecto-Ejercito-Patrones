using EjercicioEjercito.Artilleria;
using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{

    public class Cañon : IArtilleria, IDestructor
    {
        private double _precio;
        private double _potenciaDeFuego;

        public Cañon(double potenciaDeFuego, double precio)
        {
            Precio = precio;
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

        public double damePrecio()
        {
            return Precio;
        }
    }
}