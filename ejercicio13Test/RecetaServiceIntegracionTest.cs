using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejercicio13;

namespace ejercicio13Test
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {

        IUnityContainer container;
        Receta receta;

        [TestInitialize]
        public void testInit()
        {
            container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            receta = new Receta();
        }

        [TestMethod]
        public void testCreate()
        {
            IRecetaService sut = container.Resolve<IRecetaService>();

            receta.nombre = "Arroz Negro";
            receta.peso = 100;

            Receta resultado = sut.Create(receta);

            Assert.AreEqual(2 * 100, resultado.peso);
        }
    }
}
