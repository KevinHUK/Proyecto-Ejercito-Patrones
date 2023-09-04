using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Caballeria
{
    public class TransporteRapido : ICaballeria, IMovil
    {
        private double _velocidad;
        private double _precio;
        public TransporteRapido(double velocidad, double precio)
        {
            Velocidad = velocidad;
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
    }
}
