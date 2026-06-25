namespace MiApp2.Tests;

using MiApp2;
using Moq;

public class TransformadorTest
{
    [Fact (Skip ="Deshabilitado")]
    public void Validar_Dependencia_Transformador_Lector_Test()
    {


        Mock<LectorFichero> mockLectorFichero = new Mock<LectorFichero>();
        TransformadorClase transformadorClase = new TransformadorClase(mockLectorFichero.Object);
        Clase clase = transformadorClase.ObtenerClaseConAlumnos();
        mockLectorFichero.Verify(l => l.leerLineas(), Times.Once);


    }

    [Fact]
    public void Obtener_Clase_Con_Alumnos_Test()
    {


        Mock<LectorFichero> mockLectorFichero = new Mock<LectorFichero>();
        mockLectorFichero.Setup(l => l.leerLineas()).Returns(ObtenerLineasAlumnosClase());
        TransformadorClase transformadorClase = new TransformadorClase(mockLectorFichero.Object);

        Clase clase = transformadorClase.ObtenerClaseConAlumnos();
        List<Alumno> alumnos = clase.Alumnos;

        Assert.Equal(4, alumnos.Count);


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
