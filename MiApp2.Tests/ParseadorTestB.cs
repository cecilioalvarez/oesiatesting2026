namespace MiApp2.Tests;

using MiApp2;
using Moq;

public class ParseadorTestB{

    private readonly ParseadorDocumento parseador;

      public ParseadorTestB()
    {
         parseador = new ParseadorDocumentoB(new Documento(ObtenerLineasAlumnosClase()));
 
    }
    [Fact]
    public void Obtener_Clase_Con_Alumnos_Test()
    {

        Clase clase = parseador.ObtenerClaseConAlumnos();
        List<Alumno> alumnos = clase.Alumnos;

        Assert.Equal(2, alumnos.Count);

        // los alumnos correctos están en la lista
        Assert.Contains(new Alumno("antonio"), alumnos);
        Assert.Contains(new Alumno("gema"), alumnos);

    }
     [Fact]
    public void Obtener_Clase_Con_Alumnos_Numero_Notas_2_Test()
    {

        Clase clase = parseador.ObtenerClaseConAlumnos();
        List<Alumno> alumnos = clase.Alumnos;
        // cada alumno tiene 2 notas
        Assert.Equal(2, alumnos[0].Notas.Count);
        Assert.Equal(2, alumnos[1].Notas.Count);


    }

     [Fact]
    public void Obtener_Clase_Con_Alumnos_Notas_Valor_Correcto_Test()
    {
        Clase clase = parseador.ObtenerClaseConAlumnos();
        List<Alumno> alumnos = clase.Alumnos;
        // las notas son las correctas
        Assert.Contains(new Nota(7.5), alumnos[0].Notas);
        Assert.Contains(new Nota(8), alumnos[0].Notas);
        Assert.Contains(new Nota(5), alumnos[1].Notas);
        Assert.Contains(new Nota(9), alumnos[1].Notas);

    }
    private List<string> ObtenerLineasAlumnosClase()
{
    return new List<string>
    {
        "/////////////////",
        "antonio,7.5,matematicas",
        "antonio,8,lengua",
        "*****************",
        "gema,5,matematicas",
        "gema,9,lengua",
        "/////////////////"
    };
}
}
