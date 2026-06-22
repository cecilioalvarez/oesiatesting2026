using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;

// FIRST

// FAST , ISOLATED, REPETABLES,Selft Validating, Timely

public class NotaTest2
{
    [Fact]
    public void Nota_Aprobada_Test()
    {
        // arrange preparar 
        var nota = new Nota(5.5);
        var calificacion = nota.ObtenerCalificacion();
        Assert.Equal("Aprobado", calificacion);
    }

    [Theory]
    [InlineData(9.5, "Sobresaliente")]
    [InlineData(9, "Sobresaliente")]
    [InlineData(10, "Sobresaliente")]
    public void Nota_SobreSaliente_Test(double valor, string calificacion)
    {
        var nota = new Nota(valor);
        var micalificacion = nota.ObtenerCalificacion();
        Assert.Equal(calificacion, micalificacion);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(10.1)]

    public void Nota_Mayor_10_Test(double valor)
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Nota(valor));
        Assert.Contains("El valor debe estar entre 0 y 10", ex.Message);
    }




}