using System.Reflection;
using Xunit;
using MiApp;
using Moq;


namespace MiApp.test;

// FIRST

// FAST , ISOLATED, REPETABLES,Selft Validating, Timely

public class NotaTest3
{
    [Fact]
    public void Nota_Aprobada_Test()
    {
        var mock = new Mock<GestorNota>();
        mock.Setup(g => g.ObtenerCalificacion(It.IsIn(5, 6, 7))).Returns("Bien");
        mock.Setup(g => g.ObtenerCalificacion(It.IsAny<double>())).Returns("Bien");
        
        mock.Setup(g => g.ObtenerCalificacion(It.IsInRange(0.1, 4.9, Moq.Range.Inclusive))).Returns("Bien");
    }
}