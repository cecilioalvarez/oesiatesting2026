using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;


// FIRST FAST ISOLATEd REPETIBLE, SELF VALIDATING ,TIMELY 
public class AlumnoTestEstadisticas
{
    private readonly Alumno alumnoConNotas;

    public AlumnoTestEstadisticas()
    {

        alumnoConNotas = new Alumno(1, "Antonio", CrearListaNotas(8, 1.5, 9, 4, 7, 6));

    }
    [Fact]
    public void ObtenerMejorNota_CuandoHayNotas_DevuelveLaDeMayorValor()
    {
        Nota? notaMejor = alumnoConNotas.ObtenerMejorNota();
        Assert.Equal(new Nota(9), notaMejor);
    }
    [Fact]
    public void ObtenerPeorNota_CuandoHayNotas_DevuelveLaMenorValor()
    {
        Nota? notaPeor = alumnoConNotas.ObtenerPeorNota();
        Assert.Equal(new Nota(1.5), notaPeor);
    }

    //incrementar el nivel de aislamiento de los test  y que cada uno sea muy independiente

    [Fact]
    public void ObtenerNotaMedia_CuandoHayNotas_DevuelveLaMedia()
    {
        // Arrange
        var alumnoConNotas = new Alumno(1, "Juan", CrearListaNotas(10, 0, 10));

        // Act
        double resultado = alumnoConNotas.ObtenerNotaMedia();

        // Assert
        Assert.Equal(6.67, resultado, precision: 2);
    }
    private List<Nota> CrearListaNotas(params double[] valores)
    {
        return valores.Select(v => new Nota(v)).ToList();
    }








}
