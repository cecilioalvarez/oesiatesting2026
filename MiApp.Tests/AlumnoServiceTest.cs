using Moq;

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
    public void BuscarPorId_DevuelveAlumnoCorrectamenteIntegracion()
    {
        //arrange 
        var repo = new AlumnoRepository(alumnos);
        var utilidades =new Utilidades();

        var service = new AlumnoService(repo,utilidades);
        var alumnoEncontrado = service.BuscarPorId(2);

        Assert.Equal(2, alumnoEncontrado?.Id);
        Assert.Equal("Luis martínez", alumnoEncontrado?.Nombre);

    }

        [Fact]
    public void BuscarPorId_DevuelveAlumnoCorrectamenteUnitaria()
    {
        //arrange 
        
        var mockRepositorio = new Mock<AlumnoRepository>();
        var mockUtilidades= new Mock<Utilidades>();

        var alumno= new Alumno{Id=2,Nombre="luis Martinez"};

         mockRepositorio.Setup(r=>r.BuscarPorId(2)).Returns(alumno);
         mockUtilidades.Setup(u=>u.PrimeraLetraMayuscula("luis Martinez")).Returns("Luis");


      
        var service = new AlumnoService(mockRepositorio.Object,mockUtilidades.Object);

        var alumnoEncontrado = service.BuscarPorId(2);

        mockRepositorio.Verify(r=>r.BuscarPorId(2),Times.Once);
        mockUtilidades.Verify(r=>r.PrimeraLetraMayuscula("luis Martinez"),Times.Once);


        Assert.Equal(2, alumnoEncontrado?.Id);
        Assert.Equal("Luis", alumnoEncontrado?.Nombre);

    }

}