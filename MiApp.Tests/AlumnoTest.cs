using System.Reflection;
using Xunit;
using MiApp;

namespace MiApp.test;


// FIRST FAST ISOLATEd REPETIBLE, SELF VALIDATING ,TIMELY 
public class AlumnoTest
{
    [Fact]
    public void Alumno_No_Tiene_Notas_Test()
    {
        // arrange preparar 
        var alumno = new Alumno(1, "pedro");

        Assert.Single(alumno.Notas);


    }

        [Fact]
    public void Alumno_AgregarNota_Test()
    {
        // arrange preparar 
        var alumno = new Alumno(1, "pedro");
        var nota=new Nota(7);
        alumno.AgregarNota(nota);

        var notas=alumno.Notas;
        Assert.Contains(nota,alumno.Notas);
    }

}
