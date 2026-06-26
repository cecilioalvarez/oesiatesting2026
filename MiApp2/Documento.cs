namespace MiApp2;

public class Documento {

    public List<string> lineas {get;}

    public  Documento(List<string> _lineas) 
    {
        lineas=_lineas;

    }

    public string Cabecera()
    {
        
        return lineas[0];
    }

}