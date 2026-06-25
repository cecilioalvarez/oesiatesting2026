namespace MiApp2.Tests;

using MiApp2;

public class LectorFicheroTest
{
    [Fact]
    public void leerLineasTest()
    {

        LectorFichero lectorFichero= new LectorFichero ("datosAlumno.txt");
        List<String> lineas=lectorFichero.leerLineas();
        Assert.Equal(7,lineas.Count);
        
    }
}
