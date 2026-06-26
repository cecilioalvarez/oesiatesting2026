namespace MiApp2;

public class ParseadorDocumentoB : ParseadorDocumento
{

    private LectorFichero lectorFichero;

    public ParseadorDocumentoB(LectorFichero _lectorFichero)
    {
        lectorFichero = _lectorFichero;

    }


    protected override List<string> ObtenerLineasFiltradas()
    {

        List<string> lineas = lectorFichero.leerLineas();
        lineas.RemoveAll(linea => linea.Contains("/"));
        lineas.RemoveAll(linea => linea.Contains("*"));
        return lineas;
    }

    protected override void ProcesarLinea(Clase miClase, string linea)
    {
        string[] datosLinea = linea.Split(",");

        Alumno alumno = ObtenerOCrearAlumno(miClase, datosLinea[0]);

        Nota nota = new Nota(double.Parse(datosLinea[1]));
        alumno.AgregarNota(nota);
    }
}
