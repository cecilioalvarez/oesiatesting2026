namespace MiApp2
{
    public class Clase
    {
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Clase(string nombre)
        {
            Nombre = nombre;
            Alumnos = new List<Alumno>();
        }

        public Clase()
        {
               Alumnos = new List<Alumno>();
        }
        internal Clase(string nombre, List<Alumno> alumnos)
        {
            Nombre = nombre;
            Alumnos = alumnos;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }

        public void EliminarAlumno(Alumno alumno)
        {
            if (!Alumnos.Contains(alumno))
                throw new InvalidOperationException("El alumno no existe en la lista");

            Alumnos.Remove(alumno);
        }
        public double ObtenerMediaClase()
        {
            double suma = 0;
            foreach (Alumno alumno in Alumnos)
            {
                suma += alumno.ObtenerNotaMedia();
            }
            return suma / Alumnos.Count;
        }

    }
}