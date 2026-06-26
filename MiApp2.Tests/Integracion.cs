namespace MiApp2.Tests;

using MiApp2;
using Moq;

public class Integracion
{

    [Fact]
    public void Instanciar_Parseador_Documento_A()
    {
        //le estoy pidiendo que genere un fichero real
        string rutaFichero = Path.GetTempFileName();
        File.WriteAllLines(rutaFichero, ObtenerLineasAlumnosClase());
        LectorFichero lector = new LectorFichero(rutaFichero);
        Documento documento = new Documento(lector.leerLineas());

        ParseadorDocumento parseador = ParseadorDocumento.ObtenerParser(documento);
        Clase miclase = parseador.ObtenerClaseConAlumnos();
        List<Alumno> alumnos = miclase.Alumnos;

        Assert.Equal(2, alumnos.Count);

        // los alumnos correctos están en la lista
        Assert.Contains(new Alumno("antonio"), alumnos);
        Assert.Contains(new Alumno("gema"), alumnos);


    }
    

    private List<string> ObtenerLineasAlumnosClase()
    {
        return new List<string>
    {
        "*****************",
        "antonio,matematicas,7.5",
        "antonio,lengua,8",
        "-----------------",
        "gema,matematicas,5",
        "gema,lengua,9",
        "*****************"
    };
    }
}
