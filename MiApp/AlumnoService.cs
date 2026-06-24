

using MiApp;
public class AlumnoService
{
    private readonly AlumnoRepository _repo;
    private readonly Utilidades _utilidades;

    public AlumnoService(AlumnoRepository repo,Utilidades utilidades)
    {
        _repo = repo;
        _utilidades=utilidades;

    }

    public void Guardar(Alumno alumno)
    {
        _repo.Guardar(alumno);
    }

    public Alumno? BuscarPorId(int id)
    {   Alumno? alumno = _repo.BuscarPorId(id);

    
        alumno?.Nombre=_utilidades.PrimeraLetraMayuscula(alumno.Nombre);
    
        return alumno;
    }

    public List<Alumno> ObtenerTodos()
    {
        return _repo.ObtenerTodos();
    }

    public void Eliminar(int id)
    {
        _repo.Eliminar(id);
    }
}