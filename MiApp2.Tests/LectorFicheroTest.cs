namespace MiApp2.Tests;

using MiApp2;

public class LectorFicheroTest
{
    [Fact]
    public void leerLineasTest()
    {

        string rutaFichero = Path.GetTempFileName();
        string[] lineasOriginales= new string[] { "l1", "l2", "l3", "l4", "l5", "l6", "l7" };

        File.WriteAllLines(rutaFichero,lineasOriginales);
        LectorFichero lectorFichero = new(rutaFichero);
        List<String> lineas = lectorFichero.leerLineas();
        
        Assert.Equal(lineasOriginales, lineas);

        File.Delete(rutaFichero);

    }
}
