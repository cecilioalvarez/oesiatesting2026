using MiApp;
using Moq;

public class ClaseTests
{
    [Fact]
    public void AgregarAlumno_CuandoSeAgrega_ElAlumnoEstaEnLaLista()
    {
        // Arrange
        var claseVacia = new Clase("Matemáticas");
        var alumno = new Alumno(1, "Juan");

        // Act
        claseVacia.AgregarAlumno(alumno);

        // Assert
        Assert.Single(claseVacia.Alumnos);
        Assert.Contains(alumno, claseVacia.Alumnos);
    }
    [Fact]
    public void EliminarAlumno_CuandoAlumnoExiste_LoEliminaDeLaLista()
    {
        // Arrange
        var alumno1 = new Alumno(1, "Juan");
        var alumno2 = new Alumno(2, "María");
        var claseConAlumnos = new Clase("Matemáticas", new List<Alumno> { alumno1, alumno2 });

        // Act
        claseConAlumnos.EliminarAlumno(alumno1);

        // Assert
        Assert.DoesNotContain(alumno1, claseConAlumnos.Alumnos);
        Assert.Single(claseConAlumnos.Alumnos);
        Assert.Contains(alumno2, claseConAlumnos.Alumnos);
    }
    [Fact]
    public void ObtenerMediaClase_CuandoHayAlumnos_DevuelveLaMediaDeTodos()
    {
        // Arrange
        var alumno1 = new Mock<Alumno>();
        alumno1.Setup(a => a.ObtenerNotaMedia()).Returns(4);
        var alumno2 = new Mock<Alumno>();
        alumno2.Setup(a => a.ObtenerNotaMedia()).Returns(6);
        var claseConAlumnos = new Clase("Matemáticas", [alumno1.Object, alumno2.Object]);

        // Act
        double resultado = claseConAlumnos.ObtenerMediaClase();

        // Assert
        Assert.Equal(5, resultado);
    }
    private List<Nota> CrearListaNotas(params double[] valores)
    {
        return valores.Select(v => new Nota(v)).ToList();
    }
}