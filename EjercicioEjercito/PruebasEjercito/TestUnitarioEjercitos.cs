using EjercicioEjercito;
using EjercicioEjercito.Artilleria;
using EjercicioEjercito.Caballeria;
using EjercicioEjercito.Infanteria;
using System.Runtime.InteropServices;

namespace PruebasEjercito
{
    [TestClass]
    public class TestUnitarioEjercitos
    {
        [TestMethod]
        public void EjercitoBasicoBien()
        {

            ColeccionEjercito ejercitoBasico = new ColeccionEjercito();
            IArtilleria cañon = new Cañon(14, 1100);
            IArtilleria antiaereo = new CañonAntiaereo(1, 22, 1100);
            IInfanteria infanteriaBasica = new InfanteriaBasica(6, 7, 250);

            ejercitoBasico.add(cañon);
            ejercitoBasico.add(antiaereo);
            ejercitoBasico.add(infanteriaBasica);

            Assert.AreEqual(3, ejercitoBasico.dameElementosTotales());
            Assert.AreEqual(43, ejercitoBasico.damePotenciaDeFuegoTotal());
            Assert.AreEqual(7, ejercitoBasico.dameCapacidadDeMovimientoTotal());
            Assert.AreEqual(0.49, ejercitoBasico.dameCM());
            Assert.AreEqual(2450, ejercitoBasico.precioTotal());

        }
        [TestMethod]
        public void EjercitoBasicoMal()
        {

            ColeccionEjercito ejercitoBasico = new ColeccionEjercito();
            IArtilleria cañon = new Cañon(14, 1100);
            IArtilleria antiaereo = new CañonAntiaereo(1100, 1, 22);
            IInfanteria infanteriaBasica = new InfanteriaBasica(6, -7, 250);

            ejercitoBasico.add(cañon);
            ejercitoBasico.add(antiaereo);
            ejercitoBasico.add(infanteriaBasica);

            Assert.AreEqual(3, ejercitoBasico.dameElementosTotales());
            Assert.AreEqual(22, ejercitoBasico.damePotenciaDeFuegoTotal());
            Assert.AreEqual(7, ejercitoBasico.dameCapacidadDeMovimientoTotal());
            Assert.AreEqual(0, ejercitoBasico.dameCM());
            Assert.AreEqual(2450, ejercitoBasico.precioTotal());

        }

        [TestMethod]
        public void EjercitoCompletoBien()
        {

            ColeccionEjercito ejercitoCompleto = new ColeccionEjercito();
            IArtilleria cañon = new Cañon(14, 1100);
            IArtilleria antiaereo = new CañonAntiaereo(1, 22, 1100);
            IInfanteria infanteriaBasica = new InfanteriaBasica(6, 7, 250);
            IInfanteria sanitario = new Sanitario(7, 5, 500);
            ICaballeria tanqueDeAtaque = new TanqueDeAtaque(7.3, 4.8, 9.8, 15600);
            ICaballeria transporte = new Transporte(4.5, 1.4, 4200);

            ejercitoCompleto.add(cañon);
            ejercitoCompleto.add(antiaereo);
            ejercitoCompleto.add(infanteriaBasica);
            ejercitoCompleto.add(sanitario);
            ejercitoCompleto.add(tanqueDeAtaque);
            ejercitoCompleto.add(transporte);

            Assert.AreEqual(6, ejercitoCompleto.dameElementosTotales());
            Assert.AreEqual(52.8, ejercitoCompleto.damePotenciaDeFuegoTotal());
            Assert.AreEqual(25.8, ejercitoCompleto.dameCapacidadDeMovimientoTotal());
            Assert.AreEqual(0.55, ejercitoCompleto.dameCM());
            Assert.AreEqual(22750, ejercitoCompleto.precioTotal());
            Assert.IsInstanceOfType(cañon, typeof(IArtilleria));
            Assert.IsInstanceOfType(sanitario, typeof(IInfanteria));
            Assert.IsInstanceOfType(tanqueDeAtaque, typeof(ICaballeria));
            Assert.IsInstanceOfType(cañon, typeof(IEjercito));
            Assert.IsInstanceOfType(tanqueDeAtaque, typeof(IEjercito));
            Assert.IsInstanceOfType(sanitario, typeof(IEjercito));


        }

        [TestMethod]
        public void EjercitoCompletoMal()
        {

            ColeccionEjercito ejercitoCompleto = new ColeccionEjercito();
            IArtilleria cañon = new Cañon(14, 1100);
            IArtilleria antiaereo = new CañonAntiaereo(1, 22, 1100);
            IInfanteria infanteriaBasica = new InfanteriaBasica(6, 7, 250);
            IInfanteria sanitario = new Sanitario(7, 5, 500);
            ICaballeria tanqueDeAtaque = new TanqueDeAtaque(7.3, 0, 9.8, 15600);
            ICaballeria transporte = new Transporte(4.5, 1.4, 0);

            ejercitoCompleto.add(cañon);
            ejercitoCompleto.add(antiaereo);
            ejercitoCompleto.add(infanteriaBasica);
            ejercitoCompleto.add(sanitario);
            ejercitoCompleto.add(tanqueDeAtaque);
            ejercitoCompleto.add(transporte);

            Assert.AreEqual(6, ejercitoCompleto.dameElementosTotales());
            Assert.AreEqual(52.8, ejercitoCompleto.damePotenciaDeFuegoTotal());
            Assert.AreEqual(25.8, ejercitoCompleto.dameCapacidadDeMovimientoTotal());
            Assert.AreEqual(0.53, ejercitoCompleto.dameCM());
            Assert.AreEqual(18551, ejercitoCompleto.precioTotal());
            Assert.IsInstanceOfType(cañon, typeof(ICaballeria));
            Assert.IsInstanceOfType(sanitario, typeof(ColeccionEjercito));
            Assert.IsInstanceOfType(tanqueDeAtaque, typeof(IArtilleria));



        }
    }
}