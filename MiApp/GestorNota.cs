namespace MiApp;

public class GestorNota
{
      public string ObtenerCalificacion(double Valor)
        {
            if (Valor < 5)
                return "Suspenso";
            else if (Valor >= 5 && Valor < 6)
                return "Aprobado";
            else if (Valor >= 6 && Valor <= 7)
                return "Bien";
            else if (Valor > 7 && Valor < 9)
                return "Notable";
            else
                return "Sobresaliente";
        }
}