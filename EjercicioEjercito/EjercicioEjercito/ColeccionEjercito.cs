using EjercicioEjercito.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito
{
    public class ColeccionEjercito
    {
        public List<IEjercito> ejercito = new List<IEjercito>();
        private double _CM;
        private double _blindajeTotal;
        private double _potenciaDeFuegoTotal;
        private double _movilidadTotal;
        private double _costeTotal;
        public void add(IEjercito item)
        {
            ejercito.Add(item);
        }

        public double dameCM()
        {
            double pf = 0;
            double cm = 0;
            double bl = 0;
            double valor1;
            double valor2;
            foreach (var item in ejercito)
            {
                if (item is IBlindado)

                {
                    if ((item as IBlindado).resistenciaAlAtaque() <= 0)
                    {
                        bl = 1;
                    }
                    else
                    {
                        bl += (item as IBlindado).resistenciaAlAtaque();
                    }
                }
                else if (item is IMovil)
                {
                    if ((item as IMovil).capacidadDeMovimiento() <= 0)
                    {
                        cm = 1;
                    }
                    else
                    {
                        cm += (item as IMovil).capacidadDeMovimiento();
                    }
                }
                else if (item is IDestructor)
                {

                    if ((item as IDestructor).capacidadDeDestruccion() <= 0)
                    {
                        pf = 1;
                    }
                    else
                    {
                        pf += (item as IDestructor).capacidadDeDestruccion();
                    }
                }


            }
            valor1 = pf * (cm / 2);
            valor2 = 100 - bl;
            _CM = valor1 / valor2;
            return Math.Round(_CM, 2);
        }

        public double dameElementosTotales()
        {
            return ejercito.Count;
        }
        public double dameBlindajeTotal()
        {
            foreach (var item in ejercito)
            {

                if (item is IBlindado)
                {
                    _blindajeTotal += (item as IBlindado).resistenciaAlAtaque();
                }

            }
            return _blindajeTotal;
        }
        public double damePotenciaDeFuegoTotal()
        {
            foreach (var item in ejercito)
            {

                if (item is IDestructor)
                {
                    _potenciaDeFuegoTotal += (item as IDestructor).capacidadDeDestruccion();
                }

            }
            return _potenciaDeFuegoTotal;
        }
        public double dameCapacidadDeMovimientoTotal()
        {
            foreach (var item in ejercito)
            {

                if (item is IMovil)
                {
                    _movilidadTotal += (item as IMovil).capacidadDeMovimiento();
                }

            }
            return _movilidadTotal;
        }

        public double precioTotal()
        {
            foreach (var item in ejercito)
            {

                if (item is ICoste)
                {
                    _costeTotal += (item as ICoste).damePrecio();
                }

            }
            return _costeTotal;
        }


    }
}
