namespace MiApp2;

public class TransformadorClase
{

    private LectorFichero lectorFichero;
    private ParseadorDocumento parseadorDocumento;
    public TransformadorClase(LectorFichero _lectorFichero,ParseadorDocumento _parseador)
    {
        lectorFichero=_lectorFichero;
        parseadorDocumento=_parseador;



    }

    public Clase ObtenerClaseConAlumnos(){
       return  parseadorDocumento.ObtenerClaseConAlumnos();
  
    }
}