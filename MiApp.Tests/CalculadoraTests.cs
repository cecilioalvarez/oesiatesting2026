using System.Reflection;
using Xunit;

namespace MiApp.test;


    public class CalculadoraTests
    {
        [Fact]
        public void Suma_DebeDevolverCuatro()
        {
            // arrange preparar 
            var calculadora = new Calculadora();
            // act ejecuto el codigo
            double resultado = calculadora.Suma(2, 2);
            //valido el codigo
            Assert.Equal(4, resultado);


        }
         [Fact]
        public void Resta_DebeDevolverCero()
        {
            // arrange preparar 
            var calculadora = new Calculadora();
            // act ejecuto el codigo
            double resultado = calculadora.Resta(2, 2);
            //valido el codigo
            Assert.Equal(0, resultado);


        }
    }
