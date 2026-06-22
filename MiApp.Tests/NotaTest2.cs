using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;

// FIRST

// FAST , ISOLATED, REPETABLES,Selft Validating, Timely

public class NotaTest2
{
    [Theory]
    [InlineData(4.9, "Suspenso")]
    [InlineData(5.0, "Aprobado")]
    [InlineData(5.9, "Aprobado")]
     [InlineData(6.0, "Bien")]
    public void Nota_Aprobado_Test(double valor, string calificacion)
    {
        var nota = new Nota(valor);
        var micalificacion = nota.ObtenerCalificacion();
        Assert.Equal(calificacion, micalificacion);
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

    [Fact]
    public void Nota_Igualdad_Test()
    {
        
        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(5);

        Assert.Equal(nota1,nota2);
    }
   [Fact]
   public void Nota_No_Igualdad_Test()
    {
        
        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(6);

        Assert.NotEqual(nota1,nota2);
    }

       [Fact]
    public void Nota_HashCode_Test()
    {
        
        Nota nota1= new Nota(5);
        Nota nota2 = new Nota(5);
        int numero1=nota1.GetHashCode();
        int numero2=nota2.GetHashCode();
        Assert.Equal(numero1,numero2);
    }




}