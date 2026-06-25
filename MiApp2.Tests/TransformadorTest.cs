namespace MiApp2.Tests;

using MiApp2;
using Moq;

public class TransformadorTest
{
    [Fact]
    public void Validar_Dependencia_Transformador_Lector_Test()
    {


        Mock<LectorFichero> mockLectorFichero = new Mock<LectorFichero>();
        TransformadorClase transformadorClase = new TransformadorClase(mockLectorFichero.Object);
        Clase clase = transformadorClase.ObtenerClaseConAlumnos();

        mockLectorFichero.Verify(l => l.leerLineas(), Times.Once);


    }
}
