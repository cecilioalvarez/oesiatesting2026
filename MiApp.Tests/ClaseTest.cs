using MiApp;

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
}