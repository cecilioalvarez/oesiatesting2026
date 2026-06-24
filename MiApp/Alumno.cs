namespace MiApp
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=string.Empty;
        public List<Nota> Notas { get; set; }= new List<Nota>();

        public Alumno()
        {
            
        }

        public Alumno(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Notas = new List<Nota>();

        }

        internal Alumno(int id, string nombre, List<Nota> lista)
        {
            Id = id;
            Nombre = nombre;
            Notas = lista;


        }

        public void AgregarNota(Nota nota)
        {
            Notas.Add(nota);

        }

        public void EliminarNota(Nota nota)
        {
            if (!Notas.Contains(nota))
                throw new InvalidOperationException("La nota no existe en la lista");

            Notas.Remove(nota);
        }

        public virtual Nota? ObtenerMejorNota()
        {
            return Notas.OrderByDescending(nota => nota.Valor).FirstOrDefault();
        }

        public Nota? ObtenerPeorNota()
        {
            return Notas.OrderByDescending(nota => nota.Valor).Reverse().FirstOrDefault();
        }
        public virtual double ObtenerNotaMedia()
        {
            return Notas.Average(nota => nota.Valor);

        }

    }
    
}