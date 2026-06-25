namespace MiApp2;

public class TransformadorClase
{

    private LectorFichero lectorFichero;
    public TransformadorClase(LectorFichero _lectorFichero)
    {
        lectorFichero = _lectorFichero;

    }




    public Clase ObtenerClaseConAlumnos()
    {
        Clase miClase = new Clase();
        List<string> lineas = ObtenerLineasFiltradas();

        foreach (string linea in lineas)
        {
           // if (!linea.Contains("-"))
                ProcesarLinea(miClase, linea);
        }

        return miClase;
    }

    private List<string> ObtenerLineasFiltradas()
    {
        List<string> lineas = lectorFichero.leerLineas();
        lineas.RemoveAll(linea => linea.Contains("*"));
        lineas.RemoveAll(linea => linea.Contains("-"));
        return lineas;
    }

    private void ProcesarLinea(Clase miClase, string linea)
    {
        string[] datosLinea = linea.Split(",");

        Alumno alumno = ObtenerOCrearAlumno(miClase, datosLinea[0]);

        Nota nota = new Nota(double.Parse(datosLinea[2]));
        alumno.AgregarNota(nota);
    }

    private Alumno ObtenerOCrearAlumno(Clase miClase, string nombre)
    {
        Alumno alumno = new Alumno();
        alumno.Nombre = nombre;

        int posicion = miClase.Alumnos.IndexOf(alumno);
        if (posicion == -1)
        {
            miClase.AgregarAlumno(alumno);
            return alumno;
        }

        return miClase.Alumnos[posicion];
    }
}