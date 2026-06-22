using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;


public class FacturaTests
{
    [Fact]
    public void Calculo_Iva_Factura()
    {
        // arrange preparar 
        var factura = new Factura(1, "ordenador", 1000);

        // act ejecuto el codigo
        double resultado = factura.calcularIva();
        //valido el codigo
        Assert.Equal(1210, resultado);


    }
    [Fact]
    public void Factura_Valor_Valido_Mayor_Cero_Test()
    {
        //valido el codigo
        var ex = Assert.Throws<ArgumentException>(() => new Factura(1, "ordenador", -1));
        Assert.Contains("Valor no valido", ex.Message);
    }

}
