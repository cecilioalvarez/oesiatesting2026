namespace MiApp2;

public class LectorFichero
{

    private string ruta;

    public LectorFichero(string _ruta)
    {
        ruta = _ruta;
    }
    public LectorFichero()
    {
        
    }

    public virtual List<string> leerLineas()
    {
        return new List<string>(File.ReadAllLines(ruta));
    }
}