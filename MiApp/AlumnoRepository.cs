

using MiApp;

public class AlumnoRepository
{
    private readonly List<Alumno> _alumnos = new();
    private int _nextId = 1;

    internal AlumnoRepository(List<Alumno> alumnos)
    {
        _alumnos=alumnos;
    }
    public AlumnoRepository()
    {
        
    }
    
    public virtual void Guardar(Alumno alumno)
    {

        var existente = BuscarPorId(alumno.Id);

        if (existente is null)
        {
            if (alumno.Id == 0)
                alumno.Id = _nextId++;

            _alumnos.Add(alumno);
        }
        else
        {
            existente.Nombre = alumno.Nombre;

        }
    }

    public virtual Alumno? BuscarPorId(int id) =>
        _alumnos.FirstOrDefault(a => a.Id == id);


    public virtual List<Alumno> ObtenerTodos() => new(_alumnos);


    public virtual void Eliminar(int id)
    {
        var alumno = BuscarPorId(id);
        if (alumno is not null)
            _alumnos.Remove(alumno);
    }
}