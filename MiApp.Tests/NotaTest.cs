using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;

// FIRST

// FAST , ISOLATED, REPETABLES,Selft Validating, Timely

public class NotaTest
{
    [Fact]
    public void Nota_Aprobada_Test()
    {
        // arrange preparar 

        var nota = new Nota(5.5);
        var calificacion= nota.ObtenerCalificacion();
        Assert.Equal("Aprobado",calificacion);
    }

   [Fact]
    public void Nota_SobreSaliente_Test()
    {
        var nota = new Nota(9.5);
        var calificacion= nota.ObtenerCalificacion();
        Assert.Equal("Sobresaliente",calificacion);
    }

    //boundaries los limites entonces a mi me interesa tener un test
     [Fact]
    public void Nota_SobreSaliente9_Test()
    {
        var nota = new Nota(9);
        var calificacion= nota.ObtenerCalificacion();
        Assert.Equal("Sobresaliente",calificacion);
    }

     [Fact]
    public void Nota_SobreSaliente10_Test()
    {
        var nota = new Nota(10);
        var calificacion= nota.ObtenerCalificacion();
        Assert.Equal("Sobresaliente",calificacion);
    }
    
    [Fact]
      public void Nota_Mayor_10_Test()
    {
  
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>  new Nota(10.1));
        Assert.Contains("El valor debe estar entre 0 y 10", ex.Message);
    }


    

}