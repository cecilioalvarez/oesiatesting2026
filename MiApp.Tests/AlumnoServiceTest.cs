namespace MiApp.test;


public class AlumnoServiceTest
{


    private List<Alumno> alumnos;

    public AlumnoServiceTest()
    {

        alumnos = new List<Alumno>
        {
        new() { Id = 2, Nombre = "luis martínez" },
        };
    }
    [Fact]
    public void BuscarPorId_DevuelveAlumnoCorrectamente()
    {
        //arrange 
        var repo = new AlumnoRepository(alumnos);
        var utilidades =new Utilidades();

        var service = new AlumnoService(repo,utilidades);
        var alumnoEncontrado = service.BuscarPorId(2);

        Assert.Equal(2, alumnoEncontrado?.Id);
        Assert.Equal("Luis martínez", alumnoEncontrado?.Nombre);

    }

}