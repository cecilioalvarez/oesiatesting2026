namespace MiApp2;


public abstract class ParseadorDocumento
{

    protected abstract List<string> ObtenerLineasFiltradas();
     protected abstract void ProcesarLinea(Clase miClase, string linea);
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

     protected Alumno ObtenerOCrearAlumno(Clase miClase, string nombre)
    {
        var alumno = miClase.Alumnos.FirstOrDefault(a => a.Nombre == nombre);
        if (alumno == null)
        {
            alumno = new Alumno { Nombre = nombre };
            miClase.AgregarAlumno(alumno);
        }
        return alumno;
    }

  



   
    
      
    
    
}