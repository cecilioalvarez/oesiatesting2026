namespace MiApp.test;

public class UtilidadesTests
{
    private readonly Utilidades _utilidades = new();

    [Fact]
    public void PrimeraLetraMayuscula_ConvierteCorrectamente()
    {
        var resultado = _utilidades.PrimeraLetraMayuscula("ana");

        Assert.Equal("Ana", resultado);
    }

    [Fact]
    public void PrimeraLetraMayuscula_CadenaVacia_DevuelveVacia()
    {
        var resultado = _utilidades.PrimeraLetraMayuscula("");

        Assert.Equal("", resultado);
    }

    [Fact]
    public void PrimeraLetraMayuscula_CadenaNula_DevuelveNula()
    {
        var resultado = _utilidades.PrimeraLetraMayuscula(null!);

        Assert.Null(resultado);
    }
}