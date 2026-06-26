namespace MiApp2
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Nota> Notas { get; set; } = new List<Nota>();

        public Alumno()
        {

        }

        public override bool Equals(object? obj)
        {
            if (obj is Alumno otro)
                return Nombre == otro.Nombre;
            return false;
        }

        public override int GetHashCode() => Nombre.GetHashCode();

        public Alumno(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Notas = new List<Nota>();

        }
        
        public Alumno(string nombre)
        {
            Nombre = nombre;
        

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