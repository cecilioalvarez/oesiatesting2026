namespace MiApp
{
public class Utilidades
{
    public virtual string PrimeraLetraMayuscula(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return texto;

        return char.ToUpper(texto[0]) + texto[1..];
    }
}
}