namespace MiApp2;

internal class ParseadorDocumentoC : ParseadorDocumento
{

   public ParseadorDocumentoC(Documento documento): base(documento)
    {
        
    }

    protected override List<string> ObtenerLineasFiltradas()
    {

    
        documento.lineas.RemoveAll(linea => linea.Contains("-"));
        documento.lineas.RemoveAll(linea => linea.Contains("*"));
        return documento.lineas;
    }

    protected override void ProcesarLinea(Clase miClase, string linea)
    {
        string[] datosLinea = linea.Split("|");

        Alumno alumno = ObtenerOCrearAlumno(miClase, datosLinea[0]);

        Nota nota = new Nota(double.Parse(datosLinea[1]));
        alumno.AgregarNota(nota);
    }
}
