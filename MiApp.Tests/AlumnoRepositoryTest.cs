using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;


// FIRST FAST ISOLATEd REPETIBLE, SELF VALIDATING ,TIMELY 
public class AlumnoRepositoryTest
{
    private List<Alumno> alumnos;

    public AlumnoRepositoryTest() {
        
     alumnos = new List<Alumno>
        {
        new() { Id = 1, Nombre = "Ana García"    },
        new() { Id = 2, Nombre = "Luis Martínez" },
        new() { Id = 3, Nombre = "Sara López"    },
         new() { Id = 4, Nombre = "Pedro López"    }

        };

    }
    [Fact]
    public void Alumno_BuscarTodos_Test()
    {     
        AlumnoRepository repository = new AlumnoRepository(alumnos);

        List<Alumno> lista = repository.ObtenerTodos();

        Assert.Equal(alumnos, lista);


    }

    [Fact]
    public void Alumno_Guardar_Test()
    {
        AlumnoRepository repository = new AlumnoRepository(alumnos);

        //act
        Alumno alumno = new Alumno(5, "pepe");
        repository.Guardar(alumno);


        Assert.Contains(alumno, alumnos);

    }
        [Fact]
        public void Alumno_Guardar_Test2()
    {

        AlumnoRepository repository = new AlumnoRepository(alumnos);

        //act
        Alumno alumno = new Alumno(5, "pepe");
        repository.Guardar(alumno);
        List<Alumno> lista= repository.ObtenerTodos();


        Assert.Contains(alumno, lista);

    }
    [Fact]
     public void Alumno_Buscar_Por_Id_Test()
    {

        AlumnoRepository repository = new AlumnoRepository(alumnos);

        //act
      
        Alumno? alumnoBuscado=repository.BuscarPorId(2);
    
        Assert.Equal(2,alumnoBuscado?.Id);
        Assert.Equal("Luis Martínez",alumnoBuscado?.Nombre);


    }


}
