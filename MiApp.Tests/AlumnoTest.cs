using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;


// FIRST FAST ISOLATEd REPETIBLE, SELF VALIDATING ,TIMELY 
public class AlumnoTest
{
    

    [Fact]
    public void Alumno_AgregarNota_Test()
    {
        // arrange preparar 
        var alumno = new Alumno(1, "pedro", new List<Nota>());
        var nota = new Nota(7);

        //assert guard y sirve para validar antes de actuar que los datos iniciales son ok
        Assert.Empty(alumno.Notas);

        alumno.AgregarNota(nota);

        //assert validar
        Assert.Contains(nota, alumno.Notas);
        Assert.Single(alumno.Notas);

    }

    [Fact]
    public void EliminarNota_CuandoNotaExiste_LaEliminaDeLaLista()
    {
        Nota nota = new Nota(8);
        var alumno = new Alumno(1, "Juan", new List<Nota> { nota });
        // Act
        alumno.EliminarNota(nota);

        // Assert
        Assert.DoesNotContain(nota, alumno.Notas);
    }






}
