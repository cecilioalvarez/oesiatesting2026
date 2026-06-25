namespace MiApp2;

public class TransformadorClase
{

    private LectorFichero lectorFichero;
    public TransformadorClase(LectorFichero _lectorFichero)
    {
        lectorFichero = _lectorFichero;

    }


    public virtual Clase ObtenerClaseConAlumnos()

    {

        List<Alumno> alumnos = new List<Alumno>();
        Clase miClase = new Clase();
        List<string> lineas = lectorFichero.leerLineas();

        lineas.RemoveAll(linea => linea.Contains("*"));

        foreach (string linea in lineas)
        {
            if (!linea.Contains("-"))
            {
                string[] datosLinea = linea.Split(",");

                Alumno alumno = new Alumno();
                alumno.Nombre = datosLinea[0];

                // accedo a la posicion del alumno
                int posicion = miClase.Alumnos.IndexOf(alumno);

                // si el alumno no existe devuelve -1
                if (posicion == -1)
                {
                    // añadimos el alumno a la lista
                    miClase.AgregarAlumno(alumno);
                }
                else
                {
                    // obtenemos el alumno que hay en la lista
                    alumno = miClase.Alumnos[posicion];
                }

                Nota nota = new Nota(double.Parse(datosLinea[2]));
                alumno.AgregarNota(nota);
            }
        }

        return miClase;
    }
}